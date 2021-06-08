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
                await client.GetAccessToken();

                var url = $"{client.Host}/api/v2/env";
                var message = new HttpRequestMessage(HttpMethod.Post, url)
                {
                    Content = new StringContent(JsonConvert.SerializeObject(
                    new
                    {
                        key,
                        value,
                    },
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }), Encoding.UTF8, "application/json")
                };
                var result = await client.Send(message, cancellationToken);

                if (!result.IsSuccessStatusCode)
                {
                    throw new AuthingException(result.ReasonPhrase, (int)result.StatusCode);
                }

                var content = await result.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<RestfulResponse<Env>>(content);

                if (res.Code != 200)
                {
                    throw new AuthingException(res.Message, res.Code);
                }

                return res.Data;
            }

            /// <summary>
            /// 删除环境变量
            /// </summary>
            /// <param name="key">环境变量键</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task RemoveEnv(
                string key,
                CancellationToken cancellationToken = default)
            {
                await client.GetAccessToken();

                var url = $"{client.Host}/api/v2/env/${key}";
                var message = new HttpRequestMessage(HttpMethod.Delete, url);
                var result = await client.Send(message, cancellationToken);

                if (!result.IsSuccessStatusCode)
                {
                    throw new AuthingException(result.ReasonPhrase, (int)result.StatusCode);
                }

                var content = await result.Content.ReadAsStringAsync();
                var res = JsonConvert.DeserializeObject<RestfulResponse<object>>(content);

                if (res.Code != 200)
                {
                    throw new AuthingException(res.Message, res.Code);
                }
            }
        }
    }
}
