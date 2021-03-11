# Authing - C#

Authing C# SDK 由两部分组成：`ManagementClient` 和 `AuthenticationClient`。`ManagementClient` 中进行的所有操作均以管理员的身份进行，包含管理用户、管理角色、管理权限策略、管理用户池配置等模块。`AuthenticationClient` 中的所有操作以当前终端用户的身份进行，包含登录、注册、修改用户资料、退出登录等方法。

你应该将初始化过后的 `ManagementClient` 实例设置为一个全局变量（只初始化一次），而 `AuthenticationClient` 应该每次请求初始化一个。

## 安装

通过 Nuget 安装：

```
Install-Package Authing.ApiClient
```

## 使用管理模块

初始化 `ManagementClient` 需要 `userPoolId`（用户池 ID） 和 `secret`（用户池密钥）:

> 你可以在此[了解如何获取 UserPoolId 和 Secret](https://docs.authing.cn/v2/guides/faqs/get-userpool-id-and-secret.html) .

```csharp
using Authing.ApiClient;

var managementClient = new ManagementClient("AUTHING_USERPOOL_ID", "AUTHING_USERPOOL_SECRET");
```

现在 `ManagementClient()` 实例就可以使用了。例如可以获取用户池中的用户列表：

```csharp
var managementClient = new ManagementClient("AUTHING_USERPOOL_ID", "AUTHING_USERPOOL_SECRET");
var data = await managementClient.Users.List();
```

## 使用认证模块

初始化 `ManagementClient` 需要 `AppId` （应用 ID）：

> 你可以在控制台的 **应用** 中查看自己的应用列表。

```csharp
using Authing.ApiClient;

var authenticationClient = new AuthenticationClient(opt =>
            {
                opt.AppId = "AUTHING_APP_ID";
            });
```

接下来可以进行注册登录等操作：

```csharp
var username = GetRandomString(10);
var password = GetRandomString(10);
var user = await authenticationClient.LoginByUsername(
    username,
    password,
)
```

完成登录之后，`update_profile` 等要求用户登录的方法就可用了：

```csharp
await authenticationClient.UpdateProfile(new UpdateUserInput() {
  Nickname = "Nick",
})
```

你也可以在初始化后设置 `AccessToken` 参数, 不需要每次都调用 `LoginByXXX` 方法:

```csharp
using Authing.ApiClient;

var authenticationClient = new AuthenticationClient(opt =>
            {
                opt.AppId = "AUTHING_APP_ID";
            });
authenticationClient.AccessToken = "USER_TOKEN";
```

再次执行 `UpdateProfile` 方法，发现也成功了:

```csharp
await authenticationClient.UpdateProfile(new UpdateUserInput() {
  Nickname = "Nick",
})
```

## 私有化部署

**私有化部署**场景需要指定你私有化的 Authing 服务的 GraphQL 端点（**不带协议头和 Path**），如果你不清楚可以联系 Authing IDaaS 服务管理员。

## 接口索引

可用的 Authentication 方法

- 获取当前用户的用户资料: `CurrentUser`
- 使用邮箱注册: `RegisterByEmail`
- 使用用户名注册: `RegisterByUsername`
- 使用手机号验证码注册: `RegisterByPhoneCode`
- 使用邮箱登录: `LoginByEmail`
- 使用用户名登录: `LoginByUsername`
- 使用手机号验证码登录 `LoginByPhoneCode`
- 使用手机号密码登录: `LoginByPhonePassword`
- 发送邮件: `SendEmail`
- 发送短信验证码: `SendSmsCode`
- 检查 token 的有效状态: `CheckLoginStatus`
- 使用手机号验证码重置密码: `ResetPasswordByPhoneCode`
- 使用邮件验证码重置密码: `ResetPasswordByEmailCode`
- 更新用户资料: `UpdateProfile`
- 更新密码: `UpdatePassword`
- 更新手机号: `UpdatePhone`
- 更新邮箱: `UpdateEmail`
- 刷新 token: `RefreshToken`
- 绑定手机号: `BindPhone`
- 解绑手机号: `UnbindPhone`
- 添加当前用户自定义字段值: `SetUdv`
- 获取当前用户的自定义字段值： `ListUdv`
- 删除当前用户自定义字段值: `RemoveUdv`

详情请见：

[用户认证模块](https://docs.authing.cn/v2/reference/sdk-for-csharp/authentication/)

管理模块包含以下子模块：

[管理用户](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/UsersManagementClient.html)

[管理角色](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/RolesManagementClient.html)

[管理策略](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/PoliciesManagementClient.html)

[管理权限、访问控制](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/AclManagementClient.html)

[管理分组](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/GroupsManagementClient.html)

[管理用户自定义字段](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/UdfManagementClient.html)

[管理用户池配置](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/UserpoolManagementClient.html)

[管理注册白名单](https://docs.authing.cn/v2/reference/sdk-for-csharp/management/WhitelistManagementClient.html)

## 获取帮助

Join us on Gitter: [#authing-chat](https://gitter.im/authing-chat/community)
