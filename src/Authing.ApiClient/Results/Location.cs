using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class Location
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember]
        public string When { get; set; }

        [DataMember]
        public string Where { get; set; }
    }
}
