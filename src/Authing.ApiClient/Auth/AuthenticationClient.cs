﻿using System.Linq;
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
using Authing.ApiClient.Types;

namespace Authing.ApiClient.Auth
{
    /// <summary>
    /// Authing 认证客户端类
    /// </summary>
    public class AuthenticationClient : BaseClient
    {
        [Obsolete("建议使用重载方法，使用委托完成初始化")]
        /// <summary>
        /// 通过用户池 ID 初始化
        /// </summary>
        /// <param name="userPoolId">用户池 ID，可以在控制台获取</param>
        public AuthenticationClient(string userPoolId) : base(userPoolId)
        {
        }

        /// <summary>
        /// 通过委托完成初始化
        /// </summary>
        /// <param name="init">配置参数</param>
        public AuthenticationClient(Action<InitAuthenticationClientOptions> init) : base(init)
        {
        }

        private User User
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
                AccessToken = value?.Token ?? AccessToken;
            }
        }
        private User user;

        public string CheckLoggedIn()
        {
            if (user != null)
            {
                return user.Id;
            }
            if (String.IsNullOrEmpty(Token))
            {
                throw new Exception("请先登录!");
            }

            var tokenInfo = AuthingUtils.GetPayloadByToken(Token);
            var userDataString = tokenInfo.Payload.Claims.First(item => item.Type == "data").Value;
            var userData = JsonConvert.DeserializeObject<UserData>(userDataString);
            var userId = tokenInfo.Payload.Sub ?? userData.id;
            if (String.IsNullOrEmpty(userId))
            {
                throw new Exception("不合法的 accessToken");
            }
            return userId;
        }

        public void SetCurrentUser(User user)
        {
            User = user;
        }

        public void SetToken(string token)
        {
            Token = token;
        }

        [Obsolete("该函数已弃用，请使用　GetCurrentUser")]
        /// <summary>
        /// 获取当前用户
        /// </summary>
        /// <param name="accessToken">用户 access token</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> CurrentUser(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            var param = new UserParam();
            var res = await Request<UserResponse>(param.CreateRequest(), cancellationToken, accessToken);
            user = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 通过邮箱注册
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户资料</param>
        /// <param name="forceLogin">强制登录</param>
        /// <param name="generateToken">自动生成 token</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> RegisterByEmail(
            string email,
            string password,
            RegisterProfile profile = null,
            bool forceLogin = false,
            bool generateToken = false,
            CancellationToken cancellationToken = default)
        {
            var param = new RegisterByEmailParam(
                new RegisterByEmailInput(email, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            );

            var res = await Request<RegisterByEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> RegisterByEmail(
            string email,
            string password,
            RegisterProfile profile = null,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions != null && andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }
            var param = new RegisterByEmailParam(
                new RegisterByEmailInput(email, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = andLoginOptions?.ForceLogin,
                    GenerateToken = andLoginOptions?.GenerateToken,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<RegisterByEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
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
            var param = new RegisterByUsernameParam(
                new RegisterByUsernameInput(username, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            );

            var res = await Request<RegisterByUsernameResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> RegisterByUsername(
            string username,
            string password,
            RegisterProfile profile = null,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions != null && andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new RegisterByUsernameParam(
                new RegisterByUsernameInput(username, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = andLoginOptions?.ForceLogin,
                    GenerateToken = andLoginOptions?.GenerateToken,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<RegisterByUsernameResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
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
            var param = new RegisterByPhoneCodeParam(
                new RegisterByPhoneCodeInput(phone, code)
                {
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = forceLogin,
                    GenerateToken = generateToken,
                }
            );

            var res = await Request<RegisterByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> RegisterByPhoneCode(
            string phone,
            string code,
            string password = null,
            RegisterProfile profile = null,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions != null && andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new RegisterByPhoneCodeParam(
                new RegisterByPhoneCodeInput(phone, code)
                {
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = andLoginOptions?.ForceLogin,
                    GenerateToken = andLoginOptions?.GenerateToken,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<RegisterByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<CheckPasswordStrengthResult> CheckPasswordStrength(string password, CancellationToken cancellationToken = default)
        {
            var param = new CheckPasswordStrengthParam(password);
            var res = await Request<CheckPasswordStrengthResult>(param.CreateRequest(), cancellationToken);
            return res;
        }

        /// <summary>
        /// 发送短信验证码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task SendSmsCode(string phone, CancellationToken cancellationToken = default)
        {
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
                        NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore
                    }), Encoding.UTF8, "application/json")
            };
            var result = await Send(message, cancellationToken);

            if (!result.IsSuccessStatusCode)
            {
                throw new AuthingException(result.ReasonPhrase, (int)result.StatusCode);
            }

            var content = await result.Content.ReadAsStringAsync();
            var response = JsonConvert.DeserializeObject<SendSmsCodeResponse>(content);

            if (response.Code != 200)
            {
                throw new AuthingException(response.Message, response.Code);
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
            var param = new LoginByEmailParam(
                new LoginByEmailInput(email, Encrypt(password))
                {
                    AutoRegister = autoRegister,
                    CaptchaCode = captchaCode,
                }
            );

            var res = await Request<LoginByEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> LoginByEmail(
            string email,
            string password,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new LoginByEmailParam(
                new LoginByEmailInput(email, Encrypt(password))
                {
                    AutoRegister = andLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = andLoginOptions?.CaptchaCode,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<LoginByEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
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
            var param = new LoginByUsernameParam(
                new LoginByUsernameInput(username, Encrypt(password))
                {
                    AutoRegister = autoRegister,
                    CaptchaCode = captchaCode,
                }
            );

            var res = await Request<LoginByUsernameResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> LoginByUsername(
            string username,
            string password,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new LoginByUsernameParam(
                new LoginByUsernameInput(username, Encrypt(password))
                {
                    AutoRegister = andLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = andLoginOptions?.CaptchaCode,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<LoginByUsernameResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 通过手机号验证码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> LoginByPhoneCode(
            string phone,
            string code,
            bool autoRegister = false,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginByPhoneCodeParam(
                new LoginByPhoneCodeInput(phone, code)
                {
                    AutoRegister = autoRegister,
                }
            );

            var res = await Request<LoginByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> LoginByPhoneCode(
            string phone,
            string code,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new LoginByPhoneCodeParam(
                new LoginByPhoneCodeInput(phone, code)
                {
                    AutoRegister = andLoginOptions?.AutoRegister ?? false,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<LoginByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 通过手机号密码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="password">密码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="captchaCode">人机验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> LoginByPhonePassword(
            string phone,
            string password,
            bool autoRegister = false,
            string captchaCode = null,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginByPhonePasswordParam(
                new LoginByPhonePasswordInput(phone, Encrypt(password))
                {
                    AutoRegister = autoRegister,
                    CaptchaCode = captchaCode,
                }
            );

            var res = await Request<LoginByPhonePasswordResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> LoginByPhonePassword(
            string phone,
            string password,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 andLoginOptions.CustomData Params
            string ParamsString = "{}";
            string ContextString = "{}";
            if (andLoginOptions != null && andLoginOptions.CustomData != null)
            {
                ParamsString = JsonConvert.SerializeObject(andLoginOptions.CustomData);
            }
            if (andLoginOptions.Context != null)
            {
                ContextString = JsonConvert.SerializeObject(andLoginOptions.Context);
            }

            var param = new LoginByPhonePasswordParam(
                new LoginByPhonePasswordInput(phone, Encrypt(password))
                {
                    AutoRegister = andLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = andLoginOptions?.CaptchaCode,
                    ClientIp = andLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<LoginByPhonePasswordResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<User> LoginBySubAccount(
            string account,
            string password,
            RegisterAndLoginOptions andLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginBySubAccountParam(account, Encrypt(password))
            {
                CaptchaCode = andLoginOptions?.CaptchaCode,
                ClientIp = andLoginOptions?.ClientIp,
            };

            var res = await Request<LoginByPhonePasswordResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 检查登录状态
        /// </summary>
        /// <param name="accessToken">用户的 access token</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<JWTTokenStatus> CheckLoginStatus(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            var param = new CheckLoginStatusParam();
            var res = await Request<CheckLoginStatusResponse>(param.CreateRequest(), cancellationToken, accessToken);
            return res.Result;
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="email">邮件</param>
        /// <param name="scene"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CommonMessage> SendEmail(
            string email,
            EmailScene scene,
            CancellationToken cancellationToken = default)
        {
            var param = new SendEmailParam(email, scene);
            var res = await Request<SendEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过手机号验证码重置密码
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CommonMessage> ResetPasswordByPhoneCode(
            string phone,
            string code,
            string newPassword,
            CancellationToken cancellationToken = default)
        {
            var param = new ResetPasswordParam(code, Encrypt(newPassword))
            {
                Phone = phone,
            };
            var res = await Request<ResetPasswordResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 通过邮箱验证码重置密码
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="code">验证码</param>
        /// <param name="newPassword">新密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CommonMessage> ResetPasswordByEmailCode(
            string email,
            string code,
            string newPassword,
            CancellationToken cancellationToken = default)
        {
            var param = new ResetPasswordParam(code, Encrypt(newPassword))
            {
                Email = email,
            };
            var res = await Request<ResetPasswordResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="updates">更新项</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> UpdateProfile(
            UpdateUserInput updates,
            CancellationToken cancellationToken = default)
        {
            var param = new UpdateUserParam(updates);
            var res = await Request<UpdateUserResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="newPassword">新密码</param>
        /// <param name="oldPassword">旧密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> UpdatePassword(
            string newPassword,
            string oldPassword,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new UpdatePasswordParam(Encrypt(newPassword))
            {
                OldPassword = Encrypt(oldPassword),
            };
            var res = await Request<UpdatePasswordResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 更新手机号
        /// </summary>
        /// <param name="phone">新手机号</param>
        /// <param name="phoneCode">新手机号的验证码</param>
        /// <param name="oldPhone">旧手机号</param>
        /// <param name="oldPhoneCode">旧手机号的验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> UpdatePhone(
            string phone,
            string phoneCode,
            string oldPhone = null,
            string oldPhoneCode = null,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new UpdatePhoneParam(phone, phoneCode)
            {
                OldPhone = oldPhone,
                OldPhoneCode = oldPhoneCode,
            };
            var res = await Request<UpdatePhoneResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 更新邮箱
        /// </summary>
        /// <param name="email">新邮箱</param>
        /// <param name="emailCode">新邮箱的验证码</param>
        /// <param name="oldEmail">旧邮箱</param>
        /// <param name="oldEmailCode">旧邮箱的验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> UpdateEmail(
            string email,
            string emailCode,
            string oldEmail = null,
            string oldEmailCode = null,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new UpdateEmailParam(email, emailCode)
            {
                OldEmail = oldEmail,
                OldEmailCode = oldEmailCode,
            };
            var res = await Request<UpdateEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        public async Task<RefreshToken> RefreshToken(CancellationToken cancellationToken = default)
        {
            var param = new RefreshTokenParam();
            var res = await Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken);
            SetToken(res.Result.Token);
            return res.Result;
        }

        public async Task<SimpleResponse> LinkAccount(string primaryUserToken, string secondaryUserToken, CancellationToken cancellationToken = default)
        {
            await Host.AppendPathSegment("api/v2/users/link").PostJsonAsync(new
            {
                primaryUserToken,
                secondaryUserToken,
            },
            cancellationToken);
            return new SimpleResponse
            {
                code = 200,
                message = "绑定成功"
            };
        }

        public async Task<SimpleResponse> UnLinkAccount(string primaryUserToken, ProviderType provider, CancellationToken cancellationToken = default)
        {
            await Host.AppendPathSegment("api/v2/users/unlink").PostJsonAsync(new
            {
                primaryUserToken,
                provider,
            },
            cancellationToken);
            return new SimpleResponse
            {
                code = 200,
                message = "解绑成功"
            };
        }

        /// <summary>
        /// 绑定手机号，如果已绑定则会报错
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="phoneCode">手机号验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> BindPhone(
            string phone,
            string phoneCode,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new BindPhoneParam(phone, phoneCode);
            var res = await Request<BindPhoneResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 解绑定手机号，如果未绑定则会报错
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> UnbindPhone(CancellationToken cancellationToken = default)
        {
            var userId =  CheckLoggedIn();
            var param = new UnbindPhoneParam();
            var res = await Request<UnbindPhoneResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 绑定邮箱
        /// </summary>
        /// <param name="email"></param>
        /// <param name="emailCode"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<User> BindEamil(string email, string emailCode, CancellationToken cancellationToken = default)
        {
            var param = new BindEmailParam(email, emailCode);
            var res = await Request<BindEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        public async Task<User> UnbindEmail(CancellationToken cancellationToken = default)
        {
            var param = new UnbindEmailParam();
            var res = await Request<UnbindEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        public async Task<User> GetCurrentUser(CancellationToken cancellationToken = default)
        {
            var param = new UserParam();
            var res = await Request<UserResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }
        
        public async void Logout(CancellationToken cancellationToken = default)
        {
            await Host.AppendPathSegment($"/api/v2/logout?app_id={Options.AppId}").WithHeaders(_getHeaders()).GetAsync();
            _clearUser();
        }

        private void _clearUser()
        {
            User = null;
            Token = null;
        }
        
        private object _getHeaders()
        {
            const string SDK_VERSION = "4.2.3";
            // 如果用户需要则取得 headers 之后进行合并
            return new
            {
                x_authing_sdk_version = $"js:{ SDK_VERSION}",
                x_authing_userpool_id = Options.UserPoolId ?? "",
                x_authing_request_from = Options.RequestFrom ?? "sdk",
                x_authing_app_id = Options.AppId ?? "",
                x_authing_lang = Options.Lang ?? "",
                Authorization = $"Bearer {Token}",
            };
        }

        /// <summary>
        /// 获取用户自定义字段的值列表
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<UserDefinedData>> ListUdv(CancellationToken cancellationToken = default)
        {
            await CheckLoggedIn(cancellationToken);
            var param = new UdvParam(UdfTargetType.USER, User.Id);
            var res = await Request<UdvResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }
        
        /// <summary>
        /// 设置自定义字段值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<UserDefinedData>> SetUdv(
            string key,
            object value,
            CancellationToken cancellationToken = default)
        {
            var userId =  CheckLoggedIn();
            var param = new SetUdvParam(UdfTargetType.USER, User.Id, key, JsonConvert.SerializeObject(value));
            var res = await Request<SetUdvResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        

        

        

        /// <summary>
        /// 移除用户自定义字段的值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ResUdv>> RemoveUdv(
            string key,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new RemoveUdvParam(UdfTargetType.USER, User.Id, key);
            var res = await Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
            var resUdv = AuthingUtils.ConvertUdv(res.Result);
            return resUdv;
        }

        // [Obsolete("该方法已经弃用")]
        /// <summary>
        /// 注销
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        // public async Task Logout(CancellationToken cancellationToken = default)
        // {
        //     await CheckLoggedIn();
        //     var param = new UpdateUserParam(
        //         new UpdateUserInput()
        //         {
        //             TokenExpiredAt = "0",
        //         }
        //      )
        //     {
        //         Id = User.Id,
        //     };
        //     await Request<UpdateUserResponse>(param.CreateRequest(), cancellationToken);
        //     User = null;
        // }

        /// <summary>
        /// 用户是否进行登录，登录返回用户信息，没有登录则抛出错误
        /// </summary>
        /// <returns></returns>
        private async Task<string> CheckLoggedIn(CancellationToken cancellationToken)
        {
            var user = await GetCurrentUser(cancellationToken);
            if (user == null)
            {
                throw new AuthingException("请先登录");
            }

            return user.Id;
        }

        public async Task<HttpResponseMessage> ListOrgs(CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/users/me/orgs").GetAsync(cancellationToken);
            return res.ResponseMessage;
        }

        public async Task<User> LoginByLdap(string username, string password, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/ldap/verify-user").PostJsonAsync(new
            {
                username,
                password
            });
            var user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(res.ResponseMessage));
            SetCurrentUser(user);
            return user;
        }
        
        public async Task<User> LoginByAd(string username, string password, CancellationToken cancellationToken = default)
        {
            var firstLevelDomain = Url.Parse(Host).Host;
            var websocketHost = Options.WebsocketHost ?? $"https://ws.{firstLevelDomain}";
            var res = await Host.AppendPathSegment("api/v2/ldap/verify-user").PostJsonAsync(new
            {
                username,
                password
            },
                cancellationToken);
            var user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(res.ResponseMessage));
            SetCurrentUser(user);
            return user;
        }

        public async Task<List<KeyValuePair<string, object>>> GetUdfValue(CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new UdvParam(UdfTargetType.USER, userId);
            var res = await Request<UdvResponse>(param.CreateRequest(), cancellationToken);
            var list = res.Result;
            var resUdvList = AuthingUtils.ConverUdvToKeyValuePair(list);
            return resUdvList;
        }
        
        public async Task<List<KeyValuePair<string, object>>> SetUdfValue(KeyValueDictionary data,CancellationToken 
        cancellationToken = 
        default)
        {
            if (data.Count == 0)
            {
                throw new Exception("empty udf value list");
            }

            var input = new List<UserDefinedDataInput>();
            foreach (var item in data)
            {
                input.Add(new UserDefinedDataInput(item.Key)
                {
                    Key = item.Key,
                    Value = item.Value,
                });
            }
            var userId = CheckLoggedIn();
            var param = new SetUdvBatchParam(UdfTargetType.USER, userId)
            {
                UdvList = input,
            };
            var res = await Request<SetUdvBatchResponse>(param.CreateRequest(), cancellationToken);
            var list = res.Result;
            var resUdvList = AuthingUtils.ConverUdvToKeyValuePair(list);
            return resUdvList;
        }

        public async Task<bool> RemoveUdfValue(string key, CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new RemoveUdvParam(UdfTargetType.USER, userId, key);
            var res = await Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
            return true;
        }

        public async Task<SecurityLevel> GetSecurityLevel(CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/users/me/security-level").GetAsync(cancellationToken);
            return res.ResponseMessage.Convert<SecurityLevel>();
        }

        public async Task<PaginatedAuthorizedResources> ListAuthorizedResources(string _namespace, ResourceType ? _resourceType, CancellationToken 
        cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            string resourceType;
            var param = new ListUserAuthorizedResourcesParam(userId)
            {
                Namespace = _namespace,
                ResourceType = _resourceType == null ? String.Empty : _resourceType.ToString(),
            };
            var res = await Request<ListUserAuthorizedResourcesResponse>(param.CreateRequest(), cancellationToken);
            var user = res.Result;
            if (user == null)
            {
                throw new Exception("用户不存在");
            }

            var authorizedResources = user.AuthorizedResources;
            var list = authorizedResources.List;
            var totalCount = authorizedResources.TotalCount;
            AuthingUtils.FormatAuthorizedResources(ref list);
            return authorizedResources;
        }

        public PasswordSecurityLevel ComputedPasswordSecurityLevel(string password, CancellationToken cancellationToken)
        {
            var highLevel = @"/^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[^]{12,}$/g";
            var middleLevel = @"/^(?=.*[a-zA-Z])(?=.*\d)[^]{8,}$/g";
            if (Regex.Matches(password, highLevel).Count != 0)
            {
                return PasswordSecurityLevel.HIGH;
            }
            if (Regex.Matches(password, middleLevel).Count != 0)
            {
                return PasswordSecurityLevel.MIDDLE;
            }

            return PasswordSecurityLevel.LOW;
        }
        
        /// <summary>
        /// 刷新 access token
        /// </summary>
        /// <param name="accessToken">用户 access token</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RefreshToken> RefreshToken(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            var userId =  CheckLoggedIn();
            var param = new RefreshTokenParam();
            var res = await Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken, accessToken);
            return res.Result;
        }

        public async Task<bool> HasRole(string roleCode, string _namespace = "", CancellationToken 
        cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new GetUserRolesParam(userId)
            {
                Namespace = _namespace,
            };
            var res = await Request<GetUserRolesResponse>(param.CreateRequest(), cancellationToken);
            if (res.Result == null)
            {
                return false;
            }

            var roleList = user.Roles?.List;
            if (!roleList.Any())
            {
                return false;
            }

            var hasRole = roleList.Any(item => string.Equals(item.Code, roleCode));
            return hasRole;
        }

        public async Task<HttpResponseMessage> ListApplications(ListParams _params = null, CancellationToken cancellationToken = 
        default)
        {
            _params = _params ?? AuthingUtils.ListParams;
            var res = await Host.AppendPathSegment(
                $"api/v2/users/me/applications/allowed?page={_params.Page}&limit={_params.Limit}").GetAsync();
            return res.ResponseMessage;
        }
    }
}
