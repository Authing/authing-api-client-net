using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class LoginByPhoneParam : IApiParam
    {
        public string ClientId { get; set; }

        public string PhoneNumber { get; set; }

        public int VerifyCode { get; set; }

        public LoginByPhoneParam(string phone, int code)
        {
            PhoneNumber = phone ?? throw new ArgumentNullException(nameof(phone));
            VerifyCode = code;
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "login",
                Variables = new
                {
                    phone = PhoneNumber,
                    phoneCode = VerifyCode,
                    registerInClient = ClientId
                }
            };
        }

        private const string QUERY = @"
        mutation login($phone: String, $phoneCode: Int, $registerInClient: String!) {
            login(phone: $phone, phoneCode: $phoneCode, registerInClient: $registerInClient) {
            _id
            email
            emailVerified
            username
            nickname
            phone
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
