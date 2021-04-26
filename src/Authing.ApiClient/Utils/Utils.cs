using System.IdentityModel.Tokens.Jwt;

namespace Authing.ApiClient.Utils
{
    public static class AuthingUtils
    {
        public static JwtSecurityToken GetPayloadByToken(string token)
        {
            var tokenInfo = new JwtSecurityToken(token);
            return tokenInfo;
        }
    }
}