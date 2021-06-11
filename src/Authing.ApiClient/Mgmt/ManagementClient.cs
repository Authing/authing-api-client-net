using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient.Mgmt
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

        public Action<InitAuthenticationClientOptions> Init { get; }

        /// <summary>
        /// 构造方法
        /// </summary>
        public ManagementClient(string userPoolId, string secret): base(userPoolId)
        {
            this.secret = secret;
        }

        public ManagementClient(Action<InitAuthenticationClientOptions> init) : base(init)
        {
            if (init is null)
            {
                throw new ArgumentNullException(nameof(init));
            }
            Init = init;
        }

        public async Task<ManagementClient> InitManagementClient(string userPoolId, string secret)
        {
            var manageClient = new ManagementClient(userPoolId, secret);
            await manageClient.GetAccessToken();

            Users = new UsersManagementClient(manageClient);
            Roles = new RolesManagementClient(manageClient);
            Acl = new AclManagementClient(manageClient);
            Groups = new GroupsManagementClient(manageClient);
            Udf = new UdfManagementClient(manageClient);
            Whitelist = new WhitelistManagementClient(manageClient);
            Userpool = new UserpoolManagementClient(manageClient);
            Policies = new PoliciesManagementClient(manageClient);
            return manageClient;
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
