using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class UserInfoParam
    {
        public string UserId { get; set; }

        public string ClientId { get; set; }

        public UserInfoParam(string userId)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "user",
                Variables = new
                {
                    id = UserId,
                    registerInClient = ClientId
                }
            };
        }

        private const string QUERY = @"
        query user($id: String!, $registerInClient: String!) {
            user(id: $id, registerInClient: $registerInClient) {
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
