using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class LoginByEmailParam : IApiParam
    {
        public string UnionId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string LastIP { get; set; }

        public string VerifyCode { get; set; }

        public string ClientId { get; set; }

        public LoginByEmailParam(string unionId)
        {
            UnionId = unionId;
        }

        public LoginByEmailParam(string email, string password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "login",
                Variables = new
                {
                    registerInClient = ClientId,
                    unionId = UnionId,
                    email = Email,
                    password = Password,
                    lastIP = LastIP,
                    verifyCode = VerifyCode
                }
            };
        }

        private const string QUERY = @"
        mutation login($unionid: String, $email: String, $password: String, $lastIP: String, $registerInClient: String!, $verifyCode: String) {
            login(unionid: $unionid, email: $email, password: $password, lastIP: $lastIP, registerInClient: $registerInClient, verifyCode: $verifyCode) {
                _id
                email
                emailVerified
                username
                nickname
                company
                photo
                browser
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
