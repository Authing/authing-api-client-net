using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Authing.ApiClient.GraphQL
{
    public class GraphQLHttpClient
    {
        /// <summary>
        /// the json serializer
        /// </summary>
        public JsonSerializer JsonSerializer { get; } = new JsonSerializer();

        /// <summary>
        /// the instance of <see cref="HttpClient"/> which is used internally
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// The Options	to be used
        /// </summary>
        public GraphQLHttpClientOptions Options { get; }

        public GraphQLHttpClient(GraphQLHttpClientOptions options) : this(options, new HttpClient())
        {
        }

        public GraphQLHttpClient(GraphQLHttpClientOptions options, HttpClient httpClient)
        {
            Options = options ?? throw new ArgumentNullException(nameof(options));
            HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <inheritdoc />
        public async Task<GraphQLResponse<TResponse>> SendQueryAsync<TResponse>(GraphQLRequest request, CancellationToken cancellationToken = default)
        {
            return await SendHttpRequestAsync<TResponse>(request, cancellationToken);
        }

        /// <inheritdoc />
        public Task<GraphQLResponse<TResponse>> SendMutationAsync<TResponse>(GraphQLRequest request,
            CancellationToken cancellationToken = default)
            => SendQueryAsync<TResponse>(request, cancellationToken);

        public void SetAccessToken(string accessToken)
        {
            if (accessToken == null)
            {
                Options.Authorization = null;
            } else
            {
                Options.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }
        }

        #region Private Methods

        private async Task<GraphQLHttpResponse<TResponse>> SendHttpRequestAsync<TResponse>(GraphQLRequest request, CancellationToken cancellationToken = default)
        {
            var preprocessedRequest = new GraphQLHttpRequest(request);

            using (var httpRequestMessage = preprocessedRequest.ToHttpRequestMessage(Options))
            using (var httpResponseMessage = await HttpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
            {
                var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                if (httpResponseMessage.IsSuccessStatusCode)
                {

                    using (var reader = new StreamReader(contentStream))
                    using (var jsonTextReader = new JsonTextReader(reader))
                    {
                        var graphQLResponse = JsonSerializer.Deserialize<GraphQLResponse<TResponse>>(jsonTextReader);
                        return graphQLResponse.ToGraphQLHttpResponse(httpResponseMessage.Headers, httpResponseMessage.StatusCode);
                    }
                }

                // error handling
                string content = null;
                if (contentStream != null)
                    using (var sr = new StreamReader(contentStream))
                        content = await sr.ReadToEndAsync();

                throw new GraphQLHttpRequestException(httpResponseMessage.StatusCode, httpResponseMessage.Headers, content);
            }
        }

        #endregion
    }
}
