using System.Collections.Generic;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Authing.ApiClient.Management.Types {
    public enum BatchFetchUserTypes {
        ID,
        USERNAME,
        PHONE,
        EMAIL,
        EXTERNALID,
    }

    public class ExistsOption
    {
        public string? Username { get; set; }

        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? ExternalId { get; set; }
    }

    public class FindUserOption : ExistsOption
    {
        public string? ExternalId { get; set; }
    }

    public class UdfValues
    {
        public string UserId { get; set; }

        public KeyValueDictionary Data { get; set; }
    }

    public class SearchOption
    {
        public string []? Fields { get; set; }

        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 10;

        public SearchUserDepartmentOpt [] DepartmentOpts { get; set; }

        // public IEnumerable<SearchUserDepartmentOpt>? DepartmentOpts { get; set; }
        public SearchUserGroupOpt [] GroupOpts { get; set; }

        public SearchUserRoleOpt [] RoleOpts { get; set; }

        public bool WithCustomData { get; set; }
        

    }

    public class ListAuthorizedResourcesOption
    {
        public ResourceType? ResourceType { get; set; }
    }

    public class LogoutParam
    {
        public string? AppId { get; set; }
        public string UserId { get; set; }
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class Application
    {
        public QrcodeScanning QrcodeScanning { get; set; }
        public string Id { get; set; }
        public string UserPoolId { get; set; }
        public string Protocol { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
        public string Identifier { get; set; }
        public string Domain { get; set; }
        
        public KeyValuePair<string, string> Jwks { get; set; }

        public string [] RedirectUris { get; set; }
        public string Css { get; set; }

        public OidcConfig OidcConfig { get; set; }
        public OauthConfig OauthConfig { get; set; }
        public string CreateAt { get; set; }
        public string UpdatedAt { get; set; }
        public string Description { get; set; }
        public object? SsoPageCustomizationSettings { get; set; }
        public string Logo { get; set; }
        public object? LogoutRedirectUris { get; set; }
        public object? LoginTabs { get; set; }

        public string DefaultLoginTab { get; set; }

        public object RegisterTabs { get; set; }
        public string DefaultRegisterTab { get; set; }
        public object? LdapConnections { get; set; }
        public object? AdConnections { get; set; }
        public object? DisabledSocialConnections { get; set; }
        public object? DisabledOidcConnections { get; set; }
        public object? DisabledSamlConnections { get; set; }
        public object? DisabledOauth2Connections { get; set; }
        public object? DisabledCasConnections { get; set; }
        public object? DisabledAzureAdConnections { get; set; }
        public object? ExtendsFields { get; set; }
        public object? Ext { get; set; }
        public object? SamlConfig { get; set; }
        public object? CasConfig { get; set; }
        public bool skipMfa { get; set; }
        public PermissionStrategy PermissionStrategy { get; set; }
        public bool IsOfficial { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public bool OidcProviderEnabled { get; set; }
        public bool OauthProviderEnabled { get; set; }
        public bool SamlProviderEnabled { get; set; }
        public bool CasProviderEnabled { get; set; }
        public bool RegisterDisabled { get; set; }
        public bool ExtendsFieldsEnabled { get; set; }
        public bool ShowAuthorizationPage { get; set; }
        public bool EnableSubAccount { get; set; }
        public bool LoginRequireEmailVerified { get; set; }
        public bool AgreementEnabled { get; set; }

    }

    public class QrcodeScanning
    {
        public bool Redirect { get; set; }
        public int interval { get; set; }
    }

    public class OidcConfig
    {
        public int Id { get; set; }
        public string ClientSecret { get; set; }

        public string[] RedirectUris { get; set; }

        public string[] Grants { get; set; }

        public int AccessTokenLifeTime { get; set; }

        public int RefreshTokenLifetime { get; set; }

        public string IntrospectionEndpointAuthMethod { get; set; }

        public string RevocationEndpointAuthMethod { get; set; }
    }

    public class OauthConfig
    {
        public string[] GrantTypes { get; set; }

        public string[] ResponseTypes { get; set; }

        public string IdTokenSignedResponseAlg { get; set; }

        public object? JwksUri { get; set; }

        public string TokenEndpointAuthMethod { get; set; }

        public object? RequestObjectEncryptionAlg { get; set; }
        public object? RequestObjectSigningAlg { get; set; }
        public object? UserinfoEncryptedResponseEnc { get; set; }
        public object? UserinfoEncryptedResponseAlg { get; set; }
        public object? UserinfoSignedResponseAlg { get; set; }
        public object? IdTokenEncryptedResponseEnc { get; set; }
        public object? IdTokenEncryptedResponseAlg { get; set; }
        public object? Jwks { get; set; }
        public int AuthorizationCodeExpire { get; set; }
        public int IdTokenExpire { get; set; }
        public int AccessTokenExpire { get; set; }
        public int RefreshTokenExpire { get; set; }
        public int CasExpire { get; set; }
        public bool SkipConsent { get; set; }
    }

    public class PermissionStrategy
    {
        public string AllowPolicyId { get; set; }

        public string DenyPolicyId { get; set; }

        public bool Enabled { get; set; }

        public string DefaultStrategy { get; set; }
    }

    public class CheckLoginStatusRes
    {
        public bool IsLogin { get; set; }
        public User User { get; set; }
        public Application [] Application { get; set; }
    }

    public class SetUdfValueBatchParam
    {
        public string UserId { get; set; }
        public KeyValueDictionary Data { get; set; }
    }

    public class ListUserActionsParam
    {
        public string? ClientIp { get; set; }

        public string []? OperationNames { get; set; }

        public string []? UserIds { get; set; }

        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;

        public string ExcludeNonAppRecords { get; set; }

        public string [] ? AppIds { get; set; }

        public int? Start { get; set; }
        public int? End { get; set; }
    }

    public class ListUserActionsRes
    {
        public int TotalCount { get; set; }

        public UserAction [] List { get; set; }

    }

    public class ListUserActionsRealRes
    {
        public int TotalCount { get; set; }

        public UserActionRes[] List { get; set; }
    }

    public class UserActionRes
    {
        public string Id { get; set; }

        public string UserPoolId { get; set; }

        public string UserName { get; set; }

        public string CityName { get; set; }

        public string RegionName { get; set; }

        public string ClientIp { get; set; }

        public string OperationDesc { get; set; }

        public string OperationName { get; set; }

        public string TimeStamp { get; set; }

        public string AppId { get; set; }
        public string AppName { get; set; }
    }

    public class UserAction
    {
        public string OperatorArn { get; set; }

        public string Timestamp { get; set; }

        public string UserAgent { get; set; }

        public Geoip Geoip { get; set; }

        public string Message { get; set; }

        public Ua Ua { get; set; }
        public string UserPoolId { get; set; }
        public string Host { get; set; }
        public string Version { get; set; }

        public string AppId { get; set; }

        public string OperationName { get; set; }

        public string ClientIp { get; set; }

        public string ExtraData { get; set; }

        public string RequestId { get; set; }

        public string Path { get; set; }

        public User User { get; set; }

        public App App { get; set; }
        public string OperationDesc { get; set; }
    }

    public class Geoip
    {
        public string ContinentCode { get; set; }

        public string CountryCode2 { get; set; }

        public string RegionName { get; set; }

        public string CityName { get; set; }

        public string Ip { get; set; }

        public int Latitude { get; set; }

        public string RegionCode { get; set; }

        public string Timezone { get; set; }

        public string CountryCode3 { get; set; }

        public int Longitude { get; set; }

        public string CountryName { get; set; }

        public Location Location { get; set; }

    }

    public class Location
    {
        public int Lon { get; set; }

        public int Lat { get; set; }
    }

    public class Ua
    {
        public string Build { get; set; }
        public string Os { get; set; }
        public string Device { get; set; }

        public string Patch { get; set; }
        public string OsMinor { get; set; }

        public string OsMajor { get; set; }

        public string OsName { get; set; }

        public string Minor { get; set; }

        public string Name { get; set; }
        public string major { get; set; }
    }


    public class App
    {
        public KeyValuePair<string, object>  QrcodeScanning { get; set; }

        public string Id { get; set; }

        public string Name { get; set; }

        public object? Description { get; set; }

        public string Identifier { get; set; }

        public string Logo { get; set; }

        public string [] LoginTabs { get; set; }

        public string [] RegisterTabs { get; set; }

        public object [] AdConnections { get; set; }

        public object []   DisabledOidcConnections { get; set; }

        public object [] DisabledSamlConnections { get; set; }

        public object [] ExtendsFields { get; set; }

        public object [] DisabledAzureAdConnections { get; set; }

        public object [] DisabledOauth2Connections { get; set; }

        public object [] DisabledCasConnections { get; set; }
    }

    public class GetAuthorizedTargetsOptions
    {
        public string NameSpace { get; set; }
        public string Resource { get; set; }
        public ResourceType ResourceType { get; set; } = default;

        public AuthorizedTargetsActionsInput Actions { get; set; }

        public PolicyAssignmentTargetType TargetType { get; set; }
    }

    public class ResourceQueryFilter
    {
        public int Page { get; set; }

        public int Limit { get; set; }

        public ResourceType Type { get; set; }
        // public string NameSpaceCode { get; set; }       
        public string NameSpace { get; set; }
    }

    public class ListResourcesRes
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public Resources [] Data { get; set; }
    }

    public class Resources
    {
        public string UserPoolId { get; set; }
        public string Code { get; set; }
        public ResourceAction [] Actions { get; set; }
        public ResourceType Type { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public string NameSpaceId { get; set; }
        public string ApiIdentifier { get; set; }

    }

    public class ResourceAction
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class GetResourceByCodeParam
    {
        public string NameSpace { get; set; }
        public string Code { get; set; }
    }

    public class CreateResourceParam
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("type")]
        public ResourceType Type { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
        [JsonProperty("actions")]
        public  ResourceAction [] Actions { get; set; }
        [JsonProperty("namespace")]
        public string NameSpace { get; set; }
    }

    public class UpdateResourceParam
    {
        [JsonProperty("type")]
        public ResourceType Type { get; set; }
        [JsonProperty("description")]
        public string? Description { get; set; }
        [JsonProperty("actions")]
        public ResourceAction[] Actions { get; set; }
        [JsonProperty("namespace")]
        public string NameSpace { get; set; }
    }

    public class AppAccessPolicyQueryFilter
    {
        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
        public string AppId { get; set; }
    }

    public class ApplicationAccessPolicies
    {
        public int TotalCount { get; set; }

        public Policy [] List { get; set; }
    }

    public class AppAccessPolicy
    {
        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType TargetType { get; set; }

        [JsonProperty("targetIdentifiers")]
        public string [] TartgetIdentifiers { get; set; }

        [JsonProperty("namespace")]
        public string NameSpace { get; set; }

        [JsonProperty("inheritByChildren")]
        public bool InheritByChildren { get; set; }
    }

    public class UpdateDefaultApplicationAccessPolicyParam
    {
        public DefaultStrategyEnum DefaultStrategy { get; set; }
        public string AppId { get; set; }
    }

    public enum DefaultStrategyEnum
    {
        ALLOW_ALL,
        DENY_ALL
    }
    

    public class UpdateDefaultApplicationAccessPolicyRes
    {
        public int Code { get; set; }
        public string Message { get; set; }

        public PublicApplication Data { get; set; }
    }

    public class PublicApplication
    {
        public QrcodeScanning QrcodeScanning { get; set; }
        public string Id { get; set; }
        public string UserPoolId { get; set; }
        public string Protocol { get; set; }
        public string Name { get; set; }
        public string Secret { get; set; }
        public string Identifier { get; set; }

        public KeyValuePair<string, string> Jwks { get; set; }

        public string[] RedirectUris { get; set; }
        public string Css { get; set; }

        public string CreateAt { get; set; }
        public string UpdatedAt { get; set; }
        public object? Description { get; set; }
        public object? SsoPageCustomizationSettings { get; set; }
        public string Logo { get; set; }
        public object? LogoutRedirectUris { get; set; }
        public object? LoginTabs { get; set; }

        public string DefaultLoginTab { get; set; }

        public object RegisterTabs { get; set; }
        public string DefaultRegisterTab { get; set; }
        public object? LdapConnections { get; set; }
        public object? AdConnections { get; set; }
        public object? DisabledSocialConnections { get; set; }
        public object? DisabledOidcConnections { get; set; }
        public object? DisabledSamlConnections { get; set; }
        public object? DisabledOauth2Connections { get; set; }
        public object? DisabledCasConnections { get; set; }
        public object? DisabledAzureAdConnections { get; set; }
        public object? ExtendsFields { get; set; }
        public object? Ext { get; set; }
        public bool skipMfa { get; set; }
        public PermissionStrategy PermissionStrategy { get; set; }
        public bool IsOfficial { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsDefault { get; set; }
        public bool OidcProviderEnabled { get; set; }
        public bool OauthProviderEnabled { get; set; }
        public bool SamlProviderEnabled { get; set; }
        public bool CasProviderEnabled { get; set; }
        public bool RegisterDisabled { get; set; }
        public bool ExtendsFieldsEnabled { get; set; }
        public bool ShowAuthorizationPage { get; set; }
        public bool EnableSubAccount { get; set; }
        public bool LoginRequireEmailVerified { get; set; }
        public bool AgreementEnabled { get; set; }
    }

    public class ProgrammaticAccessAccountList
    {
        public int TotalCount { get; set; }
        public object List { get; set; }
    }

    public class ProgrammaticAccessAccount
    {
        public string Id { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string AppId { get; set; }
        public string Secret { get; set; }
        public string Remarks { get; set; }
        public int TokenLifetime { get; set; }
        public bool Enabled { get; set; }
        public string UserId { get; set; }


    }

    public class CreateProgrammaticAccessAccountParam
    {
        public string Remarks { get; set; }
        public int TokenLifetime { get; set; } = 600;
    }

    public class Namespaces
    {
        public int Total { get; set; }

        public NameSpace [] List { get; set; }
    }

    public class NameSpace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string AppId { get; set; }
        public string AppName { get; set; }
    }

    public class UpdateNamespaceParam
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class ApplicationList
    {
        public int TotalCount { get; set; }
        public Application [] List { get; set; }
    }

    public class UpdateRoleOptions
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string NewCode { get; set; }

        public string NameSpace { get; set; }
    }

    public class ListUsersOption
    {
        public string NameSpace { get; set; }
        public bool WithCustomData { get; set; } = false;

        public int Page { get; set; } = 1;
        public int Limit { get; set; } = 10;
    }

    public class SetUdfValueParam
    {
        public string RoleId { get; set; }
        public KeyValueDictionary UdvList { get; set; }
    }

    public enum ProviderTypeEnum
    {
        DINGTALK,
        WECHATWORK,
        AD,

    }

    public class CreateUserOption
    {
        public bool KeppPassword { get; set; }
        
        public bool ResetPasswordOnFirstLogin { get; set; }
        
    }

    public class ActiveUsers
    {
        public int TotalCount { get; set; }
        
        public IEnumerable<User> List { get; set; }
        
    }

    [JsonObject(NamingStrategyType = typeof(CamelCaseNamingStrategy))]
    public class ListApplicationsRes
    {
        public string Code { get; set; }
        
        public string Message { get; set; }
        
        public ApplicationList Data { get; set; }
        
    }

}