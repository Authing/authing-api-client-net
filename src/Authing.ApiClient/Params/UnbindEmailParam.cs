using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class UnbindEmailParam : IApiParam
    {
        public string ClientId { get; set; }

        public string UserId { get; set; }

        public UnbindEmailParam(string userId)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "unbindEmail",
                Variables = new
                {
                    user = UserId,
                    client = ClientId
                }
            };
        }

        private const string QUERY = @"
        mutation unbindEmail($user: String, $client: String){
            unbindEmail(user: $user, client: $client){
              _id
              email
              emailVerified
              username
              nickname
              company
              photo
              browser
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
            }
        }";
    }
}
