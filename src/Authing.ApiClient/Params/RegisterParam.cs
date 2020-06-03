using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class RegisterParam : IApiParam
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string UnionId { get; set; }

        public string Oauth { get; set; }

        public string Username { get; set; }

        public string Nickname { get; set; }

        public string Company { get; set; }

        public string Photo { get; set; }

        public string LastIP { get; set; }

        public string ClientId { get; set; }

        public RegisterParam(string email, string password)
        {
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "register",
                Variables = new
                {
                    email = Email,
                    password = Password,
                    unionid = UnionId,
                    oauth = Oauth,
                    username = Username,
                    nickname = Nickname,
                    company = Company,
                    photo = Photo,
                    lastIP = LastIP,
                    registerInClient = ClientId,
                }
            };
        }

        private const string QUERY = @"
        mutation register(
            $unionid: String,
            $email: String, 
            $password: String, 
            $lastIP: String, 
            $forceLogin: Boolean,
            $registerInClient: String!,
            $oauth: String,
            $username: String,
            $nickname: String,
            $registerMethod: String,
            $photo: String
        ) {
            register(userInfo: {
                unionid: $unionid,
                email: $email,
                password: $password,
                lastIP: $lastIP,
                forceLogin: $forceLogin,
                registerInClient: $registerInClient,
                oauth: $oauth,
                registerMethod: $registerMethod,
                photo: $photo,
                username: $username,
                nickname: $nickname
            }) {
                _id,
                email,
                emailVerified,
                username,
                nickname,
                company,
                photo,
                browser,
                password,
                token,
                group {
                    name
                },
                blocked
            }
        }";
    }
}
