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
        public async Task<UserResponse> UserAsync(UserParam param, CancellationToken cancellationToken = default)
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
        public async Task<UpdateUserResponse> UpdateUserAsync(UpdateUserParam param, CancellationToken cancellationToken = default)
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
        public async Task<UserPatchResponse> UsersPatchAsync(UserPatchParam param, CancellationToken cancellationToken = default)
        {
            return await Request<UserPatchResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查询用户池中的用户列表
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UsersResponse> UsersAsync(UsersParam param, CancellationToken cancellationToken = default)
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

        /// <summary>
        /// 读取用户绑定的社会化登录列表
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<NotBindOAuthListResponse> UserOAuthListAsync(NotBindOAuthListParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<NotBindOAuthListResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 绑定用户第三方登录方式
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<BindOtherOAuthResponse> BindOtherOAuthAsync(BindOtherOAuthParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<BindOtherOAuthResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 解绑用户第三方登录方式
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UnbindOtherOAuthResponse> UnBindOtherOAuthAsync(UnbindOtherOAuthParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<UnbindOtherOAuthResponse>(param.CreateRequest(), cancellationToken);
        }


        /// <summary>
        /// 开启或关闭手机号注册时的白名单限制
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<SetInvitationStateResponse> SetInvitationStateAsync(SetInvitationStateParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<SetInvitationStateResponse>(param.CreateRequest(), cancellationToken);
        }


        /// <summary>
        /// 查看手机号白名单开启状态
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<QueryInvitationStateResponse> QueryInvitationStateAsync(QueryInvitationStateParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<QueryInvitationStateResponse>(param.CreateRequest(), cancellationToken);
        }


        /// <summary>
        /// 增加手机号到白名单
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<AddToInvitationResponse> AddToInvitationAsync(AddToInvitationParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<AddToInvitationResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 从白名单中删除手机号
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RemoveFromInvitationResponse> RemoveFromInvitationAsync(RemoveFromInvitationParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<RemoveFromInvitationResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查看白名单中的手机号
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<QueryInvitationParam> QueryInvitationAsync(QueryInvitationParam param, CancellationToken cancellationToken = default)
        {
            param.Client = UserPoolId;

            return await Request<QueryInvitationParam>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查询 MFA 信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<QueryMfaResponse> QueryMfaAsync(QueryMfaParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;

            return await Request<QueryMfaResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 修改 MFA 信息
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<ChangeMfaResponse> ChangeMfaAsync(ChangeMfaParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;

            return await Request<ChangeMfaResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 查询用户授权过的 SSO 应用列表
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<GetUserAuthorizedAppsResponse> GetUserAuthorizedAppsAsync(GetUserAuthorizedAppsParam param, CancellationToken cancellationToken = default)
        {
            param.ClientId = UserPoolId;

            return await Request<GetUserAuthorizedAppsResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 撤回用户对 SSO 应用的授权
        /// </summary>
        /// <param name="param"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<RevokeUserAuthorizedAppResponse> RevokeUserAuthorizedAppAsync(RevokeUserAuthorizedAppParam param, CancellationToken cancellationToken = default)
        {
            param.UserPoolId = UserPoolId;

            return await Request<RevokeUserAuthorizedAppResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 获取用户权限列表
        /// </summary>
        /// <param name="param">_id: 用户 id，必填</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserPermissionListResponse> UserPermissionListAsync(UserPermissionListParam param, CancellationToken cancellationToken = default)
        {
            return await Request<UserPermissionListResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 获取用户角色列表
        /// </summary>
        /// <param name="param">_id: 用户 id，必填</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserRoleListResponse> UserRoleListAsync(UserRoleListParam param, CancellationToken cancellationToken = default)
        {
            return await Request<UserRoleListResponse>(param.CreateRequest(), cancellationToken);
        }

        /// <summary>
        /// 获取用户分组列表
        /// </summary>
        /// <param name="param">_id: 用户 id，必填</param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<UserGroupListResponse> UserGroupListAsync(UserGroupListParam param, CancellationToken cancellationToken = default)
        {
            return await Request<UserGroupListResponse>(param.CreateRequest(), cancellationToken);
        }
    }
}
