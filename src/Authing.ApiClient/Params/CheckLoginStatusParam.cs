using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    public class CheckLoginStatusParam : IApiParam
    {
        public string Token { get; set; }

        public CheckLoginStatusParam(string token)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "checkLoginStatus",
                Variables = new
                {
                    token = Token
                }
            };
        }

        private const string QUERY = @"
        query checkLoginStatus($token: String) {
            checkLoginStatus(token: $token) {
                status
                code
                message
            }
        }";
    }
}
