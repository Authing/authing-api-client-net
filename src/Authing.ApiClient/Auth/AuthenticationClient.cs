using System.Linq;
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
using Authing.ApiClient.Extensions;

namespace Authing.ApiClient.Auth
{
    /// <summary>
    /// Authing 认证客户端类
    /// </summary>
    public class AuthenticationClient : BaseClient
    {
        [Obsolete("建议使用委托完成初始化")]
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

        /// <summary>
        /// 检查登录状态
        /// </summary>
        /// <returns>当前用户 ID</returns>
        public string CheckLoggedIn()
        {
            if (user != null)
            {
                return user.Id;
            }
            if (string.IsNullOrEmpty(Token))
            {
                throw new Exception("请先登录!");
            }

            var tokenInfo = AuthingUtils.GetPayloadByToken(Token);
            var userDataString = tokenInfo.Payload.Claims.First(item => item.Type == "data").Value;
            var userData = JsonConvert.DeserializeObject<UserData>(userDataString);
            var userId = tokenInfo.Payload.Sub ?? userData.Id;
            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("不合法的 accessToken");
            }
            return userId;
        }

        /// <summary>
        /// 设置当前用户信息
        /// </summary>
        /// <param name="user">用户数据</param>
        public void SetCurrentUser(User user)
        {
            User = user;
        }

        /// <summary>
        /// 设置当前 Token
        /// </summary>
        /// <param name="token">token 值</param>
        public void SetToken(string token)
        {
            Token = token;
        }

        [Obsolete("该函数已弃用，请使用　GetCurrentUser")]
        /// <summary>
        /// 获取当前用户
        /// </summary>
        /// <param name="accessToken">用户 access token</param>
        /// <param name="cancellationToken">请求令牌</param>
        /// <returns>当前用户</returns>
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
        /// <param name="cancellationToken">请求令牌</param>
        /// <returns>注册的用户</returns>
        /// TODO: 下个大版本弃用
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

