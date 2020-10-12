using Authing.ApiClient.Results;
using Authing.ApiClient.Types;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public class AuthenticationClient : BaseClient
    {
        /// <summary>
        /// 通过邮箱注册
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户资料</param>
        /// <param name="forceLogin">强制登录</param>
        /// <param name="generateToken">自动生成 token</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> RegisterByEmail(
            string email,
            string password, 
            RegisterProfile profile = null, 
            bool forceLogin = false, 
            bool generateToken = false, 
            CancellationToken cancellationToken = default)
        {
            var param = new RegisterByEmailParam()
            {
                Input = new RegisterByEmailInput()
                {
                    Email = email,
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            };

            var res = await Request<RegisterByEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过用户名注册
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户资料</param>
        /// <param name="forceLogin">强制登录</param>
        /// <param name="generateToken">自动生成 token</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> RegisterByUsername(
            string username, 
            string password,
            RegisterProfile profile = null,
            bool forceLogin = false, 
            bool generateToken = false, 
            CancellationToken cancellationToken = default)
        {
            var param = new RegisterByUsernameParam()
            {
                Input = new RegisterByUsernameInput()
                {
                    Username = username,
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            };

            var res = await Request<RegisterByUsernameResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过手机号注册
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">手机号验证码</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户资料</param>
        /// <param name="forceLogin">强制登录</param>
        /// <param name="generateToken">自动生成 token</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> RegisterByPhoneCode(
            string phone,
            string code,
            string password = null,
            RegisterProfile profile = null,
            bool forceLogin = false,
            bool generateToken = false,
            CancellationToken cancellationToken = default)
        {
            var param = new RegisterByPhoneCodeParam()
            {
                Input = new RegisterByPhoneCodeInput()
                {
                    Phone = phone,
                    Code = code,
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            };

            var res = await Request<RegisterByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 发送短信验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task SendSmsCode(string phone, CancellationToken cancellationToken = default)
        {
            var httpClient = CreateHttpClient();
            var url = $"{Host}/api/v2/sms/send";

            var message = new HttpRequestMessage(HttpMethod.Post, url)
            {
                Content = new StringContent(JsonConvert.SerializeObject(
                    new 
                    {
                        phone
                    },
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }), Encoding.UTF8, "application/json")
            };
            var result = await httpClient.SendAsync(message, cancellationToken);

            if (!result.IsSuccessStatusCode)
            {
                throw new AuthingApiException(result.ReasonPhrase, (int)result.StatusCode);
            }

            var content = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<SendSmsCodeResponse>(content);

            if (response.Code != 200)
            {
                throw new AuthingApiException(response.Message, response.Code);
            }
        }

        /// <summary>
        /// 通过邮箱登录
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="captchaCode">人机验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> LoginByEmail(
            string email, 
            string password,
            bool autoRegister = false, 
            string captchaCode = null,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginByEmailParam()
            {
                Input = new LoginByEmailInput()
                {
                    Email = email,
                    Password = password,
                    AutoRegister = autoRegister,
                    CaptchaCode = captchaCode,
                }
            };

            var res = await Request<LoginByEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过用户名登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="captchaCode">人机验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> LoginByUsername(
            string username,
            string password,
            bool autoRegister = false,
            string captchaCode = null,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginByUsernameParam()
            {
                Input = new LoginByUsernameInput()
                {
                    Username = username,
                    Password = password,
                    AutoRegister = autoRegister,
                    CaptchaCode = captchaCode,
                }
            };

            var res = await Request<LoginByUsernameResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过用户名登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="captchaCode">人机验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> LoginByPhoneCode(
            string phone,
            string code,
            bool autoRegister = false,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginByPhoneCodeParam()
            {
                Input = new LoginByPhoneCodeInput()
                {
                    Phone = phone,
                    Code = code,
                    AutoRegister = autoRegister,
                }
            };

            var res = await Request<LoginByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }
    }
}
