using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class SendVerifyEmailParam : IApiParam
    {
        public string Email { get; set; }

        public string ClientId { get; set; }

        public SendVerifyEmailParam(string email)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "sendVerifyEmail",
                Variables = new
                {
                    email = Email,
                    client = ClientId
                }
            };
        }

        private const string QUERY = @"
        mutation sendVerifyEmail(
            $email: String!,
            $client: String!
        ){
            sendVerifyEmail(
                email: $email,
                client: $client
            ) {
                message,
                code,
                status
            }
        }";
    }
}
