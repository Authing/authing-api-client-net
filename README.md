# authing-api-client-net 2.0

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

> 注：Param 中的 Client、ClientId、UserPoolId 和 RegisterInClient 均等同于 UserpoolId，接口方法内已自动为其赋值。

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
var result = await client.RegisterAsync(new RegisterParam()
{
  Email = email,
  Pasword = password,
});
```

### 使用 Secret 登录

登录后会得到管理员的 access token，
设置到 client 的 AccessToken 属性后可以获得调用所有接口的权限

client.LoginBySecretAsync()

**需要在初始化时传入 Secret**

示例

```c#
var accessToken = await client.LoginBySecretAsync();
client.AccessToken = accessToken;
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
var result = await client.LoginByEmailAsync(new LoginByEmailParam()
{
  Email = email,
  Pasword = password,
});
```

### 使用用户名登录

client.LoginByUsernameAsync(LoginByUsernameParam param)

- param {LoginByUsernameParam}
  - param.Username {string}，必填，用户邮箱
  - param.Password {string}，必填，用户密码

示例

```c#
var username = "";
var password = "";
var result = await client.LoginByUsernameAsync(new LoginByUsernameParam()
{
  Username = username,
  Pasword = password,
});
```

### 使用 AD 账号登录

client.LoginByAdAsync(LoginByAdParam param)

- param {LoginByAdParam}
  - param.AdConnectorId {string}，必填，AD Connector ID
  - param.Username {string}，必填，用户名
  - param.Password {string}，必填，密码

示例

```c#
var result = await client.LoginByAdAsync(new LoginByAdParam()
{
  adConnectorId = "adConnectorId",
  Username = "username",
  Password = "password",
});
```

### 使用 LDAP 账号登录

client.LoginByLdapAsync(LoginByLdapParam param)

- param {LoginByLdapParam}
  - param.Password {string}，必填，密码
  - param.Username {string}，必填，用户名

示例

```c#
var result = await client.LoginByLdapAsync(new LoginByLdapParam()
{
  Username = "username",
  Password = "password",
});
```

### 使用手机号和密码登录

client.LoginByPhonePasswordAsync(LoginByPhonePasswordParam param)

- param {LoginByPhonePasswordParam}
  - param.Phone {string}，手机号
  - param.PhoneCode {int}，短信验证码

示例

```c#
var result = await client.LoginByPhonePasswordAsync(new LoginByPhonePasswordParam()
{
  Phone = "phone",
  PhoneCode = 1234,
});
```

### 使用手机号和验证码登录

client.LoginByPhoneCodeAsync(LoginByPhoneCodeParam param)

- param {LoginByPhoneCodeParam}
  - param.Phone {string}，手机号
  - param.PhoneCode {int}，短信验证码

示例

```c#
var result = await client.LoginByPhoneCodeAsync(new LoginByPhoneCodeParam()
{
  Phone = "phone",
  PhoneCode = 1234,
});
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

### 解析 User Token

client.DecodeJwtTokenAsync(DecodeJwtTokenParam param)

- param {DecodeJwtTokenParam}
  - param.Token {string}，必填，用户 Authing Token

示例

```c#
var result = await client.DecodeJwtTokenAsync(new DecodeJwtTokenParam()
{
  Token = "token",
});
```

### 刷新 User Token

client.RefreshTokenAsync(RefreshTokenParam param)

- param {RefreshTokenParam}
  - param.User {string}，必填，用户 ID

```c#
var result = await client.RefreshTokenAsync(new RefreshTokenParam()
{
  User = "user id"
});
```

### 获取用户信息

client.UserAsync(UserInfoParam param)

- param {UserParam}
  - param.Token {string}，用户登录后的 token，非管理员身份必填
  - param.Id {string}，被查询用户的 ID

```c#
var result = await client.UserAsync(new UserParam()
{
  Token = "token",
  Id = "id",
});
```

### 更新用户信息

client.UpdateUserAsync(UpdateUserParam param)

- param {UpdateUserParam}
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
  - param.Token {string}，可选，Authing Token，非管理员必填
  - param.TokenExpiredAt {string}，可选，Authing Token 过期时间
  - param.Username {string}，可选，用户名

示例

```c#
var result = await client.UpdateUserAsync(new UpdateUserParam()
{
  _Id = "user id",
  Nickname = "nick name"
});
```

### 查看用户登录状态

