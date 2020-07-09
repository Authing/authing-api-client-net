using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace Authing.ApiClient.GraphQL
{
    public class GraphQLHttpClientOptions
    {
        /// <summary>
        /// The GraphQL EndPoint to be used
        /// </summary>
        public Uri EndPoint { get; set; }

        /// <summary>
        /// The authorization header
        /// </summary>
        public AuthenticationHeaderValue Authorization { get; set; }
    }
}
