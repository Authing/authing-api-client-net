using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class VerifyResetPasswordVerifyCodeParam : IApiParam
    {
        public string Email { get; set; }

        public string ClientId { get; set; }

        public string VerifyCode { get; set; }

        public VerifyResetPasswordVerifyCodeParam(string email, string verifyCode)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            VerifyCode = verifyCode ?? throw new ArgumentNullException(nameof(verifyCode));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "verifyResetPasswordVerifyCode",
                Variables = new
                {
                    email = Email,
                    client = ClientId,
                    verifyCode = VerifyCode
                }
            };
        }

        private const string QUERY = @"
        mutation verifyResetPasswordVerifyCode(
            $email: String!,
            $client: String!,
            $verifyCode: String!
        ) {
            verifyResetPasswordVerifyCode(
                email: $email,
                client: $client,
                verifyCode: $verifyCode
            ) {
                  message
                  code
                  status
            }
        }";
    }
}
