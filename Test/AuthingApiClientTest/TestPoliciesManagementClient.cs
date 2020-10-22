using Authing.ApiClient.Mgmt;
using Authing.ApiClient.Types;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthingApiClientTest
{
    public class TestPoliciesManagementClient
    {
        private ManagementClient client;

        private string RandomString()
        {
            return new Random().Next().ToString();
        }

        [SetUp]
        public void Setup()
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
        }

        [Test]
        public async Task List()
        {
            var list = await client.Policies.List();
            Assert.AreEqual(list.TotalCount > 0, true);
        }

        [Test]
        public async Task Create()
        {
            var code = RandomString();
            var list = await client.Policies.Create(code, new PolicyStatementInput[] {
                new PolicyStatementInput("resource id", new string[] { "action id" })
            });
            Assert.AreEqual(list.Code, 200);
        }

        [Test]
        public async Task Update()
        {
            var code = RandomString();
            var policy = await client.Policies.Update(code, description: "asd");
            Assert.AreEqual(policy.Code, code);
        }

        [Test]
        public async Task Detail()
        {
            var code = RandomString();
            var policy = await client.Policies.Detail(code);
            Assert.AreEqual(policy.Code, code);
        }

        [Test]
        public async Task Delete()
        {
            var code = RandomString();
            var message = await client.Policies.Delete(code);
            Assert.AreEqual(message.Code, 200);
        }

        [Test]
        public async Task DeleteMany()
        {
            var code = RandomString();
            var message = await client.Policies.DeleteMany(new string[] { code });
            Assert.AreEqual(message.Code, 200);
        }
    }
}
