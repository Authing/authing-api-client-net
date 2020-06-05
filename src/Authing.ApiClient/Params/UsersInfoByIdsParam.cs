using Authing.ApiClient.GrqphQL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Authing.ApiClient.Params
{
    public class UsersInfoByIdsParam : IApiParam
    {
        public List<string> UserIdList { get; set; }

        public UsersInfoByIdsParam(List<string> userIdList)
        {
            UserIdList = userIdList ?? throw new ArgumentNullException(nameof(userIdList));
        }

        public GraphQLRequest CreateRequest()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < UserIdList.Count; i++)
            {
                builder.Append(UserIdList[i]);
                if (i != UserIdList.Count - 1)
                {
                    builder.Append(",");
                }
            }

            return new GraphQLRequest()
            {
                Query = QUERY,
                OperationName = "userPatch",
                Variables = new
                {
                    ids = builder.ToString()
                }
            };
        }

        private const string QUERY = @"
        query userPatch($ids: String){
            userPatch(ids: $ids){
              list {
                _id
                unionid
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
                userLocation {
                  _id
                  when
                  where
                }
                userLoginHistory {
                  totalCount
                  list {
                    _id
                    when
                    success
                    ip
                    result
                  }
                }
              }
              totalCount
            }
        }";
    }
}
