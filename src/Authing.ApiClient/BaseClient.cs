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
    /// 客户端基类
    /// </summary>
    public abstract class BaseClient
    {
        /// <summary>
        /// 用户池 ID，必填
        /// </summary>
        public string UserPoolId { get; set; }

        /// <summary>
        /// 接口超时时间，默认为 10 秒
        /// </summary>
        public TimeSpan Timeout { get; set; } = TimeSpan.FromSeconds(10);

        /// <summary>
        /// Authing 接口 URL，默认为 https://core.authing.cn
        /// </summary>
        public string Host { get; set; } = "https://core.authing.cn";

        /// <summary>
        /// GraphQL Endpoint
        /// </summary>
        private string Endpoint { get { return Host + "/v2/graphql"; } }

        /// <summary>
        /// 加密密码使用的公钥
        /// </summary>
        public string PublicKey { get; set; } = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----";


        private GraphQLHttpClient client;
        private GraphQLHttpClient Client
        {
            get
            {
                // 直接初始化会导致实例化时修改 Host 无效，这里用了懒加载
                return client ?? (client = CreateGqlClient(Endpoint));
            }
        }

        private readonly string type = "SDK";
        private readonly string version = "c-sharp:2.2.0";

        /// <summary>
        /// 设置 AccessToken 以访问某些接口
        /// </summary>
        protected string accessToken;

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
        protected async Task<TResponse> Request<TResponse>(GraphQLRequest request, CancellationToken cancellationToken = default, string accessToken = null)
        {
            Client.SetAccessToken(accessToken ?? this.accessToken);
            var result = await Client.SendQueryAsync<TResponse>(request, cancellationToken);
            CheckResult(result);
            return result.Data;
        }

        /// <summary>
        /// 通过 rsa 加密字符串，通常用来加密密码
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        protected string Encrypt(string message)
        {
            if (message == null)
            {
                return null;
            }

            if (PublicKey == null)
            {
                throw new NullReferenceException("PublicKey");
            }

            var util = new RsaPkcs1Util(Encoding.UTF8, PublicKey);
            return util.Encrypt(message, RSAEncryptionPadding.Pkcs1);
        }

        protected GraphQLHttpClient CreateGqlClient(string endPoint)
        {
            return new GraphQLHttpClient(new GraphQLHttpClientOptions()
            {
                EndPoint = new Uri(endPoint),
            }, CreateHttpClient());
        }

        protected HttpClient CreateHttpClient()
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

        protected static void CheckResult<T>(GraphQLResponse<T> result)
        {
            if (result.Errors != null && result.Errors.Length > 0)
            {
                var error = result.Errors[0].Message;
                throw new AuthingException(error.Message, error.Code);
            }
        }
    }
}
