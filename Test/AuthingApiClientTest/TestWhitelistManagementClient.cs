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
    public class TestWhitelistManagementClient
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
        public async Task List()
        {
            var list = await client.Whitelist.List(WhitelistType.USERNAME);
            Assert.AreEqual(list.Count(), 0);
        }

        [Test]
        public async Task Add()
        {
            var list = await client.Whitelist.Add(WhitelistType.EMAIL, new string[] { "test@test.com" });
            Assert.AreEqual(list.Count(), 1);
        }

        [Test]
        public async Task Remove()
        {
            var list = await client.Whitelist.Remove(WhitelistType.EMAIL, new string[] { "test@test.com" });
            Assert.AreEqual(list.Count(), 0);
        }

        [Test]
        public async Task Enable()
        {
            await client.Whitelist.Enable(WhitelistType.EMAIL);
        }

        [Test]
        public async Task Disable()
        {
            await client.Whitelist.Disable(WhitelistType.EMAIL);
        }
    }
}
