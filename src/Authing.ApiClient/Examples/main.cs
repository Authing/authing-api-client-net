using System;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;

namespace Authing.ApiClient.Examples
{
    public class AuthenticationClientEample
    {
        static void Main(string[] args)
        {
            var client = new AuthenticationClient(options =>
            {
                options.AppId = "6086687e4dc066aee99ecc71";
                options.Host = "https://1409458062aaa.authing.cn";
                options.Secret = "108981f01f616fcf576f1347a84f34cc";
                options.RedirectUri = "http://localhost:5000/auth/callback";
                options.TokenEndPointAuthMethod = TokenEndPointAuthMethod.NONE;
                options.Protocol = Protocol.OIDC;
            });
            var oauthOption = new OidcOption
            {
                AppId = "6086687e4dc066aee99ecc71",
                RedirectUri = "http://localhost:5000/auth/callback",
                State = "state",
            };
            var url = client.BuildAuthorizeUrl(oauthOption);
            Console.WriteLine(url);
        }
    }
}