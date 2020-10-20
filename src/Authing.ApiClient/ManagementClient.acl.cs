using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public partial class ManagementClient
    {
        /// <summary>
        /// 权限控制
        /// </summary>
        public AclManagementClient Acl { get; private set; }

        /// <summary>
        /// 权限控制类
        /// </summary>
        public class AclManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public AclManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 允许某个用户操作某个资源
            /// </summary>
            /// <param name="resource"></param>
            /// <param name="action"></param>
            /// <param name="userId"></param>
            /// <param name="role"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Allow(
                string resource, 
                string action, 
                string userId= null, 
                string role= null,
                CancellationToken cancellationToken = default)
            {
                var param = new AllowParam(resource, action)
                {
                    UserId = userId,
                    RoleCode = role,
                };
                await client.GetAccessToken();
                var res = await client.Request<AllowResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 是否允许某个用户操作某个资源
            /// </summary>
            /// <param name="userId"></param>
            /// <param name="action"></param>
            /// <param name="resource"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<bool> IsAllowed(
                string userId,
                string action,
                string resource,
                CancellationToken cancellationToken = default)
            {
                var param = new IsActionAllowedParam(resource, action, userId);
                await client.GetAccessToken();
                var res = await client.Request<IsActionAllowedResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
