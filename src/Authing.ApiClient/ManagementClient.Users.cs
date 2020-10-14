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
        }
    }
}
