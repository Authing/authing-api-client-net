using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.GraphQL
{
    /// <summary>
    /// Represents a GraphQL Error of a GraphQL Query
    /// </summary>
    public class GraphQLError
    {
        /// <summary>
        /// The message object of the error
        /// </summary>
        [DataMember(Name = "message")]
        public GraphQLErrorMessage Message { get; set; }
    }
}
