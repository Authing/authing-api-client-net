using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Authing.ApiClient.Extensions;
using Authing.ApiClient.Utils;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        public ApplicationsManagementClient Applications { get; private set; }

        public class ApplicationsManagementClient
        {
            private readonly ManagementClient client;
            private readonly AclManagementClient aclManagementClient;

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public ApplicationsManagementClient(ManagementClient client)
            {
                this.client = client;
                this.aclManagementClient = client.Acl;
            }

            public async Task<object> List(int page = 1, int limit = 2, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/applications").WithOAuthBearerToken(client.Token).SetQueryParams(new
                {
                    page,
                    limit
                }).GetJsonAsync<ApplicationList>(cancellationToken);
                return res;
            }

            public async Task<Application> Create(string name, string identifier, string redirectUris, string logo = null, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/applications").WithOAuthBearerToken(client.Token).PostJsonAsync(new
                {
                    name,
                    identifier,
                    redirectUris,
                    logo
                }, cancellationToken).ReceiveJson<Application>();
                return res;
            }

            public async Task<bool> Delete(string appId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appId}").WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<Application> findById(string id, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/applications/{id}").WithOAuthBearerToken(client.Token).GetJsonAsync<Application>(cancellationToken);
                return res;
            }

            public async Task<Resources> CreateResource(string appId, CreateResourceParam createResourceParam, CancellationToken cancellationToken = default)
            {
                createResourceParam.NameSpace = appId;
                var res = await aclManagementClient.CreateResource(createResourceParam, cancellationToken);
                return res;
            }

            public async Task<Resources> UpdateResource(string appId, string code, UpdateResourceParam updateResourceParam, CancellationToken cancellationToken = default)
            {
                updateResourceParam.NameSpace = appId;
                var res = await aclManagementClient.UpdateResource(code, updateResourceParam, cancellationToken);
                return res;
            }

            public async Task<bool> DeleteResource(string  appId,string code, CancellationToken cancellationToken = default)
            {
                var res = await aclManagementClient.DeleteResource(code, appId, cancellationToken);
                return res;
            }

            public async Task<ApplicationAccessPolicies> GetAccessPolicies(string appId,AppAccessPolicyQueryFilter appAccessPolicyQueryFilter, CancellationToken cancellationToken = default)
            {
                appAccessPolicyQueryFilter.AppId = appId;
                var res = await aclManagementClient.GetAccessPolicies(appAccessPolicyQueryFilter, cancellationToken);
                return res;
            }

            public async Task<CommonMessage> EnableAccessPolicy(string appId, AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
            {
                appAccessPolicy.NameSpace = appId;
                appAccessPolicy.AppId = appId;
                var res = await aclManagementClient.EnableAccessPolicy(appAccessPolicy, cancellationToken);
                return res;
            }

            public async Task<CommonMessage> DisableAccessPolicy(string appId,AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
            {
                appAccessPolicy.AppId = appId;
                appAccessPolicy.NameSpace = appId;
                var res = await aclManagementClient.DisableAccessPolicy(appAccessPolicy, cancellationToken);
                return res;
            }

            public async Task<CommonMessage> DeleteAccessPolicy(string appId, AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
            )
            {
                appAccessPolicy.AppId = appId;
                appAccessPolicy.NameSpace = appId;
                var res = await aclManagementClient.DeleteAccessPolicy(appAccessPolicy, cancellationToken);
                return res;
            }

            public async Task<CommonMessage> AllowAccess(string appId, AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
            )
            {
                appAccessPolicy.AppId = appId;
                appAccessPolicy.NameSpace = appId;
                var res = await aclManagementClient.AllowAccess(appAccessPolicy, cancellationToken);
                return res;
            }

        }
    }
}
