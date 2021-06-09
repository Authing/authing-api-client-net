using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Authing.ApiClient.Management.Types;
using Authing.ApiClient.Auth.Types;

namespace Authing.ApiClient.Mgmt
{
    public partial class ManagementClient
    {
        public MFAManagementClient MFA { get; private set; }

        
        public class MFAManagementClient
        {
            private readonly ManagementClient client;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="client"></param>
            public MFAManagementClient(ManagementClient client)
            {
                this.client = client;
            }

            // TODO: 返回的数据类型似乎不合适
            public async Task<Dictionary<UserMfaTypeEnum, bool>> GetStatus(string userId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/{userId}/mfa-bound").WithOAuthBearerToken(client.Token).GetJsonAsync<Dictionary<UserMfaTypeEnum, bool>>(cancellationToken);
                return res;
            }

            public async Task<bool> UnAssociateMfa(string userId, UserMfaTypeEnum userMfaType, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/{userId}/mfa-bound?type={userMfaType}").WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken);
                return true;
            }

            public async Task<ISetTotpRes> ImportTotp(
                string userId, string secret, string recoverCode = null, CancellationToken cancellationToken = default
            )
            {
                var res = await client.Host.AppendPathSegment("api/v2/mfa/totp/import").WithOAuthBearerToken(client.Token).PostJsonAsync(new
                {
                    userId,
                    secret,
                    recoverCode
                }, cancellationToken).ReceiveJson<ISetTotpRes>();
                return res;
            }

        }
    }
}
