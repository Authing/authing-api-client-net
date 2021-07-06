using System;
using System.Threading;
using Authing.ApiClient.Auth;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Types;


#region 初始化    
var authenticationClient = new AuthenticationClient(
    options =>
            {
                options.AppId = "60b8e96ae2d07854b769c643";
                // options.Host = "http://localhost:3000";
            }
);

await authenticationClient.LoginByUsername("Authing-test", "123456aa", new RegisterAndLoginOptions { }, new CancellationTokenSource().Token);

#endregion

#region CheckLoggedIn

/* var userId = authenticationClient.CheckLoggedIn();

Console.WriteLine(userId); */

#endregion

#region CurrentUser SetCurrentUser GetCurrentUser
/* // CurrentUser
var currentUser = await authenticationClient.CurrentUser();
Console.WriteLine(currentUser);

// SetCurrentUser
authenticationClient.SetCurrentUser(currentUser);

// GetCurrentUser
var _currentUser = await authenticationClient.GetCurrentUser();
Console.WriteLine(_currentUser); */

#endregion

#region 注册
// RegisterByEmail
/* var user = await authenticationClient.RegisterByEmail("2q@qq.com", "Authing", new RegisterProfile(), new RegisterAndLoginOptions());

Console.WriteLine(user is User); */

// RegisterByUsername
/* var user = await authenticationClient.RegisterByUsername("Authing-test", "Authing", new RegisterProfile(), new RegisterAndLoginOptions());

Console.WriteLine(user is User); */

// SendSmsCode
// RegisterByPhoneCode
/* var phone = "17630802710";
var res = await authenticationClient.SendSmsCode(phone);
if (res.Code == 500)
{
    // 来自手机的验证码
    var code = "7600";
    var user = await authenticationClient.RegisterByPhoneCode(phone, code, "", new RegisterProfile(), new RegisterAndLoginOptions());

    Console.WriteLine(user is User);
} */


#endregion

// CheckPasswordStrength
/* var strength = await authenticationClient.CheckPasswordStrength("Authing?!.cn@1-2#3");

Console.WriteLine(strength.Valid);
Console.WriteLine(strength.Message);
Console.WriteLine(strength is CheckPasswordStrengthResult); */

#region 登录
// LoginByEmail

/* var user = await authenticationClient.LoginByEmail("shubuzuo@gmail.com", "Authing", new RegisterAndLoginOptions { }, new CancellationTokenSource().Token);

Console.WriteLine(user is User); */

// LoginByUsername

/* var user = await authenticationClient.LoginByUsername("shubuzuo-test", "Authing", new RegisterAndLoginOptions { }, new CancellationTokenSource().Token);

Console.WriteLine(user is User); */

// LoginByPhoneCode

/* var phone = "17630802710";
var res = await authenticationClient.SendSmsCode(phone);
if (res.Code == 200)
{
    var code = "1990";

    var user = await authenticationClient.LoginByPhoneCode(phone, code, new RegisterAndLoginOptions { }, new CancellationTokenSource().Token);

    Console.WriteLine(user is User);
} */

// LoginByPhonePassword

/* var phone = "17630802710";
var password = "Authing";
var user = await authenticationClient.LoginByPhonePassword(phone, password, false);

Console.WriteLine(user is User); */

// LoginBySubAccount

// TODO: 不重要这个方法

// CheckLoginStatus

/* var jWTTokenStatus = await authenticationClient.CheckLoginStatus();

Console.WriteLine(jWTTokenStatus is JWTTokenStatus); */

// SendEmail

/* var res = await authenticationClient.SendEmail("1409458062@qq.com", EmailScene.CHANGE_EMAIL);

Console.WriteLine(res is CommonMessage); */

#endregion


// ResetPasswordByPhoneCode

/* var phone = "17630802710";
var sendSmsCodeRes = await authenticationClient.SendSmsCode(phone);

if (sendSmsCodeRes.Code == 500)
{
    var code = "7260";
    var res = await authenticationClient.ResetPasswordByPhoneCode(phone, code, "AuthingNew");
    Console.WriteLine(res is CommonMessage);
} */


// ResetPasswordByEmailCode

/* var email = "1409458062@qq.com";
var sendEmailRes = await authenticationClient.SendEmail(email, EmailScene.RESET_PASSWORD);

if (sendEmailRes.Code == 500)
{
    var code = "5275";
    var res = await authenticationClient.ResetPasswordByEmailCode(email, code, "AuthingNew");
    Console.WriteLine(res is CommonMessage);
} */

// UpdateProfile

/* var user = await authenticationClient.UpdateProfile(new UpdateUserInput()
{
    Name = "New Name"
});

Console.WriteLine(user is User); */

// UpdatePassword

/* var user = await authenticationClient.UpdatePassword("AuthingNew", "AuthingNewNew");

Console.WriteLine(user is User); */

// UpdatePhone

/* var phone = "17670416754";
var res = await authenticationClient.SendSmsCode(phone);
if (res.Code == 200)
{
    var code = "3990";
    var user = await authenticationClient.UpdatePhone(phone, code);

    Console.WriteLine(user);
} */


