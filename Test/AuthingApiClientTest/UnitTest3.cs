using Authing.ApiClient;
using Authing.ApiClient.Types;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class UnitTest3
    {
        private AuthingApiClient client;
        private ExtendUser newUser;

        [SetUp]
        public void Setup()
        {
            client = new AuthingApiClient("5e72d65c77932a59a266a5ca")
            {
                Secret = "699b99005bdf51d5f7ca97014ed9fdea"
            };
            client.LoginBySecret().ContinueWith((result) =>
            {
                client.AccessToken = result.Result;
            }).Wait();

            var email = new Random().Next().ToString() + "@gmail.com";
            var password = "123456";

            client.RegisterAsync(new RegisterParam()
            {
                UserInfo = new UserRegisterInput()
                {
                    Email = email,
                    Password = password
                }
            }).ContinueWith((result) =>
            {
                newUser = result.Result.Result;
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
            var response = await client.SendVerifyEmailAsync(new SendVerifyEmailParam()
            {
                Email = "1498881550@qq.com"
            });
            Console.WriteLine(response.Result.Code);
        }

        [Test]
        public async Task Test03_SendResetPasswordEmail()
        {
            var response = await client.SendResetPasswordEmailAsync(new SendResetPasswordEmailParam()
            {
                Email = "1498881550@qq.com"
            });
            Console.WriteLine(response.Result.Code);
        }

        [Test]
        public async Task Test04_UserExist()
        {
            var result = await client.UserExistAsync(new UserExistParam()
            {
                Email = newUser.Email
            });
            Console.WriteLine(result);
        }

        [Test]
        public async Task Test05_UsersInfoByCount()
        {
            var response = await client.UsersAsync(new UsersParam()
            {
                Count = 10
            });
            Console.WriteLine(response.Result.TotalCount);
        }

        [Test]
        public async Task Test06_UsersInfoByIds()
        {
            var response = await client.UsersPatchAsync(new UserPatchParam()
            {
                Ids = string.Join(',', new List<string>()
                {
                    newUser._Id
                })
            });
            Console.WriteLine(response.Result.TotalCount);
        }

        [Test]
        public async Task Test07_VerifyResetPasswordVerifyCode()
        {
            // var result = await client.VerifyResetPasswordVerifyCodeAsync(new VerifyResetPasswordVerifyCodeParam(newUser.Email, ""));
            // Console.WriteLine(result.Code);
        }

        [Test]
        public async Task Test08_ChangePassword()
        {
            // var result = await client.ChangePasswordAsync(new ChangePasswordParam(newUser.Email, "12345678", ""));
            // Console.WriteLine(result.Email);
        }


        [Test]
        public async Task Test09_UnbindEmail()
        {
            // 需要配置其他登录方式才能解绑
            var response = await client.UnbindEmailAsync(new UnbindEmailParam()
            {
                User = newUser._Id
            });
            Console.WriteLine(response.Result.Email);
        }

        [Test]
        public async Task Test10_RemoveUsers()
        {
            var response = await client.RemoveUsersAsync(new RemoveUsersParam()
            {
                Ids = string.Join(',', new List<string>()
                {
                    newUser._Id
                })
            });
            Console.WriteLine(response.Result.Count());
        }
    }
}
