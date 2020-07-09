using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Authing.ApiClient.GraphQL
{
    [DataContract]
    public class GraphQLResponse<T>
    {
        [DataMember(Name = "data")]
        public T Data { get; set; }

        [DataMember(Name = "errors")]
        public GraphQLError[] Errors { get; set; }
    }
}
