using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class ChangePasswordParam : IApiParam
    {
        public string Email { get; set; }

        public string ClientId { get; set; }

        public string Password { get; set; }

        public string VerifyCode { get; set; }

        public ChangePasswordParam(string email, string password, string verifyCode)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
            VerifyCode = verifyCode ?? throw new ArgumentNullException(nameof(verifyCode));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "changePassword",
                Variables = new
                {
                    email = Email,
                    client = ClientId,
                    password = Password,
                    verifyCode = VerifyCode
                }
            };
        }

        private const string QUERY = @"
        mutation changePassword(
            $email: String!,
            $client: String!,
            $password: String!,
            $verifyCode: String!
        ){
            changePassword(
                email: $email,
                client: $client,
                password: $password,
                verifyCode: $verifyCode
            ) {
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
