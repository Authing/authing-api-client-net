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

            try
            {
                result.EnsureSuccessStatusCode();
                var content = await result.Content.ReadAsStringAsync();
                var sendPhoneCodeResult = JsonConvert.DeserializeObject<SendPhoneCodeResult>(content);
                if (sendPhoneCodeResult.Code != 200)
                {
                    throw new AuthingApiException(sendPhoneCodeResult.Message, sendPhoneCodeResult.Code);
                }
            }
            catch (AuthingApiException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new AuthingApiException(e.Message);
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

            try
            {
                result.EnsureSuccessStatusCode();
                var content = await result.Content.ReadAsStringAsync();
                var sendPhoneCodeResult = JsonConvert.DeserializeObject<SendPhoneCodeResult>(content);
                if (sendPhoneCodeResult.Code != 200)
                {
                    throw new AuthingApiException(sendPhoneCodeResult.Message, sendPhoneCodeResult.Code);
                }
            }
            catch (AuthingApiException)
            {
                throw;
            }
            catch (Exception e)
            {
                throw new AuthingApiException(e.Message);
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
    }
}
