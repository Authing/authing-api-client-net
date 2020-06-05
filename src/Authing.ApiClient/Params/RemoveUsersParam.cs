using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    public class RemoveUsersParam : IApiParam
    {
        public List<string> UserIdList { get; set; }

        public string ClientId { get; set; }

        public RemoveUsersParam(List<string> userIdList)
        {
            UserIdList = userIdList ?? throw new ArgumentNullException(nameof(userIdList));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "removeUsers",
                Variables = new
                {
                    ids = UserIdList,
                    registerInClient = ClientId
                }
            };
        }

        private const string QUERY = @"
        mutation removeUsers($ids: [String], $registerInClient: String, $operator: String) {
            removeUsers(ids: $ids, registerInClient: $registerInClient, operator: $operator) {
                _id
                email
                emailVerified
                username
                nickname
                company
                photo
                browser
                password
                registerInClient
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
