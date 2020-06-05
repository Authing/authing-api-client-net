using Authing.ApiClient.Params;
using Authing.ApiClient.Results;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public partial class AuthingApiClient
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<RegisterResult> RegisterAsync(RegisterParam param)
        {
            param.ClientId = UserPoolId;
            param.Password = Encrypt(param.Password);

            var result = await userGqlClient.SendMutationAsync<RegisterResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.Register;
        }

        /// <summary>
        /// 使用邮箱和密码登录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<LoginResult> LoginByEmailAsync(LoginByEmailParam param)
        {
            param.ClientId = UserPoolId;
            if (param.Password != null)
            {
                param.Password = Encrypt(param.Password);
            }

            var result = await userGqlClient.SendMutationAsync<LoginResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.Login;
        }

        /// <summary>
        /// 使用 Ad 账号进行登录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<LoginResult> LoginByAdAsync(LoginByAdParam param)
        {
            if (param.Password != null)
            {
                param.Password = Encrypt(param.Password);
            }

            var result = await userGqlClient.SendMutationAsync<LoginByAdResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.LoginByLDAP;
        }

        /// <summary>
        /// 使用手机号和验证码登录
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<LoginResult> LoginByPhoneAsync(LoginByPhoneParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<LoginResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.Login;
        }

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public async Task SendPhoneCodeAsync(string phone)
        {
            var httpClient = CreateHttpClient();
            var url = $"https://users.authing.cn/send_smscode/{phone}/{UserPoolId}";
            var result = await httpClient.GetAsync(url);

            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            var sendPhoneCodeResult = JsonConvert.DeserializeObject<SendPhoneCodeResult>(content);

            if (sendPhoneCodeResult.Code != 200)
            {
                throw new AuthingApiException(sendPhoneCodeResult.Message, sendPhoneCodeResult.Code);
            }
        }

        /// <summary>
        /// 发送验证码，如果手机号已注册则会发送失败
        /// </summary>
        /// <param name="phone"></param>
        /// <returns></returns>
        public async Task SendRegisterPhoneCodeAsync(string phone)
        {
            var httpClient = CreateHttpClient();
            var url = $"https://users.authing.cn/notification/send_register_smscode/{phone}/{UserPoolId}";
            var result = await httpClient.GetAsync(url);

            result.EnsureSuccessStatusCode();

            var content = await result.Content.ReadAsStringAsync();
            var sendPhoneCodeResult = JsonConvert.DeserializeObject<SendPhoneCodeResult>(content);

            if (sendPhoneCodeResult.Code != 200)
            {
                throw new AuthingApiException(sendPhoneCodeResult.Message, sendPhoneCodeResult.Code);
            }
        }

        /// <summary>
        /// 解析 user token
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<DecodeTokenResult> DecodeTokenAsync(DecodeTokenParam param)
        {
            var result = await userGqlClient.SendMutationAsync<DecodeTokenResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.DecodeJwtToken;
        }

        /// <summary>
        /// 发送重置密码的邮件验证码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<SendResetPasswordEmailResult> SendResetPasswordEmailAsync(SendResetPasswordEmailParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<SendResetPasswordEmailResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.SendResetPasswordEmail;
        }

        /// <summary>
        /// 验证重置密码的验证码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<VerifyResetPasswordVerifyCodeResult> VerifyResetPasswordVerifyCodeAsync(VerifyResetPasswordVerifyCodeParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<VerifyResetPasswordVerifyCodeResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.VerifyResetPasswordVerifyCode;
        }

        /// <summary>
        /// 在忘记密码的时候使用邮件验证码来修改密码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<UserInfoResult> ChangePasswordAsync(ChangePasswordParam param)
        {
            param.ClientId = UserPoolId;
            param.Password = Encrypt(param.Password);

            var result = await userGqlClient.SendMutationAsync<ChangePasswordResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.ChangePassword;
        }

        /// <summary>
        /// 在忘记密码的时候使用邮件验证码来修改密码
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<SendVerifyEmailResult> SendVerifyEmailAsync(SendVerifyEmailParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<SendVerifyEmailResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.SendVerifyEmail;
        }

        /// <summary>
        /// 查询用户是否存在
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<bool> UserExistAsync(UserExistParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<UserExistResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.UserExist;
        }
    }
}
