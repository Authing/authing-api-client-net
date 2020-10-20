using Authing.ApiClient;
using Authing.ApiClient.Types;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class TestAuthenticationClient
    {
        private AuthenticationClient authenticationClient;

        private string RandomString()
        {
            return new Random().Next().ToString();
        }

        [SetUp]
        public void Setup()
        {
            authenticationClient = new AuthenticationClient("59f86b4832eb28071bdd9214")
            {
                Host = "http://192.168.50.64:3000",
                PublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----",
            };
        }

        [Test]
        public async Task CurrentUser()
        {
            var phone = "17611161550";
            var password = "123456";
            await authenticationClient.LoginByPhonePassword(phone, password);
            var user = await authenticationClient.CurrentUser();
            Assert.AreEqual(phone, user.Phone);
        }

        [Test]
        public async Task RegisterByEmail()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            var user = await authenticationClient.RegisterByEmail(email, password);
            Assert.AreEqual(email, user.Email);
        }

        [Test]
        public async Task RegisterByUsername()
        {
            var username = RandomString();
            var password = "123456";
            var user = await authenticationClient.RegisterByUsername(username, password);
            Assert.AreEqual(username, user.Username);
        }

        [Test]
        public async Task RegisterByPhoneCode()
        {
            var phone = "17611161550";
            var code = "8942";
            var password = "123456";
            var user = await authenticationClient.RegisterByPhoneCode(phone, code, password);
            Assert.AreEqual(phone, user.Phone);
        }

        [Test]
        public async Task SendSmsCode()
        {
            var phone = "17611161550";
            await authenticationClient.SendSmsCode(phone);
            Console.WriteLine();
        }

        [Test]
        public async Task LoginByEmail()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            var user = await authenticationClient.LoginByEmail(email, password);
            Assert.AreEqual(email, user.Email);
        }

        [Test]
        public async Task LoginByUsername()
        {
            var username = RandomString();
            var password = "123456";
            await authenticationClient.RegisterByUsername(username, password);
            var user = await authenticationClient.LoginByUsername(username, password);
            Assert.AreEqual(username, user.Username);
        }

        [Test]
        public async Task LoginByPhoneCode()
        {
            var phone = "17611161550";
            var code = "6579";
            var user = await authenticationClient.LoginByPhoneCode(phone, code);
            Assert.AreEqual(phone, user.Phone);
        }

        [Test]
        public async Task LoginByPhonePassword()
        {
            var phone = "17611161550";
            var password = "123456";
            var user = await authenticationClient.LoginByPhonePassword(phone, password);
            Assert.AreEqual(phone, user.Phone);
        }

        [Test]
        public async Task CheckLoginStatus()
        {
            var phone = "17611161550";
            var password = "123456";
            await authenticationClient.LoginByPhonePassword(phone, password);
            var status = await authenticationClient.CheckLoginStatus();
            Assert.AreEqual(status.Code, 200);
        }

        [Test]
        public async Task SendEmail()
        {
            var message = await authenticationClient.SendEmail("1498881550@qq.com", EmailScene.RESET_PASSWORD);
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task ResetPasswordByPhoneCode()
        {
            var phone = "17611161550";
            var code = "1234";
            var password = "123456";
            var message = await authenticationClient.ResetPasswordByPhoneCode(phone, code, password);
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task ResetPasswordByEmailCode()
        {
            var email = "1498881550@qq.com";
            var code = "1234";
            var password = "123456";
            var message = await authenticationClient.ResetPasswordByEmailCode(email, code, password);
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task UpdateProfile()
        {
            var phone = "17611161550";
            var password = "123456";
            var nickname = RandomString();
            await authenticationClient.LoginByPhonePassword(phone, password);
            var user = await authenticationClient.UpdateProfile(new UpdateUserInput()
            {
                Nickname = nickname,
            });
            Assert.AreEqual(user.Nickname, nickname);
        }

        [Test]
        public async Task UpdatePassword()
        {
            var phone = "17611161550";
            var password = "111111";
            await authenticationClient.LoginByPhonePassword(phone, password);
            await authenticationClient.UpdatePassword("123456", "111111");
        }

        [Test]
        public async Task UpdatePhone()
        {
            var username = RandomString();
            var password = "123456";
            await authenticationClient.RegisterByUsername(username, password);
            await authenticationClient.LoginByUsername(username, password);
            await authenticationClient.UpdatePhone("17611161550", "1234");
        }

        [Test]
        public async Task UpdateEmail()
        {
            var email = RandomString() + "@gmail.com";
            var newEmail = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            await authenticationClient.LoginByEmail(email, password);
            await authenticationClient.UpdateEmail(newEmail, "1234");
        }

        [Test]
        public async Task BindPhone()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            await authenticationClient.LoginByEmail(email, password);
            await authenticationClient.BindPhone("17611161550", "1234");
        }

        [Test]
        public async Task UnbindPhone()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            await authenticationClient.LoginByEmail(email, password);
            await authenticationClient.BindPhone("17611161550", "1234");
            await authenticationClient.UnbindPhone();
        }

        [Test]
        public async Task RefreshToken()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            await authenticationClient.LoginByEmail(email, password);
            var refreshToken = await authenticationClient.RefreshToken();
            Assert.AreNotEqual(refreshToken.Token, null);
        }

        [Test]
        public async Task Logout()
        {
            var email = RandomString() + "@gmail.com";
            var password = "123456";
            await authenticationClient.RegisterByEmail(email, password);
            await authenticationClient.LoginByEmail(email, password);
            await authenticationClient.Logout();
        }
    }
}