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
            /// 获取用户池角色列表
            /// </summary>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
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
                await client.GetAccessToken();
                var res = await client.Request<CreateRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取角色详情
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Role> Detail(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new RoleParam(code);
                await client.GetAccessToken();
                var res = await client.Request<RoleResponse>(param.CreateRequest(), cancellationToken);
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

            /// <summary>
            /// 删除角色
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Delete(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRoleParam(code);
                await client.GetAccessToken();
                var res = await client.Request<DeleteRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量删除角色
            /// </summary>
            /// <param name="codeList">角色 code 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<BatchOperationResult> DeleteMany(
                IEnumerable<string> codeList,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteRolesParam(codeList);
                await client.GetAccessToken();
                var res = await client.Request<DeleteRolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            } 

            /// <summary>
            /// 获取用户列表
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedUsers> ListUsers(
                string code,
                CancellationToken cancellationToken = default)
            {
                var param = new RoleWithUsersParam(code);
                await client.GetAccessToken();
                var res = await client.Request<RoleWithUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result.Users;
            }

            /// <summary>
            /// 批量添加用户到角色
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddUsers(
                string code,
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam() {
                    UserIds = userIds,
                    RoleCode = code
                };
                await client.GetAccessToken();
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

            /// <summary>
            /// 获取策略列表
            /// </summary>
            /// <param name="code">角色唯一标志</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedPolicyAssignment> ListPolicies(
                string code,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new PolicyAssignmentsParam()
                {
                    TargetType = PolicyAssignmentTargetType.ROLE,
                    TargetIdentifier = code,
                    Page = page,
                    Limit = limit,
                };
                await client.GetAccessToken();
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
                await client.GetAccessToken();
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
                await client.GetAccessToken();
                var res = await client.Request<RemovePolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
