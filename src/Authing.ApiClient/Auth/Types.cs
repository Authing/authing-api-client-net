using System.IO;
using System;
using System.Collections.Generic;
using Authing.ApiClient.Types;
using Newtonsoft.Json;

namespace Authing.ApiClient.Auth.Types
{
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
}