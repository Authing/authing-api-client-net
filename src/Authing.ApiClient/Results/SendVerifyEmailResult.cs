using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class SendVerifyEmailResult
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool? Status { get; set; }
    }

    [DataContract]
    internal class SendVerifyEmailResponse
    {
        [DataMember]
        public SendVerifyEmailResult SendVerifyEmail { get; set; }
    }
}
