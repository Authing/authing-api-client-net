using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class SendPhoneCodeResult
    {
        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
