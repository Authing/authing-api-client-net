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
using Authing.ApiClient.Management.Types;


namespace Authing.ApiClient.Auth
{
    /// <summary>
    /// Authing 认证客户端类
    /// </summary>
    public partial class AuthenticationClient : BaseClient
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
            // TODO: 是否需要返回值
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
                x_authing_lang = Options.Lang.ToString().ToUpper(),
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
        public async Task<string> ListOrgs(CancellationToken cancellationToken = default)
        {
            // TODO: 确定返回类型
            var res = await Host.AppendPathSegment("api/v2/users/me/orgs").WithHeaders(GetHeaders()).GetJsonAsync(cancellationToken);
            return res;
        }
        
        // TODO: 缺少方法

        /// <summary>
        /// 通过 LDAP 进行登录
        /// </summary>
        /// <param name="username">LDAP 用户名</param>
        /// <param name="password">LDAP 用户密码</param>
        /// <param name="cancellationToken"></param>
        /// <returns>User</returns>
        /// TODO: 下个大版本去除
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

        // TODO: 缺少 loginByLdap 重载方法

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
            var user = await websocketHost.AppendPathSegment("api/v2/ldap/verify-user").WithHeaders(GetHeaders()).PostJsonAsync(new
            {
                username,
                password
            },
                cancellationToken).ReceiveJson<User>();
            SetCurrentUser(user);
            return user;
        }

        // TODO: 缺少 uploadPhoto 方法
        // TODO: 缺少 updateAvatar 方法
        // TODO: 缺少 uploadAvatar 方法

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
                    Value = item.Value.ConvertJson(),
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
            // TODO: 注意返回类型转换
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
            var param = new ListUserAuthorizedResourcesParam(userId)
            {
                Namespace = _namespace,
                ResourceType = _resourceType?.ToString()?.ToUpper(),
            };
            var res = await Request<ListUserAuthorizedResourcesResponse>(param.CreateRequest(), cancellationToken);
            var user = res.Result;
            if (user == null)
            {
                throw new Exception("用户不存在");
            }

            var authorizedResources = user.AuthorizedResources;
            var list = authorizedResources.List;
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
            // TODO: 正则需要额外注意一下
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
        // INFO: 这个 RefreshToken 与上面的 RefreshToken 是有区别的
        public async Task<RefreshToken> RefreshToken(
            string accessToken = null,
            CancellationToken cancellationToken = default)
        {
            CheckLoggedIn();
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
            if (roleList == null || !roleList.Any())
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
        public async Task<ApplicationList> ListApplications(ListParams _params = null, CancellationToken cancellationToken =
        default)
        {
            // TODO: 注意返回类型转换
            _params ??= new ListParams();
            var res = await Host.AppendPathSegment(
                $"api/v2/users/me/applications/allowed").SetQueryParams(new 
                {
                    page = _params.Page,
                    limit = _params.Limit   
                }).WithHeaders(GetHeaders()).GetJsonAsync<ApplicationList>(cancellationToken);
            return res;
        }

        public void SetLang(LangEnum lang)
        {
            Options.Lang = lang;
        }
    }
}
