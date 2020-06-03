using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class TokenStatus
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool? Status { get; set; }
    }
}
