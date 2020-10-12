using Newtonsoft.Json;

namespace Authing.ApiClient.Results
{
    public class SendSmsCodeResponse
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
