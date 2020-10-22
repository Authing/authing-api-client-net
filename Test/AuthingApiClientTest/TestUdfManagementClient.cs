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
    public class TestUdfManagementClient
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
        public async Task Set()
        {
            var udf = await client.Udf.Set(UdfTargetType.USER, "key", UdfDataType.STRING, "label");
            Assert.AreEqual(udf.Key, "key");
        }

        [Test]
        public async Task Remove()
        {
            var udf = await client.Udf.Remove(UdfTargetType.USER, "key");
            Assert.AreEqual(udf.Code, 200);
        }

        [Test]
        public async Task List()
        {
            var udf = await client.Udf.List(UdfTargetType.USER);
            Assert.AreEqual(udf.Count() > 0, true);
        }
    }
}
