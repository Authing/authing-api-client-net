﻿using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    internal class LoginByAdResponse
    {
        [DataMember]
        public LoginResult LoginByLDAP { get; set; }
    }
}
