using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class UsersInfoByCountResult
    {
        [DataMember]
        public int TotalCount { get; set; }

        [DataMember]
        public List<UserInfoResult> List { get; set; }
    }

    [DataContract]
    internal class UsersInfoByCountResponse
    {
        [DataMember]
        public UsersInfoByCountResult Users { get; set; }
    }
}
