using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient.Mgmt
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

            // /// <summary>
            // /// 允许某个用户操作某个资源
            // /// </summary>
            // /// <param name="resource"></param>
            // /// <param name="action"></param>
            // /// <param name="userId"></param>
            // /// <param name="role"></param>
            // /// <param name="cancellationToken"></param>
            // /// <returns></returns>
            // public async Task<CommonMessage> Allow(
            //     string resource, 
            //     string action, 
            //     string userId = null, 
            //     string role= null,
            //     CancellationToken cancellationToken = default)
            // {
            //     var param = new AllowParam(resource, action)
            //     {
            //         UserId = userId,
            //         RoleCode = role,
            //     };
            //     await client.GetAccessToken();
            //     var res = await client.Request<AllowResponse>(param.CreateRequest(), cancellationToken);
            //     return res.Result;
            // }

            public async Task<CommonMessage> Allow(
                string userId,
                string resource,
                string action,
                string nameSpace,
                CancellationToken cancellationToken = default)
            {
                var param = new AllowParam(resource, action)
                {
                    UserId = userId,
                    Resource = resource,
                    Namespace = nameSpace
                };
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

            public async Task<bool> IsAllowed(
                string userId,
                string resource,
                string action,
                string nameSpace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new IsActionAllowedParam(resource, action, userId)
                {
                    Namespace = nameSpace
                };
                var res = await client.Request<IsActionAllowedResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            // public async Task<object> listAuthorizedResources(
            //     PolicyAssignmentTargetType policyAssignmentTargetType,
            //     string targetIdentifier,
            //     string nameSpace,
            //     ResourceType resourceType,
            //     CancellationToken cancellation = default
            // )
            // {
            //     var param = new ListAuth
            //     var res = 
            // }

            public async Task<CommonMessage> AuthorizeResource(
                string nameSpace,
                string resource,
                AuthorizeResourceOpt[] authorizeResourceOptions,
                CancellationToken cancellation = default
            )
            {
                var param = new AuthorizeResourceParam()
                {
                    Namespace = nameSpace,
                    Resource = resource,
                    Opts = authorizeResourceOptions
                };
                var res = await client.Request<AuthorizeResourceResponse>(param.CreateRequest(), cancellation);
                return res.Result;
            }

            public async Task<object> GetAuthorizedTargets(GetAuthorizedTargetsOptions getAuthorizedTargetsOptions, CancellationToken cancellation = default)
            {
                if (getAuthorizedTargetsOptions.NameSpace == null)
                {
                    throw new Exception("请传入 options.namespace，含义为权限分组标识");
                }
                if (getAuthorizedTargetsOptions.Resource == null)
                {
                    throw new Exception("请传入 options.resource，含义为资源标识");
                }
                if (getAuthorizedTargetsOptions.ResourceType == default)
                {
                    throw new Exception("请传入 options.resourceType，含义为资源类型");
                }
                var param = new AuthorizedTargetsParam(getAuthorizedTargetsOptions.NameSpace, getAuthorizedTargetsOptions.ResourceType, getAuthorizedTargetsOptions.Resource)
                {
                    Actions = getAuthorizedTargetsOptions.Actions
                };
                var res = await client.Request<AuthorizedTargetsResponse>(param.CreateRequest(), cancellation);
                return res.Result;
            }

        }
    }
}
