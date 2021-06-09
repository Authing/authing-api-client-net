using System.Linq;
using Authing.ApiClient.Results;
using Authing.ApiClient.Types;
using Authing.ApiClient.Utils;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Extensions;

namespace Authing.ApiClient.Auth
{
    /// <summary>
    /// Authing 认证客户端类
    /// </summary>
    public partial class AuthenticationClient : BaseClient
    {
        
        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithClientSecretPost(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    grant_type = "authorization_code",
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();
            return res;
        }

        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithClientSecretBasic(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    grant_type = "authorization_code",
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();
            return res;
        }

        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithNone(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).
            PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    grant_type = "authorization_code",
                    // secrect = Options.Secret,
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();

            return res;
        }

        /// <summary>
        /// code 换 token
        /// </summary>
        /// <param name="code"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CodeToTokenRes> GetAccessTokenByCode(string code, GetAccessTokenByCodeOptions options = null, CancellationToken cancellationToken =
        default)
        {
            if (Options.Secret == null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await GetAccessTokenByCodeWithClientSecretPost(code, options?.CodeVerifier, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await GetAccessTokenByCodeWithClientSecretBasic(code, options?.CodeVerifier, cancellationToken);
            }
            if (Options.Secret != null && Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await GetAccessTokenByCodeWithNone(code, options?.CodeVerifier, cancellationToken);
            }
            throw new Exception("请检查参数 TokenEndPointAuthMethod");
        }

        /// <summary>
        /// 生成 codechallenge
        /// </summary>
        /// <returns>codechallenge</returns>
        public string GenerateCodeChallenge()
        {
            return AuthingUtils.GenerateRandomString(43);
        }

        /// <summary>
        /// 获取 codechallengedigest
        /// </summary>
        /// <param name="options">相关配置</param>
        /// <returns>codechallengedigest</returns>
        public string GetCodeChallengeDigest(CodeChallengeDigestOption options)
        {
            if (options.CodeChallenge == null)
            {
                throw new Exception("请提供 options.codeChallenge，值为一个长度大于等于 43 的字符串");
            }
            if (options.Method == CodeChallengeDigestMethod.S256)
            {
                // url safe base64
                // return sha256(options.codeChallenge).toString(CryptoJS.enc.Base64).replace(/\+/ g, '-').replace(/\//g, '_').replace(/=/g, '');
            }
            if (options.Method == CodeChallengeDigestMethod.PLAIN)
            {
                return options.CodeChallenge;
            }
            throw new Exception("不支持的 options.method，可选值为 S256、plain");
        }

        public async Task<HttpResponseMessage> GetAccessTokenByClientCredentials(string scope, GetAccessTokenByClientCredentialsOption options, CancellationToken cancellationToken =
        default)
        {
            var i = options.AccessKey ?? Options.AppId;
            var s = options.AccessSecret ?? Options.Secret;
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).PostUrlEncodedAsync(
                new
                {
                    client_id = i,
                    client_secret = s,
                    grant_type = "client_credentials",
                    scope,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<UserInfo> GetUserInfoByAccessToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/me",
                Protocol.OAUTH => "oauth/me",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithOAuthBearerToken(token).PostAsync(null, cancellationToken).ReceiveJson<UserInfo>();
            return res;
        }

        public string BuildAuthorizeUrl<T>(T option)
        {
            if (Host == null)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入应用域名 appHost 参数，形如：https://app1.authing.cn");
            }

            if (typeof(T) == typeof(OidcOption))
            {
                return BuildOidcAuthorizeUrl(option as OidcOption);
            }
            if (typeof(T) == typeof(OauthOption))
            {
                return BuildOauthAuthorizeUrl(option as OauthOption);
            }
            if (Options.Protocol == Protocol.SAML)
            {
                return BuildSamlAuthorizeUrl();
            }
            if (typeof(T) == typeof(CasOption))
            {
                return BuildCasAuthorizeUrl(option as CasOption);
            }

            throw new Exception("泛型类型必须是 OidcOption, OauthOption, CasOption 其中一种");
        }

        private string BuildOidcAuthorizeUrl(OidcOption option)
        {
            string prompt = "";
            if (option?.Scope?.IndexOf("offline_access") != -1)
            {
                prompt = "consent";
            }
            var rd = new Random();
            var res = new
            {
                nonce = option.Nonce ?? rd.Next(10, 99).ToString(),
                state = option.State ?? rd.Next(10, 99).ToString(),
                scope = "openid profile email phone address",
                client_id = option.AppId ?? Options.AppId,
                redirect_uri = option.RedirectUri ?? Options.RedirectUri,
                response_type = !(option.ResponseType is null) ? option.ResponseType.ToString().ToLower() : "code",
                code_challenge_method = option.CodeChallengeMethod?.ToString().ToLower(),
                code_challenge = option.CodeChallenge,
                response_mode = option.ResponseMode?.ToString().ToLower(),
                prompt = string.IsNullOrEmpty(prompt) ? null : prompt,
            };
            return $"{Options.Host ?? Host}/oidc/auth{"".SetQueryParams(res)}";
        }

        private string BuildOauthAuthorizeUrl(OauthOption option)
        {
            var rd = new Random();
            var res = new
            {
                state = option.State ?? rd.Next(10, 99).ToString(),
                scope = option.Scope ?? "openid profile email phone address",
                client_id = option.AppId ?? Options.AppId,
                redirect_uri = option.RedirectUri ?? Options.RedirectUri,
                response_type = option.ResponseType.ToString().ToLower() ?? "code",
            };
            return $"{Options.Host ?? Host}/oidc/auth{"".SetQueryParams(res)}";
        }

        private string BuildSamlAuthorizeUrl()
        {
            return $"{Host}/api/v2/saml-idp/{Options.AppId}";
        }

        private string BuildCasAuthorizeUrl(CasOption option)
        {
            if (option.Service != null)
            {
                return $"{Host}/cas-idp/{Options.AppId}?service={option.Service}";
            }
            return $"{Host}/cas-idp/{Options.AppId}";
        }

        private string BuildCasLogoutUrl(LogoutParams option = null)
        {
            if (option?.RedirectUri != null)
            {
                return $"{Host}/cas-idp/logout?url={option.RedirectUri}";
            }
            return $"{Host}/cas-idp/logout";
        }

        private string BuildOidcLogoutUrl(LogoutParams option = null)
        {
            if ((option?.RedirectUri == null && option?.IdToken != null) || (option?.RedirectUri != null && option?.IdToken == null))
            {
                throw new Exception("必须同时传入 idToken 和 redirectUri 参数，或者同时都不传入");
            }
            if (option?.RedirectUri != null)
            {
                return $"{Host}/oidc/session/end?url=id_token_hint={option.IdToken}&post_logout_redirect_uri={option.RedirectUri}";
            }
            return $"{Host}/oidc/session/end";
        }

        private string BuildEasyLogoutUrl(LogoutParams option = null)
        {
            if (option?.RedirectUri != null)
            {
                return $"{Host}/login/profile/logout?redirect_uri={option.RedirectUri}";
            }
            return $"{Host}/login/profile/logout";
        }

        public string BuildLogoutUrl(LogoutParams option = null)
        {
            if (Options?.Protocol == Protocol.CAS)
            {
                return BuildCasLogoutUrl(option);
            }

            if ((Options?.Protocol == Protocol.OIDC) && (bool)option?.Expert)
            {
                return BuildOidcLogoutUrl(option);
            }

            return BuildEasyLogoutUrl(option);
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithClientSecretPost(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithClientSecretBasic(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithNone(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<HttpResponseMessage> GetNewAccessTokenByRefreshToken(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretPost(refreshToken, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretBasic(refreshToken, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await GetNewAccessTokenByRefreshTokenWithNone(refreshToken, cancellationToken);
            }
            throw new Exception("请检查参数 TokenEndPointAuthMethod");
        }

        private async Task<HttpResponseMessage> RevokeTokenWithClientSecretPost(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => "oauth/token/revocation",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> RevokeTokenWithClientSecretBasic(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => throw new Exception("OAuth 2.0 暂不支持用 client_secret_basic 模式身份验证撤回 Token"),
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> RevokeTokenWithNone(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => "oauth/token/revocation",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<bool> RevokeToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                await RevokeTokenWithClientSecretPost(token, cancellationToken);
                return true;
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                await RevokeTokenWithClientSecretBasic(token, cancellationToken);
                return true;
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                await RevokeTokenWithNone(token, cancellationToken);
                return true;
            }
            throw new Exception("初始化 AuthenticationClient 时传入的 revocationEndPointAuthMethod 参数可选值为 client_secret_base、client_secret_post、none，请检查参数");
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithClientSecretPost(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithClientSecretBasic(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithNone(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<HttpResponseMessage> IntrospectToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await IntrospectTokenWithClientSecretPost(token, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await IntrospectTokenWithClientSecretBasic(token, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await IntrospectTokenWithNone(token, cancellationToken);
            }
            throw new Exception("初始化 AuthenticationClient 时传入的 revocationEndPointAuthMethod 参数可选值为 client_secret_base、client_secret_post、none，请检查参数");
        }

        public async Task<ValidateTicketV1Res> ValidateTicketV1(string ticket, string service, CancellationToken cancellationToken =
        default)
        {
            var api = $"cas-idp/{Options.AppId}/validate";
            var resStr = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).SetQueryParams(new
            {
                ticket,
                service
            }).
            GetJsonAsync<string>(cancellationToken);
            var regex = new Regex("\n");
            var resAtt = regex.Split(resStr);
            var valid = resAtt[0];
            var username = resAtt[1];
            var validable = valid == "yes";
            if (validable)
            {
                return new ValidateTicketV1Res()
                {
                    Valid = true,
                    Username = username
                };
            }
            else
            {
                return new ValidateTicketV1Res()
                {
                    Valid = true,
                    Username = username,
                    Message = "ticket 不合法"
                };
            }
        }

        public async Task<HttpResponseMessage> ValidateToken(ValidateTokenOption option, CancellationToken cancellationToken =
        default)
        {
            if (option.IdToken != null)
            {
                var res = await Host.AppendPathSegment("api/v2/oidc/validate_token").SetQueryParams(new
                {
                    id_token = option.IdToken
                }).GetAsync(cancellationToken);
                return res.ResponseMessage;
            }
            else if (option.AccessToken != null)
            {
                var res = await Host.AppendPathSegment("api/v2/oidc/validate_token").SetQueryParams(new
                {
                    access_token = option.AccessToken
                }).GetAsync(cancellationToken);
                return res.ResponseMessage;
            }
            throw new Exception("请在传入的参数对象中包含 accessToken 或 idToken 字段");
        }
    }
}
