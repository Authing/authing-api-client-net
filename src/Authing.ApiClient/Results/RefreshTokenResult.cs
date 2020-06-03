using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class RefreshTokenResult
    {
        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public int Iat { get; set; }

        [DataMember]
        public int Exp { get; set; }
    }

    [DataContract]
    internal class RefreshTokenResponse
    {
        [DataMember]
        public RefreshTokenResult RefreshToken { get; set; }
    }
}
