using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class DecodeTokenResult
    {
        [DataMember]
        public TokenData Data { get; set; }

        [DataMember]
        public TokenStatus Status { get; set; }

        [DataMember]
        public int Iat { get; set; }

        [DataMember]
        public int Exp { get; set; }
    }

    [DataContract]
    internal class DecodeTokenResponse
    {
        [DataMember]
        public DecodeTokenResult DecodeJwtToken { get; set; }
    }
}
