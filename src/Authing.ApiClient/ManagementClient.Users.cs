using Authing.ApiClient.Types;
using Newtonsoft.Json;
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
        /// 用户管理模块
        /// </summary>
        public UsersManagementClient users;

        /// <summary>
        /// 用户管理类
        /// </summary>
        public class UsersManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public UsersManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 获取用户列表
            /// </summary>
            /// <param name="page">当前页数，默认为 1</param>
            /// <param name="limit">每页最大数量，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedUsers> List(
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new UsersParam()
                {
                    Page = page,
                    Limit = limit,
                };
                await client.GetAccessToken();
                var res = await client.Request<UsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 创建用户
            /// </summary>
            /// <param name="userInfo">用户信息</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<User> Create(
                CreateUserInput userInfo,
                CancellationToken cancellationToken = default)
            {
                userInfo.Password = client.Encrypt(userInfo.Password);
                var param = new CreateUserParam()
                {
                    UserInfo = userInfo,
                };
                await client.GetAccessToken();
                var res = await client.Request<CreateUserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 更新用户信息
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="updates">更新信息</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<User> Update(
                string userId,
                UpdateUserInput updates,
                CancellationToken cancellationToken = default)
            {
                updates.Password = client.Encrypt(updates.Password);
                var param = new UpdateUserParam()
                {
                    Id = userId,
                    Input = updates,
                };
                await client.GetAccessToken();
                var res = await client.Request<UpdateUserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户信息
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<User> Detail(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new UserParam() { Id = userId };
                await client.GetAccessToken();
                var res = await client.Request<UserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 模糊搜索用户
            /// </summary>
            /// <param name="query">关键字</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedUsers> Search(
                string query,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new SearchUserParam()
                {
                    Query = query,
                    Page = page,
                    Limit = limit,
                };
                await client.GetAccessToken();
                var res = await client.Request<SearchUserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 通过 ID 列表批量获取用户信息
            /// </summary>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<User>> Batch(
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new UserBatchParam() { Ids = userIds };
                await client.GetAccessToken();
                var res = await client.Request<UserBatchResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 删除用户
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Delete(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteUserParam() { Id = userId };
                await client.GetAccessToken();
                var res = await client.Request<DeleteUserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量删除用户
            /// </summary>
            /// <param name="userIds">用户 ID 列表，多个 ID 以英文逗号分隔</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> DeleteMany(
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteUsersParam() { Ids = userIds };
                await client.GetAccessToken();
                var res = await client.Request<DeleteUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户角色列表
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedRoles> ListRoles(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new GetUserRolesParam() { Id = userId };
                await client.GetAccessToken();
                var res = await client.Request<GetUserRolesResponse>(param.CreateRequest(), cancellationToken);
                return res.Result.Roles;
            }

            /// <summary>
            /// 批量授权角色
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="roles">用户角色 Code 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddRoles(
                IEnumerable<string> userId,
                IEnumerable<string> roles,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam() { UserIds = userId, RoleCodes = roles };
                await client.GetAccessToken();
                var res = await client.Request<AssignRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量撤销用户角色
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="roles">用户角色 Code 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> RemoveRoles(
                IEnumerable<string> userId,
                IEnumerable<string> roles,
                CancellationToken cancellationToken = default)
            {
                var param = new RevokeRoleParam() { UserIds = userId, RoleCodes = roles };
                await client.GetAccessToken();
                var res = await client.Request<RevokeRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 刷新 access token
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<RefreshToken> RefreshToken(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new RefreshTokenParam() { Id = userId };
                await client.GetAccessToken();
                var res = await client.Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取策略列表
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedPolicyAssignment> ListPolicies(
                string userId,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new PolicyAssignmentsParam() {
                    TargetType = PolicyAssignmentTargetType.USER,
                    TargetIdentifier = userId,
                    Page = page,
                    Limit = limit
                };
                await client.GetAccessToken();
                var res = await client.Request<PolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 添加策略
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="policies">策略列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddPolicies(
                string userId,
                IEnumerable<string> policies,
                CancellationToken cancellationToken = default)
            {
                var param = new AddPolicyAssignmentsParam()
                {
                    TargetType = PolicyAssignmentTargetType.USER,
                    TargetIdentifiers = new string[] { userId },
                    Policies = policies,
                };
                await client.GetAccessToken();
                var res = await client.Request<AddPolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 移除策略
            /// </summary>
            /// <param name="userId"></param>
            /// <param name="policies"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> RemovePolicies(
                string userId,
                IEnumerable<string> policies,
                CancellationToken cancellationToken = default)
            {
                var param = new RemovePolicyAssignmentsParam()
                {
                    TargetType = PolicyAssignmentTargetType.USER,
                    TargetIdentifiers = new string[] { userId },
                    Policies = policies,
                };
                await client.GetAccessToken();
                var res = await client.Request<RemovePolicyAssignmentsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户自定义字段的值列表
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<UserDefinedData>> ListUdv(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new UdvParam()
                {
                    TargetId = userId,
                    TargetType = UdfTargetType.USER,
                };
                var res = await client.Request<UdvResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 设置自定义字段值
            /// </summary>
            /// <param name="userId"></param>
            /// <param name="key"></param>
            /// <param name="value"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<UserDefinedData>> AddUdv(
                string userId,
                string key,
                object value,
                CancellationToken cancellationToken = default)
            {
                var param = new SetUdvParam()
                {
                    Key = key,
                    Value = JsonConvert.SerializeObject(value),
                    TargetId = userId,
                    TargetType = UdfTargetType.USER,
                };
                var res = await client.Request<SetUdvResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 移除用户自定义字段的值
            /// </summary>
            /// <param name="userId"></param>
            /// <param name="key"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<IEnumerable<UserDefinedData>> RemoveUdv(
                string userId,
                string key,
                CancellationToken cancellationToken = default)
            {
                var param = new RemoveUdvParam()
                {
                    Key = key,
                    TargetId = userId,
                    TargetType = UdfTargetType.USER,
                };
                var res = await client.Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
