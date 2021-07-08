using System;
using System.Threading;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Mgmt;
using Authing.ApiClient.Types;


var manageMentClient = await ManagementClient.InitManagementClient(init: opt =>
{
    opt.UserPoolId = "5f819ffdaaf252c4df2c9266";
    opt.Secret = "06eca4ed85c807db9fc6a9d5483a4dc7";
});

var rolesManageClient = manageMentClient.Roles;

var roles = await rolesManageClient.List();

Console.WriteLine();

