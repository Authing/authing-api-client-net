using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    public class DecodeTokenParam : IApiParam
    {
        public string Token { get; set; }

        public DecodeTokenParam(string token)
        {
            Token = token ?? throw new ArgumentNullException(nameof(token));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "decodeJwtToken",
                Variables = new
                {
                    token = Token
                }
            };
        }

        private const string QUERY = @"
        query decodeJwtToken($token: String) {
            decodeJwtToken(token: $token) {
                data {
                    email
                    id
                    clientId
                    unionid
                }
                status {
                    message
                    code
                    status
                }
                iat
                exp
            }
        }";
    }
}
