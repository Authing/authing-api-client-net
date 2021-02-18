using System;
using System.Threading.Tasks;
using Authing.ApiClient.Auth;

namespace _1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var authenticationClient = new AuthenticationClient(opt =>
            {
                opt.AppId = "---";
            });
            var username = "---";
            var password = "---";
            var user = await authenticationClient.LoginByUsername(username, password);
            Console.WriteLine(user);
        }
    }
}
