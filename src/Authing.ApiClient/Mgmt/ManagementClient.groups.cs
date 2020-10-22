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
        /// 分组管理模块
        /// </summary>
        public GroupsManagementClient Groups { get; private set; }

        /// <summary>
        /// 分组管理类
        /// </summary>
        public class GroupsManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public GroupsManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            /// <summary>
            /// 获取分组列表
            /// </summary>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedGroups> List(
                int page = 1, 
                int limit = 10, 
                CancellationToken cancellationToken = default)
            {
                var param = new GroupsParam()
                {
                    Page = page,
                    Limit = limit,
                };

                await client.GetAccessToken();
                var res = await client.Request<GroupsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 创建分组
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="name">分组名称</param>
            /// <param name="description">m描述</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Group> Create(
                string code, 
                string name, 
                string description = null, 
                CancellationToken cancellationToken = default)
            {
                var param = new CreateGroupParam(code, name)
                {
                    Description = description,
                };

                await client.GetAccessToken();
                var res = await client.Request<CreateGroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 更新分组信息
            /// </summary>
            /// <param name="code"></param>
            /// <param name="name"></param>
            /// <param name="description"></param>
            /// <param name="newCode"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Group> Update(
                string code,
                string name = null,
                string description = null,
                string newCode = null,
                CancellationToken cancellationToken = default)
            {
                var param = new UpdateGroupParam(code)
                {
                    Name = name,
                    Description = description,
                    NewCode = newCode,
                };

                await client.GetAccessToken();
                var res = await client.Request<UpdateGroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取分组详情
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<Group> Detail(string code, CancellationToken cancellationToken = default)
            {
                var param = new GroupParam(code);

                await client.GetAccessToken();
                var res = await client.Request<GroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 删除分组
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> Delete(string code, CancellationToken cancellationToken = default)
            {
                var param = new DeleteGroupsParam(new string[] { code });

                await client.GetAccessToken();
                var res = await client.Request<DeleteGroupsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量删除分组
            /// </summary>
            /// <param name="codeList">分组唯一标志列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> DeleteMany(IEnumerable<string> codeList, CancellationToken cancellationToken = default)
            {
                var param = new DeleteGroupsParam(codeList);

                await client.GetAccessToken();
                var res = await client.Request<DeleteGroupsResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 获取分组用户列表
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="page">分页页数，默认为 1</param>
            /// <param name="limit">分页大小，默认为 10</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<PaginatedUsers> ListUsers(
                string code,
                int page = 1,
                int limit = 10,
                CancellationToken cancellationToken = default)
            {
                var param = new GroupWithUsersParam(code)
                {
                    Page = page,
                    Limit = limit,
                };

                await client.GetAccessToken();
                var res = await client.Request<GroupWithUsersResponse>(param.CreateRequest(), cancellationToken);
                return res.Result.Users;
            }

            /// <summary>
            /// 批量添加用户
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> AddUsers(
                string code,
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new AddUserToGroupParam(userIds)
                {
                    Code = code,
                };

                await client.GetAccessToken();
                var res = await client.Request<AddUserToGroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }

            /// <summary>
            /// 批量移除用户
            /// </summary>
            /// <param name="code">分组唯一标志</param>
            /// <param name="userIds">用户 ID 列表</param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CommonMessage> RemoveUsers(
                string code,
                IEnumerable<string> userIds,
                CancellationToken cancellationToken = default)
            {
                var param = new RemoveUserFromGroupParam(userIds)
                {
                    Code = code,
                };

                await client.GetAccessToken();
                var res = await client.Request<RemoveUserFromGroupResponse>(param.CreateRequest(), cancellationToken);
                return res.Result;
            }
        }
    }
}
