using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public partial class AuthingApiClient
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="param">用户 ID</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserResponse> UserInfoAsync(UserParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;

            return await Request<UserResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 刷新用户 token
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RefreshTokenResponse> RefreshTokenAsync(RefreshTokenParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<RefreshTokenResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UpdateUserResponse> UpdateUserInfoAsync(UpdateUserParam param, CancellationToken cancellationToken = default)
        {
            param.Options = param.Options ?? new UserUpdateInput();
            param.Options.RegisterInClient = UserPoolId;
            param.Options.Password = Encrypt(param.Options.Password);
            param.Options.OldPassword = Encrypt(param.Options.OldPassword);

            return await Request<UpdateUserResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 检查用户登录状态
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<CheckLoginStatusResponse> CheckLoginStatusAsync(CheckLoginStatusParam param, CancellationToken cancellationToken = default)
        {
            return await Request<CheckLoginStatusResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 通过用户 ID 列表批量查询用户信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserPatchResponse> UsersInfoByIdsAsync(UserPatchParam param, CancellationToken cancellationToken = default)
        {
            return await Request<UserPatchResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查询用户池中的用户列表
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UsersResponse> UsersInfoByCountAsync(UsersParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;

            return await Request<UsersResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 通过用户 ID 列表批量删除用户
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RemoveUsersResponse> RemoveUsersAsync(RemoveUsersParam param, CancellationToken cancellationToken = default)
        {
            param.RegisterInClient = UserPoolId;

            return await Request<RemoveUsersResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 解绑邮箱
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UnbindEmailResponse> UnbindEmailAsync(UnbindEmailParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<UnbindEmailResponse>(param.CreateRequest(), cancellationToken);
        }
    }
}
