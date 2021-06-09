using System.Linq;
using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Types;
using Authing.ApiClient.Utils;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Extensions;

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
            /// TODO： 下一个大版本移除
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

            public async Task<User> Create(
                CreateUserInput userInfo,
                CreateUserOption createUserOption = null,
                CancellationToken cancellationToken = default)
            {
                userInfo.Password = client.Encrypt(userInfo.Password);
                var param = new CreateUserParam(userInfo)
                {
                    KeepPassword = createUserOption?.KeppPassword,
                    ResetPasswordOnFirstLogin = createUserOption?.ResetPasswordOnFirstLogin,
                    UserInfo = userInfo,
                };

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
                    Input = updates
                };

                var res = await client.Request<UpdateUserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户信息
            /// </summary>
            /// <param name="userId">用户 ID</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 下个大版本去除
            public async Task<User> Detail(
                string userId,
                CancellationToken cancellationToken = default)
            {
                var param = new UserParam() { Id = userId };
                await client.GetAccessToken();
                var res = await client.Request<UserResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            public async Task<User> Detail(
                string userId,
                bool withCustomData = false,
                CancellationToken cancellationToken = default)
            {
                if (withCustomData)
                {
                    var _param = new UserWithCustomDataParam()
                    {
                        Id = userId
                    };
                    var _res = await client.Request<UserWithCustomDataResponse>(_param.CreateRequest(), cancellationToken);
                    return _res.Result;
                }
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

                var res = await client.Request<DeleteUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 通过 ID 列表批量获取用户信息
            /// </summary>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 缺少 customData 配置参数
            public async Task<IEnumerable<User>> Batch(
                IEnumerable<string> userIds,
                BatchFetchUserTypes batchFetchUserType = BatchFetchUserTypes.ID,
                CancellationToken cancellationToken = default)
            {
                var param = new UserBatchParam(userIds)
                {
                    Type = batchFetchUserType.ToString().ToUpper()
                };
                var res = await client.Request<UserBatchResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取用户列表
            /// </summary>
            /// <param name="page">当前页数，默认为 1</param>
            /// <param name="limit">每页最大数量，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 缺少 customData 配置参数
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

            public async Task<bool?> Exists(ExistsOption options, CancellationToken cancellation = default)
            {
                var parma = new IsUserExistsParam()
                {
                    Username = options.Username,
                    Email = options.Email,
                    Phone = options.Phone,
                    ExternalId = options.ExternalId
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
            /// TODO: 下一个大版本中去除
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

            // TODO: 缺少配置参数 withCustomData
            public async Task<User> Find(
                FindUserOption options,
                CancellationToken cancellationToken = default)
            {
                var param = new FindUserParam()
                {
                    Username = options.Username,
                    Phone = options.Phone,
                    Email = options.Email,
                    ExternalId = options.ExternalId,
                };

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
            /// TODO: 下个大版本去除
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
            /// 模糊搜索用户
            /// </summary>
            /// <param name="query">关键字</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// TODO: 缺少配置参数 withCustomData 
            public async Task<PaginatedUsers> Search(
                string query,
                SearchOption option = null,
                CancellationToken cancellationToken = default)
            {
                if (option == null)
                {
                    option = new SearchOption();
                }
                var param = new SearchUserParam(query)
                {
                    Page = option.Page,
                    Limit = option.Limit,
                    Fields = option.Fields,
                    DepartmentOpts = option.DepartmentOpts,
                    GroupOpts = option.GroupOpts,
                    RoleOpts = option.RoleOpts,
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
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new GetUserRolesParam(userId)
                {
                    Namespace = _namespace
                };
                await client.GetAccessToken();
                var res = await client.Request<GetUserRolesResponse>(param.CreateRequest(), cancellationToken);
                var user = res.Result;
                if (user == null)
                {
                    throw new Exception("用户不存在！");
                }
                return user.Roles;
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
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new AssignRoleParam()
                {
                    UserIds = new string[] { userId },
                    RoleCodes = roles,
                    Namespace = _namespace,
                };

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
                string _namespace = null,
                CancellationToken cancellationToken = default)
            {
                var param = new RevokeRoleParam()
                {
                    UserIds = new string[] { userId },
                    RoleCodes = roles,
                    Namespace = _namespace,
                };
                await client.GetAccessToken();
                var res = await client.Request<RevokeRoleResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            // TODO: 注意类型转换
            public async Task<HttpResponseMessage> ListOrgs(string userId, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/{userId}/orgs").WithHeaders(client.GetAuthHeaders()).WithOAuthBearerToken(client.AccessToken).GetAsync(cancellation);
                return res.ResponseMessage;
            }

            public async Task<PaginatedDepartments> ListDepartment(string userId, CancellationToken cancellation = default)
            {
                var param = new GetUserDepartmentsParam(userId);
                var res = await client.Request<GetUserDepartmentsResponse>(param.CreateRequest(), cancellation);
                var user = res.Result;
                if (user == null)
                {
                    throw new Exception("用户不存在！");
                }
                return user.Departments;
            }

            public async Task<PaginatedAuthorizedResources> ListAuthorizedResources(string userId, string _namespace, ListAuthorizedResourcesOption option = null, CancellationToken cancellationToken = default)
            {
                var resourceType = option.ResourceType;
                var param = new ListUserAuthorizedResourcesParam(userId)
                {
                    Namespace = _namespace,
                };
                if (resourceType != null)
                {
                    param.ResourceType = resourceType.ToString().ToUpper();
                }
                var res = await client.Request<ListUserAuthorizedResourcesResponse>(param.CreateRequest(), cancellationToken);
                var user = res.Result;
                if (user == null)
                {
                    throw new Exception("用户不存在！");
                }

                return user.AuthorizedResources;
            }

            public async Task<List<KeyValuePair<string, object>>> GetUdfValue(string userId, CancellationToken cancellation = default)
            {
                var param = new UdvParam(UdfTargetType.USER, userId);
                var res = await client.Request<UdvResponse>(param.CreateRequest(), cancellation);
                return AuthingUtils.ConverUdvToKeyValuePair(res.Result);
            }

            public async Task<Dictionary<string, List<KeyValuePair<string, object>>>> GetUdfValueBatch(string[] userIds, CancellationToken cancellation = default)
            {
                if (userIds.Length < 1)
                {
                    throw new Exception("empty user id list");
                }
                var param = new UdfValueBatchParam(UdfTargetType.USER, userIds);
                var res = await client.Request<UdfValueBatchResponse>(param.CreateRequest(), cancellation);
                var dic = new Dictionary<string, List<KeyValuePair<string, object>>>();
                foreach (var item in res.Result)
                {
                    dic.Add(item.TargetId, AuthingUtils.ConverUdvToKeyValuePair(item.Data));
                }
                return dic;
            }

            public async Task<IEnumerable<UserDefinedData>> SetUdfValue(string userId, KeyValueDictionary data, CancellationToken cancellation = default)
            {
                if (data.Count() < 1)
                {
                    throw new Exception("empty udf value list");
                }
                var param = new SetUdvBatchParam(UdfTargetType.USER, userId)
                {
                    UdvList = data.ToList().Select(item => new UserDefinedDataInput(item.Key)
                    {
                        Value = item.Value.ConvertJson()
                    }),
                };
                var res = await client.Request<SetUdvBatchResponse>(param.CreateRequest(), cancellation);
                return res.Result;
            }

            public async Task<IEnumerable<UserDefinedData>> SetUdfValueBatch(Management.Types.SetUdfValueBatchParam[] setUdfValueBatchInput, CancellationToken cancellation = default)
            {
                if (setUdfValueBatchInput.Length < 1)
                {
                    throw new Exception("empty input list");
                }
                var param = new List<SetUdfValueBatchInput>();
                setUdfValueBatchInput.ToList().ForEach(
                    item =>
                        item.Data.ToList().ForEach(
                            keyValue =>
                            param.Add(
                                new SetUdfValueBatchInput(
                                    item.UserId,
                                    keyValue.Key,
                                    keyValue.Value.ConvertJson()
                                )
                        )
                ));
                var _param = new Types.SetUdfValueBatchParam(UdfTargetType.USER, param);
                var res = await client.Request<SetUdvBatchResponse>(_param.CreateRequest(), cancellation);
                return res.Result;
            }

            // TODO: 衡量两个方法的优劣
            public async Task<CommonMessage> SetUdfValueBatch(IEnumerable<UdfValues>  udfValues, CancellationToken cancellation = default)
            {
                if (udfValues.Count() < 1)
                {
                    throw new Exception("empty input list");
                }
                var param = new List<SetUdfValueBatchInput> { };
                foreach (var udfValue in udfValues)
                {
                    foreach (var kvp in udfValue.Data)
                    {
                        param.Add(
                            new SetUdfValueBatchInput(
                                udfValue.UserId,
                                kvp.Key,
                                kvp.Value.ConvertJson()
                            )
                        );
                    }
                }
                var _param = new Types.SetUdfValueBatchParam(UdfTargetType.USER, param);
                var res = await client.Request<SetUdfValueBatchResponse>(_param.CreateRequest(), cancellation);
                return res.Result;
            }

            // ? RemoveUdfValue 方法却使用了 UdvParam 这合理吗?
            public async Task<CommonMessage> RemoveUdfValue(string userId, string key, CancellationToken cancellation = default)
            {
                var param = new RemoveUdvParam(UdfTargetType.USER, userId, key);
                var res = await client.Request<SetUdfValueBatchResponse>(param.CreateRequest(), cancellation);
                return res.Result;
            }

            public async Task<bool> hasRole(string userId, string roleCode, string _namespace = null, CancellationToken cancellation = default)
            {
                var roleList = await ListRoles(userId, _namespace, cancellation);

                if (roleList.TotalCount < 1)
                {
                    return false;
                }

                var hasRole = roleList.List.Where(item => item.Code == roleCode).ToList();

                return hasRole.Count > 0;
            }

            public async Task<CommonMessage> Kick(IEnumerable<string> userIds, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/kick").WithHeaders(client.GetAuthHeaders()).WithOAuthBearerToken(client.Token).PostJsonAsync(new
                {
                    userIds,
                }, cancellation);
                return new CommonMessage
                {
                    Code = 200,
                    Message = "强制下线成功"
                };
            }

            public async Task<CommonMessage> Logout(LogoutParam logoutParam, CancellationToken cancellation = default)
            {
                if (logoutParam.UserId == null)
                {
                    throw new Exception("请传入 options.userId，内容为要下线的用户 ID");
                }

                var res = await client.Host.AppendPathSegment("logout").SetQueryParams(new
                {
                    appId = logoutParam.AppId,
                    userId = logoutParam.UserId
                }).WithHeaders(client.GetAuthHeaders()).WithOAuthBearerToken(client.Token).GetAsync(cancellation);
                return new CommonMessage
                {
                    Code = 200,
                    Message = "强制登出成功"
                };
            }

            public async Task<CheckLoginStatusRes> CheckLoginStatus(string userId, string appId = null, string devicdId = null, CancellationToken cancellation = default)
            {
                var res = await client.Host.AppendPathSegment("api/v2/users/login-status").
                WithHeaders(client.GetAuthHeaders()).WithOAuthBearerToken(client.Token).SetQueryParams(new
                {
                    userId,
                    appId,
                    devicdId
                }).GetJsonAsync<CheckLoginStatusRes>(cancellation);
                return res;
            }

            public async Task<ListUserActionsRealRes> ListUserActions(ListUserActionsParam listUserActionsParam = null, CancellationToken cancellation = default)
            {
                var dic = new Dictionary<string, object>()
                {
                    {
                        "clientip", listUserActionsParam.ClientIp
                    },
                    {
                        "operation_name", listUserActionsParam.OperationNames
                    },
                    {
                        "operator_arn",
                        listUserActionsParam.UserIds.Select(userId => $"arn:cn:authing:{client.Options.UserPoolId}:user:${userId}").ToArray()
                    },
                    {
                        "page", listUserActionsParam.Page
                    },
                    {
                        "limit", listUserActionsParam.Limit
                    },
                    {
                        "exclude_non_app_records", listUserActionsParam.ExcludeNonAppRecords
                    },
                    {
                        "app_id", listUserActionsParam.AppIds
                    },
                    {
                        "start", listUserActionsParam.Start
                    },
                    {
                        "end", listUserActionsParam.End
                    }
                };
                dic["exclude_non_app_records"] = listUserActionsParam.ExcludeNonAppRecords ?? "1";
                var res = await client.Host.AppendPathSegment("api/v2/analysis/user-action").SetQueryParams(dic).WithHeaders(client.GetAuthHeaders()).GetJsonAsync<ListUserActionsRes>(cancellation);
                var list = res.List;
                var resList = list.Select(log => new UserActionRes
                {
                    UserPoolId = log.UserPoolId,
                    Id = log.User.Id,
                    UserName = log.User.Username,
                    CityName = log.Geoip.CityName,
                    RegionName = log.Geoip.RegionName,
                    ClientIp = log.Geoip.Ip,
                    OperationDesc = log.OperationDesc,
                    OperationName = log.OperationName,
                    TimeStamp = log.Timestamp,
                    AppId = log.AppId,
                    AppName = log.App.Name
                }).ToArray();
                var resReal = new ListUserActionsRealRes()
                {
                    TotalCount = res.TotalCount,
                    List = resList
                };
                return resReal;
            }

            public async Task<SendFirstLoginVerifyEmailResponse> SendFirstLoginVerifyEmail(SendFirstLoginVerifyEmailParam sendFirstLoginVerifyEmailParam, CancellationToken cancellation = default)
            {
                var param = sendFirstLoginVerifyEmailParam;
                var res = await client.Request<SendFirstLoginVerifyEmailResponse>(param.CreateRequest(), cancellation);
                return res;
            }

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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

            [Obsolete("方法已经转移至 RolesManagementClient 中")]
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
