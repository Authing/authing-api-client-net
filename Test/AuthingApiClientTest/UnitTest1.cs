using Authing.ApiClient;
using Authing.ApiClient.Types;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class UnitTest1
    {
        private AuthingApiClient client;

        [SetUp]
        public void Setup()
        {
            client = new AuthingApiClient("5e72d65c77932a59a266a5ca")
            {
                Secret = "699b99005bdf51d5f7ca97014ed9fdea"
            };
        }

        [Test]
        public async Task Test1_GetAccessToken()
        {
            var response = await client.GetAccessTokenAsync();
            Console.WriteLine(response);
        }

        [Test]
        public async Task Test2_Register()
        {
            var email = new Random().Next().ToString() + "@gmail.com";
            var password = "123456";
            var response = await client.RegisterAsync(new RegisterParam()
            {
                UserInfo = new UserRegisterInput()
                {
                    Email = email,
                    Password = password
                }
            });
            Console.WriteLine(response.Register.Email);
        }

        [Test]
        public async Task Test2_SendPhoneCode()
        {
            await client.SendPhoneCodeAsync("17611161550");
        }

        [Test]
        public void Test2_SendRegisterPhoneCode()
        {
            Assert.ThrowsAsync<AuthingApiException>(async () =>
            {
                await client.SendRegisterPhoneCodeAsync("17611161550");
            });
        }
    }
}