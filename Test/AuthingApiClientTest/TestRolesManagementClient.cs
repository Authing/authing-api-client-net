using Authing.ApiClient;
using Authing.ApiClient.Types;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class TestRolesManagementClient
    {
        private ManagementClient rolesManagementClient;

        private string code;
        private Role role;

        private string RandomString()
        {
            return new Random().Next().ToString();
        }

        [SetUp]
        public void Setup()
        {
            rolesManagementClient = new ManagementClient("59f86b4832eb28071bdd9214", "4b880fff06b080f154ee48c9e689a541")
            {
                Host = "http://192.168.50.64:3000",
                PublicKey = @"-----BEGIN PUBLIC KEY-----
MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQC4xKeUgQ+Aoz7TLfAfs9+paePb
5KIofVthEopwrXFkp8OCeocaTHt9ICjTT2QeJh6cZaDaArfZ873GPUn00eOIZ7Ae
+TiA2BKHbCvloW3w5Lnqm70iSsUi5Fmu9/2+68GZRH9L7Mlh8cFksCicW2Y2W2uM
GKl64GDcIq3au+aqJQIDAQAB
-----END PUBLIC KEY-----",
            };

            code = RandomString();
            role = rolesManagementClient.Roles.Create(code, "test role").Result;
        }

        [TearDown]
        public void TearDown()
        {
            if (role == null) return;
            rolesManagementClient.Roles.Delete(code).Wait();
        }

        [Test]
        public async Task List()
        {
            var roles = await rolesManagementClient.Roles.List();
            Assert.AreEqual(roles.List != null, true);
        }

        [Test]
        public async Task Create()
        {
            Assert.AreEqual(role.Code, code);
        }

        [Test]
        public async Task Detail()
        {
            var role = await rolesManagementClient.Roles.Detail(code);
            Assert.AreEqual(role.Code, code);
        }

        [Test]
        public async Task Update()
        {
            var desc = "update desc";
            var role = await rolesManagementClient.Roles.Update(code, desc);
            Assert.AreEqual(role.Description, desc);
        }

        [Test]
        public async Task Delete()
        {
            var message = await rolesManagementClient.Roles.Delete(code);
            role = null;
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task DeleteMany()
        {
            var message = await rolesManagementClient.Roles.DeleteMany(new string[] { code });
            role = null;
            Assert.AreEqual(message.SucceedCount, 1);
        }

        [Test]
        public async Task ListUsers()
        {
            var users = await rolesManagementClient.Roles.ListUsers(code);
            Assert.AreEqual(users.TotalCount, 0);
        }

        [Test]
        public async Task ListPolicies()
        {
            var policies = await rolesManagementClient.Roles.ListPolicies(code);
            Assert.AreEqual(policies.TotalCount, 0);
        }
    }
}
