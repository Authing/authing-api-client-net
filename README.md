# authing-api-client-net

Authing 的 .Net SDK 为开发者提供了简单、安全的操作接口，支持在客户端和服务端使用。

## 安装

### NuGet

```bash
$ Install-Package Authing.ApiClient
```

## 初始化

先从 [Authing 控制台](https://authing.cn/dashbord)中获取[用户池 ID](https://learn.authing.cn/authing/others/faq#ru-he-huo-qu-client-id-he-client-secret)。

为保证 secret 安全，在服务端的初始化和客户端的初始化有所不同。

### 服务端

服务端可传入 `userPoolId` 和 `secret`，并执行 GetAccessTokenAsync 方法以获取到访问某些接口所需的权限。

```c#
var client = new AuthingApiClient("userPoolId")
{
  Secret = "secret"
};

// 只有传入 Secret 后才能使用这个接口
await client.GetAccessTokenAsync()
```

### 客户端

客户端只允许调用部分函数，无权调用一些用户池管理函数，如删除用户，获取全部用户列表等。

```c#
var client = new AuthingApiClient("userPoolId");
```

### 使用方法

所有接口均为异步执行。

```c#
public async Task fun()
{
  var result = await client.RegisterAsync(new RegisterParam("email", "password"));
  Console.WriteLine(result.Id);
}
```

### 超时说明

SDK 默认的请求超时时间是 10s，如果想加大或减小超时时间，请在 SDK 中指定 Timeout 参数：

```c#
var client = new AuthingApiClient("userPoolId")
{
  // 20s 超时时间
  Timeout = TimeSpan.FromSeconds(20)
};
```

### 所有参数

- UserPoolId: 用户池 ID。
- Secret: 用户池 Secret。
- Timeout: 接口超时时间，默认为 10 秒。
- UserHost: 供私有化部署了 Authing 服务的开发者填写。
- OAuthHost: 供私有化部署了 Authing 服务的开发者填写。
- PublicKey: PEM 格式密码加密公钥，默认为 Authing 官方的加密公钥。私有化部署用户需要传入自己的加密公钥。

## API

### 注册

client.RegisterAsync(RegisterParam param)

- param {RegisterParam}
  - param.UnionId {string}，unionid 和 email 参数只能填写一个
  - param.Email {string}，unionid 和 email 参数只能填写一个
  - param.Password {string}，不填 unionid 时必填，填 unionid 时不填
  - param.Username {string}，可选，用户名
  - param.Nickname {string}，可选，昵称
  - param.Company {string}，可选，公司
  - param.LastIP {string}，可选，上次登录 IP 地址
  - param.OAuth {string}，可选，用户社会化登录信息或其他自定义数据
  - param.Photo {string}，可选，头像

示例

```c#
var email = "";
var password = "";
var result = await client.RegisterAsync(new RegisterParam(email, password));
```

### 使用邮箱登录

client.LoginByEmailAsync(LoginByEmailParam param)

- param {LoginByEmailParam}
  - param.Email {string}，必填，用户邮箱
  - param.Password {string}，必填，用户密码

示例

```c#
var email = "";
var password = "";
var result = await client.LoginByEmailAsync(new LoginByEmailParam(email, password));
```

### 使用手机号登录

client.LoginByPhoneAsync(LoginByPhoneParam param)

- param {LoginByPhoneParam}
  - param.PhoneNumber {string}，手机号
  - param.VerifyCode {int}，短信验证码

示例

```c#
var result = await client.LoginByPhoneAsync(new LoginByPhone("phone number", 1234));
```

### 发送手机号验证码

client.SendPhoneCodeAsync(string phone)

- phone {string}，必填，手机号

示例

```c#
await client.SendPhoneCodeAsync("phone number");
```

### 发送手机号注册验证码

client.SendRegisterPhoneCodeAsync(string phone)

- phone {string}，必填，未注册过的手机号，如果已经注册，则会抛出错误

示例

```c#
await client.SendRegisterPhoneCodeAsync("phone number");
```

### 获取 Access Token

client.GetAccessTokenAsync()

**需要在初始化时传入 Secret**

示例

```c#
await client.GetAccessTokenAsync();
```

### 解析 User Token

client.DecodeTokenAsync(DecodeTokenParam param)

- param {DecodeTokenParam}
  - param.Token {string}，必填，用户 Authing Token

示例

```c#
var result = await client.DecodeTokenAsync(new DecodeTokenParam("token"));
```

### 刷新 User Token

client.RefreshTokenAsync(RefreshTokenParam param)

- param {RefreshTokenParam}
  - param.UserId {string}，必填，用户 ID

```c#
var result = await client.RefreshTokenAsync(new RefreshTokenParam("user ID"));
```

### 获取用户信息

client.UserInfoAsync(UserInfoParam param)

- param {UserInfoParam}
  - param.UserId {string}，必填，用户 ID

```c#
var result = await client.UserInfoAsync(new UserInfoParam("user ID"));
```

### 更新用户信息

client.UpdateUserInfoAsync(UpdateUserInfoParam param)

- param {UpdateUserInfoParam}
  - param.UserId {string}，必填，用户 ID
  - param.Blocked {bool}，可选，是否被锁定
  - param.Browser {string}，可选，浏览器信息
  - param.Company {string}，可选，公司
  - param.Email {string}，可选，邮箱
  - param.EmailVerified {bool}，可选，邮箱是否被验证
  - param.LastLogin {string}，可选，上次登录时间
  - param.LastIP {string}，可选，上次登录 IP 地址
  - param.LoginsCount {Int}，可选，登录次数
  - param.Nickname {string}，可选，昵称
  - param.SignUp {string}，可选，注册时间
  - param.Photo {string}，可选，头像
  - param.Password {string}，可选，密码
  - param.Token {string}，可选，Authing Token
  - param.TokenExpiredAt {string}，可选，Authing Token 过期时间
param.Username {string}，可选，用户名

示例

```c#
var result = await client.UpdateUserInfoAsync(new UpdateUserInfoParam("user ID")
{
  Nickname = "nick name"
});
```

### 查看用户登录状态

client.CheckLoginStatusAsync(CheckLoginStatusParam param)

- param {CheckLoginStatusParam}
  - param.Token {string}，必填，用户 Authing Token

示例

```c#
var result = await client.CheckLoginStatusAsync(new CheckLoginStatusParam("token"));
```

### 使用 AD 账号登录

client.LoginByAdAsync(LoginByAdParam param)

- param {LoginByAdParam}
  - param.AdConnectorId {string}，必填，AD Connector ID
  - param.Username {string}，必填，用户名
  - param.Password {string}，必填，密码

示例

```c#
var result = await client.LoginByAdAsync(new LoginByAdParam("adConnectorId", "username", "password"));
```

### 发送验证邮件

向目标邮箱发送带有验证链接的邮件，可以用来验证邮箱真实性

client.SendVerifyEmailAsync(SendVerifyEmailParam param)

- param {SendVerifyEmailParam}
  - param.Email {string}，必填，邮箱

示例

```c#
await client.SendVerifyEmailAsync(new SendVerifyEmailParam("email"));
```

### 发送重置密码的验证邮件

向目标邮箱发送带有验证码的邮件，可以用来重置密码

client.SendResetPasswordEmailAsync(SendResetPasswordEmailParam param)

- param {SendResetPasswordEmailParam}
  - param.Email {string}，必填，邮箱

示例

```c#
await client.SendResetPasswordEmailAsync(new SendResetPasswordEmailParam("email"));
```

### 验证重置密码的邮件验证码

client.VerifyResetPasswordVerifyCodeAsync(VerifyResetPasswordVerifyCodeParam param)

- param {VerifyResetPasswordVerifyCodeParam}
  - param.Email {string}，必填，邮箱
  - param.VerifyCode {string}，必填，验证码

示例

```c#
var result = await client.VerifyResetPasswordVerifyCodeAsync(new VerifyResetPasswordVerifyCodeParam("email", "code"));
```

### 修改密码

client.ChangePasswordAsync(ChangePasswordParam param)

- param {ChangePasswordParam}
  - param.Email {string}，必填，邮箱
  - param.Password {string}，必填，新密码
  - param.VerifyCode {string}，必填，上一步的验证码

示例

```c#
var result = await client.ChangePasswordAsync(new ChangePasswordParam("email", "new password", "code"));
```

### 判断用户是否存在

client.UserExistAsync(UserExistParam param)

- param {UserExistParam}
  - param.Username {string}，用户名
  - param.Phone {string}，电话
  - param.Email {string}，邮箱

示例

```c#
var result = await client.UserExistAsync(new UserExistParam() {
  Email = "email"
});
```

### 批量查询用户池中的用户信息

client.UsersInfoByCountAsync(UsersInfoByCountParam param)

- param {UsersInfoByCountParam}
  - param.Count {int}，必填，每页用户数量
  - param.Page {int}，当前页数，默认为 1

示例

```c#
var result = await client.UsersInfoByCountAsync(new UsersInfoByCountParam(10));
```

### 根据 ID 列表查询用户信息

client.UsersInfoByIdsAsync(UsersInfoByIdsParam param)

- param {UsersInfoByIdsParam}
  - param.UserIdList {List}，必填，用户 ID 列表

示例

```c#
var result = await client.UsersInfoByIdsAsync(new UsersInfoByIdsParam(new List<string>()
{
  "ID1",
  "ID2",
  "ID3"
}));
```

### 解绑邮箱

client.UnbindEmailAsync(UnbindEmailParam param)

- param {UnbindEmailParam}
  - param.UserId {string}，必填，用户 ID

示例

```c#
var result = await client.UnbindEmailAsync(new UnbindEmailParam("ID"));
```

### 批量删除用户

client.RemoveUsersAsync(RemoveUsersParam param)

- param {RemoveUsersParam}
  - param.UserIdList {string}，必填，用户 ID 列表

示例

```c#
var result = await client.RemoveUsersAsync(new RemoveUsersParam(new List<string>()
{
  "ID1",
  "ID2",
  "ID3"
}));
```

## 获取帮助

1. Gitter: [#authing-chat](https://gitter.im/authing-chat/community)

## 开发者信息

[Authing](https://authing.cn)

## License

This project is licensed under the MIT license. See the LICENSE file for more info.
