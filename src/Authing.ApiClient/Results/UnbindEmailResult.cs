using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class UnbindEmailResponse
    {
        [DataMember]
        public UserInfoResult unbindEmail;
    }
}
