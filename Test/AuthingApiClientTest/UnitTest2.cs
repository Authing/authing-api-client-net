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
    public class UnitTest2
    {
        private AuthingApiClient client;
        private RegisterResult newUser;
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjp7ImVtYWlsIjoicmVjYWxsc3VmdXR1cmVAZ21haWwuY29tIiwiaWQiOiI1ZWQ3MzQ1NzdlMDRkMzMwZDU1MjBmMTAiLCJjbGllbnRJZCI6IjVlNzJkNjVjNzc5MzJhNTlhMjY2YTVjYSJ9LCJpYXQiOjE1OTExNjkwNzIsImV4cCI6MTU5MjQ2NTA3Mn0.vgaoULOEYXptBMYe-S7_NNHBK90M2BXRTVzl_qCc2xo";

        [SetUp]
        public void Setup()
        {
            client = new AuthingApiClient("5e72d65c77932a59a266a5ca")
            {
                Secret = "699b99005bdf51d5f7ca97014ed9fdea"
            };
            client.GetAccessToken().Wait();

            var email = new Random().Next().ToString() + "@gmail.com";
            var password = "123456";
            client.RegisterAsync(new RegisterParam(email, password)).ContinueWith((user) =>
            {
                newUser = user.Result;
            }).Wait();
        }

        [Test]
        public async Task Test1_GetAccessToken()
        {
            await client.GetAccessToken();
        }

        [Test]
        public async Task Test2_LoginByEmail()
        {
            await client.LoginByEmailAsync(new LoginByEmailParam(newUser.Email, "123456"));
        }

        [Test]
        public async Task Test3_DecodeToken()
        {
            var result = await client.DecodeTokenAsync(new DecodeTokenParam(token));
            Console.WriteLine(result.Data.Email);
        }

        [Test]
        public async Task Test4_UserInfo()
        {
            var result = await client.UserInfoAsync(new UserInfoParam(newUser.Id));
            Console.WriteLine(result.Email);
        }

        [Test]
        public async Task Test5_RefreshToken()
        {
            var result = await client.RefreshTokenAsync(new RefreshTokenParam(newUser.Id));
            Console.WriteLine(result.Token);
            newUser.Token = result.Token;
        }

        [Test]
        public async Task Test6_UpdateUserInfo()
        {
            var result = await client.UpdateUserInfoAsync(new UpdateUserInfoParam("5ed734577e04d330d5520f10")
            {
                Nickname = "test user"
            });

            Console.WriteLine(result.Nickname);
        }

        [Test]
        public async Task Test6_CheckLoginStatus()
        {
            var result = await client.CheckLoginStatusAsync(new CheckLoginStatusParam(token));

            Console.WriteLine(result.Message);
        }
    }
}