        /// <summary>
        /// 通过邮箱注册用户
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户信息</param>
        /// <param name="registerAndLoginOptions">注册配置信息</param>
        /// <param name="cancellationToken">请求令牌</param>
        /// <returns>注册的用户</returns>
        public async Task<User> RegisterByEmail(
            string email,
            string password,
            RegisterProfile profile = null,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions?.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }
            var param = new RegisterByEmailParam(
                new RegisterByEmailInput(email, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = registerAndLoginOptions?.ForceLogin,
                    GenerateToken = registerAndLoginOptions?.GenerateToken,
                    ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// <param name="cancellationToken">请求令牌</param>
        /// <returns>注册的用户</returns>
        /// TODO: 下个大版本弃用
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

        /// <summary>
        /// 通过用户名注册用户
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户信息</param>
        /// <param name="registerAndLoginOptions">注册配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>注册的用户</returns>
        public async Task<User> RegisterByUsername(
            string username,
            string password,
            RegisterProfile profile = null,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions?.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new RegisterByUsernameParam(
                new RegisterByUsernameInput(username, Encrypt(password))
                {
                    Profile = profile,
                    ForceLogin = registerAndLoginOptions?.ForceLogin,
                    GenerateToken = registerAndLoginOptions?.GenerateToken,
                    ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// TODO: 下个大版本弃用
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

        /// <summary>
        /// 通过手机验证码注册用户
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <param name="password">密码</param>
        /// <param name="profile">用户信息</param>
        /// <param name="registerAndLoginOptions">注册配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>注册的用户</returns>
        public async Task<User> RegisterByPhoneCode(
            string phone,
            string code,
            string password = null,
            RegisterProfile profile = null,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions?.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new RegisterByPhoneCodeParam(
                new RegisterByPhoneCodeInput(phone, code)
                {
                    Password = Encrypt(password),
                    Profile = profile,
                    ForceLogin = registerAndLoginOptions?.ForceLogin,
                    GenerateToken = registerAndLoginOptions?.GenerateToken,
                    ClientIp = registerAndLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<RegisterByPhoneCodeResponse>(param.CreateRequest(), cancellationToken);

            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 检查密码强度
        /// </summary>
        /// <param name="password">密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>CheckPasswordStrengthResult</returns>
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
        /// TODO: 破坏性更新
        public async Task<CommonMessage> SendSmsCode(string phone, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/sms/send").WithHeaders(GetHeaders()).PostJsonAsync(new 
            {
                phone
            }, cancellationToken).ReceiveJson<CommonMessage>();
            return res;
        }


        /// <summary>
        /// 通过邮箱登录
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="autoRegister">自动注册</param>
        /// <param name="captchaCode">人机验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        /// TODO: 下个大版本去除
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

        /// <summary>
        /// 通过邮箱登录
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="password">密码</param>
        /// <param name="registerAndLoginOptions">登录配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByEmail(
            string email,
            string password,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new LoginByEmailParam(
                new LoginByEmailInput(email, Encrypt(password))
                {
                    AutoRegister = registerAndLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = registerAndLoginOptions?.CaptchaCode,
                    ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// <returns>User</returns>
        /// TODO: 下个大版本去除
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

        /// <summary>
        /// 通过用户名登录
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="registerAndLoginOptions">注册配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByUsername(
            string username,
            string password,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new LoginByUsernameParam(
                new LoginByUsernameInput(username, Encrypt(password))
                {
                    AutoRegister = registerAndLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = registerAndLoginOptions?.CaptchaCode,
                    ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// <returns>User</returns>
        /// TODO: 下一个大版本去除
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

        /// <summary>
        /// 通过手机验证码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="code">验证码</param>
        /// <param name="registerAndLoginOptions">登录配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByPhoneCode(
            string phone,
            string code,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new LoginByPhoneCodeParam(
                new LoginByPhoneCodeInput(phone, code)
                {
                    AutoRegister = registerAndLoginOptions?.AutoRegister ?? false,
                    ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// <returns>User</returns>
        /// TODO：下个大版本去除
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

        /// <summary>
        /// 通过手机号密码登录
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="password">密码</param>
        /// <param name="registerAndLoginOptions">登录信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByPhonePassword(
            string phone,
            string password,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            // 序列化 registerAndLoginOptions.CustomData Params
            string ParamsString = null;
            string ContextString = null;
            if (registerAndLoginOptions?.CustomData != null)
            {
                ParamsString = registerAndLoginOptions.CustomData.ConvertJson();
            }
            if (registerAndLoginOptions.Context != null)
            {
                ContextString = registerAndLoginOptions.Context.ConvertJson();
            }

            var param = new LoginByPhonePasswordParam(
                new LoginByPhonePasswordInput(phone, Encrypt(password))
                {
                    AutoRegister = registerAndLoginOptions?.AutoRegister ?? false,
                    CaptchaCode = registerAndLoginOptions?.CaptchaCode,
                    ClientIp = registerAndLoginOptions?.ClientIp,
                    Params = ParamsString,
                    Context = ContextString,
                }
            );

            var res = await Request<LoginByPhonePasswordResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 通过子账户登录
        /// </summary>
        /// <param name="account">子账户</param>
        /// <param name="password">密码</param>
        /// <param name="registerAndLoginOptions">登录配置信息</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginBySubAccount(
            string account,
            string password,
            RegisterAndLoginOptions registerAndLoginOptions = null,
            CancellationToken cancellationToken = default)
        {
            var param = new LoginBySubAccountParam(account, Encrypt(password))
            {
                CaptchaCode = registerAndLoginOptions?.CaptchaCode,
                ClientIp = registerAndLoginOptions?.ClientIp,
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
        /// <returns>JWTTokenStatus</returns>
        public async Task<JWTTokenStatus> CheckLoginStatus(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            var param = new CheckLoginStatusParam()
            { 
                Token = accessToken ?? Token
            };
            var res = await Request<CheckLoginStatusResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="email">邮件</param>
        /// <param name="scene">场景</param>
        /// <param name="cancellationToken"></param>
        /// <returns>CommonMessage</returns>
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
        /// <returns>CommonMessage</returns>
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
        /// <returns>CommonMessage</returns>
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

        // TODO: 缺少 resetPasswordByFirstLoginToken 方法

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="updates">更新项</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
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
        /// <returns>User</returns>
        public async Task<User> UpdatePassword(
            string newPassword,
            string oldPassword = null,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
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
        /// <returns>User</returns>
        public async Task<User> UpdatePhone(
            string phone,
            string phoneCode,
            string oldPhone = null,
            string oldPhoneCode = null,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
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
        /// <returns>User</returns>
        public async Task<User> UpdateEmail(
            string email,
            string emailCode,
            string oldEmail = null,
            string oldEmailCode = null,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
            var param = new UpdateEmailParam(email, emailCode)
            {
                OldEmail = oldEmail,
                OldEmailCode = oldEmailCode,
            };
            var res = await Request<UpdateEmailResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 刷新 Token
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>RefreshToken</returns>
        public async Task<RefreshToken> RefreshToken(CancellationToken cancellationToken = default)
        {
            var param = new RefreshTokenParam();
            var res = await Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken);
            SetToken(res.Result.Token);
            return res.Result;
        }

        /// <summary>
        /// 关联账户
        /// </summary>
        /// <param name="primaryUserToken">主账号</param>
        /// <param name="secondaryUserToken">子账号</param>
        /// <param name="cancellationToken"></param>
        /// <returns>SimpleResponse</returns>
        public async Task<CommonMessage> LinkAccount(string primaryUserToken, string secondaryUserToken, CancellationToken cancellationToken = default)
        {
            // TODO： 返回值是否合适
            await Host.AppendPathSegment("api/v2/users/link").WithHeaders(GetHeaders()).PostJsonAsync(new
            {
                primaryUserToken,
                secondaryUserToken,
            },
            cancellationToken);
            return new CommonMessage
            {
                Code = 200,
                Message = "绑定成功"
            };
        }

        /// <summary>
        /// 取消关联账户
        /// </summary>
        /// <param name="primaryUserToken">主账户</param>
        /// <param name="provider">提供者</param>
        /// <param name="cancellationToken"></param>
        /// <returns>SimpleResponse</returns>
        public async Task<CommonMessage> UnLinkAccount(string primaryUserToken, ProviderType provider, CancellationToken cancellationToken = default)
        {
            // TODO： 返回值是否合适
            await Host.AppendPathSegment("api/v2/users/unlink").WithHeaders(GetHeaders()).PostJsonAsync(new
            {
                primaryUserToken,
                provider,
            },
            cancellationToken);
            return new CommonMessage
            {
                Code = 200,
                Message = "解绑成功"
            };
        }

        /// <summary>
        /// 绑定手机号，如果已绑定则会报错
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="phoneCode">手机号验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> BindPhone(
            string phone,
            string phoneCode,
            CancellationToken cancellationToken = default)
        {
            var param = new BindPhoneParam(phone, phoneCode);
            var res = await Request<BindPhoneResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 解绑定手机号，如果未绑定则会报错
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> UnbindPhone(CancellationToken cancellationToken = default)
        {
            var param = new UnbindPhoneParam();
            var res = await Request<UnbindPhoneResponse>(param.CreateRequest(), cancellationToken);
            User = res.Result;
            return res.Result;
        }

        /// <summary>
        /// 绑定邮箱
        /// </summary>
        /// <param name="email">邮箱</param>
        /// <param name="emailCode">邮箱验证码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> BindEamil(string email, string emailCode, CancellationToken cancellationToken = default)
        {
            var param = new BindEmailParam(email, emailCode);
            var res = await Request<BindEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 取消绑定的邮箱
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> UnbindEmail(CancellationToken cancellationToken = default)
        {
            var param = new UnbindEmailParam();
            var res = await Request<UnbindEmailResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 获取当前用户
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> GetCurrentUser(CancellationToken cancellationToken = default)
        {
            var param = new UserParam();
            var res = await Request<UserResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        /// <summary>
        /// 当前用户登出
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async void Logout(CancellationToken cancellationToken = default)
        {
            await Host.AppendPathSegment($"/api/v2/logout").SetQueryParam("app_id", Options.AppId).WithHeaders(GetHeaders()).GetAsync(cancellationToken);
            ClearUser();
        }

        private void ClearUser()
        {
            User = null;
            Token = null;
        }

        private object GetHeaders()
        {
            const string SDK_VERSION = "4.2.3";
            // 如果用户需要则取得 headers 之后进行合并
            return new
            {
                x_authing_sdk_version = $"csharp:{SDK_VERSION}",
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
        /// <returns>自定义字段列表</returns>
        public async Task<IEnumerable<ResUdv>> ListUdv(CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
            var param = new UdvParam(UdfTargetType.USER, User.Id);
            var res = await Request<UdvResponse>(param.CreateRequest(), cancellationToken);
            var resUdv = AuthingUtils.ConvertUdv(res.Result);
            return resUdv;
        }

        /// <summary>
        /// 设置自定义字段值
        /// </summary>
        /// <param name="key">自定义字段的 key</param>
        /// <param name="value">自定义字段的 value</param>
        /// <param name="cancellationToken"></param>
        /// <returns>用户自定义字段</returns>
        public async Task<IEnumerable<ResUdv>> SetUdv(
            string key,
            object value,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
            var param = new SetUdvParam(UdfTargetType.USER, User.Id, key, value.ConvertJson());
            var res = await Request<SetUdvResponse>(param.CreateRequest(), cancellationToken);
            var resUdv = AuthingUtils.ConvertUdv(res.Result);
            return resUdv;
        }


        /// <summary>
        /// 移除用户自定义字段的值
        /// </summary>
        /// <param name="key">自定义字段的 key </param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<ResUdv>> RemoveUdv(
            string key,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
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
        /// <returns>用户 ID</returns>
        private async Task<string> CheckLoggedIn(CancellationToken cancellationToken)
        {
            var user = await GetCurrentUser(cancellationToken);
            if (user == null)
            {
                throw new AuthingException("请先登录");
            }

            return user.Id;
        }

        /// <summary>
        /// 组织列表
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>HttpResponseMessage</returns>
        public async Task<HttpResponseMessage> ListOrgs(CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/users/me/orgs").WithHeaders(GetHeaders()).GetAsync(cancellationToken);
            return res.ResponseMessage;
        }

        /// <summary>
        /// 通过 LDAP 进行登录
        /// </summary>
        /// <param name="username">LDAP 用户名</param>
        /// <param name="password">LDAP 用户密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByLdap(string username, string password, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/ldap/verify-user").WithHeaders(GetHeaders()).PostJsonAsync(
                new
                {
                    username,
                    password
                },
                cancellationToken
            );
            var user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(res.ResponseMessage));
            SetCurrentUser(user);
            return user;
        }

        /// <summary>
        /// 通过 AD 登录
        /// </summary>
        /// <param name="username">AD 用户账号</param>
        /// <param name="password">AD 用户密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        public async Task<User> LoginByAd(string username, string password, CancellationToken cancellationToken = default)
        {
            var firstLevelDomain = Url.Parse(Host).Host;
            var websocketHost = Options.WebsocketHost ?? $"https://ws.{firstLevelDomain}";
            var res = await firstLevelDomain.AppendPathSegment("api/v2/ldap/verify-user").WithHeaders(GetHeaders()).PostJsonAsync(new
            {
                username,
                password
            },
                cancellationToken);
            var user = JsonConvert.DeserializeObject<User>(JsonConvert.SerializeObject(res.ResponseMessage));
            SetCurrentUser(user);
            return user;
        }

        /// <summary>
        /// 获取自定义字段列表
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>自定义字段列表</returns>
        public async Task<List<KeyValuePair<string, object>>> GetUdfValue(CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new UdvParam(UdfTargetType.USER, userId);
            var res = await Request<UdvResponse>(param.CreateRequest(), cancellationToken);
            var list = res.Result;
            var resUdvList = AuthingUtils.ConverUdvToKeyValuePair(list);
            return resUdvList;
        }

        /// <summary>
        /// 设置自定义字段
        /// </summary>
        /// <param name="data">自定义字段相关数据</param>
        /// <param name="cancellationToken"></param>
        /// <returns>自定义字段列表</returns>
        public async Task<List<KeyValuePair<string, object>>> SetUdfValue(KeyValueDictionary data, CancellationToken
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

        /// <summary>
        /// 删除自定义字段
        /// </summary>
        /// <param name="key">自定义字段的 key</param>
        /// <param name="cancellationToken"></param>
        /// <returns>是否成功</returns>
        public async Task<bool> RemoveUdfValue(string key, CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new RemoveUdvParam(UdfTargetType.USER, userId, key);
            var res = await Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
            return true;
        }

        /// <summary>
        /// 获取密码登记
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>SecurityLevel</returns>
        public async Task<SecurityLevel> GetSecurityLevel(CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/users/me/security-level").WithHeaders(GetHeaders()).GetAsync(cancellationToken);
            return res.ResponseMessage.Convert<SecurityLevel>();
        }

        /// <summary>
        /// 允许访问的资源列表
        /// </summary>
        /// <param name="_namespace">命名空间</param>
        /// <param name="_resourceType">资源类型</param>
        /// <param name="cancellationToken"></param>
        /// <returns>PaginatedAuthorizedResources</returns>
        public async Task<PaginatedAuthorizedResources> ListAuthorizedResources(string _namespace, ResourceType? _resourceType, CancellationToken
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

        /// <summary>
        /// 计算密码强度
        /// </summary>
        /// <param name="password">密码</param>
        /// <returns>PasswordSecurityLevel</returns>
        public PasswordSecurityLevel ComputedPasswordSecurityLevel(string password)
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
        /// <returns>RefreshToken</returns>
        public async Task<RefreshToken> RefreshToken(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            var userId = CheckLoggedIn();
            var param = new RefreshTokenParam();
            var res = await Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken, accessToken);
            return res.Result;
        }

        /// <summary>
        /// 当前用户是否具有某种角色
        /// </summary>
        /// <param name="roleCode">角色 code</param>
        /// <param name="_namespace">命名空间</param>
        /// <param name="cancellationToken"></param>
        /// <returns>bool</returns>
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

        /// <summary>
        /// 应用程序列表
        /// </summary>
        /// <param name="_params">列表参数</param>
        /// <param name="cancellationToken"></param>
        /// <returns>HttpResponseMessage</returns>
        public async Task<HttpResponseMessage> ListApplications(ListParams _params = null, CancellationToken cancellationToken =
        default)
        {
            _params = _params ?? AuthingUtils.ListParams;
            var res = await Host.AppendPathSegment(
                $"api/v2/users/me/applications/allowed?page={_params.Page}&limit={_params.Limit}").WithHeaders(GetHeaders()).GetAsync(cancellationToken);
            return res.ResponseMessage;
        }

        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithClientSecretPost(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    grant_type = "authorization_code",
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();
            return res;
        }

        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithClientSecretBasic(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    grant_type = "authorization_code",
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();
            return res;
        }

        private async Task<CodeToTokenRes> GetAccessTokenByCodeWithNone(string code, string codeVerifier = null, CancellationToken cancellationToken =
        default)
        {
            string api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).
            PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    grant_type = "authorization_code",
                    // secrect = Options.Secret,
                    code,
                    redirect_uri = Options.RedirectUri,
                    code_verifier = codeVerifier
                },
                cancellationToken
            ).ReceiveJson<CodeToTokenRes>();

            return res;
        }

        /// <summary>
        /// code 换 token
        /// </summary>
        /// <param name="code"></param>
        /// <param name="options"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CodeToTokenRes> GetAccessTokenByCode(string code, GetAccessTokenByCodeOptions options = null, CancellationToken cancellationToken =
        default)
        {
            if (Options.Secret == null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await GetAccessTokenByCodeWithClientSecretPost(code, options?.CodeVerifier, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await GetAccessTokenByCodeWithClientSecretBasic(code, options?.CodeVerifier, cancellationToken);
            }
            if (Options.Secret != null && Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await GetAccessTokenByCodeWithNone(code, options?.CodeVerifier, cancellationToken);
            }
            throw new Exception("请检查参数 TokenEndPointAuthMethod");
        }

        /// <summary>
        /// 生成 codechallenge
        /// </summary>
        /// <returns>codechallenge</returns>
        public string GenerateCodeChallenge()
        {
            return AuthingUtils.GenerateRandomString(43);
        }

        /// <summary>
        /// 获取 codechallengedigest
        /// </summary>
        /// <param name="options">相关配置</param>
        /// <returns>codechallengedigest</returns>
        public string GetCodeChallengeDigest(CodeChallengeDigestOption options)
        {
            if (options.CodeChallenge == null)
            {
                throw new Exception("请提供 options.codeChallenge，值为一个长度大于等于 43 的字符串");
            }
            if (options.Method == CodeChallengeDigestMethod.S256)
            {
                // url safe base64
                // return sha256(options.codeChallenge).toString(CryptoJS.enc.Base64).replace(/\+/ g, '-').replace(/\//g, '_').replace(/=/g, '');
            }
            if (options.Method == CodeChallengeDigestMethod.PLAIN)
            {
                return options.CodeChallenge;
            }
            throw new Exception("不支持的 options.method，可选值为 S256、plain");
        }

        public async Task<HttpResponseMessage> GetAccessTokenByClientCredentials(string scope, GetAccessTokenByClientCredentialsOption options, CancellationToken cancellationToken =
        default)
        {
            var i = options.AccessKey ?? Options.AppId;
            var s = options.AccessSecret ?? Options.Secret;
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).PostUrlEncodedAsync(
                new
                {
                    client_id = i,
                    client_secret = s,
                    grant_type = "client_credentials",
                    scope,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<UserInfo> GetUserInfoByAccessToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/me",
                Protocol.OAUTH => "oauth/me",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithOAuthBearerToken(token).PostAsync(null, cancellationToken).ReceiveJson<UserInfo>();
            return res;
        }

        public string BuildAuthorizeUrl<T>(T option)
        {
            if (Host == null)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入应用域名 appHost 参数，形如：https://app1.authing.cn");
            }

            if (typeof(T) == typeof(OidcOption))
            {
                return BuildOidcAuthorizeUrl(option as OidcOption);
            }
            if (typeof(T) == typeof(OauthOption))
            {
                return BuildOauthAuthorizeUrl(option as OauthOption);
            }
            if (Options.Protocol == Protocol.SAML)
            {
                return BuildSamlAuthorizeUrl();
            }
            if (typeof(T) == typeof(CasOption))
            {
                return BuildCasAuthorizeUrl(option as CasOption);
            }

            throw new Exception("泛型类型必须是 OidcOption, OauthOption, CasOption 其中一种");
        }

        private string BuildOidcAuthorizeUrl(OidcOption option)
        {
            string prompt = "";
            if (option?.Scope?.IndexOf("offline_access") != -1)
            {
                prompt = "consent";
            }
            var rd = new Random();
            var res = new
            {
                nonce = option.Nonce ?? rd.Next(10, 99).ToString(),
                state = option.State ?? rd.Next(10, 99).ToString(),
                scope = "openid profile email phone address",
                client_id = option.AppId ?? Options.AppId,
                redirect_uri = option.RedirectUri ?? Options.RedirectUri,
                response_type = !(option.ResponseType is null) ? option.ResponseType.ToString().ToLower() : "code",
                code_challenge_method = option.CodeChallengeMethod?.ToString().ToLower(),
                code_challenge = option.CodeChallenge,
                response_mode = option.ResponseMode?.ToString().ToLower(),
                prompt = string.IsNullOrEmpty(prompt) ? null : prompt,
            };
            return $"{Options.Host ?? Host}/oidc/auth{"".SetQueryParams(res)}";
        }

        private string BuildOauthAuthorizeUrl(OauthOption option)
        {
            var rd = new Random();
            var res = new
            {
                state = option.State ?? rd.Next(10, 99).ToString(),
                scope = option.Scope ?? "openid profile email phone address",
                client_id = option.AppId ?? Options.AppId,
                redirect_uri = option.RedirectUri ?? Options.RedirectUri,
                response_type = option.ResponseType.ToString().ToLower() ?? "code",
            };
            return $"{Options.Host ?? Host}/oidc/auth{"".SetQueryParams(res)}";
        }

        private string BuildSamlAuthorizeUrl()
        {
            return $"{Host}/api/v2/saml-idp/{Options.AppId}";
        }

        private string BuildCasAuthorizeUrl(CasOption option)
        {
            if (option.Service != null)
            {
                return $"{Host}/cas-idp/{Options.AppId}?service={option.Service}";
            }
            return $"{Host}/cas-idp/{Options.AppId}";
        }

        private string BuildCasLogoutUrl(LogoutParams option = null)
        {
            if (option?.RedirectUri != null)
            {
                return $"{Host}/cas-idp/logout?url={option.RedirectUri}";
            }
            return $"{Host}/cas-idp/logout";
        }

        private string BuildOidcLogoutUrl(LogoutParams option = null)
        {
            if ((option?.RedirectUri == null && option?.IdToken != null) || (option?.RedirectUri != null && option?.IdToken == null))
            {
                throw new Exception("必须同时传入 idToken 和 redirectUri 参数，或者同时都不传入");
            }
            if (option?.RedirectUri != null)
            {
                return $"{Host}/oidc/session/end?url=id_token_hint={option.IdToken}&post_logout_redirect_uri={option.RedirectUri}";
            }
            return $"{Host}/oidc/session/end";
        }

        private string BuildEasyLogoutUrl(LogoutParams option = null)
        {
            if (option?.RedirectUri != null)
            {
                return $"{Host}/login/profile/logout?redirect_uri={option.RedirectUri}";
            }
            return $"{Host}/login/profile/logout";
        }

        public string BuildLogoutUrl(LogoutParams option = null)
        {
            if (Options?.Protocol == Protocol.CAS)
            {
                return BuildCasLogoutUrl(option);
            }

            if ((Options?.Protocol == Protocol.OIDC) && (bool)option?.Expert)
            {
                return BuildOidcLogoutUrl(option);
            }

            return BuildEasyLogoutUrl(option);
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithClientSecretPost(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithClientSecretBasic(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> GetNewAccessTokenByRefreshTokenWithNone(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    grant_type = "refresh_token",
                    refresh_token = refreshToken,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<HttpResponseMessage> GetNewAccessTokenByRefreshToken(string refreshToken, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretPost(refreshToken, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await GetNewAccessTokenByRefreshTokenWithClientSecretBasic(refreshToken, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await GetNewAccessTokenByRefreshTokenWithNone(refreshToken, cancellationToken);
            }
            throw new Exception("请检查参数 TokenEndPointAuthMethod");
        }

        private async Task<HttpResponseMessage> RevokeTokenWithClientSecretPost(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => "oauth/token/revocation",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> RevokeTokenWithClientSecretBasic(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => throw new Exception("OAuth 2.0 暂不支持用 client_secret_basic 模式身份验证撤回 Token"),
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> RevokeTokenWithNone(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/revocation",
                Protocol.OAUTH => "oauth/token/revocation",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<bool> RevokeToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                await RevokeTokenWithClientSecretPost(token, cancellationToken);
                return true;
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                await RevokeTokenWithClientSecretBasic(token, cancellationToken);
                return true;
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                await RevokeTokenWithNone(token, cancellationToken);
                return true;
            }
            throw new Exception("初始化 AuthenticationClient 时传入的 revocationEndPointAuthMethod 参数可选值为 client_secret_base、client_secret_post、none，请检查参数");
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithClientSecretPost(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    client_secret = Options.Secret,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithClientSecretBasic(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).WithBasicAuth(Options.AppId, Options.Secret).PostUrlEncodedAsync(
                new
                {
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        private async Task<HttpResponseMessage> IntrospectTokenWithNone(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token/introspection",
                Protocol.OAUTH => "oauth/token/introspection",
                _ => throw new ArgumentOutOfRangeException()
            };
            var res = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).PostUrlEncodedAsync(
                new
                {
                    client_id = Options.AppId,
                    token,
                },
                cancellationToken
            );
            return res.ResponseMessage;
        }

        public async Task<HttpResponseMessage> IntrospectToken(string token, CancellationToken cancellationToken =
        default)
        {
            var api = Options?.Protocol switch
            {
                Protocol.OIDC => "oidc/token",
                Protocol.OAUTH => "oauth/token",
                _ => throw new Exception("初始化 AuthenticationClient 时传入的 protocol 参数必须为 oauth 或 oidc，请检查参数")
            };
            if (Options?.Secret != null && Options.TokenEndPointAuthMethod != TokenEndPointAuthMethod.NONE)
            {
                throw new Exception("请在初始化 AuthenticationClient 时传入 appId 和 secret 参数");
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_POST)
            {
                return await IntrospectTokenWithClientSecretPost(token, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.CLIENT_SECRET_BASIC)
            {
                return await IntrospectTokenWithClientSecretBasic(token, cancellationToken);
            }
            if (Options.TokenEndPointAuthMethod == TokenEndPointAuthMethod.NONE)
            {
                return await IntrospectTokenWithNone(token, cancellationToken);
            }
            throw new Exception("初始化 AuthenticationClient 时传入的 revocationEndPointAuthMethod 参数可选值为 client_secret_base、client_secret_post、none，请检查参数");
        }

        public async Task<ValidateTicketV1Res> ValidateTicketV1(string ticket, string service, CancellationToken cancellationToken =
        default)
        {
            var api = $"cas-idp/{Options.AppId}/validate";
            var resStr = await Host.AppendPathSegment(api).WithHeaders(GetHeaders()).SetQueryParams(new
            {
                ticket,
                service
            }).
            GetJsonAsync<string>(cancellationToken);
            var regex = new Regex("\n");
            var resAtt = regex.Split(resStr);
            var valid = resAtt[0];
            var username = resAtt[1];
            var validable = valid == "yes";
            if (validable)
            {
                return new ValidateTicketV1Res()
                {
                    Valid = true,
                    Username = username
                };
            }
            else
            {
                return new ValidateTicketV1Res()
                {
                    Valid = true,
                    Username = username,
                    Message = "ticket 不合法"
                };
            }
        }

        public async Task<HttpResponseMessage> ValidateToken(ValidateTokenOption option, CancellationToken cancellationToken =
        default)
        {
            if (option.IdToken != null)
            {
                var res = await Host.AppendPathSegment("api/v2/oidc/validate_token").SetQueryParams(new
                {
                    id_token = option.IdToken
                }).GetAsync(cancellationToken);
                return res.ResponseMessage;
            }
            else if (option.AccessToken != null)
            {
                var res = await Host.AppendPathSegment("api/v2/oidc/validate_token").SetQueryParams(new
                {
                    access_token = option.AccessToken
                }).GetAsync(cancellationToken);
                return res.ResponseMessage;
            }
            throw new Exception("请在传入的参数对象中包含 accessToken 或 idToken 字段");
        }
    }
}
