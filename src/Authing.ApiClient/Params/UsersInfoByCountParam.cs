using Authing.ApiClient.GrqphQL;

namespace Authing.ApiClient.Params
{
    public class UsersInfoByCountParam
    {
        public string ClientId { get; set; }

        public int Page { get; set; }

        public int Count { get; set; }

        public UsersInfoByCountParam(int count, int page = 1)
        {
            Page = page;
            Count = count;
        }

        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "users",
                Variables = new
                {
                    registerInClient = ClientId,
                    page = Page,
                    count = Count
                }
            };
        }

        private const string QUERY = @"
        query users($registerInClient: String, $page: Int, $count: Int){
          users(registerInClient: $registerInClient, page: $page, count: $count) {
            totalCount
            list {
              _id
              email
              emailVerified
              username
              nickname
              company
              photo
              browser
              password
              registerInClient
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              group {
                _id
                name
                descriptions
                createdAt
              }
              clientType {
                _id
                name
                description
                image
                example
              }
              userLocation {
                _id
                when
                where
              }
              userLoginHistory {
                totalCount
                list{
                  _id
                  when
                  success
                  ip
                  result
                }
              }
            }
          }
        }";
    }
}
