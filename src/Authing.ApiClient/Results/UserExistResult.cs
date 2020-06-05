using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class UserExistResponse
    {
        [DataMember]
        public bool UserExist { get; set; }
    }
}
