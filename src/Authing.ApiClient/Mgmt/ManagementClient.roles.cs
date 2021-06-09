using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using Authing.ApiClient.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Extensions;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        /// <summary>
        /// 角色管理
        /// </summary>
        public RolesManagementClient Roles { get; private set; }

        /// <summary>
        /// 角色管理类
        /// </summary>
        public class RolesManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 构造方法
            /// </summary>
            /// <param name="client"></param>
            public RolesManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 创建角色
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="description">角色描述</param>
            /// <param name="parentCode">父角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Role> Create(
                string code,
                string description = null,
                string parentCode = null,
                CancellationToken cancellationToken = default)
            {
                var param = new CreateRoleParam(code)
                {
                    Description = description,
                    Parent = parentCode,
                };
                var res = await client.Request<CreateRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 删除角色
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 在下一个大版本中去除
            public async Task<CommonMessage> Delete(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRoleParam(code);
                await client.GetAccessToken();
                var res = await client.Request<DeleteRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> Delete(
                string code,
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRoleParam(code)
                {
                    Namespace = _namespace
                };
                var res = await client.Request<DeleteRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量删除角色
            /// </summary>
            /// <param name="codeList">角色 code 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO： 在下一个大版本中去除
            public async Task<CommonMessage> DeleteMany(
                IEnumerable<string> codeList,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRolesParam(codeList);
                await client.GetAccessToken();
                var res = await client.Request<DeleteRolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> DeleteMany(
                IEnumerable<string> codeList,
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRolesParam(codeList)
                {
                    Namespace = _namespace
                };
                var res = await client.Request<DeleteRolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 修改角色资料
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="description">角色描述</param>
            /// <param name="newCode">新的 code</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 下一个大版本中去除
            public async Task<Role> Update(
                string code,
                string description = null,
                string newCode = null,
                CancellationToken cancellationToken = default)
            {
                var param = new UpdateRoleParam(code)
                {
                    Description = description,
                    NewCode = newCode,
                };
                await client.GetAccessToken();
                var res = await client.Request<UpdateRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Role> Update(
                string code,
                UpdateRoleOptions updateRoleOptions,
                CancellationToken cancellationToken = default)
            {
                var param = new UpdateRoleParam(code)
                {
                    Namespace = updateRoleOptions.NameSpace,
                    Description = updateRoleOptions.Description,
                    NewCode = updateRoleOptions.NewCode,
                };
                var res = await client.Request<UpdateRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }


            /// <summary>
            /// 获取角色详情
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO：下一个大版本去除
            public async Task<Role> Detail(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new RoleParam(code);
                await client.GetAccessToken();
                var res = await client.Request<RoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Role> Detail(
                string code,
                string _namespace = null,
                CancellationToken cancellationToken = default
            )
            {
                var param = new RoleParam(code)
                {
                    Namespace = _namespace
                };
                var res = await client.Request<RoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Role> FindByCode(
                string code,
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var res = await Detail(code, _namespace, cancellationToken);
                return res;
            }

            /// <summary>
            /// 获取用户池角色列表
            /// </summary>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO：下一个大版本去除
            public async Task<PaginatedRoles> List(
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new RolesParam() { Page = page, Limit = limit };
                await client.GetAccessToken();
                var res = await client.Request<RolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<PaginatedRoles> List(
                string _namespace,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new RolesParam()
                {
                    Page = page,
                    Limit = limit,
                    Namespace = _namespace
                };
                var res = await client.Request<RolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户列表
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO：下一个大版本去除            
            public async Task<PaginatedUsers> ListUsers(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new RoleWithUsersParam(code);
                await client.GetAccessToken();
                var res = await client.Request<RoleWithUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result.Users;
            }

            public async Task<PaginatedUsers> ListUsers(
                string code,
                ListUsersOption listUsersOption,
                CancellationToken cancellationToken = default)
            {
                if (!listUsersOption.WithCustomData)
                {
                    var _param = new RoleWithUsersParam(code)
                    {
                        Code = code,
                        Limit = listUsersOption.Limit,
                        Page = listUsersOption.Page,
                        Namespace = listUsersOption.NameSpace
                    };
                    var _res = await client.Request<RoleWithUsersResponse>(_param.CreateRequest(), cancellationToken);
                    return _res.Result.Users;
                }
                else
                {
                    var _param = new RoleWithUsersWithCustomDataParam(code)
                    {
                        Code = code,
                        Namespace = listUsersOption.NameSpace,
                        Page = listUsersOption.Page,
                        Limit = listUsersOption.Limit
                    };
                    var _res = await client.Request<RoleWithUsersWithCustomDataResponse>(_param.CreateRequest(), cancellationToken);
                    return _res.Result.Users;
                }
            }

            /// <summary>
            /// 批量添加用户到角色
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO：下一个大版本去除
            public async Task<CommonMessage> AddUsers(
                string code,
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam()
                {
                    UserIds = userIds,
                    RoleCode = code
                };
                await client.GetAccessToken();
                var res = await client.Request<AssignRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> AddUsers(
                string code,
                IEnumerable<string> userIds,
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam()
                {
                    UserIds = userIds,
                    RoleCode = code,
                    Namespace = _namespace
                };
                var res = await client.Request<AssignRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量移除角色上的用户
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO：下一个大版本去除
            public async Task<CommonMessage> RemoveUsers(
                string code,
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new RevokeRoleParam()
                {
                    UserIds = userIds,
                    RoleCode = code
                };
                await client.GetAccessToken();
                var res = await client.Request<RevokeRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<CommonMessage> RemoveUsers(
                string code,
                IEnumerable<string> userIds,
                string _namespace = null,
                CancellationToken cancellationToken = default
            )
            {
                var param = new RevokeRoleParam()
                {
                    UserIds = userIds,
                    RoleCode = code,
                    Namespace = _namespace,
                };
                var res = await client.Request<RevokeRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取策略列表
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedPolicyAssignments> ListPolicies(
                string code,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default
            )
            {
                var param = new PolicyAssignmentsParam()
                {
                    TargetType = PolicyAssignmentTargetType.ROLE,
                    TargetIdentifier = code,
                    Page = page,
                    Limit = limit,
                };
                var res = await client.Request<PolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量添加策略
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="policies">策略 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddPolicies(
                string code,
                IEnumerable<string> policies,
                CancellationToken cancellationToken = default)
            {
                var param = new AddPolicyAssignmentsParam(policies, PolicyAssignmentTargetType.ROLE)
                {
                    TargetIdentifiers = new string[] { code },
                };
                
                var res = await client.Request<AddPolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量移除策略
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="policies">策略 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> RemovePolicies(
                string code,
                IEnumerable<string> policies,
                CancellationToken cancellationToken = default)
            {
                var param = new RemovePolicyAssignmentsParam(policies, PolicyAssignmentTargetType.ROLE)
                {
                    TargetIdentifiers = new string[] { code },
                };
                var res = await client.Request<RemovePolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<Role> ListAuthorizedResources(string code, string _namespace, ResourceType resourceType = default, CancellationToken cancellationToken = default)
            {
                var param = new ListRoleAuthorizedResourcesParam(code)
                {
                    ResourceType = resourceType.ToString().ToUpper(),
                    Namespace = _namespace,
                };
                var res = await client.Request<ListRoleAuthorizedResourcesResponse>(param.CreateRequest(), cancellationToken);
                if (res.Result == null)
                {
                    throw new Exception("角色不存在");
                }
                return res.Result;
            }

            public async Task<List<KeyValuePair<string, object>>> GetUdfValue(string roleId, CancellationToken cancellationToken = default)
            {
                var param = new UdvParam(UdfTargetType.ROLE, roleId);
                var res = await client.Request<UdvResponse>(param.CreateRequest(), cancellationToken);
                return AuthingUtils.ConverUdvToKeyValuePair(res.Result);
            }

            public async Task<KeyValuePair<string, object>> GetSpecificUdfValue(string roleId, string udfKey, CancellationToken cancellationToken = default)
            {
                var param = new UdvParam(UdfTargetType.ROLE, roleId);
                var res = await client.Request<UdvResponse>(param.CreateRequest(), cancellationToken);
                var udfList = AuthingUtils.ConverUdvToKeyValuePair(res.Result);
                var keyValuePair = udfList.Where(item => item.Key == udfKey).ToList();
                return keyValuePair[0];
            }

            public async Task<Dictionary<string, List<KeyValuePair<string, object>>>> GetUdfValueBatch(IEnumerable<string> roleIds, CancellationToken cancellationToken = default)
            {
                var param = new UdfValueBatchParam(UdfTargetType.ROLE, roleIds);
                var res = await client.Request<UdfValueBatchResponse>(param.CreateRequest(), cancellationToken);
                var dic = new Dictionary<string, List<KeyValuePair<string, object>>>();
                res.Result.ToList().ForEach(
                    item =>
                        dic.Add(item.TargetId, AuthingUtils.ConverUdvToKeyValuePair(item.Data))
                );
                return dic;
            }

            public async void SetUdfValue(SetUdfValueParam setUdfValueParam, CancellationToken cancellationToken = default)
            {
                if (setUdfValueParam.UdvList?.Count < 1)
                {
                    throw new Exception("empty udf value list");
                }
                var _udvList = new List<UserDefinedDataInput>();
                setUdfValueParam.UdvList.ToList().ForEach(udv => _udvList.Add(
                new UserDefinedDataInput(udv.Key)
                {
                    Value = udv.Value.ConvertJson()
                }));
                var param = new SetUdvBatchParam(UdfTargetType.ROLE, setUdfValueParam.RoleId)
                {
                    UdvList = _udvList
                };
                var res = await client.Request<SetUdvBatchResponse>(param.CreateRequest(), cancellationToken);

                //TODO: 缺少返回值
            }

            public async void SetUdfValueBatch(IEnumerable<SetUdfValueParam> setUdfValueBatchParam, CancellationToken cancellationToken = default)
            {
                if (setUdfValueBatchParam.ToList().Count < 1)
                {
                    throw new Exception("empty input list");
                }
                var param = new List<SetUdfValueBatchInput>();
                setUdfValueBatchParam.ToList().ForEach(
                    setUdfValueBatch =>
                        setUdfValueBatch.UdvList.ToList().ForEach(udf => 
                        param.Add(new SetUdfValueBatchInput(setUdfValueBatch.RoleId, udf.Key, udf.Value))
                ));
                var _param = new Types.SetUdfValueBatchParam(UdfTargetType.ROLE, param);
                var res = await client.Request<SetUdvBatchResponse>(_param.CreateRequest(), cancellationToken);
                //TODO: 缺少返回值
            }

            public async void RemoveUdfValue(string roleId, string key, CancellationToken cancellationToken = default)
            {
                var param = new RemoveUdvParam(UdfTargetType.ROLE, roleId, key);
                var res = await client.Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
                // TODO: 缺少返回值
            }

        }
    }
}
