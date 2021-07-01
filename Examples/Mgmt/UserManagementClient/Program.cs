using System;
using System.Threading;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Mgmt;
using Authing.ApiClient.Types;


// var manageMentClient = await ManagementClient.InitManagementClient(init: opt =>
// {
//     opt.UserPoolId = "5f819ffdaaf252c4df2c9266";
//     opt.Secret = "06eca4ed85c807db9fc6a9d5483a4dc7";
// });

// var userManageClient = manageMentClient.Users;

var authenticationClient = new AuthenticationClient(
    options =>
            {
                options.AppId = "60d0821c19269500b7dd2e3d";
                options.Secret = "61397d427fba9206f7c08b876f098d97";
            }
);

var code = "c3-gu_RGEsgW_q7nXXRH1MZFJkVCP2sBoGStGxWK4CB";

var res = await authenticationClient.GetAccessTokenByCode(code);

Console.WriteLine(res.AccessToken);

// Create

/* var user = await userManageClient.Create(userInfo: new CreateUserInput() 
{
    Username = "test-user-create",
    Password = "test-user-create"
}, keepPassword: true);

Console.WriteLine(user is User); */

// Update

/* var user = await userManageClient.Update(userId: "60c810e18e491c82c3e9dbd4", updates: new UpdateUserInput()
{
    Email = "1409458062@qq.com"
});

Console.WriteLine(user is User); */

// Detail

// Delete

// DeleteMany

// Batch

// List

// ListArchivedUsers

// Exists

// Find

// Search

// RefreshToken

// ListGroups

// AddGroup

// RemoveGroup

// ListRoles

// AddRoles

// RemoveRoles

// ListOrgs

// ListDepartment

// ListAuthorizedResources

// GetUdfValue

// GetUdfValueBatch

// SetUdfValue

// SetUdfValueBatch

// RemoveUdfValue

// hasRole

// Kick

// Logout

// CheckLoginStatus

// ListUserActions

// SendFirstLoginVerifyEmail

