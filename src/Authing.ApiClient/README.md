# Authing - C#

Authing C# SDK 由两部分组成：`ManagementClient` 和 `AuthenticationClient`。`ManagementClient` 中进行的所有操作均以管理员的身份进行，包含管理用户、管理角色、管理权限策略、管理用户池配置等模块。`AuthenticationClient` 中的所有操作以当前终端用户的身份进行，包含登录、注册、修改用户资料、退出登录等方法。

你应该将初始化过后的 `ManagementClient` 实例设置为一个全局变量（只初始化一次），而 `AuthenticationClient` 应该每次请求初始化一个。

- [Authing - C](#authing---c)
  - [安装](#安装)
  - [使用 ManagementClient](#使用-managementclient)
    - [可用的 Management 模块](#可用的-management-模块)
  - [使用 AuthenticationClient](#使用-authenticationclient)
    - [可用的 Authentication 方法](#可用的-authentication-方法)

## 安装

```
Install-Package Authing.ApiClient
```

## 使用 ManagementClient

初始化 `ManagementClient` 需要 `userPoolId`（用户池 ID） 和 `secret`（用户池密钥）:

> 你可以在此[了解如何获取 UserPoolId 和 Secret](https://docs.authing.cn/others/faq.html) .

```csharp
using Authing.ApiClient;

var managementClient = new ManagementClient("AUTHING_USERPOOL_ID", "AUTHING_USERPOOL_SECRET");
```

现在 `ManagementClient()` 实例就可以使用了。例如可以获取用户池中的用户列表：

```csharp
var data = await managementClient.Users.List();
```

返回的数据如下：

```json
{
  "totalCount": 1,
  "list": [
    {
      "id": "5f7ddfe62ba819802422362e",
      "arn": "arn:cn:authing:5f7a993eb9b49dcd5c021e40:user:5f7ddfe62ba819802422362e",
      "userPoolId": "5f7a993eb9b49dcd5c021e40",
      "username": "nhxcpzmklk",
      "email": null,
      "emailVerified": false,
      "phone": null,
      "phoneVerified": false,
      "unionid": null,
      "openid": null,
      "nickname": null,
      "registerSource": [
        "import:manual"
      ],
      "photo": "https://usercontents.authing.cn/authing-avatar.png",
      "password": "a56f21e5659428f9b353be4ed667fc05",
      "oauth": null,
      "token": null,
      "tokenExpiredAt": null,
      "loginsCount": 0,
      "lastLogin": null,
      "lastIP": null,
      "signedUp": "2020-10-07T23:33:58+08:00",
      "blocked": false,
      "isDeleted": false,
      "device": null,
      "browser": null,
      "company": null,
      "name": null,
      "givenName": null,
      "familyName": null,
      "middleName": null,
      "profile": null,
      "preferredUsername": null,
      "website": null,
      "gender": "U",
      "birthdate": null,
      "zoneinfo": null,
      "locale": null,
      "address": null,
      "formatted": null,
      "streetAddress": null,
      "locality": null,
      "region": null,
      "postalCode": null,
      "country": null,
      "createdAt": "2020-10-07T23:33:58+08:00",
      "updatedAt": "2020-10-07T23:33:58+08:00",
    }
  ]
}
```


### 可用的 Management 模块

- Users `ManagementClient().users`
- Roles `ManagementClient().roles`
- Access Control: `ManagementClient().acl`

## 使用 AuthenticationClient

初始化 `ManagementClient` 需要 `userPoolId`（用户池 ID）：

> 你可以在此[了解如何获取 UserPoolId](https://docs.authing.cn/others/faq.html) .


```csharp
using Authing.ApiClient;

var authenticationClient = new AuthenticationClient("AUTHING_USERPOOL_ID");
```

或者通过委托设置配置

```csharp
using Authing.ApiClient;


var authenticationClient = new AuthenticationClient(opt =>
            {
                opt.AppId = "AUTHING_APP_ID";
                opt.UserPoolId = "AUTHING_USERPOOL_ID";
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

var authenticationClient = new AuthenticationClient("AUTHING_USERPOOL_ID");
authenticationClient.AccessToken = "access token";
```

再次执行 `UpdateProfile` 方法，发现也成功了:

```csharp
await authenticationClient.UpdateProfile(new UpdateUserInput() {
  Nickname = "Nick",
})
```

### 可用的 Authentication 方法

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
