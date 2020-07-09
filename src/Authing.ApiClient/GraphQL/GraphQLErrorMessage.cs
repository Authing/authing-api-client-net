using System.Runtime.Serialization;

namespace Authing.ApiClient.GraphQL
{
    /// <summary>
    /// The message object of the error
    /// </summary>
    public class GraphQLErrorMessage
    {
        /// <summary>
        /// The code of the error
        /// </summary>
        [DataMember(Name = "code")]
        public int Code { get; set; }

        /// <summary>
        /// The message of the error
        /// </summary>
        [DataMember(Name = "message")]
        public string Message { get; set; }
    }
}
