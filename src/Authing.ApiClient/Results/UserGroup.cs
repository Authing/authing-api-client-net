using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class UserGroup
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string CreatedAt { get; set; }
    }
}
