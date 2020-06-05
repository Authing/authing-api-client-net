using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class UserPatchResult
    {
        [DataMember]
        public List<UserInfoResult> List { get; set; }
    }
}
