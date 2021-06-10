using System;
using Authing.ApiClient.Auth;


namespace _AuthenticationClient.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var authenticationClient = new AuthenticationClient(options => 
            {
                options.AppId = "60b8e96ae2d07854b769c643";
            });
            authenticationClient
        }
    }
}
