using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    /// <summary>
    /// Authing 管理类
    /// </summary>
    public partial class ManagementClient : BaseClient
    {
        /// <summary>
        /// 用户池密钥，可以在控制台获取
        /// </summary>
        public string Secret { get; set; }

        private UserPool currentUserPool = null;
        private int accessTokenExpriredAt = 0;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagementClient()
        {
            users = new UsersManagementClient(this);
            roles = new RolesManagementClient(this);
            acl = new AclManagementClient(this);
        }

        private async Task<UserPool> GetUserpoolDetail(CancellationToken cancellationToken = default)
        {
            if (currentUserPool != null)
            {
                return currentUserPool;
            }

            var param = new UserpoolParam();
            var res = await Request<UserpoolResponse>(param.CreateRequest(), cancellationToken);
            currentUserPool = res.Result;
            return res.Result;
        }

        private async Task<AccessTokenRes> GetClientWhenSdkInit(CancellationToken cancellationToken = default)
        {
            var param = new AccessTokenParam()
            {
                UserPoolId = UserPoolId,
                Secret = Secret,
            };
            var res = await Request<AccessTokenResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        private async Task<string> GetAccessToken(CancellationToken cancellationToken = default)
        {
            long now = DateTimeOffset.Now.ToUnixTimeSeconds();

            if (accessTokenExpriredAt > now + 3600)
            {
                return accessToken;
            }
            var res = await GetClientWhenSdkInit(cancellationToken);
            accessToken = res.AccessToken;
            accessTokenExpriredAt = res.Exp ?? 0;
            return accessToken;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="fetchUserDetail"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task CheckLoginStatus(
            string token,
            bool fetchUserDetail = false,
            CancellationToken cancellationToken = default)
        {
            var jwtSecret = (await GetUserpoolDetail()).JwtSecret;
            
        }
    }
}
