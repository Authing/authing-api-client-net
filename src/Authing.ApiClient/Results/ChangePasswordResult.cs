using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class ChangePasswordResponse
    {
        [DataMember]
        public UserInfoResult ChangePassword { get; set; }
    }
}
