using Authing.ApiClient.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        /// <summary>
        /// 用户池管理模块
        /// </summary>
        public UserpoolManagementClient Userpool { get; private set; }

        /// <summary>
        /// 用户池管理类
        /// </summary>
        public class UserpoolManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public UserpoolManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 用户池详情
            /// </summary>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<UserPool> Detail(CancellationToken cancellationToken = default)
            {
                // var param = new UserpoolParam();

                // await client.GetAccessToken();
                // var res = await client.Request<UserpoolResponse>(param.CreateRequest(), cancellationToken);
                // return res.Result;
                var res = await client.Host.AppendPathSegment("api/v2/userpools/detail").WithOAuthBearerToken(client.Token).GetJsonAsync<UserPool>(cancellationToken);
                return res;
            }

            /// <summary>
            /// 更新用户池信息
            /// </summary>
            /// <param name="updates"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<UserPool> Update(UpdateUserpoolInput updates, CancellationToken cancellationToken = default)
            {
                var param = new UpdateUserpoolParam(updates);

                var res = await client.Request<UpdateUserpoolResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取环境变量列表
            /// </summary>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<Env>> ListEnv(CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/env").WithOAuthBearerToken(client.Token).GetJsonAsync<IEnumerable<Env>>(cancellationToken);
                return res;
            }

            /// <summary>
            /// 添加环境变量
            /// </summary>
            /// <param name="key">环境变量键</param>
            /// <param name="value">环境变量值</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Env> AddEnv(
                string key,
                object value,
                CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/env").WithOAuthBearerToken(client.Token).PatchJsonAsync(new
                {
                    key,
                    value
                }, cancellationToken).ReceiveJson<Env>();
                return res;
            }

            /// <summary>
            /// 删除环境变量
            /// </summary>
            /// <param name="key">环境变量键</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Dictionary<string, object>> RemoveEnv(
                string key,
                CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/env/{key}").WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken).ReceiveJson<Dictionary<string, object>>();
                return res;
            }
        }
    }
}
