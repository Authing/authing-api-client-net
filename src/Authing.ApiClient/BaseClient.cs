using Authing.ApiClient.Types;
using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Authing.ApiClient.GraphQL;
using System.Text;
using XC.RSAUtil;
using System.Security.Cryptography;
using System.Net.Http.Headers;

namespace Authing.ApiClient
{

    public class InitAuthenticationClientOptions
    {
        public string AppId { get; set; }
        public string UserPoolId { get; set; }
    }

    /// <summary>
    /// 客户端基类
    /// </summary>
    public abstract class BaseClient
    {
        /// <summary>
        /// 用户池 ID，注意用户池 ID 与 AppID，必填其一
        /// </summary>
        public string UserPoolId { get; private set; }

        /// <summary>
        /// AppID，注意用户池 ID 与 AppID，必填其一
        /// </summary>
        public string AppId { get; private set; }

        /// <summary>
        /// 配置对象
        /// </summary>
        /// <returns></returns>
        public InitAuthenticationClientOptions initAuthenticationClientOptions = new();

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
        private string Endpoint { get { return Host + "/graphql/v2"; } }

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
        private readonly string version = "c-sharp:3.1.0";

        protected BaseClient(string userPoolId)
        {
            UserPoolId = userPoolId ?? throw new ArgumentNullException(nameof(userPoolId));
        }

        protected BaseClient(Action<InitAuthenticationClientOptions> init)
        {
            if (init == null)
            {
                throw new ArgumentNullException(nameof(init));
            }
            init(initAuthenticationClientOptions);
            UserPoolId = initAuthenticationClientOptions.UserPoolId;
            AppId = initAuthenticationClientOptions.AppId;
            if (UserPoolId == string.Empty && AppId == string.Empty)
            {
                throw new Exception("参数错误");
            }
            // UserPoolId ?? AppId ?? Console.WriteLine("oko");
            // UserPoolId = userPoolId ?? throw new ArgumentNullException(nameof(userPoolId));
        }

        /// <summary>
        /// 设置 AccessToken 以访问某些接口
        /// </summary>
        public string AccessToken { get; set; }

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
        public async Task<TResponse> Request<TResponse>(GraphQLRequest request, CancellationToken cancellationToken = default, string accessToken = null)
        {
            Client.SetAccessToken(accessToken ?? this.AccessToken);
            var result = await Client.SendQueryAsync<TResponse>(request, cancellationToken);
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
                throw new NullReferenceException("PublicKey");
            }

            var util = new RsaPkcs1Util(Encoding.UTF8, PublicKey);
            return util.Encrypt(message, RSAEncryptionPadding.Pkcs1);
        }

        /// <summary>
        /// 发送 HTTP 请求
        /// </summary>
        /// <param name="message"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public Task<HttpResponseMessage> Send(HttpRequestMessage message, CancellationToken cancellationToken = default)
        {
            var httpClient = CreateHttpClient();
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", AccessToken);
            return httpClient.SendAsync(message, cancellationToken);
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
            var httpClient = new HttpClient()
            {
                Timeout = Timeout
            };

            httpClient.DefaultRequestHeaders.Add("x-authing-userpool-id", UserPoolId);
            httpClient.DefaultRequestHeaders.Add("x-authing-app-id", AppId);
            httpClient.DefaultRequestHeaders.Add("x-authing-request-from", type);
            httpClient.DefaultRequestHeaders.Add("x-authing-sdk-version", version);

            return httpClient;
        }

        private static void CheckResult<T>(GraphQLResponse<T> result)
        {
            if (result.Errors != null && result.Errors.Length > 0)
            {
                var error = result.Errors[0].Message;
                throw new AuthingException(error.Message, error.Code);
            }
        }
    }
}
