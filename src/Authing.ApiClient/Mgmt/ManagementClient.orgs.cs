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
        public OrgManagementClient Orgs { get; private set; }

        public class OrgManagementClient
        {
            private readonly ManagementClient client;
            

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public OrgManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            public async Task<Types.Org> Create(string name, string description = null, string code = null, CancellationToken cancellationToken = default)
            {
                var param = new CreateOrgParam(name)
                {
                    Description = description,
                    Code = code
                };
                var res = await client.Request<CreateOrgResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            

            

        }
    }
}
