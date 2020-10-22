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
    public class TestUserpoolManagementClient
    {
        private ManagementClient client;

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
        public async Task Detail()
        {
            var userpool = await client.Userpool.Detail();
            Assert.AreNotEqual(userpool, null);
        }

        [Test]
        public async Task Update()
        {
            var userpool = await client.Userpool.Update(new UpdateUserpoolInput()
            {
                Description = "Description"
            });
            Assert.AreEqual(userpool.Description, "Description");
        }

        [Test]
        public async Task ListEnv()
        {
            var env = await client.Userpool.ListEnv();
            Assert.AreEqual(env.Count() == 0, true);
        }

        [Test]
        public async Task AddEnv()
        {
            var env = await client.Userpool.AddEnv("key", "value");
            Assert.AreEqual(env.Key, "key");
        }

        [Test]
        public async Task RemoveEnv()
        {
            await client.Userpool.RemoveEnv("key");
        }
    }
}
