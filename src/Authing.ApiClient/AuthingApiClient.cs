using Authing.ApiClient.Params;
using Authing.ApiClient.Results;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Authing.ApiClient.GrqphQL;
using System.Text;
using XC.RSAUtil;
using System.Security.Cryptography;

namespace Authing.ApiClient
{
    public partial class AuthingApiClient
    {
        public string UserPoolId { get; set; }

        public string Secret { get; set; }

        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(10);

        public string UserHost { get; set; } = "https://users.authing.cn/graphql";

        public string OAuthHost { get; set; } = "https://oauth.authing.cn/graphql";

        public string PublicKey { get; set; } = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----";

        private string accessToken;
        private GraphQLHttpClient userGqlClient;
        private GraphQLHttpClient oAuthGqlClient;

        public AuthingApiClient(string userPoolId)
        {
            UserPoolId = userPoolId ?? throw new ArgumentNullException(nameof(userPoolId));
            userGqlClient = CreateGqlClient(UserHost);
            oAuthGqlClient = CreateGqlClient(OAuthHost);
        }

        /// <summary>
        /// 获取 access token，可以用来访问更多接口，
        /// 需要提供 Secret
        /// </summary>
        /// <returns>access token</returns>
        public async Task<string> GetAccessTokenAsync()
        {
            var param = new InitParam()
            {
                ClientId = UserPoolId,
                Secret = Secret ?? throw new ArgumentNullException("AuthingApiClient.Secret")
            };

            var result = await userGqlClient.SendQueryAsync<InitResponse>(param.CreateRequest());
            CheckResult(result);

            accessToken = result.Data.GetClientWhenSdkInit.AccessToken;
            userGqlClient.AddAccessToken(accessToken);
            oAuthGqlClient.AddAccessToken(accessToken);

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
            return new HttpClient()
            {
                Timeout = Timeout
            };
        }

        private void CheckResult<T>(GraphQLResponse<T> result)
        {
            if (result.Errors != null && result.Errors.Length > 0)
            {
                var error = result.Errors[0].Message;
                throw new AuthingApiException(error.Message, error.Code);
            }
        }

        private string Encrypt(string message)
        {
            if (PublicKey == null)
            {
                throw new NullReferenceException("AuthingApiClient.PublicKey");
            }

            var util = new RsaPkcs1Util(Encoding.UTF8, PublicKey);
            return util.Encrypt(message, RSAEncryptionPadding.Pkcs1);
        }
    }
}
