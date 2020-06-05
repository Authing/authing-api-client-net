using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class UsersInfoByIdsResponse
    {
        [DataMember]
        public UserPatchResult UserPatch { get; set; }
    }
}
