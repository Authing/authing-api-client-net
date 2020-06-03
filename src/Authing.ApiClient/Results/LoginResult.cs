using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class LoginResult
    {
        [DataMember(Name = "_id")]
        public string Id { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public bool EmailVerified { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Nickname { get; set; }

        [DataMember]
        public string Company { get; set; }

        [DataMember]
        public string Photo { get; set; }

        [DataMember]
        public string Browser { get; set; }

        [DataMember]
        public string Token { get; set; }

        [DataMember]
        public string TokenExpiredAt { get; set; }

        [DataMember]
        public int LoginsCount { get; set; }

        [DataMember]
        public string LastLogin { get; set; }

        [DataMember]
        public string LastIP { get; set; }

        [DataMember]
        public string SignedUp { get; set; }

        [DataMember]
        public bool Blocked { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public string OAuth { get; set; }

        [DataMember]
        public string RegisterMethod { get; set; }

        [DataMember]
        public string UnionId { get; set; }
    }

    internal class LoginResponse
    {
        public LoginResult Login { get; set; }
    }
}
