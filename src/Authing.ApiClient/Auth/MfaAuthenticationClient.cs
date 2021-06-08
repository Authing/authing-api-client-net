using System;
using System.Threading;
using System.Threading.Tasks;
using Authing.ApiClient.Auth.Types;
using Flurl;
using Flurl.Http;

namespace Authing.ApiClient.Auth
{
    public class MfaAuthenticationClient: BaseClient
    {
        public MfaAuthenticationClient(Action<InitAuthenticationClientOptions> init) : base(init)
        {
        }
        
        public async Task<ISetTotpRes []> GetMfaAuthenticators(GetMfaAuthenticatorsParam getMfaAuthenticatorsParam, CancellationToken cancellationToken = default)
        {
            var res = await Host.AppendPathSegment("api/v2/mfa/authenticator").WithOAuthBearerToken(MFAToken).SetQueryParams(new
            {
                type = getMfaAuthenticatorsParam.Type,
                source = getMfaAuthenticatorsParam.Source
            }).GetJsonAsync<ISetTotpRes []>(cancellationToken);
            return res;
        }
    }
}