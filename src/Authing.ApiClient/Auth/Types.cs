using System.IO;
using System;
using System.Collections.Generic;
using Authing.ApiClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Authing.ApiClient.Auth.Types
{

    public class InitAuthenticationClientOptions
    {
        [Required]
        public string AppId { get; set; }
        public string UserPoolId { get; set; }
        // public string UserPoolId { get; set; }
        public string Host { get; set; }

        public string Secret { get; set; }
        public string RedirectUri { get; set; }
        public string RequestFrom { get; set; }
        public LangEnum Lang { get; set; } = LangEnum.ZH_CN;
        public string WebsocketHost { get; set; }

        public Protocol Protocol { get; set; } = Protocol.OIDC;
        public TokenEndPointAuthMethod TokenEndPointAuthMethod { get; set; } = TokenEndPointAuthMethod.CLIENT_SECRET_POST;

        public TokenEndPointAuthMethod IntrospectionEndPointAuthMethod { get; set; } = TokenEndPointAuthMethod.CLIENT_SECRET_POST;

        public TokenEndPointAuthMethod RevocationEndPointAuthMethod { get; set; } = TokenEndPointAuthMethod.CLIENT_SECRET_POST;

    }

    public enum TokenEndPointAuthMethod
    {
        NONE,
        CLIENT_SECRET_POST,
        CLIENT_SECRET_BASIC,
    }

    public enum Protocol
    {
        OIDC,
        OAUTH,
        SAML,
        CAS,
    }

    public class KeyValueDictionary : Dictionary<string, string>
    {
        public new void Add(string key, string value)
        {
            base.Add(key, value);
        }

        public new string this[string key]
        {
            get { return base[key]; }
            set { base[key] = value; }
        }
    }

    public class RegisterAndLoginOptions
    {
        public bool ForceLogin { get; set; }
        public bool GenerateToken { get; set; }
        public bool AutoRegister { get; set; } = false;

        public string ClientIp { get; set; }
        public KeyValueDictionary[] CustomData { get; set; }

        public Dictionary<string, object>[] Context { get; set; }

        public string CaptchaCode { get; set; }
    }

    public class ProviderType
    {
        public static string Value { get; set; }

        private ProviderType(string value)
        {
            Value = value;
        }


        public static ProviderType WECHAT_PC
        {
            get { return new ProviderType("wechat:pc"); }
            set { }
        }

        public static ProviderType GITHUB
        {
            get { return new ProviderType("github"); }
            set { }
        }

        public static ProviderType GOOGLE
        {
            get { return new ProviderType("google"); }
            set { }
        }

        public static ProviderType QQ
        {
            get { return new ProviderType("qq"); }
            set { }
        }

        public static ProviderType APPLE
        {
            get { return new ProviderType("apple"); }
            set { }
        }

        public static ProviderType BAIDU
        {
            get { return new ProviderType("baidu"); }
            set { }
        }

        public static ProviderType ALIPAY
        {
            get { return new ProviderType("alipay"); }
            set { }
        }

        public static ProviderType LARK_APP_STORE
        {
            get { return new ProviderType("lark:app-store"); }
            set { }
        }

        public static ProviderType LARK_CUSTOM_APP
        {
            get { return new ProviderType("lark:custom-app"); }
            set { }
        }

        public static ProviderType WEIBO
        {
            get { return new ProviderType("weibo"); }
            set { }
        }

        public static ProviderType DINGTALK
        {
            get { return new ProviderType("dingtalk"); }
            set { }
        }

        public static ProviderType WECHAT_WEBPAGE_AUTHORIZATION
        {
            get { return new ProviderType("wechat:webpage-authorization"); }
            set { }
        }

        public static ProviderType WECHAT_MINIPROGRAM_DEFAULT
        {
            get { return new ProviderType("wechat:miniprogram:default"); }
            set { }
        }

        public static ProviderType WECHAT_MOBILE
        {
            get { return new ProviderType("wechat:mobile"); }
            set { }
        }

        public static ProviderType WECHATWORK_SERVICE_PROVIDER_AUTHORIZATION
        {
            get { return new ProviderType("wechatwork:service-provider:authorization"); }
            set { }
        }

        public static ProviderType WECHATWORK_SERVICE_PROVIDER_QRCONNECT
        {
            get { return new ProviderType("wechatwork:service-provider:qrconnect"); }
            set { }
        }

        public static ProviderType WECHATWORK_CORP_QRCONNECT
        {
            get { return new ProviderType("wechatwork:corp:qrconnect"); }
            set { }
        }

        public static ProviderType WECHAT_MINIPROGRAM_APP_LAUNCH
        {
            get { return new ProviderType("wechat:miniprogram:app-launch"); }
            set { }
        }

        public static ProviderType WECHAT_MINIPROGRAM_QRCONNECT
        {
            get { return new ProviderType("wechat:miniprogram:qrconnect"); }
            set { }
        }
    }

    class HttpClientConfig
    {
        public Dictionary<string, object>[] Headers { get; set; }

    }

    public class ResUdv
    {
        public string Key { get; set; }

        public UdfDataType DataType { get; set; }

        public object Value { get; set; }

        public string Label { get; set; }
    }

    public enum PasswordSecurityLevel
    {
        LOW = 1,
        MIDDLE = 2,
        HIGH = 3,
    }
    public class SecurityLevel
    {
        [JsonProperty(PropertyName = "email")]
        public bool Email { get; set; }

        [JsonProperty(PropertyName = "mfa")]
        public bool Mfa { get; set; }

        [JsonProperty(PropertyName = "password")]
        public bool Password { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public bool Phone { get; set; }

        [JsonProperty(PropertyName = "passwordSecurityLevel")]
        public PasswordSecurityLevel PasswordSecurityLevel { get; set; }

        [JsonProperty(PropertyName = "score")]
        public int Score { get; set; }
    }

    public class ListParams
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }

    public class GetAccessTokenByCodeOptions
    {
        public string CodeVerifier { get; set; }
    }

    public class CodeChallengeDigestOption
    {
        public string CodeChallenge { get; set; }
        public CodeChallengeDigestMethod Method { get; set; } = CodeChallengeDigestMethod.S256;

    }
    public enum CodeChallengeDigestMethod
    {
        S256,
        PLAIN,
    }

    public class GetAccessTokenByClientCredentialsOption
    {
        public string AccessKey { get; set; }
        public string AccessSecret { get; set; }

    }

    public class OidcOption : IProtocolInterface
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }
        public ResponseType? ResponseType { get; set; }
        public ResponseMode? ResponseMode { get; set; }
        public string State { get; set; }
        public string Nonce { get; set; }
        public string Scope { get; set; }
        public CodeChallengeDigestMethod? CodeChallengeMethod { get; set; }
        public string CodeChallenge { get; set; }

    }

    public enum ResponseMode
    {
        QUERY,
        FRAGMENT,
        FORM_POST,
    }

    public class ResponseType
    {
        public static string Value { get; set; }

        private ResponseType(string value)
        {
            Value = value;
        }


        public static ResponseType CODE
        {
            get { return new ResponseType("code"); }
            set { }
        }

        public static ResponseType CODE_TOKEN_IDTOKEN
        {
            get { return new ResponseType("code id_token token"); }
            set { }
        }

        public static ResponseType CODE_IDTOKEN
        {
            get { return new ResponseType("code id_token"); }
            set { }
        }

        public static ResponseType CODE_TOKEN
        {
            get { return new ResponseType("code token"); }
            set { }
        }

        public static ResponseType TOKEN_IDTOKEN
        {
            get { return new ResponseType("id_token token"); }
            set { }
        }

        public static ResponseType IDTOKEN
        {
            get { return new ResponseType("id_token"); }
            set { }
        }

        public static ResponseType NONE
        {
            get { return new ResponseType("none"); }
            set { }
        }
    }

    public class OauthOption : IProtocolInterface
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }
        public OauthResponseType? ResponseType { get; set; }
        public string State { get; set; }
        public string Scope { get; set; }

    }

    public class CasOption : IProtocolInterface
    {
        public string Service { get; set; }
    }

    public class SamlOption : IProtocolInterface
    {

    }


    public enum OauthResponseType
    {
        CODE,
        TOKEN,
    }

    public class LogoutParams
    {
        public bool Expert { get; set; }
        public string? RedirectUri { get; set; }
        public string? IdToken { get; set; }
    }

    public class ValidateTicketV1Res
    {
        public bool Valid { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
    }

    public class ValidateTokenOption
    {
        public string AccessToken { get; set; }
        public string IdToken { get; set; }

    }

    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CodeToTokenRes
    {
        public string AccessToken { get; set; }

        public int ExpiresIn { get; set; }

        public string IdToken { get; set; }

        public string Scope { get; set; }

        public string TokenType { get; set; }
    }

    public class UserInfo
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }

        /// <summary>
        /// 用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// 用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 邮箱，用户池内唯一
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// 邮箱是否已验证
        /// </summary>
        [JsonProperty("email_verified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 手机号，用户池内唯一
        /// </summary>
        [JsonProperty("phone_number")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机号是否已验证
        /// </summary>
        [JsonProperty("phone_number_verified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// 昵称，该字段不唯一。
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 头像链接，默认为 https://usercontents.authing.cn/authing-avatar.png
        /// </summary>
        [JsonProperty("picture")]
        public string Photo { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("givenName")]
        public string GivenName { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("middleName")]
        public string MiddleName { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("preferred_username")]
        public string PreferredUsername { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("zoneinfo")]
        public string Zoneinfo { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("formatted")]
        public string Formatted { get; set; }

        [JsonProperty("streetAddress")]
        public string StreetAddress { get; set; }

        [JsonProperty("locality")]
        public string Locality { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("postalCode")]
        public string PostalCode { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// 用户外部 ID
        /// </summary>
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }

    public class GetMfaAuthenticatorsParam
    {
        public string Type { get; set; } = "totp";

        public string MfaToken { get; set; }

        public TotpSourceEnum Source { get; set; } = TotpSourceEnum.SELF;

    }

    public enum TotpSourceEnum
    {
        APPLICATION,
        SELF
    }

    public enum UserMfaTypeEnum
    {
        OTP,
        FACE

    }

    public class ISetTotpRes
    {
        public string UserId { get; set; }

        public bool Enable { get; set; }

        public string Secret { get; set; }

        public string AuthenticatorType { get; set; }

        public string RecoveryCode { get; set; }

        public string CreatedAt { get; set; }

        public string UpdatedAt { get; set; }

        public string Id { get; set; }

    }

    public class AssosicateMfaAuthenticatorParam
    {
        public string AuthenticatorType { get; set; } = "totp";

        public string MFAToken { get; set; }

        public TotpSourceEnum Source { get; set; } = TotpSourceEnum.SELF;

    }

    public class AssosicateMfaAuthenticatorRes
    {
        public string AuthenticatorType { get; set; }

        public string Secret { get; set; }

        public string QrCodeUri { get; set; }

        public string QrCodeDataUrl { get; set; }

        public string RecoveryCode { get; set; }


    }

    public class DeleteMfaAuthenticatorRes
    {
        public int Code { get; set; }

        public string Message { get; set; }

    }

    public class ConfirmAssosicateMfaAuthenticatorParam
    {
        public string AuthenticatorType { get; set; }

        public string Totp { get; set; }

        public TotpSourceEnum Source { get; set; }

        public string MFAToken { get; set; }

    }

    public class VerifyTotpMfaParam
    {
        public string Totp { get; set; }

        public string MFAToken { get; set; }

    }

    public class VerifyAppSmsMfaParam
    {
        public string Phone { get; set; }

        public string Code { get; set; }

        public string MFAToken { get; set; }

    }

    public class VerifyAppEmailMfaParam
    {
        public string Email { get; set; }

        public string MFAToken { get; set; }

        public string Code { get; set; }

    }

    public class PhoneOrEmailBindableParam
    {
        public string Email { get; set; }

        public string MFAToken { get; set; }

        public string Phone { get; set; }
    }

    public class VerifyTotpRecoveryCodeParam
    {
        public string RecoveryCode { get; set; }

        public string MFAToken { get; set; }

    }

    public class AssociateFaceByUrlParam
    {
        public string BaseFace { get; set; }

        public string CompareFace { get; set; }

        public string MFAToken { get; set; }

    }

    public enum LangEnum
    {
        ZH_CN,
        EN_US
    }

    public interface IProtocolInterface
    {

    }

}