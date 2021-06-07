﻿using Authing.ApiClient.Management.Types;
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

            public async Task<PaginatedAuthorizedTargets> GetAuthorizedTargets(GetAuthorizedTargetsOptions getAuthorizedTargetsOptions, CancellationToken cancellation = default)
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

            public async Task<ListResourcesRes> ListResources(ResourceQueryFilter resourceQueryFilter, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/resources").WithOAuthBearerToken(client.Token).SetQueryParams(
                    new Dictionary<string, object>
                    {
                        {
                            "namespace",
                            resourceQueryFilter.NameSpace
                        },
                        {
                            "type",
                            resourceQueryFilter.Type
                        },
                        {
                            "limit",
                            resourceQueryFilter.Limit
                        },
                        {
                            "page",
                            resourceQueryFilter.Page
                        }
                    }
                ).GetJsonAsync<ListResourcesRes>(cancellation);
                return res;
            }

            public async Task<Resources?> GetResourceById(string id, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/resources/detail").SetQueryParam("id", id).GetJsonAsync<Resources?>(cancellation);
                return res;
            }

            public async Task<Resources?> GetResourceByCode(GetResourceByCodeParam getResourceByCodeParam, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/resources/detail").SetQueryParams(new Dictionary<string, string>
                {
                    {
                    "namespace", getResourceByCodeParam.NameSpace
                    },
                    {
                        "code", getResourceByCodeParam.Code
                    }
                }).GetJsonAsync<Resources?>(cancellation);
                return res;
            }

            public async Task<ListResourcesRes> GetResources(ResourceQueryFilter resourceQueryFilter, CancellationToken cancellationToken = default)
            {
                var res = await ListResources(resourceQueryFilter);
                return res;
            }

            public async Task<Resources> CreateResource(CreateResourceParam createResourceParam, CancellationToken cancellationToken = default)
            {
                if (createResourceParam.Code == null)
                {
                    throw new Exception("请为资源设定一个资源标识符");
                }
                if (createResourceParam.Actions?.Length < 1)
                {
                    throw new Exception("请至少定义一个资源操作");
                }
                if (createResourceParam.NameSpace == null)
                {
                    throw new Exception("请传入权限分组标识符");
                }
                var res = await client.Host.AppendPathSegment("api/v2/resources").WithOAuthBearerToken(client.Token).PostJsonAsync(createResourceParam.ConvertJson(), cancellationToken).ReceiveJson<Resources>();
                return res;
            }

       
            public async Task<Resources> UpdateResource(string code, UpdateResourceParam updateResourceParam, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resources/{code}").PostJsonAsync(updateResourceParam.ConvertJson(), cancellationToken).ReceiveJson<Resources>();
                return res;
            }

            public async Task<bool> DeleteResource(string code, string nameSpace, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resources/{code}").SetQueryParam("namespace", nameSpace).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<ApplicationAccessPolicies> GetApplicationAccessPolicies(AppAccessPolicyQueryFilter appAccessPolicyQueryFilter, CancellationToken cancellationToken = default)
            {
                if (appAccessPolicyQueryFilter.AppId == null)
                {
                    throw new Exception("请传入 appId");
                }
                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicyQueryFilter.AppId}/authorization/records").SetQueryParams(new
                {
                    page = appAccessPolicyQueryFilter.Page,
                    limit = appAccessPolicyQueryFilter.Limit
                }).GetJsonAsync<ApplicationAccessPolicies>(cancellationToken);
                return res;
            }

            public async Task<CommonMessage> EnableApplicationAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
            {
                if (appAccessPolicy.AppId == null)
                {
                    throw new Exception("请传入 appId");
                }
                if (appAccessPolicy.TargetType == default)
                {
                    throw new Exception("请传入主体类型，可选值为 USER、ROLE、ORG、GROUP，含义为用户、角色、组织机构节点、用户分组");
                }
                if (appAccessPolicy.TartgetIdentifiers?.Length < 1)
                {
                    throw new Exception("请传入主体 id");
                }

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicy.AppId}/authorization/enable-effect").WithOAuthBearerToken(client.Token).PostJsonAsync(appAccessPolicy, cancellationToken);

                return new CommonMessage
                {
                    Code = 200,
                    Message = "启用应用访问控制策略成功"
                };
            }

            public async Task<CommonMessage> DisableApplicationAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
            {
                if (appAccessPolicy.AppId == null)
                {
                    throw new Exception("请传入 appId");
                }
                if (appAccessPolicy.TargetType == default)
                {
                    throw new Exception("请传入主体类型，可选值为 USER、ROLE、ORG、GROUP，含义为用户、角色、组织机构节点、用户分组");
                }
                if (appAccessPolicy.TartgetIdentifiers?.Length < 1)
                {
                    throw new Exception("请传入主体 id");
                }

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicy.AppId}/authorization/disable-effect").WithOAuthBearerToken(client.Token).PostJsonAsync(appAccessPolicy, cancellationToken);

                return new CommonMessage
                {
                    Code = 200,
                    Message = "停用应用访问控制策略成功"
                };
            }

            public async Task<CommonMessage> DeleteApplicationAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
            )
            {
                if (appAccessPolicy.AppId == null)
                {
                    throw new Exception("请传入 appId");
                }
                if (appAccessPolicy.TargetType == default)
                {
                    throw new Exception("请传入主体类型，可选值为 USER、ROLE、ORG、GROUP，含义为用户、角色、组织机构节点、用户分组");
                }
                if (appAccessPolicy.TartgetIdentifiers?.Length < 1)
                {
                    throw new Exception("请传入主体 id");
                }

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicy.AppId}/authorization/revoke").WithOAuthBearerToken(client.Token).PostJsonAsync(appAccessPolicy, cancellationToken);

                return new CommonMessage
                {
                    Code = 200,
                    Message = "删除应用访问控制策略成功"
                };
            }

            
        }
    }
}
