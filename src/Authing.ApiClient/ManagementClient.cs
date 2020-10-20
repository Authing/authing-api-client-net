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
        private readonly string secret;
        private int? accessTokenExpriredAt = 0;

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagementClient(string userPoolId, string secret)
        {
            UserPoolId = userPoolId;
            this.secret = secret;

            Users = new UsersManagementClient(this);
            Roles = new RolesManagementClient(this);
            Acl = new AclManagementClient(this);
        }

        private async Task<AccessTokenRes> GetClientWhenSdkInit(CancellationToken cancellationToken = default)
        {
            var param = new AccessTokenParam(UserPoolId, secret);
            var res = await Request<AccessTokenResponse>(param.CreateRequest(), cancellationToken);
            return res.Result;
        }

        private async Task<string> GetAccessToken(CancellationToken cancellationToken = default)
        {
            long now = DateTimeOffset.Now.ToUnixTimeSeconds();

            if (accessTokenExpriredAt.HasValue && accessTokenExpriredAt > now + 3600)
            {
                return AccessToken;
            }
            var res = await GetClientWhenSdkInit(cancellationToken);
            AccessToken = res.AccessToken;
            accessTokenExpriredAt = res.Exp;
            return AccessToken;
        }
    }
}
