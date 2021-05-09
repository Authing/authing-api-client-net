using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        /// <summary>
        /// 用户管理模块
        /// </summary>
        public UsersManagementClient Users { get; private set; }

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
            /// 创建用户
            /// </summary>
            /// <param name="userInfo">用户信息</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<User> Create(
                CreateUserInput userInfo,
                bool keepPassword = false,
                CancellationToken cancellationToken = default)
            {
                userInfo.Password = client.Encrypt(userInfo.Password);
                var param = new CreateUserParam(userInfo)
                {
                    KeepPassword = keepPassword,
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
                var param = new UpdateUserParam(updates)
                {
                    Id = userId,
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
            /// 删除用户
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Delete(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new DeleteUserParam(userId);
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
                var param = new DeleteUsersParam(userIds);
                await client.GetAccessToken();
                var res = await client.Request<DeleteUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 通过 ID 列表批量获取用户信息
            /// </summary>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<HttpResponseMessage> Batch(
                IEnumerable<string> userIds,
                BatchFetchUserTypes batchFetchUserType = BatchFetchUserTypes.ID,
                CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/users/batch").WithHeaders(client.GetAuthHeaders()).WithOAuthBearerToken(client.AccessToken).PostJsonAsync(new {
                    ids = userIds,
                    type = batchFetchUserType.ToString(),
                }, cancellationToken);
                return res.ResponseMessage;
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

            public async Task<PaginatedUsers> ListArchivedUsers(int page = 1, int limit = 10, CancellationToken cancellation = default)
            {
                var param = new ArchivedUsersParam()
                {
                    Page = page,
                    Limit = limit,
                };
                var res = await client.Request<ArchivedUsersResponse>(param.CreateRequest(), cancellation);
                return res.Result;
            }

            public async Task<bool?> Exists(ExistsOptions options, CancellationToken cancellation = default)
            {
                var parma = new IsUserExistsParam() { 
                    Username = options.Username,
                    Email = options.Email,
                    Phone = options.Email
                };
                var res = await client.Request<IsUserExistsResponse>(parma.CreateRequest(), cancellation);
                return res.Result;
            }

            /// <summary>
            /// 通过手机号、游戏、用户名查找用户
            /// </summary>
            /// <param name="username">用户名</param>
            /// <param name="phone">手机号</param>
            /// <param name="email">邮箱</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<User> Find(
                string username = null,
                string phone = null,
                string email = null,
                CancellationToken cancellationToken = default)
            {
                var param = new FindUserParam()
                {
                    Username = username,
                    Phone = phone,
                    Email = email
                };
                await client.GetAccessToken();
                var res = await client.Request<FindUserResponse>(param.CreateRequest(), cancellationToken);
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
                var param = new SearchUserParam(query)
                {
                    Page = page,
                    Limit = limit,
                };
                await client.GetAccessToken();
                var res = await client.Request<SearchUserResponse>(param.CreateRequest(), cancellationToken);
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
            /// 获取用户分组列表
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedGroups> ListGroups(string userId, CancellationToken cancellationToken = default)
            {
                var param = new GetUserGroupsParam(userId);
                await client.GetAccessToken();
                var res = await client.Request<GetUserGroupsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result.Groups;
            }

            /// <summary>
            /// 加入分组
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="group">分组 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddGroup(
                string userId,
                string group,
                CancellationToken cancellationToken = default)
            {
                var param = new AddUserToGroupParam(new string[] { userId })
                {
                    Code = group
                };
                await client.GetAccessToken();
                var res = await client.Request<AddUserToGroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 退出分组
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="group">分组 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> RemoveGroup(
                string userId,
                string group,
                CancellationToken cancellationToken = default)
            {
                var param = new RemoveUserFromGroupParam(new string[] { userId })
                {
                    Code = group
                };
                await client.GetAccessToken();
                var res = await client.Request<RemoveUserFromGroupResponse>(param.CreateRequest(), cancellationToken);
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
                var param = new GetUserRolesParam(userId);
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
                string userId,
                IEnumerable<string> roles,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam() { UserIds = new string[] { userId }, RoleCodes = roles };
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
                string userId,
                IEnumerable<string> roles,
                CancellationToken cancellationToken = default)
            {
                var param = new RevokeRoleParam() { UserIds = new string[] { userId }, RoleCodes = roles };
                await client.GetAccessToken();
                var res = await client.Request<RevokeRoleResponse>(param.CreateRequest(), cancellationToken);
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
            public async Task<PaginatedPolicyAssignments> ListPolicies(
                string userId,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new PolicyAssignmentsParam()
                {
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
                var param = new AddPolicyAssignmentsParam(policies, PolicyAssignmentTargetType.USER)
                {
                    TargetIdentifiers = new string[] { userId },
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
                var param = new RemovePolicyAssignmentsParam(policies, PolicyAssignmentTargetType.USER)
                {
                    TargetIdentifiers = new string[] { userId },
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
                var param = new UdvParam(UdfTargetType.USER, userId);
                await client.GetAccessToken();
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
                var param = new SetUdvParam(UdfTargetType.USER, userId, key, JsonConvert.SerializeObject(value));
                await client.GetAccessToken();
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
                var param = new RemoveUdvParam(UdfTargetType.USER, userId, key);
                await client.GetAccessToken();
                var res = await client.Request<RemoveUdvResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 检查登录状态
            /// </summary>
            /// <param name="token"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<JWTTokenStatus> CheckLoginStatus(
                string token,
                CancellationToken cancellationToken = default)
            {
                var param = new CheckLoginStatusParam() { Token = token };
                var res = await client.Request<CheckLoginStatusResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
