using System.Runtime.Serialization;

namespace Authing.ApiClient.Results
{
    [DataContract]
    public class VerifyResetPasswordVerifyCodeResult
    {
        [DataMember]
        public string Message { get; set; }

        [DataMember]
        public int Code { get; set; }

        [DataMember]
        public bool? Status { get; set; }
    }

    [DataContract]
    internal class VerifyResetPasswordVerifyCodeResponse
    {
        [DataMember]
        public VerifyResetPasswordVerifyCodeResult VerifyResetPasswordVerifyCode { get; set; }
    }
}
