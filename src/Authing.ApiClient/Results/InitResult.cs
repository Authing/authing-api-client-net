using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class InitResult
    {
        [DataMember]
        public string AccessToken { get; set; }
    }

    [DataContract]
    internal class InitResponse
    {
        [DataMember]
        public InitResult GetClientWhenSdkInit { get; set; }
    }
}