client.CheckLoginStatusAsync(CheckLoginStatusParam param)

- param {CheckLoginStatusParam}
  - param.Token {string}，必填，用户 Authing Token

示例

```c#
var result = await client.CheckLoginStatusAsync(new CheckLoginStatusParam()
{
  Token = "token"
});
```


### 发送验证邮件

向目标邮箱发送带有验证链接的邮件，可以用来验证邮箱真实性

client.SendVerifyEmailAsync(SendVerifyEmailParam param)

- param {SendVerifyEmailParam}
  - param.Email {string}，必填，邮箱

示例

```c#
await client.SendVerifyEmailAsync(new SendVerifyEmailParam()
{
  Email = "email",
});
```

### 发送重置密码的验证邮件

向目标邮箱发送带有验证码的邮件，可以用来重置密码

client.SendResetPasswordEmailAsync(SendResetPasswordEmailParam param)

- param {SendResetPasswordEmailParam}
  - param.Email {string}，必填，邮箱

示例

```c#
await client.SendResetPasswordEmailAsync(new SendResetPasswordEmailParam()
{
  Email = "email",
});
```

### 验证重置密码的邮件验证码

client.VerifyResetPasswordVerifyCodeAsync(VerifyResetPasswordVerifyCodeParam param)

- param {VerifyResetPasswordVerifyCodeParam}
  - param.Email {string}，必填，邮箱
  - param.VerifyCode {string}，必填，验证码

示例

```c#
var result = await client.VerifyResetPasswordVerifyCodeAsync(new VerifyResetPasswordVerifyCodeParam()
{
  Email = "email",
  VerifyCode = "verifyCode",
});
```

### 修改密码

client.ResetPasswordAsync(ResetPasswordParam param)

- param {ResetPasswordParam}
  - param.Email {string}，必填，邮箱
  - param.Password {string}，必填，新密码
  - param.VerifyCode {string}，必填，上一步的验证码

示例

```c#
var result = await client.ResetPasswordAsync(new ResetPasswordParam()
{
  Email = "email",
  Password = "password",
  VerifyCode = "verifyCode",
});
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

client.UsersAsync(UsersParam param)

- param {UsersParam}
  - param.Count {int}，可选，每页用户数量
  - param.Page {int}，当前页数，默认为 1

示例

```c#
var result = await client.UsersInfoByCountAsync(new UsersInfoByCountParam()
{
  Count = 10,
});
```

### 根据 ID 列表查询用户信息

client.UserPatchAsync(UserPatchParam param)

- param {UserPatchParam}
  - param.Ids {string}，必填，用户 ID 列表，用英文逗号分隔

示例

```c#
var result = await client.UsersInfoByIdsAsync(new UsersInfoByIdsParam()
{
  Ids = "id1,id2,id3",
});
```

### 解绑邮箱

client.UnbindEmailAsync(UnbindEmailParam param)

- param {UnbindEmailParam}
  - param.User {string}，必填，用户 ID

示例

```c#
var result = await client.UnbindEmailAsync(new UnbindEmailParam()
{
  User = "user id",
});
```

### 批量删除用户

client.RemoveUsersAsync(RemoveUsersParam param)

- param {RemoveUsersParam}
  - param.Ids {string}，必填，用户 ID 列表，用英文逗号分隔

示例

```c#
var result = await client.RemoveUsersAsync(new RemoveUsersParam()
{
  Ids = "id1,id2,id3",
});
```

### 更多接口

SDK 中提供了所有线上 Graphql 的 Param、Response 类型，但由于工作量较大，并未封装完成所有的接口，如需调用还未封装的 Graphql 接口，可以继承 AuthingApiClient 类并实现对应的方法，例如：

```c#
public class AuthingApiClientExtends : AuthingApiClient
{
  public AuthingApiClientExtends(): base("userPoolId") {}

  public async Task<SignInResponse> SignInAsync(SignInParam param, CancellationToken cancellationToken = default)
  {
    param.UserPoolId = UserPoolId;
    param.Password = Encrypt(param.Password);

    return await Request<SignInResponse>(param.CreateRequest(), cancellationToken);
  }
}
```

## 获取帮助

1. Gitter: [#authing-chat](https://gitter.im/authing-chat/community)

## 开发者信息

[Authing](https://authing.cn)

## License

This project is licensed under the MIT license. See the LICENSE file for more info.
