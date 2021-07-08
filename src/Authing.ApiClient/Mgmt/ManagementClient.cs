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
        private int? accessTokenExpriredAt = 0;

        private string Sercet { get; set; }
        
        

        public Action<InitAuthenticationClientOptions> Init { get; }

        /// <summary>
        /// 构造方法
        /// </summary>
        private ManagementClient(string userPoolId, string secret) : base(userPoolId)
        {
            // this.secret = secret;
        }

        private ManagementClient(Action<InitAuthenticationClientOptions> init) : base(init)
        {
            if (init is null)
            {
                throw new ArgumentNullException(nameof(init));
            }
            Init = init;
        }

        public static async Task<ManagementClient> InitManagementClient(string userPoolId, string secret)
        {
            var manageClient = new ManagementClient(userPoolId, secret);
            await manageClient.GetAccessToken();

            manageClient.Users = new UsersManagementClient(manageClient);
            manageClient.Roles = new RolesManagementClient(manageClient);
            manageClient.Acl = new AclManagementClient(manageClient);
            manageClient.Groups = new GroupsManagementClient(manageClient);
            manageClient.Udf = new UdfManagementClient(manageClient);
            manageClient.Whitelist = new WhitelistManagementClient(manageClient);
            manageClient.Userpool = new UserpoolManagementClient(manageClient);
            manageClient.Policies = new PoliciesManagementClient(manageClient);
            return manageClient;
        }


        public static async Task<ManagementClient> InitManagementClient(Action<InitAuthenticationClientOptions> init)
        {
            var manageClient = new ManagementClient(init);
            await manageClient.GetAccessToken();

            manageClient.Users = new UsersManagementClient(manageClient);
            manageClient.Roles = new RolesManagementClient(manageClient);
            manageClient.Acl = new AclManagementClient(manageClient);
            manageClient.Groups = new GroupsManagementClient(manageClient);
            manageClient.Orgs = new OrgManagementClient(manageClient);
            manageClient.Udf = new UdfManagementClient(manageClient);
            manageClient.Whitelist = new WhitelistManagementClient(manageClient);
            manageClient.Userpool = new UserpoolManagementClient(manageClient);
            manageClient.Policies = new PoliciesManagementClient(manageClient);
            return manageClient;
        }

        private async Task<AccessTokenRes> GetClientWhenSdkInit(CancellationToken cancellationToken = default)
        {
            var param = new AccessTokenParam(UserPoolId, Secret);
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