// UpdateEmail

/* var email = "shubuzuo@gmail.com";
var oldEmail = "1409458062@qq.com";
var res1 = await authenticationClient.SendEmail(email, EmailScene.CHANGE_EMAIL);
var res2 = await authenticationClient.SendEmail(oldEmail, EmailScene.CHANGE_EMAIL);
if (res1.Code == 200 && res2.Code == 200)
{
    var emailCode = "2649";
    var oldEmailCode = "6787";
    var user = await authenticationClient.UpdateEmail(email, emailCode, "1409458062@qq.com", oldEmailCode);

    Console.WriteLine(user);
} */

// RefreshToken

/* var res = await authenticationClient.RefreshToken();

Console.WriteLine(res is RefreshToken); */

// LinkAccount

/* var primaryUserToken = "";
var secondaryUserToken = "";
var res = await authenticationClient.LinkAccount(primaryUserToken, secondaryUserToken);

Console.WriteLine(res is CommonMessage); */

// UnLinkAccount

/* var primaryUserToken = "";
var res = await authenticationClient.UnLinkAccount(primaryUserToken, ProviderType.GITHUB);

Console.WriteLine(res is CommonMessage); */

// BindPhone

/* var phone = "17630802710";
var sendPhoneCode = await authenticationClient.SendSmsCode(phone);
if (sendPhoneCode.Code == 500)
{
    var code = "8089";
    var res = await authenticationClient.BindPhone(phone, code);

    Console.WriteLine(res is User);
} */

// UnbindPhone

/* var res = await authenticationClient.UnbindPhone();

Console.WriteLine(res is User); */

// BindEamil

/* var email = "1409458062@qq.com";
var codeRes = await authenticationClient.SendEmail(email, EmailScene.CHANGE_EMAIL);

if (codeRes.Code == 500)
{
    var code = "8056";
    var res = await authenticationClient.BindEamil(email, code);

    Console.WriteLine(res is User);
} */

// UnbindEmail

/* var res = await authenticationClient.UnbindEmail();

Console.WriteLine(res is User);
 */

// Logout

/* var _ = await authenticationClient.Logout();

var user = await authenticationClient.GetCurrentUser();

Console.WriteLine(user is User); */

// ListUdv

/* var res = await authenticationClient.ListUdv();

Console.WriteLine(res is IEnumerable<ResUdv>); */

// SetUdv

/* var res = await authenticationClient.SetUdv(key: "key", value: "value");

Console.WriteLine(res is IEnumerable<ResUdv>); */

// RemoveUdv

/* var res = await authenticationClient.RemoveUdv(key: "key");

Console.WriteLine(res is IEnumerable<ResUdv>); */

// ListOrgs

// TODO: 返回结果有问题
/* var res = await authenticationClient.ListOrgs();

Console.WriteLine(res is PaginatedOrgs); */

// ListDepartment

var res = await authenticationClient.ListDepartment();

Console.WriteLine(res is PaginatedDepartments);

// LoginByLdap

/* var userName = "username";
var password = "admin";
var res = await authenticationClient.LoginByLdap(userName, password);

Console.WriteLine(res is User); */

// LoginByAd

/* var userName = "username";
var password = "admin";
var res = await authenticationClient.LoginByAd(userName, password);

Console.WriteLine(res is User); */

// GetUdfValue

/* var res = await authenticationClient.GetUdfValue();

Console.WriteLine(res is IEnumerable<KeyValuePair<string, object>>); */

// SetUdfValue

/* var res = await authenticationClient.SetUdfValue(new KeyValueDictionary()
{
    {"key", "value11"},
});

Console.WriteLine(res is IEnumerable<KeyValuePair<string, object>>); */

// RemoveUdfValue

/* var res = await authenticationClient.RemoveUdfValue(key: "key");

Console.WriteLine(res is true);
 */

// GetSecurityLevel

/* var res = await authenticationClient.GetSecurityLevel();

Console.WriteLine(res is SecurityLevel); */

// ListAuthorizedResources

/* var res = await authenticationClient.ListAuthorizedResources(_namespace: "default", null);

Console.WriteLine(res is PaginatedAuthorizedResources); */

// ComputedPasswordSecurityLevel

// TODO: 有问题

/* var res = authenticationClient.ComputedPasswordSecurityLevel("Authing!@.com_123");

Console.WriteLine(res); */

// RefreshToken

/* var res = await authenticationClient.RefreshToken();

Console.WriteLine(res is RefreshToken); */

// HasRole

/* var res = await authenticationClient.HasRole("AuthingAdministratorRole");

Console.WriteLine(res is true);
 */

// ListApplications

/* var res = await authenticationClient.ListApplications();

Console.WriteLine(res is ListApplicationsRes); */

// SetLang

/* authenticationClient.SetLang(LangEnum.ZH_CN);

Console.WriteLine(authenticationClient.Options.Lang); */
