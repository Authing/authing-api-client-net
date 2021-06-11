using System.Threading;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Mgmt;

var manageMentClient = new ManagementClient(opt =>
{
    opt.UserPoolId = "5f819ffdaaf252c4df2c9266";
    opt.Secret = "06eca4ed85c807db9fc6a9d5483a4dc7";
});

var userManageClient = manageMentClient.Users;

// 