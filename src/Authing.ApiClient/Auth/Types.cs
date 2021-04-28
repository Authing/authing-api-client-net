using System.IO;
using System;
using System.Collections.Generic;
using Authing.ApiClient.Types;
using Newtonsoft.Json;

namespace Authing.ApiClient.Auth.Types
{

    public class InitAuthenticationClientOptions
    {
        public string AppId { get; set; }
        public string UserPoolId { get; set; }
        // public string UserPoolId { get; set; }

        public string Secret { get; set; }
        public string RedirectUri { get; set; }
        public string RequestFrom { get; set; }
        public string Lang { get; set; }
        public string WebsocketHost { get; set; }

        public Protocol Protocol { get; set; } = Protocol.OIDC;
        public TokenEndPointAuthMethod TokenEndPointAuthMethod { get; set; }

        
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
        public Boolean ForceLogin { get; set; }
        public Boolean GenerateToken { get; set; }
        public Boolean AutoRegister { get; set; } = false;

        public string ClientIp { get; set; }
        public KeyValueDictionary[] CustomData { get; set; }

        public Dictionary<string, Object>[] Context { get; set; }

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
        public Dictionary<string, object> [] Headers { get; set; }
        
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
        public int Page { get; set; }
        public int Limit { get; set; }
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

    public class OidcOption
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }
        public ResponseType ResponseType { get; set; }
        public ResponseMode ResponseMode { get; set; }
        public string State { get; set; }
        public string Nonce { get; set; }
        public string Scope { get; set; }
        public CodeChallengeDigestMethod CodeChallengeMethod { get; set; }
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

    public class OauthOption
    {
        public string AppId { get; set; }
        public string RedirectUri { get; set; }
        public OauthResponseType ResponseType { get; set; }
        public string State { get; set; }
        public string Scope { get; set; }
        
    }

    public class CasOption
    {
        public string Service { get; set; }
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
}