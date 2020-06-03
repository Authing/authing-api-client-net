using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class RegisterResult
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
        public string NickName { get; set; }

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
        public int LoignsCount { get; set; }

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
        public UserGroup Group { get; set; }
    }

    [DataContract]
    internal class RegisterResponse
    {
        [DataMember]
        public RegisterResult Register { get; set; }
    }
}