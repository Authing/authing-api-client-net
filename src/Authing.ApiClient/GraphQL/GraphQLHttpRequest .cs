using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace Authing.ApiClient.GraphQL
{
    public class GraphQLHttpRequest : GraphQLRequest
    {
        public GraphQLHttpRequest()
        {
        }

        public GraphQLHttpRequest(string query, object variables = null, string operationName = null) : base(query, variables, operationName)
        {
        }

        public GraphQLHttpRequest(GraphQLRequest other) : base(other.Query, other.Variables, other.OperationName)
        {
        }

        /// <summary>
        /// Creates a <see cref="HttpRequestMessage"/> from this <see cref="GraphQLHttpRequest"/>.
        /// Used by <see cref="GraphQLHttpClient"/> to convert GraphQL requests when sending them as regular HTTP requests.
        /// </summary>
        /// <param name="options">the <see cref="GraphQLHttpClientOptions"/> passed from <see cref="GraphQLHttpClient"/></param>
        /// <returns></returns>
        public virtual HttpRequestMessage ToHttpRequestMessage(GraphQLHttpClientOptions options)
        {
            var message = new HttpRequestMessage(HttpMethod.Post, options.EndPoint)
            {
                Content = new StringContent(JsonConvert.SerializeObject(
                    this,
                    Formatting.None,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    }), Encoding.UTF8, "application/json")
            };

            message.Headers.Authorization = options.Authorization;

            return message;
        }
    }
}
