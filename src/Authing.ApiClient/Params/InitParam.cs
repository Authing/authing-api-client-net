using Authing.ApiClient.GrqphQL;

namespace Authing.ApiClient.Params
{
    public class InitParam : IApiParam
    {
        public string ClientId { get; set; }

        public string Secret { get; set; }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "getClientWhenSdkInit",
                Variables = new
                {
                    clientId = ClientId,
                    secret = Secret,
                }
            };
        }

        private const string QUERY = @"
        query getClientWhenSdkInit($secret: String, $clientId: String) {
            getClientWhenSdkInit(secret: $secret, clientId: $clientId) {
                accessToken
            }
        }";
    }
}
