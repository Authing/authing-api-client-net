using Authing.ApiClient.Types;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Authing.ApiClient.GraphQL;
using System.Text;
using XC.RSAUtil;
using System.Security.Cryptography;

namespace Authing.ApiClient
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AuthingApiClient
    {
        /// <summary>
        /// 用户池 ID，必填
        /// </summary>
        public string UserPoolId { get; set; }

        /// <summary>
        /// 用户池密钥
        /// </summary>
        public string Secret { get; set; }

        /// <summary>
        /// 接口超时时间
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Graphql 接口地址
        /// </summary>
        public string UserHost { get; set; } = "https://users.authing.cn/graphql";

        /// <summary>
        /// Graphql 接口地址
        /// </summary>
        public string OAuthHost { get; set; } = "https://oauth.authing.cn/graphql";

        /// <summary>
        /// 加密密码使用的公钥
        /// </summary>
        public string PublicKey { get; set; } = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----";

        private string accessToken;
        private GraphQLHttpClient userGqlClient;
        private GraphQLHttpClient oAuthGqlClient;

        private readonly string type = "SDK";
        private readonly string version = "c-sharp:2.0.0";

        /// <summary>
        /// 通过 userPoolId 和可选的一些参数来初始化
        /// </summary>
        /// <param name="userPoolId"></param>
        public AuthingApiClient(string userPoolId)
        {
            UserPoolId = userPoolId ?? throw new ArgumentNullException(nameof(userPoolId));
            userGqlClient = CreateGqlClient(UserHost);
            oAuthGqlClient = CreateGqlClient(OAuthHost);
        }

        /// <summary>
        /// 向任意 Graphql 接口发出请求，
        /// 详见 https://docs.authing.cn/sdk/open-graphql.html
        /// </summary>
        /// 
        /// <example>
        /// <code>
        /// var param = new GetClientWhenSdkInitParam()
        /// {
        ///     ClientId = userPoolId,
        ///     Secret = secret
        /// };
        /// var response = await client.Request&lt;GetClientWhenSdkInitResponse&gt;(param.GetRequest());
        /// Console.WriteLine(response.GetClientWhenSdkInit.AccessToken);
        /// </code>
        /// </example>
        /// <typeparam name="TResponse">返回值类型</typeparam>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<TResponse> Request<TResponse>(GraphQLRequest request, CancellationToken cancellationToken = default, GraphqlHostType hostType = GraphqlHostType.User)
        {
            var client = hostType == GraphqlHostType.User ? userGqlClient : oAuthGqlClient;
            var result = await client.SendQueryAsync<TResponse>(request, cancellationToken);
            CheckResult(result);
            return result.Data;
        }

        /// <summary>
        /// 通过 rsa 加密字符串，通常用来加密密码
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string Encrypt(string message)
        {
            if (message == null)
            {
                return null;
            }

            if (PublicKey == null)
            {
                throw new NullReferenceException("AuthingApiClient.PublicKey");
            }

            var util = new RsaPkcs1Util(Encoding.UTF8, PublicKey);
            return util.Encrypt(message, RSAEncryptionPadding.Pkcs1);
        }

        /// <summary>
        /// 获取 access token，可以用来访问更多接口，
        /// 需要提供 Secret
        /// </summary>
        /// <returns>access token</returns>
        public async Task<string> GetAccessTokenAsync()
        {
            var param = new GetAccessTokenByAppSecretParam()
            {
                ClientId = UserPoolId,
                Secret = Secret ?? throw new ArgumentNullException("AuthingApiClient.Secret")
            };

            var result = await userGqlClient.SendQueryAsync<GetAccessTokenByAppSecretResponse>(param.CreateRequest());
            CheckResult(result);

            accessToken = result.Data.GetAccessTokenByAppSecret;
            userGqlClient.SetAccessToken(accessToken);
            oAuthGqlClient.SetAccessToken(accessToken);

            return accessToken;
        }

        private GraphQLHttpClient CreateGqlClient(string endPoint)
        {
            return new GraphQLHttpClient(new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri(endPoint),
            }, CreateHttpClient());
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient()
            {
                Timeout = Timeout
            };

            client.DefaultRequestHeaders.Add("x-authing-userpool-id", UserPoolId);
            client.DefaultRequestHeaders.Add("x-authing-request-from", type);
            client.DefaultRequestHeaders.Add("x-authing-sdk-version", version);

            return client;
        }

        private void CheckResult<T>(GraphQLResponse<T> result)
        {
            if (result.Errors != null && result.Errors.Length > 0)
            {
                var error = result.Errors[0].Message;
                throw new AuthingApiException(error.Message, error.Code);
            }
        }
    }
}
