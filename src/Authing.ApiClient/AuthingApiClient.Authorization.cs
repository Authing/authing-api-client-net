using Authing.ApiClient.Results;
using Authing.ApiClient.Types;
using Newtonsoft.Json;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public partial class AuthingApiClient
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="param">用户信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RegisterResponse> RegisterAsync(RegisterParam param, CancellationToken cancellationToken = default)
        {
            param.UserInfo = param.UserInfo ?? new UserRegisterInput();
            param.UserInfo.RegisterInClient = UserPoolId;
            Console.WriteLine(param.UserInfo.Password);
            param.UserInfo.Password = Encrypt(param.UserInfo.Password);
            Console.WriteLine(param.UserInfo.Password);

            return await Request<RegisterResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 使用邮箱和密码登录
        /// </summary>
        /// <param name="param">需要提供 Email 和 Password</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<LoginResponse> LoginByEmailAsync(LoginParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;
            param.Password = Encrypt(param.Password);

            return await Request<LoginResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 使用用户名和密码登录
        /// </summary>
        /// <param name="param">需要提供 Username 和 Password</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<LoginResponse> LoginByUsernameAsync(LoginParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;
            param.Password = Encrypt(param.Password);

            return await Request<LoginResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 使用 Ad 账号进行登录
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<LoginByAdResponse> LoginByAdAsync(LoginByAdParam param, CancellationToken cancellationToken = default)
        {
            param.Password = Encrypt(param.Password);

            return await Request<LoginByAdResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 使用 LDAP 账号进行登录
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<LoginByLdapResponse> LoginByLdapAsync(LoginByLdapParam param, CancellationToken cancellationToken = default)
        {
            param.ClientId = UserPoolId;
            param.Password = Encrypt(param.Password);

            return await Request<LoginByLdapResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 使用手机号和验证码登录
        /// </summary>
        /// <param name="param">需要提供 Phone 和 PhoneCode</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<LoginResponse> LoginByPhoneAsync(LoginParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;

            return await Request<LoginResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task SendPhoneCodeAsync(string phone, CancellationToken cancellationToken = default)
        {
            var httpClient = CreateHttpClient();
            var url = $"https://users.authing.cn/send_smscode/{phone}/{UserPoolId}";
            var result = await httpClient.GetAsync(url, cancellationToken);

            if (!result.IsSuccessStatusCode)
            {
                throw new AuthingApiException(result.ReasonPhrase, (int)result.StatusCode);
            }

            var content = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<SendPhoneCodeResponse>(content);

            if (response.Code != 200)
            {
                throw new AuthingApiException(response.Message, response.Code);
            }
        }

        /// <summary>
        /// 发送验证码，如果手机号已注册则会发送失败
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task SendRegisterPhoneCodeAsync(string phone, CancellationToken cancellationToken = default)
        {
            var httpClient = CreateHttpClient();
            var url = $"https://users.authing.cn/notification/send_register_smscode/{phone}/{UserPoolId}";
            var result = await httpClient.GetAsync(url, cancellationToken);

            if (!result.IsSuccessStatusCode)
            {
                throw new AuthingApiException(result.ReasonPhrase, (int)result.StatusCode);
            }

            var content = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<SendPhoneCodeResponse>(content);

            if (response.Code != 200)
            {
                throw new AuthingApiException(response.Message, response.Code);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<SignInResponse> SignInAsync(SignInParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;
            param.Password = Encrypt(param.Password);

            return await Request<SignInResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RefreshSignInTokenResponse> RefreshSignInTokenAsync(RefreshSignInTokenParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;

            return await Request<RefreshSignInTokenResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 解析 user token
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<DecodeJwtTokenResponse> DecodeJwtTokenAsync(DecodeJwtTokenParam param, CancellationToken cancellationToken = default)
        {
            return await Request<DecodeJwtTokenResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 发送重置密码的邮件验证码
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<SendResetPasswordEmailResponse> SendResetPasswordEmailAsync(SendResetPasswordEmailParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<SendResetPasswordEmailResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 验证重置密码的验证码
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<VerifyResetPasswordVerifyCodeResponse> VerifyResetPasswordVerifyCodeAsync(VerifyResetPasswordVerifyCodeParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<VerifyResetPasswordVerifyCodeResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 在忘记密码的时候使用邮件验证码来修改密码
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ChangePasswordResponse> ChangePasswordAsync(ChangePasswordParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;
            param.Password = Encrypt(param.Password);

            return await Request<ChangePasswordResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 在忘记密码的时候使用邮件验证码来修改密码
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<SendVerifyEmailResponse> SendVerifyEmailAsync(SendVerifyEmailParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<SendVerifyEmailResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserExistResponse> UserExistAsync(UserExistParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;

            return await Request<UserExistResponse>(param.CreateRequest(), cancellationToken);
        }
    }
}
