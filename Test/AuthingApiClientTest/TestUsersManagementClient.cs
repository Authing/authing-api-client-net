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
    public class TestUsersManagementClient
    {
        private ManagementClient client;

        private string email;
        private string password;
        private User user;

        [SetUp]
        public async void Setup()
        {
            client = new ManagementClient("59f86b4832eb28071bdd9214", "4b880fff06b080f154ee48c9e689a541")
            {
                Host = "http://192.168.50.64:3000",
                PublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----",
            };

            email = RandomString() + "@gmail.com";
            password = "123456";
            user = await client.users.Create(new CreateUserInput()
            {
                Email = email,
                Password = password,
            });
        }

        [TearDown]
        public async void TearDown()
        {
            await client.users.Delete(user.Id);
        }

        private string RandomString()
        {
            return new Random().Next().ToString();
        }

        [Test]
        public async Task List()
        {
            var users = await client.users.List();
            Assert.AreEqual(users.TotalCount > 0, true);
        }

        [Test]
        public void Create()
        {
            Assert.AreEqual(user.Email, email);
        }

        [Test]
        public async Task Update()
        {
            user = await client.users.Update(user.Id, new UpdateUserInput()
            {
                Nickname = email,
            });
            Assert.AreEqual(user.Nickname, email);
        }

        [Test]
        public async Task Detail()
        {
            user = await client.users.Detail(user.Id);
            Assert.AreEqual(user.Email, email);
        }

        [Test]
        public async Task Search()
        {
            var users = await client.users.Search("gmail");
            Assert.AreEqual(users.TotalCount > 0, true);
        }

        [Test]
        public async Task Batch()
        {
            var users = await client.users.Batch(new string[] { user.Id });
            Assert.AreEqual(users.Count() == 1, true);
        }

        [Test]
        public async Task Delete()
        {
            var message = await client.users.Delete(user.Id);
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task DeleteMany()
        {
            var message = await client.users.DeleteMany(new string[] { user.Id });
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task ListRoles()
        {
            var roles = await client.users.ListRoles(user.Id);
            Assert.AreEqual(roles.TotalCount == 0, true);
        }

        [Test]
        public async Task RefreshToken()
        {
            var token = await client.users.RefreshToken(user.Id);
            Assert.AreEqual(token.Token != null, true);
        }

        [Test]
        public async Task ListPolicies()
        {
            var policies = await client.users.ListPolicies(user.Id);
            Assert.AreEqual(policies.TotalCount == 0, true);
        }

        [Test]
        public async Task ListUdv()
        {
            var udvs = await client.users.ListUdv(user.Id);
            Assert.AreEqual(udvs.Count() == 0, true);
        }
    }
}
