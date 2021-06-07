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

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public ApplicationsManagementClient(ManagementClient client)
            {
                this.client = client;
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



        }
    }
}
