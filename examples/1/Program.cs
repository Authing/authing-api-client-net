using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Extensions;

namespace _1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // var client = new AuthenticationClient(options =>
            // {
            //     // options.AppId = "608536890b8bdf9bd0aadae5";
            //     options.AppId = "6086687e4dc066aee99ecc71";
            //     // options.Host = "https://console.authing.cn";
            //     options.Host = "https://1409458062aaa.authing.cn";
            //     // options.Secret = "6b1b911c876b02717c7db9abfbec5322";
            //     options.Secret = "108981f01f616fcf576f1347a84f34cc";
            //     // options.RedirectUri = "http://console.authing.localhost:30000/console/userpool/callback";
            //     options.RedirectUri = "http://localhost:8000/auth/callback";
            //     options.TokenEndPointAuthMethod = TokenEndPointAuthMethod.CLIENT_SECRET_POST;
            //     options.Protocol = Protocol.OIDC;
            // })
            // {
            //     // Host = "http://localhost:3000"
            // };
            // // var oauthOption = new OidcOption
            // // {
            // //     AppId = "6086687e4dc066aee99ecc71",
            // //     RedirectUri = "http://localhost:5000/auth/callback",
            // //     State = "state",
            // // };
            // var token = @"eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6ImEzS3VYX0R4d1pJOEdHenhJNFJrT1R4VG9VZk5hY0g1X1NiQUJlRmN0RWMifQ.eyJqdGkiOiJTYVlOQXN1U3J3Y2RUUVJ5WGxoMXciLCJzdWIiOiI2MDgyNjA3YTNkMTllMzlhZTNiOGVhN2UiLCJpYXQiOjE2MjI2MjU2MTYsImV4cCI6MTYyMzgzNTIxNiwic2NvcGUiOiJwaG9uZSBvcGVuaWQgcHJvZmlsZSBlbWFpbCIsImlzcyI6Imh0dHBzOi8vMTQwOTQ1ODA2MmFhYS5hdXRoaW5nLmNuL29pZGMiLCJhdWQiOiI2MDg2Njg3ZTRkYzA2NmFlZTk5ZWNjNzEifQ.OFYuhSXiy7eXYA8jFXQ0o_Ya_RgICFfUi2PIN04U_SAWHQnat2I2LAnO_f5rMfDP8TPBkCNPEXzzktU1fXYtYQjBOk7vMd_OyTEaLVGrbEgPgzcNgAdzm0mTcuG7WYXzp6LAEMwW9eCvS2tFW441HDHw-YxK444G6UQa-5cYZMADAAUs0PtiBOgNqr7n6K5Ds_qVUwRuRPuvqfjDkbPpcUE-E13EQb2CPe8TztgEFkru9jPQQRB-LvlmiubcLO0vVzqtD3YBlG9y49ui-2ffi1gBSJVzDy6wOZsPlrr24OrWX4GgiCq2127_rfFIGLUI1N906Gv6aUSB_sFyWoeB2A";
            // try
            // {
            //     var res = await client.GetUserInfoByAccessToken(token);
            //     Console.WriteLine(res);
            // }
            // catch (Exception e)
            // {
            //     Console.WriteLine(e);
            // }
            var list = new List<string>()
            {
                "1",
                "2",
                "3"
            };
            var res = list.Select(item => item == "1").ToList();
            Console.WriteLine(res);
        }
    }
}
