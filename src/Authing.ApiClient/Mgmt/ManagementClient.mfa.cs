﻿using Authing.ApiClient.Types;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Authing.ApiClient.Management.Types;

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

            public async Task<Dictionary<UserMfaTypeEnum, bool>> GetStatus(string userId, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/{userId}/mfa-bound").GetJsonAsync<Dictionary<UserMfaTypeEnum, bool>>(cancellationToken);
                return res;
            }

            public async Task<bool> UnAssociateMfa(string userId, UserMfaTypeEnum userMfaType, CancellationToken cancellationToken = default)
            {
                var res = await client.Host.AppendPathSegment($"api/v2/users/{userId}/mfa-bound?type={userMfaType}").WithOAuthBearerToken(client.Token).DeleteAsync(cancellationToken);
                return true;
            }

        }
    }
}