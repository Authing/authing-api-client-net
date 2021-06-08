using System;
using System.Threading;
using System.Threading.Tasks;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Types;
using Flurl;
using Flurl.Http;

namespace Authing.ApiClient.Auth
{
    public class MfaAuthenticationClient : BaseClient
    {
        public MfaAuthenticationClient(Action<InitAuthenticationClientOptions> init) : base(init)
        {
        }

        public async Task<ISetTotpRes[]> GetMfaAuthenticators(GetMfaAuthenticatorsParam getMfaAuthenticatorsParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/authenticator").WithOAuthBearerToken(MFAToken).SetQueryParams(new
            {
                type = getMfaAuthenticatorsParam.Type,
                source = getMfaAuthenticatorsParam.Source
            }).GetJsonAsync<ISetTotpRes[]>(cancellationToken);
            return res;
        }

        public async Task<AssosicateMfaAuthenticatorRes> AssosicateMfaAuthenticator(AssosicateMfaAuthenticatorParam parameter, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/totp/associate").WithOAuthBearerToken(MFAToken).PostJsonAsync(new
            {
                authenticator_type = parameter.AuthenticatorType,
                source = parameter.Source
            }, cancellationToken).ReceiveJson<AssosicateMfaAuthenticatorRes>();
            return res;
        }

        public async Task<CommonMessage> DeleteMfaAuthenticator(CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/totp/associate").WithOAuthBearerToken(MFAToken).DeleteAsync(cancellationToken);
            return new CommonMessage
            {
                Code = 200,
                Message = "TOTP MFA 解绑成功"
            };
        }

        public async Task<CommonMessage> ConfirmAssosicateMfaAuthenticator(ConfirmAssosicateMfaAuthenticatorParam parameter, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/totp/associate/confirm").WithOAuthBearerToken(parameter.MFAToken).PostJsonAsync(
                new
                {
                    authenticator_type = parameter.AuthenticatorType,
                    totp = parameter.Totp,
                    source = parameter.Source
                },
                cancellationToken
            );
            return new CommonMessage
            {
                Code = 200,
                Message = "TOTP MFA 绑定成功"
            };
        }

        public async Task<User> VerifyTotpMfa(VerifyTotpMfaParam verifyTotpMfaParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/totp/verify").WithOAuthBearerToken(verifyTotpMfaParam.MFAToken).PostJsonAsync(new
            {
                totp = verifyTotpMfaParam.Totp
            }, cancellationToken).ReceiveJson<User>();
            return res;
        }

        public async Task<User> VerifyAppSmsMfa(VerifyAppSmsMfaParam verifyAppSmsMfaParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/applications/mfa/sms/verify").WithOAuthBearerToken(verifyAppSmsMfaParam.MFAToken).PostJsonAsync(new 
            {
                phone = verifyAppSmsMfaParam.Phone,
                code = verifyAppSmsMfaParam.Code
            }, cancellationToken).ReceiveJson<User>();
            return res;
        }

        public async Task<User> VerifyAppEmailMfa(VerifyAppEmailMfaParam verifyAppEmailMfaParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/applications/mfa/email/verify").WithOAuthBearerToken(verifyAppEmailMfaParam.MFAToken).PostJsonAsync(new
            {
                email = verifyAppEmailMfaParam.Email,
                code = verifyAppEmailMfaParam.Code
            }, cancellationToken).ReceiveJson<User>();
            return res;
        }

        public async Task<bool> PhoneOrEmailBindable(PhoneOrEmailBindableParam phoneOrEmailBindableParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/applications/mfa/check").WithOAuthBearerToken(phoneOrEmailBindableParam.MFAToken).PostJsonAsync(
                new
                {
                    email = phoneOrEmailBindableParam.Email,
                    phone = phoneOrEmailBindableParam.Phone
                },
                cancellationToken
            ).ReceiveJson<bool>();
            return res;
        }

        public async Task<User> VerifyTotpRecoveryCode(VerifyTotpRecoveryCodeParam verifyTotpRecoveryCodeParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/totp/recovery").WithOAuthBearerToken(verifyTotpRecoveryCodeParam.MFAToken).PostJsonAsync(new
            {
                recoveryCode = verifyTotpRecoveryCodeParam.RecoveryCode
            }, cancellationToken).ReceiveJson<User>();
            return res;
        }

        public async Task<User> AssociateFaceByUrl(AssociateFaceByUrlParam associateFaceByUrlParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/face/associate").WithOAuthBearerToken(associateFaceByUrlParam.MFAToken).PostJsonAsync(
                new
                {
                    photoA = associateFaceByUrlParam.BaseFace,
                    photoB = associateFaceByUrlParam.CompareFace,
                    isExternal = true
                },
                 cancellationToken
            ).ReceiveJson<User>();
            return res;
        }

        public async Task<User> AssociateFaceByLocalFile(string mfaToken = null, CancellationToken cancellationToken = default)
        {
            // TODO: 文件上传
            // var res = await Host.AppendPathSegment("")
            return new User { };
        }

        public void AssociateFaceByBlob(string parameter)
        {
            // TODO: blob 文件上传
            // return 
            // return System.NotImplementedException;
        }

        public async Task<User> VerifyFaceMfa(string photo, string mfaToken, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/face/verify").WithOAuthBearerToken(mfaToken).PostJsonAsync(new 
            {
                photo
            }, cancellationToken).ReceiveJson<User>();
            return res;
        }

    }
}