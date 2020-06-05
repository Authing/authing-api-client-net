using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    public class LoginByAdParam : IApiParam
    {
        public string AdConnectorId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public LoginByAdParam(string adConnectorId, string username, string password)
        {
            AdConnectorId = adConnectorId ?? throw new ArgumentNullException(nameof(adConnectorId));
            Username = username ?? throw new ArgumentNullException(nameof(username));
            Password = password ?? throw new ArgumentNullException(nameof(password));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "LoginByAd",
                Variables = new
                {
                    adConnectorId = AdConnectorId,
                    username = Username,
                    password = Password
                }
            };
        }

        private const string QUERY = @"
        mutation LoginByAd($adConnectorId: String!, $username: String!, $password: String!) {
            LoginByLDAP(adConnectorId: $adConnectorId, username: $username, password: $password) {
                _id
                email
                emailVerified
                unionid
                oauth
                registerMethod
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
            }
        }";
    }
}
