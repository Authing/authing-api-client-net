using Authing.ApiClient.GrqphQL;

namespace Authing.ApiClient.Params
{
    public class UserExistParam : IApiParam
    {
        public string Email { get; set; }

        public string Phone { get; set; }

        public string ClientId { get; set; }

        public string Username { get; set; }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "userExist",
                Variables = new
                {
                    email = Email,
                    phone = Phone,
                    userPoolId = ClientId,
                    username = Username
                }
            };
        }

        private const string QUERY = @"
        query userExist($userPoolId: String!,$phone: String,$username: String,$email: String){
          userExist(userPoolId: $userPoolId,phone: $phone,username: $username,email: $email)
        }";
    }
}
