using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class TokenData
    {
        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string ClientId { get; set; }

        [DataMember]
        public string UnionId { get; set; }
    }
}
