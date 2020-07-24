using Authing.ApiClient;
using Authing.ApiClient.Types;
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
        private ExtendUser newUser;
        private string token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJkYXRhIjp7ImVtYWlsIjoicmVjYWxsc3VmdXR1cmVAZ21haWwuY29tIiwiaWQiOiI1ZWQ3MzQ1NzdlMDRkMzMwZDU1MjBmMTAiLCJjbGllbnRJZCI6IjVlNzJkNjVjNzc5MzJhNTlhMjY2YTVjYSJ9LCJpYXQiOjE1OTExNjkwNzIsImV4cCI6MTU5MjQ2NTA3Mn0.vgaoULOEYXptBMYe-S7_NNHBK90M2BXRTVzl_qCc2xo";
        
        private string password = "123456";

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
            string email = new Random().Next().ToString() + "@gmail.com";
            client.RegisterAsync(new RegisterParam()
            {
                UserInfo = new UserRegisterInput()
                {
                    Email = email,
                    Password = password,
                    Nickname = "123123"
                }
            }).ContinueWith((result) =>
            {
                newUser = result.Result.Result;
            }).Wait();
        }

        [Test]
        public async Task Test2_LoginByEmail()
        {
            Console.WriteLine(newUser._Id);
            var response = await client.LoginByEmailAsync(new LoginByEmailParam()
            {
                Email = newUser.Email,
                Password = password,
            });
            Console.WriteLine(response.Result.Email);
        }

        [Test]
        public async Task Test3_DecodeToken()
        {
            var response = await client.DecodeJwtTokenAsync(new DecodeJwtTokenParam()
            {
                Token = token
            });
            Console.WriteLine(response.Result.Status);
        }

        [Test]
        public async Task Test4_UserInfo()
        {
            var response = await client.UserAsync(new UserParam()
            {
                Id = newUser._Id
            });
            Console.WriteLine(response.Result.Email);
        }

        [Test]
        public async Task Test5_RefreshToken()
        {
            var response = await client.RefreshTokenAsync(new RefreshTokenParam()
            {
                User = newUser._Id
            });
            Console.WriteLine(response.Result.Token);
            newUser.Token = response.Result.Token;
        }

        [Test]
        public async Task Test6_UpdateUserInfo()
        {
            var response = await client.UpdateUserAsync(new UpdateUserParam()
            {
                Options = new UserUpdateInput
                {
                    _Id = "5ece3c55d80d6504c46903ae",
                    Nickname = "test user"
                }
            });

            Console.WriteLine(response.Result.Nickname);
        }

        [Test]
        public async Task Test7_CheckLoginStatus()
        {
            var response = await client.CheckLoginStatusAsync(new CheckLoginStatusParam()
            {
                Token = token
            });

            Console.WriteLine(response.Result.Message);
        }
    }
}
