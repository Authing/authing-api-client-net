using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class RemoveUsersResponse
    {
        [DataMember]
        public List<UserInfoResult> RemoveUsers { get; set; }
    }
}
