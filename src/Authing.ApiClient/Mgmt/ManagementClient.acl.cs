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
            /// TODO: 下个大版本去除
            /// WARNING: 去除 CancellationToken cancellationToken = default 参数以避免与重载函数冲突
            public async Task<CommonMessage> Allow(
                string resource, 
                string action, 
                string userId = null, 
                string role= null
                )
            {
                var param = new AllowParam(resource, action)
                {
                    UserId = userId,
                    RoleCode = role,
                };
                await client.GetAccessToken();
                var res = await client.Request<AllowResponse>(param.CreateRequest());
                return res.Result;
            }

            public async Task<CommonMessage> Allow(
                string userId,
                string resource,
                string action,
                string _namespace,
                CancellationToken cancellationToken = default)
            {
                var param = new AllowParam(resource, action)
                {
                    UserId = userId,
                    Resource = resource,
                    Namespace = _namespace
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
            /// TODO: 下个大版本去除
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
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new IsActionAllowedParam(resource, action, userId)
                {
                    Namespace = _namespace
                };
                var res = await client.Request<IsActionAllowedResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public void ListAuthorizedResources(
                PolicyAssignmentTargetType policyAssignmentTargetType,
                string targetIdentifier,
                string nameSpace,
                ResourceType resourceType,
                CancellationToken cancellation = default
            )
            {
                // TODO: 缺少对应的 Graph QL 类
                // var param = new AuthorizedResourceParam()
                // {
                //     Namespace = nameSpace,
                //     ResourceType = resourceType,
                    
                // };
                // var res = 
            }

            public async Task<CommonMessage> AuthorizeResource(
                string _namespace,
                string resource,
                AuthorizeResourceOpt[] authorizeResourceOptions,
                CancellationToken cancellation = default
            )
            {
                var param = new AuthorizeResourceParam()
                {
                    Namespace = _namespace,
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
                    Actions = getAuthorizedTargetsOptions.Actions,
                    TargetType = getAuthorizedTargetsOptions.TargetType
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
                var res = await ListResources(resourceQueryFilter, cancellationToken);
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

            public async Task<bool> DeleteResource(string code, string _namespace, CancellationToken cancellationToken = default)
            {
                // TODO: 返回结果是否合适
                var res = await client.Host.AppendPathSegment($"api/v2/resources/{code}").SetQueryParam("namespace", _namespace).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<ApplicationAccessPolicies> GetAccessPolicies(AppAccessPolicyQueryFilter appAccessPolicyQueryFilter, CancellationToken cancellationToken = default)
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

            public async Task<CommonMessage> EnableAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
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

            public async Task<CommonMessage> DisableAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default)
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

            public async Task<CommonMessage> DeleteAccessPolicy(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
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

            public async Task<CommonMessage> AllowAccess(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
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

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicy.AppId}/authorization/allow").WithOAuthBearerToken(client.Token).PostJsonAsync(appAccessPolicy, cancellationToken);

                return new CommonMessage
                {
                    Code = 200,
                    Message = "允许主体访问应用的策略配置已生效"
                };
            }

            public async Task<CommonMessage> DenyAccess(AppAccessPolicy appAccessPolicy, CancellationToken cancellationToken = default
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

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appAccessPolicy.AppId}/authorization/deny").WithOAuthBearerToken(client.Token).PostJsonAsync(appAccessPolicy, cancellationToken);

                return new CommonMessage
                {
                    Code = 200,
                    Message = "拒绝主体访问应用的策略配置已生效"
                };
            }

            public async Task<PublicApplication> UpdateDefaultAccessPolicy(UpdateDefaultApplicationAccessPolicyParam updateDefaultApplicationAccessPolicyParam, CancellationToken cancellationToken = default)
            {
                if (updateDefaultApplicationAccessPolicyParam.AppId == null)
                {
                    throw new Exception("请传入 appId");
                }

                if (updateDefaultApplicationAccessPolicyParam.DefaultStrategy == default)
                {
                    throw new Exception("请传入默认策略，可选值为 ALLOW_ALL、DENY_ALL，含义为默认允许所有用户登录应用、默认拒绝所有用户登录应用");
                }

                var res = await client.Host.AppendPathSegment($"api/v2/applications/{updateDefaultApplicationAccessPolicyParam.AppId}").WithOAuthBearerToken(client.Token).PostJsonAsync(new
                {
                    permissionStrategy = new
                    {
                        defaultStrategy = updateDefaultApplicationAccessPolicyParam.DefaultStrategy.ToString()?.ToUpper()
                    }
                }, cancellationToken).ReceiveJson<PublicApplication>();

                return res;
            }

            public async Task<ProgrammaticAccessAccountList> ProgrammaticAccessAccountList(string appId, int page = 1, int limit = 10, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appId}/programmatic-access-accounts").SetQueryParams(new 
                {
                    limit,
                    page
                }).WithOAuthBearerToken(client.Token).GetJsonAsync<ProgrammaticAccessAccountList>(cancellationToken);
                return res;
            }

            public async Task<ProgrammaticAccessAccount> CreateProgrammaticAccessAccount(string appId, CreateProgrammaticAccessAccountParam createProgrammaticAccessAccountParam, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/applications/{appId}/programmatic-access-accounts").WithOAuthBearerToken(client.Token).PostJsonAsync(createProgrammaticAccessAccountParam.ConvertJson(), cancellationToken).ReceiveJson<ProgrammaticAccessAccount>();
                return res;
            }

            public async Task<bool> DeleteProgrammaticAccessAccount(string programmaticAccessAccountId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/applications/programmatic-access-accounts").SetQueryParam("id", programmaticAccessAccountId).WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<ProgrammaticAccessAccount> RefreshProgrammaticAccessAccountSecret(
                string programmaticAccessAccountId,
                string programmaticAccessAccountSecret = null,
                CancellationToken cancellationToken = default
            )
            {
                if (programmaticAccessAccountSecret == null)
                {
                    programmaticAccessAccountSecret = AuthingUtils.GenerateRandomString(32);
                }
                var res = await client.Host.AppendPathSegment("api/v2/applications/programmatic-access-accounts").WithOAuthBearerToken(client.Token).PatchJsonAsync(
                    new
                    {
                        id = programmaticAccessAccountId,
                        secret = programmaticAccessAccountSecret
                    },
                    cancellationToken
                ).ReceiveJson<ProgrammaticAccessAccount>();
                return res;
            }

            public async Task<ProgrammaticAccessAccount> EnableProgrammaticAccessAccount(string programmaticAccessAccountId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/applications/programmatic-access-accounts").WithOAuthBearerToken(client.Token).PatchJsonAsync(new {
                    id = programmaticAccessAccountId,
                    enabled = true,
                }, cancellationToken).ReceiveJson<ProgrammaticAccessAccount>();
                return res;
            }

            public async Task<ProgrammaticAccessAccount> DisableProgrammaticAccessAccount(string programmaticAccessAccountId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/applications/programmatic-access-accounts").WithOAuthBearerToken(client.Token).PatchJsonAsync(new
                {
                    id = programmaticAccessAccountId,
                    enabled = false,
                }, cancellationToken).ReceiveJson<ProgrammaticAccessAccount>();
                return res;
            }

            public async Task<Namespaces> ListNamespaces(int page = 1, int limit = 10, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resource-namespace/{client.Options.UserPoolId}").SetQueryParams(new
                {
                    page,
                    limit
                }).WithOAuthBearerToken(client.Token).GetJsonAsync<Namespaces>(cancellationToken);
                return res;
            }

            public async Task<bool> DeleteNamespace(string code, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resource-namespace/{client.UserPoolId}/code/${code}").WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<NameSpace> CreateNamespace(string code, string name, string description, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resource-namespace/{client.UserPoolId}").WithOAuthBearerToken(client.Token).PostJsonAsync(new
                {
                    name,
                    code,
                    description
                }, cancellationToken).ReceiveJson<NameSpace>();
                return res;
            }

            public async Task<NameSpace> UpdateNamespace(string code, UpdateNamespaceParam updateNamespaceParam, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/resource-namespace/{client.UserPoolId}/code/{code}").WithOAuthBearerToken(client.Token).PutJsonAsync(new
                {
                    name = updateNamespaceParam.Name,
                    code = updateNamespaceParam.Code,
                    description = updateNamespaceParam.Description
                }, cancellationToken).ReceiveJson<NameSpace>();
                return res;
            }
        }
    }
}
