using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class RefreshTokenParam : IApiParam
    {
        public string ClientId { get; set; }

        public string UserId { get; set; }

        public RefreshTokenParam(string userId)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "RefreshToken",
                Variables = new
                {
                    client = ClientId,
                    user = UserId
                }
            };
        }

        private const string QUERY = @"
        mutation RefreshToken(
          $client: String!
          $user: String!
        ) {
          refreshToken(
            client: $client
            user: $user
          ) {
            token
            iat
            exp
          }
        }";
    }
}
