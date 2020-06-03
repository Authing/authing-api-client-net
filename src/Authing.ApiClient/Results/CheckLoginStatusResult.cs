using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class CheckLoginStatusResult
    {
        [DataMember]
        public bool Status { get; set; }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public string Message { get; set; }
    }

    [DataContract]
    internal class CheckLoginStatusResponse
    {
        [DataMember]
        public CheckLoginStatusResult CheckLoginStatus { get; set; }
    }
}
