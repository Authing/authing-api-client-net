using Authing.ApiClient.Params;
using Authing.ApiClient.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authing.ApiClient
{
    public partial class AuthingApiClient
    {
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <returns></returns>
        public async Task<UserInfoResult> UserInfoAsync(UserInfoParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendQueryAsync<UserInfoResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.User;
        }

        /// <summary>
        /// 刷新用户 token
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<RefreshTokenResult> RefreshTokenAsync(RefreshTokenParam param)
        {
            param.ClientId = UserPoolId;

            var result = await userGqlClient.SendMutationAsync<RefreshTokenResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.RefreshToken;
        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<UserInfoResult> UpdateUserInfoAsync(UpdateUserInfoParam param)
        {
            param.ClientId = UserPoolId;
            if (param.Password != null)
            {
                param.Password = Encrypt(param.Password);
            }
            if (param.OldPassword != null)
            {
                param.OldPassword = Encrypt(param.OldPassword);
            }

            var result = await userGqlClient.SendMutationAsync<UpdateUserInfoResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.UpdateUser;
        }

        /// <summary>
        /// 检查用户登录状态
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public async Task<CheckLoginStatusResult> CheckLoginStatusAsync(CheckLoginStatusParam param)
        {
            var result = await userGqlClient.SendQueryAsync<CheckLoginStatusResponse>(param.CreateRequest());
            CheckResult(result);

            return result.Data.CheckLoginStatus;
        }
    }
}
