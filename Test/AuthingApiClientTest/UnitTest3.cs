using Authing.ApiClient;
using Authing.ApiClient.Params;
using Authing.ApiClient.Results;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class UnitTest3
    {
        private AuthingApiClient client;
        private RegisterResult newUser;

        [SetUp]
        public void Setup()
        {
            client = new AuthingApiClient("5e72d65c77932a59a266a5ca")
            {
                Secret = "699b99005bdf51d5f7ca97014ed9fdea"
            };
            client.GetAccessTokenAsync().Wait();

            var email = new Random().Next().ToString() + "@gmail.com";
            var password = "123456";
            client.RegisterAsync(new RegisterParam(email, password)).ContinueWith((user) =>
            {
                newUser = user.Result;
            }).Wait();
        }

        [Test]
        public async Task Test01_LoginByAd()
        {
            // await client.LoginByAdAsync(new LoginByAdParam("", newUser.Email, "123456"));
        }

        [Test]
        public async Task Test02_SendVerifyEmail()
        {
            var result = await client.SendVerifyEmailAsync(new SendVerifyEmailParam("recallsufuture@gmail.com"));
            Console.WriteLine(result.Code);
        }

        [Test]
        public async Task Test03_SendResetPasswordEmail()
        {
            var result = await client.SendResetPasswordEmailAsync(new SendResetPasswordEmailParam("recallsufuture@gmail.com"));
            Console.WriteLine(result.Code);
        }

        [Test]
        public async Task Test04_UserExist()
        {
            var result = await client.UserExistAsync(new UserExistParam() {
                Email = newUser.Email
            });
            Console.WriteLine(result);
        }

        [Test]
        public async Task Test05_UsersInfoByCount()
        {
            var result = await client.UsersInfoByCountAsync(new UsersInfoByCountParam(10));
            Console.WriteLine(result.TotalCount);
        }

        [Test]
        public async Task Test06_UsersInfoByIds()
        {
            var result = await client.UsersInfoByIdsAsync(new UsersInfoByIdsParam(new List<string>()
            {
                newUser.Id
            }));
            Console.WriteLine(result.Count);
        }

        [Test]
        public async Task Test07_VerifyResetPasswordVerifyCode()
        {
            // var result = await client.VerifyResetPasswordVerifyCodeAsync(new VerifyResetPasswordVerifyCodeParam(newUser.Email, ""));
            // Console.WriteLine(result.Code);
        }

        [Test]
        public async Task Test08_VerifyResetPasswordVerifyCode()
        {
            // var result = await client.ChangePasswordAsync(new ChangePasswordParam(newUser.Email, "12345678", ""));
            // Console.WriteLine(result.Email);
        }


        [Test]
        public async Task Test09_UnbindEmail()
        {
            var result = await client.UnbindEmailAsync(new UnbindEmailParam(newUser.Id));
            Console.WriteLine(result.Email);
        }

        [Test]
        public async Task Test10_RemoveUsers()
        {
            var result = await client.RemoveUsersAsync(new RemoveUsersParam(new List<string>()
            {
                newUser.Id
            }));
            Console.WriteLine(result.Count);
        }
    }
}
