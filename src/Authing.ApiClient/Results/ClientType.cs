using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class ClientType
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Decription { get; set; }

        [DataMember]
        public string Image { get; set; }

        [DataMember]
        public string Exapmle { get; set; }
    }
}
