using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class LoginRecord
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember]
        public string When { get; set; }

        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public string Ip { get; set; }

        [DataMember]
        public bool Result { get; set; }
    }
}
