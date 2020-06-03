using Authing.ApiClient.GrqphQL;
using System;

namespace Authing.ApiClient.Params
{
    public class UpdateUserInfoParam : IApiParam
    {
        public string UserId { get; set; }

        public string ClientId { get; set; }

        public string Email { get; set; }

        public bool EmailVerified { get; set; }

        public string Username { get; set; }

        public string Nickname { get; set; }

        public string Company { get; set; }

        public string Photo { get; set; }

        public string Browser { get; set; }

        public string Password { get; set; }

        public string OldPassword { get; set; }

        public string Token { get; set; }

        public string TokenExpiredAt { get; set; }

        public int LoginsCount { get; set; }

        public string LastLogin { get; set; }

        public string LastIP { get; set; }

        public string SignedUp { get; set; }

        public bool Blocked { get; set; }

        public bool IsDeleted { get; set; }

        public UpdateUserInfoParam(string userId)
        {
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "UpdateUser",
                Variables = new
                {
                    _id = UserId,
                    email = Email,
                    emailVerified = EmailVerified,
                    username = Username,
                    nickname = Nickname,
                    company = Company,
                    photo = Photo,
                    browser = Browser,
                    password = Password,
                    oldPassword = OldPassword,
                    registerInClient = ClientId,
                    token = Token,
                    tokenExpiredAt = TokenExpiredAt,
                    loginsCount = LoginsCount,
                    lastIP = LastIP,
                    lastLogin = LastLogin,
                    signedUp = SignedUp,
                    blocked = Blocked,
                    isDeleted = IsDeleted
                }
            };
        }

        private const string QUERY = @"
        mutation UpdateUser(
            $_id: String!,
            $email: String,
            $emailVerified: Boolean,
            $username: String,
            $nickname: String,
            $company: String,
            $photo: String,
            $browser: String,
            $password: String,
            $oldPassword: String,
            $registerInClient: String!,
            $token: String,
            $tokenExpiredAt: String,
            $loginsCount: Int,
            $lastLogin: String,
            $lastIP: String,
            $signedUp: String,
            $blocked: Boolean,
            $isDeleted: Boolean
        ){
          updateUser(options: {
            _id: $_id,
            email: $email,
            emailVerified: $emailVerified,
            username: $username,
            nickname: $nickname,
            company: $company,
            photo: $photo,
            browser: $browser,
            password: $password,
            oldPassword: $oldPassword,
            registerInClient: $registerInClient,
            token: $token,
            tokenExpiredAt: $tokenExpiredAt,
            loginsCount: $loginsCount,
            lastLogin: $lastLogin,
            lastIP: $lastIP,
            signedUp: $signedUp,
            blocked: $blocked,
            isDeleted: $isDeleted
          }) {
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
