using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class SendResetPasswordEmailParam : IApiParam
    {
        public string Email { get; set; }

        public string ClientId { get; set; }

        public SendResetPasswordEmailParam(string email)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "sendResetPasswordEmail",
                Variables = new
                {
                    email = Email,
                    client = ClientId,
                }
            };
        }

        private const string QUERY = @"
        mutation sendResetPasswordEmail(
            $email: String!,
            $client: String!
        ){
            sendResetPasswordEmail(
                email: $email,
                client: $client
            ) {
                  message
                  code
                  status
            }
        }";
    }
}
