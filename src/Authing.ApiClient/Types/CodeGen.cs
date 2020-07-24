using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Authing.ApiClient.GraphQL;

namespace Authing.ApiClient.Types
{

    #region Query
    public class Query
    {
        #region members
        [JsonProperty("ReadEmailSentList")]
        public Email ReadEmailSentList { get; set; }

        [JsonProperty("ReadEmailSentListByClient")]
        public EmailListPaged ReadEmailSentListByClient { get; set; }

        [JsonProperty("ReadEmailProvider")]
        public List<EmailProviderList> ReadEmailProvider { get; set; }

        [JsonProperty("ReadEmailProviderByClientAndName")]
        public List<EmailProviderWithClientList> ReadEmailProviderByClientAndName { get; set; }

        [JsonProperty("ReadEmailTemplatesByClient")]
        public List<EmailTemplateWithClient> ReadEmailTemplatesByClient { get; set; }

        [JsonProperty("ReadEmailProviderWithClient")]
        public List<EmailProviderWithClientList> ReadEmailProviderWithClient { get; set; }

        [JsonProperty("ReadEmailTemplateByClientAndType")]
        public EmailTemplate ReadEmailTemplateByClientAndType { get; set; }

        [JsonProperty("PreviewEmailByType")]
        public string PreviewEmailByType { get; set; }

        [JsonProperty("ReadEmailTemplatesBySystem")]
        public List<EmailTemplateWithClient> ReadEmailTemplatesBySystem { get; set; }

        [JsonProperty("ReadOauthList")]
        public List<OAuthList> ReadOauthList { get; set; }

        [JsonProperty("ReadSAMLSPList")]
        public List<SAMLSPListItem> ReadSamlspList { get; set; }

        [JsonProperty("userOAuthCount")]
        public List<int?> UserOAuthCount { get; set; }

        [JsonProperty("wxQRCodeLog")]
        public WxQRCodeLog WxQrCodeLog { get; set; }

        [JsonProperty("querySystemOAuthSetting")]
        public List<OAuthList> QuerySystemOAuthSetting { get; set; }

        [JsonProperty("notBindOAuthList")]
        public List<NotBindOAuth> NotBindOAuthList { get; set; }

        [JsonProperty("QueryClientIdByAppId")]
        public OAuthProviderClient QueryClientIdByAppId { get; set; }

        [JsonProperty("getOAuthedAppInfo")]
        public OAuthProviderClient GetOAuthedAppInfo { get; set; }

        [JsonProperty("getOAuthedAppList")]
        public OAuthAppPagedList GetOAuthedAppList { get; set; }

        [JsonProperty("GetOIDCAppInfo")]
        public OIDCProviderClient GetOidcAppInfo { get; set; }

        [JsonProperty("GetOIDCAppList")]
        public OIDCAppPagedList GetOidcAppList { get; set; }

        [JsonProperty("queryProviderInfoByDomain")]
        public ProviderGeneralInfo QueryProviderInfoByDomain { get; set; }

        [JsonProperty("queryProviderInfoByAppId")]
        public ProviderGeneralInfo QueryProviderInfoByAppId { get; set; }

        [JsonProperty("QueryAppInfoByAppID")]
        public OAuthProviderClient QueryAppInfoByAppId { get; set; }

        [JsonProperty("QueryAppInfoByDomain")]
        public OAuthProviderClient QueryAppInfoByDomain { get; set; }

        [JsonProperty("QueryOIDCAppInfoByDomain")]
        public OIDCProviderClient QueryOidcAppInfoByDomain { get; set; }

        [JsonProperty("QueryOIDCAppInfoByAppID")]
        public OIDCProviderClient QueryOidcAppInfoByAppId { get; set; }

        [JsonProperty("QuerySAMLServiceProviderInfoByAppID")]
        public SAMLServiceProviderClient QuerySamlServiceProviderInfoByAppId { get; set; }

        [JsonProperty("QuerySAMLServiceProviderInfoByDomain")]
        public SAMLServiceProviderClient QuerySamlServiceProviderInfoByDomain { get; set; }

        [JsonProperty("QuerySAMLIdentityProviderInfoByAppID")]
        public SAMLIdentityProviderClient QuerySamlIdentityProviderInfoByAppId { get; set; }

        [JsonProperty("QuerySAMLIdentityProviderInfoByDomain")]
        public SAMLIdentityProviderClient QuerySamlIdentityProviderInfoByDomain { get; set; }

        [JsonProperty("QueryDefaultSAMLIdentityProviderSettingsList")]
        public SAMLDefaultIdentityProviderSettingsList QueryDefaultSamlIdentityProviderSettingsList { get; set; }

        [JsonProperty("GetSAMLServiceProviderList")]
        public SAMLServiceProviderAppPagedList GetSamlServiceProviderList { get; set; }

        [JsonProperty("GetSAMLServiceProviderInfo")]
        public SAMLServiceProviderClient GetSamlServiceProviderInfo { get; set; }

        [JsonProperty("GetSAMLIdentityProviderInfo")]
        public SAMLIdentityProviderClient GetSamlIdentityProviderInfo { get; set; }

        [JsonProperty("GetSAMLIdentityProviderList")]
        public SAMLIdentityProviderAppPagedList GetSamlIdentityProviderList { get; set; }

        [JsonProperty("QueryLDAPServerList")]
        public LDAPServerList QueryLdapServerList { get; set; }

        [JsonProperty("TestLDAPServer")]
        public LDAPServerTesterType TestLdapServer { get; set; }

        [JsonProperty("TestLDAPUser")]
        public LDAPUserTesterType TestLdapUser { get; set; }

        [JsonProperty("QueryClientHasLDAPConfigs")]
        public ClientHasLDAPConfigs QueryClientHasLdapConfigs { get; set; }

        [JsonProperty("GetUserAuthorizedApps")]
        public UserAuthorizedAppPagedList GetUserAuthorizedApps { get; set; }

        [JsonProperty("isAppAuthorizedByUser")]
        public IsAppAuthorizedByUser IsAppAuthorizedByUser { get; set; }

        [JsonProperty("checkIsReservedDomain")]
        public IsReservedDomain CheckIsReservedDomain { get; set; }

        [JsonProperty("ReadSystemPricing")]
        public List<PricingList> ReadSystemPricing { get; set; }

        [JsonProperty("ReadOrders")]
        public PagedOrders ReadOrders { get; set; }

        [JsonProperty("ReadUserPricing")]
        public UserPricingType ReadUserPricing { get; set; }

        [JsonProperty("users")]
        public PagedUsers Users { get; set; }

        [JsonProperty("usersByOidcApp")]
        public UserIds UsersByOidcApp { get; set; }

        [JsonProperty("user")]
        public ExtendUser User { get; set; }

        [JsonProperty("userAnalytics")]
        public UserAnalytics UserAnalytics { get; set; }

        [JsonProperty("isLoginExpired")]
        public bool? IsLoginExpired { get; set; }

        [JsonProperty("client")]
        public UserClient Client { get; set; }

        [JsonProperty("userClients")]
        public PagedUserClients UserClients { get; set; }

        [JsonProperty("searchUser")]
        public PagedUsers SearchUser { get; set; }

        [JsonProperty("userClientTypes")]
        public List<UserClientType> UserClientTypes { get; set; }

        [JsonProperty("isClientOfUser")]
        public bool? IsClientOfUser { get; set; }

        [JsonProperty("getAccessTokenByAppSecret")]
        public string GetAccessTokenByAppSecret { get; set; }

        [JsonProperty("loginCount")]
        public UserLoginCount LoginCount { get; set; }

        [JsonProperty("qiNiuUploadToken")]
        public string QiNiuUploadToken { get; set; }

        [JsonProperty("decodeJwtToken")]
        public JwtDecodedData DecodeJwtToken { get; set; }

        [JsonProperty("checkLoginStatus")]
        public JWTDecodedDataCheckLogin CheckLoginStatus { get; set; }

        [JsonProperty("getAppSecretByClientId")]
        public AppSecretByClientId GetAppSecretByClientId { get; set; }

        [JsonProperty("previewEmailTemplate")]
        public CommonMessage PreviewEmailTemplate { get; set; }

        [JsonProperty("loginHotDotPicData")]
        public LoginHotDotPicData LoginHotDotPicData { get; set; }

        [JsonProperty("registerEveryDayCount")]
        public RegisterEveryDayCount RegisterEveryDayCount { get; set; }

        [JsonProperty("statistic")]
        public Statistic Statistic { get; set; }

        [JsonProperty("userClientList")]
        public PagedUserClientList UserClientList { get; set; }

        [JsonProperty("usersInGroup")]
        public UsersInGroup UsersInGroup { get; set; }

        [JsonProperty("qpsByTime")]
        public List<QpsByTime> QpsByTime { get; set; }

        [JsonProperty("todayGeoDistribution")]
        public List<GeographicalDistributionList> TodayGeoDistribution { get; set; }

        [JsonProperty("findClientsByIdArray")]
        public PagedUserClientList FindClientsByIdArray { get; set; }

        [JsonProperty("recentServiceCall")]
        public DayServiceCallListOfAllServices RecentServiceCall { get; set; }

        [JsonProperty("platformUserGrowthTrend")]
        public List<DayUserGrowth> PlatformUserGrowthTrend { get; set; }

        [JsonProperty("requestList")]
        public PagedRequestList RequestList { get; set; }

        [JsonProperty("bindedOAuthList")]
        public List<UserOAuthBind> BindedOAuthList { get; set; }

        [JsonProperty("userPatch")]
        public PatchExtendUser UserPatch { get; set; }

        [JsonProperty("isClientBelongToUser")]
        public bool? IsClientBelongToUser { get; set; }

        [JsonProperty("queryClient")]
        public UserClient QueryClient { get; set; }

        [JsonProperty("clientRoles")]
        public PagedRoles ClientRoles { get; set; }

        [JsonProperty("userGroup")]
        public PagedUserGroup UserGroup { get; set; }

        [JsonProperty("queryRoleByUserId")]
        public PagedUserGroup QueryRoleByUserId { get; set; }

        [JsonProperty("getClientWhenSdkInit")]
        public ClientInfoAndAccessToken GetClientWhenSdkInit { get; set; }

        [JsonProperty("getWebhookDetail")]
        public ClientWebhook GetWebhookDetail { get; set; }

        [JsonProperty("getAllWebhooks")]
        public List<ClientWebhook> GetAllWebhooks { get; set; }

        [JsonProperty("getWebhookLogDetail")]
        public WebhookLog GetWebhookLogDetail { get; set; }

        [JsonProperty("getWebhookLogs")]
        public List<WebhookLog> GetWebhookLogs { get; set; }

        [JsonProperty("getWebhookSettingOptions")]
        public WebhookSettingOptions GetWebhookSettingOptions { get; set; }

        [JsonProperty("queryCollaborativeUserPoolByUserId")]
        public CollaborativeUserPoolList QueryCollaborativeUserPoolByUserId { get; set; }

        [JsonProperty("queryCollaboratorsByUserPoolId")]
        public Collaborators QueryCollaboratorsByUserPoolId { get; set; }

        [JsonProperty("queryCollaboratorPermissions")]
        public CollaboratorPermissions QueryCollaboratorPermissions { get; set; }

        [JsonProperty("queryPasswordStrengthSettingsByUserPoolId")]
        public PasswordStrengthSettings QueryPasswordStrengthSettingsByUserPoolId { get; set; }

        [JsonProperty("queryCollaborationByUserPoolIdAndUserId")]
        public Collaboration QueryCollaborationByUserPoolIdAndUserId { get; set; }

        [JsonProperty("queryPermissionList")]
        public PermissionList QueryPermissionList { get; set; }

        [JsonProperty("searchUserBasicInfoById")]
        public BasicUserInfo SearchUserBasicInfoById { get; set; }

        [JsonProperty("queryPasswordFaasEnabled")]
        public PaaswordFaas QueryPasswordFaasEnabled { get; set; }

        [JsonProperty("emailDomainTopNList")]
        public List<LoginTopEmailList> EmailDomainTopNList { get; set; }

        [JsonProperty("registerMethodTopList")]
        public List<RegisterMethodList> RegisterMethodTopList { get; set; }

        [JsonProperty("querySMSSendCount")]
        public SMSCountInfo QuerySmsSendCount { get; set; }

        [JsonProperty("queryInvitation")]
        public List<Invitation> QueryInvitation { get; set; }

        [JsonProperty("queryInvitationState")]
        public InvitationState QueryInvitationState { get; set; }

        [JsonProperty("queryMFA")]
        public MFA QueryMfa { get; set; }

        [JsonProperty("queryAuthorizedUserPool")]
        public PagedUserPoolWithMFA QueryAuthorizedUserPool { get; set; }

        [JsonProperty("getCustomMFA")]
        public PagedCustomMFAList GetCustomMfa { get; set; }

        [JsonProperty("validatePassword")]
        public ValidateResult ValidatePassword { get; set; }

        [JsonProperty("getUserLoginAreaStatisticOfClient")]
        public string GetUserLoginAreaStatisticOfClient { get; set; }

        [JsonProperty("getUserPoolSettings")]
        public UserClient GetUserPoolSettings { get; set; }

        [JsonProperty("queryAuthAuditRecords")]
        public AuthAuditRecordsList QueryAuthAuditRecords { get; set; }

        [JsonProperty("queryUserPoolCommonInfo")]
        public UserPoolCommonInfo QueryUserPoolCommonInfo { get; set; }

        [JsonProperty("isDomainAvaliable")]
        public bool? IsDomainAvaliable { get; set; }

        [JsonProperty("checkPhoneCode")]
        public CommonMessage CheckPhoneCode { get; set; }

        [JsonProperty("userExist")]
        public bool? UserExist { get; set; }

        [JsonProperty("adConnectorByProvider")]
        public ADConnctorCommonInfo AdConnectorByProvider { get; set; }

        [JsonProperty("isAdConnectorAlive")]
        public isAdConenctorAlive IsAdConnectorAlive { get; set; }

        [JsonProperty("adConnectorList")]
        public List<ADConnector> AdConnectorList { get; set; }

        [JsonProperty("providerListByADConnector")]
        public List<ADConnectorEnabledProvider> ProviderListByAdConnector { get; set; }

        [JsonProperty("checkAdConnectorStatus")]
        public bool? CheckAdConnectorStatus { get; set; }

        [JsonProperty("samlIdPFieldMappings")]
        public List<SAMLFieldMappings> SamlIdPFieldMappings { get; set; }

        [JsonProperty("supportedSAMLFieldMappings")]
        public List<SAMLAvaliableFieldMappings> SupportedSamlFieldMappings { get; set; }

        [JsonProperty("rbacRole")]
        public RBACRole RbacRole { get; set; }

        [JsonProperty("rbacRoleList")]
        public PagedRBACRole RbacRoleList { get; set; }

        [JsonProperty("rbacGroup")]
        public RBACGroup RbacGroup { get; set; }

        [JsonProperty("rbacGroupList")]
        public PagedRBACGroup RbacGroupList { get; set; }

        [JsonProperty("rbacPermission")]
        public RBACPermission RbacPermission { get; set; }

        [JsonProperty("rbacPermissionList")]
        public PagedRBACPermission RbacPermissionList { get; set; }

        [JsonProperty("userPermissionList")]
        public UserPermissionList UserPermissionList { get; set; }

        [JsonProperty("userGroupList")]
        public UserGroupList UserGroupList { get; set; }

        [JsonProperty("userRoleList")]
        public UserRoleList UserRoleList { get; set; }

        [JsonProperty("org")]
        public Org Org { get; set; }

        [JsonProperty("orgs")]
        public PagedOrg Orgs { get; set; }

        [JsonProperty("orgRootNode")]
        public RBACGroup OrgRootNode { get; set; }

        [JsonProperty("orgChildrenNodes")]
        public List<OrgChildNode> OrgChildrenNodes { get; set; }

        [JsonProperty("isRootNodeOfOrg")]
        public bool? IsRootNodeOfOrg { get; set; }

        [JsonProperty("groupMetadata")]
        public List<GroupMetadata> GroupMetadata { get; set; }

        [JsonProperty("searchGroupByMetadata")]
        public PagedRBACGroup SearchGroupByMetadata { get; set; }

        [JsonProperty("searchOrgNodes")]
        public List<RBACGroup> SearchOrgNodes { get; set; }

        [JsonProperty("orgNodeUserList")]
        public PagedUsers OrgNodeUserList { get; set; }

        [JsonProperty("isUserInGroup")]
        public bool? IsUserInGroup { get; set; }

        [JsonProperty("searchOrgNodeUser")]
        public PagedUsers SearchOrgNodeUser { get; set; }

        [JsonProperty("DingTalkCorp")]
        public DingTalkCorp DingTalkCorp { get; set; }

        [JsonProperty("wechatWorkCorp")]
        public WechatWorkCorp WechatWorkCorp { get; set; }

        [JsonProperty("ruleById")]
        public Rule RuleById { get; set; }

        [JsonProperty("rules")]
        public PagedRules Rules { get; set; }

        [JsonProperty("ruleEnv")]
        public PagedRuleEnvVariable RuleEnv { get; set; }

        [JsonProperty("queryOperationLogs")]
        public OperationLogsList QueryOperationLogs { get; set; }

        [JsonProperty("getUserPoolByDomain")]
        public UserPoolCommonInfo GetUserPoolByDomain { get; set; }

        [JsonProperty("interConnections")]
        public List<InterConnection> InterConnections { get; set; }

        [JsonProperty("userMetadata")]
        public UserMetaDataList UserMetadata { get; set; }
        #endregion
    }
    #endregion

    #region Email
    public class Email
    {
        #region members
        [JsonProperty("list")]
        public List<PopulatedEmailSentList> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region PopulatedEmailSentList
    public class PopulatedEmailSentList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("receivers")]
        public List<string> Receivers { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("client")]
        public Client Client { get; set; }
        #endregion
    }
    #endregion

    #region Client
    public class Client
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
        #endregion
    }
    #endregion

    #region User
    public class User
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        [JsonProperty("registerMethod")]
        public string RegisterMethod { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("tokenExpiredAt")]
        public string TokenExpiredAt { get; set; }

        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        [JsonProperty("signedUp")]
        public string SignedUp { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

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

        [JsonProperty("preferredUsername")]
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

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("thirdPartyIdentity")]
        public ThirdPartyIdentity ThirdPartyIdentity { get; set; }

        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }
        #endregion
    }
    #endregion

    #region ThirdPartyIdentity
    public class ThirdPartyIdentity
    {
        #region members
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("expiresIn")]
        public int? ExpiresIn { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region EmailListPaged
    public class EmailListPaged
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<EmailSentList> List { get; set; }
        #endregion
    }
    #endregion

    #region EmailSentList
    public class EmailSentList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("receivers")]
        public List<string> Receivers { get; set; }

        [JsonProperty("post")]
        public string Post { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("rejected")]
        public List<string> Rejected { get; set; }

        [JsonProperty("isDeleted")]
        public string IsDeleted { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderList
    public class EmailProviderList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public List<EmailProviderForm> Fields { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("provider")]
        public EmailProviderChildrenList Provider { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderForm
    public class EmailProviderForm
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderChildrenList
    public class EmailProviderChildrenList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public List<EmailProviderForm> Fields { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("provider")]
        public EmailProviderChildrenList Provider { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderWithClientList
    public class EmailProviderWithClientList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("fields")]
        public List<EmailProviderWithClientForm> Fields { get; set; }

        [JsonProperty("provider")]
        public EmailProviderWithClient Provider { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderWithClientForm
    public class EmailProviderWithClientForm
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderWithClient
    public class EmailProviderWithClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion
    }
    #endregion

    #region EmailTemplateWithClient
    public class EmailTemplateWithClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("template")]
        public EmailTemplate Template { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        [JsonProperty("URLExpireTime")]
        public int? UrlExpireTime { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
        #endregion
    }
    #endregion

    #region EmailTemplate
    public class EmailTemplate
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        [JsonProperty("URLExpireTime")]
        public int? UrlExpireTime { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
        #endregion
    }
    #endregion

    #region OAuthList
    public class OAuthList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("oAuthUrl")]
        public string OAuthUrl { get; set; }

        [JsonProperty("wxappLogo")]
        public string WxappLogo { get; set; }

        [JsonProperty("fields")]
        public List<OAuthListFieldsForm> Fields { get; set; }

        [JsonProperty("oauth")]
        public ChildrenOAuthList Oauth { get; set; }
        #endregion
    }
    #endregion

    #region OAuthListFieldsForm
    public class OAuthListFieldsForm
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("children")]
        public List<OAuthListFieldsFormRecursion> Children { get; set; }

        [JsonProperty("checked")]
        public List<string> Checked { get; set; }
        #endregion
    }
    #endregion

    #region OAuthListFieldsFormRecursion
    public class OAuthListFieldsFormRecursion
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("children")]
        public List<OAuthListFieldsFormRecursion> Children { get; set; }
        #endregion
    }
    #endregion

    #region ChildrenOAuthList
    public class ChildrenOAuthList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("oAuthUrl")]
        public string OAuthUrl { get; set; }

        [JsonProperty("wxappLogo")]
        public string WxappLogo { get; set; }

        [JsonProperty("fields")]
        public List<OAuthListFieldsForm> Fields { get; set; }

        [JsonProperty("oauth")]
        public ChildrenOAuthList Oauth { get; set; }
        #endregion
    }
    #endregion

    #region SAMLSPListItem
    public class SAMLSPListItem
    {
        #region members
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
        #endregion
    }
    #endregion

    #region WxQRCodeLog
    public class WxQRCodeLog
    {
        #region members
        [JsonProperty("list")]
        public List<WxQRCodeLogList> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region WxQRCodeLogList
    public class WxQRCodeLogList
    {
        #region members
        [JsonProperty("random")]
        public string Random { get; set; }

        [JsonProperty("expiredAt")]
        public string ExpiredAt { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("qrcode")]
        public string Qrcode { get; set; }

        [JsonProperty("used")]
        public bool? Used { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }

        [JsonProperty("redirect")]
        public string Redirect { get; set; }

        [JsonProperty("client")]
        public ClientInWxQRCodeLogList Client { get; set; }
        #endregion
    }
    #endregion

    #region ClientInWxQRCodeLogList
    public class ClientInWxQRCodeLogList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("user")]
        public UserInClientInWxQRCodeLogList User { get; set; }
        #endregion
    }
    #endregion

    #region UserInClientInWxQRCodeLogList
    public class UserInClientInWxQRCodeLogList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
        #endregion
    }
    #endregion

    #region NotBindOAuth
    public class NotBindOAuth
    {
        #region members
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("oAuthUrl")]
        public string OAuthUrl { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("binded")]
        public bool? Binded { get; set; }
        #endregion
    }
    #endregion

    #region OAuthProviderClient
    public class OAuthProviderClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("redirectUris")]
        public List<string> RedirectUris { get; set; }

        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }

        [JsonProperty("client_id")]
        public string Client_Id { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("grants")]
        public List<string> Grants { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        [JsonProperty("casExpire")]
        public int? CasExpire { get; set; }
        #endregion
    }
    #endregion

    #region OAuthAppPagedList
    public class OAuthAppPagedList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<OAuthProviderClient> List { get; set; }
        #endregion
    }
    #endregion

    #region OIDCProviderClient
    public class OIDCProviderClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("redirect_uris")]
        public List<string> Redirect_Uris { get; set; }

        [JsonProperty("client_id")]
        public string Client_Id { get; set; }

        [JsonProperty("client_secret")]
        public string Client_Secret { get; set; }

        [JsonProperty("token_endpoint_auth_method")]
        public string Token_Endpoint_Auth_Method { get; set; }

        [JsonProperty("id_token_signed_response_alg")]
        public string Id_Token_Signed_Response_Alg { get; set; }

        [JsonProperty("id_token_encrypted_response_alg")]
        public string Id_Token_Encrypted_Response_Alg { get; set; }

        [JsonProperty("id_token_encrypted_response_enc")]
        public string Id_Token_Encrypted_Response_Enc { get; set; }

        [JsonProperty("userinfo_signed_response_alg")]
        public string Userinfo_Signed_Response_Alg { get; set; }

        [JsonProperty("userinfo_encrypted_response_alg")]
        public string Userinfo_Encrypted_Response_Alg { get; set; }

        [JsonProperty("userinfo_encrypted_response_enc")]
        public string Userinfo_Encrypted_Response_Enc { get; set; }

        [JsonProperty("request_object_signing_alg")]
        public string Request_Object_Signing_Alg { get; set; }

        [JsonProperty("request_object_encryption_alg")]
        public string Request_Object_Encryption_Alg { get; set; }

        [JsonProperty("request_object_encryption_enc")]
        public string Request_Object_Encryption_Enc { get; set; }

        [JsonProperty("jwks_uri")]
        public string Jwks_Uri { get; set; }

        [JsonProperty("_jwks_uri")]
        public string _Jwks_Uri { get; set; }

        [JsonProperty("custom_jwks")]
        public string Custom_Jwks { get; set; }

        [JsonProperty("jwks")]
        public string Jwks { get; set; }

        [JsonProperty("_jwks")]
        public string _Jwks { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("grant_types")]
        public List<string> Grant_Types { get; set; }

        [JsonProperty("response_types")]
        public List<string> Response_Types { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("isDefault")]
        public bool? IsDefault { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("authorization_code_expire")]
        public string Authorization_Code_Expire { get; set; }

        [JsonProperty("id_token_expire")]
        public string Id_Token_Expire { get; set; }

        [JsonProperty("access_token_expire")]
        public string Access_Token_Expire { get; set; }

        [JsonProperty("cas_expire")]
        public string Cas_Expire { get; set; }

        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        [JsonProperty("customStyles")]
        public OIDCProviderCustomStyles CustomStyles { get; set; }

        [JsonProperty("isForTeamory")]
        public bool? IsForTeamory { get; set; }

        [JsonProperty("confirmAuthorization")]
        public bool? ConfirmAuthorization { get; set; }
        #endregion
    }
    #endregion

    #region OIDCProviderCustomStyles
    public class OIDCProviderCustomStyles
    {
        #region members
        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("hideQRCode")]
        public bool? HideQrCode { get; set; }

        [JsonProperty("hideUP")]
        public bool? HideUp { get; set; }

        [JsonProperty("hideUsername")]
        public bool? HideUsername { get; set; }

        [JsonProperty("hideRegister")]
        public bool? HideRegister { get; set; }

        [JsonProperty("hidePhone")]
        public bool? HidePhone { get; set; }

        [JsonProperty("hideSocial")]
        public bool? HideSocial { get; set; }

        [JsonProperty("hideClose")]
        public bool? HideClose { get; set; }

        [JsonProperty("hidePhonePassword")]
        public bool? HidePhonePassword { get; set; }

        [JsonProperty("placeholder")]
        public OIDCProviderCustomStylesPlaceholder Placeholder { get; set; }

        [JsonProperty("qrcodeScanning")]
        public OIDCProviderCustomStylesQrcodeScanning QrcodeScanning { get; set; }

        [JsonProperty("defaultLoginMethod")]
        public OidcProviderDefaultLoginMethod? DefaultLoginMethod { get; set; }
        #endregion
    }
    #endregion

    #region OIDCProviderCustomStylesPlaceholder
    public class OIDCProviderCustomStylesPlaceholder
    {
        #region members
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("confirmPassword")]
        public string ConfirmPassword { get; set; }

        [JsonProperty("verfiyCode")]
        public string VerfiyCode { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }
        #endregion
    }
    #endregion

    #region OIDCProviderCustomStylesQrcodeScanning
    public class OIDCProviderCustomStylesQrcodeScanning
    {
        #region members
        [JsonProperty("redirect")]
        public bool? Redirect { get; set; }

        [JsonProperty("interval")]
        public int? Interval { get; set; }

        [JsonProperty("tips")]
        public string Tips { get; set; }
        #endregion
    }
    #endregion
    public enum OidcProviderDefaultLoginMethod
    {
        [JsonProperty("PHONE")]
        PHONE,
        [JsonProperty("PASSWORD")]
        PASSWORD,
        [JsonProperty("QRCODE")]
        QRCODE
    }


    #region OIDCAppPagedList
    public class OIDCAppPagedList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<OIDCProviderClient> List { get; set; }
        #endregion
    }
    #endregion

    #region ProviderGeneralInfo
    public class ProviderGeneralInfo
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("client_id")]
        public string Client_Id { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }

        [JsonProperty("redirect_uris")]
        public List<string> Redirect_Uris { get; set; }
        #endregion
    }
    #endregion

    #region SAMLServiceProviderClient
    public class SAMLServiceProviderClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }

        [JsonProperty("defaultIdPMap")]
        public SAMLDefaultIdentityProviderSettings DefaultIdPMap { get; set; }

        [JsonProperty("defaultIdPMapId")]
        public string DefaultIdPMapId { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        [JsonProperty("IdPEntityID")]
        public string IdPEntityId { get; set; }

        [JsonProperty("assertionConsumeService")]
        public List<AssertionConsumeService> AssertionConsumeService { get; set; }

        [JsonProperty("mappings")]
        public AssertionMap Mappings { get; set; }

        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        [JsonProperty("logoutUrl")]
        public string LogoutUrl { get; set; }

        [JsonProperty("nameId")]
        public string NameId { get; set; }

        [JsonProperty("enableSignRes")]
        public bool? EnableSignRes { get; set; }

        [JsonProperty("resSignPublicKey")]
        public string ResSignPublicKey { get; set; }

        [JsonProperty("hasResEncrypted")]
        public bool? HasResEncrypted { get; set; }

        [JsonProperty("resEncryptAlgorithm")]
        public string ResEncryptAlgorithm { get; set; }

        [JsonProperty("resAbstractAlgorithm")]
        public string ResAbstractAlgorithm { get; set; }

        [JsonProperty("resDecryptPrivateKey")]
        public string ResDecryptPrivateKey { get; set; }

        [JsonProperty("resDecryptPrivateKeyPass")]
        public string ResDecryptPrivateKeyPass { get; set; }

        [JsonProperty("resEncryptPublicKey")]
        public string ResEncryptPublicKey { get; set; }

        [JsonProperty("enableSignReq")]
        public bool? EnableSignReq { get; set; }

        [JsonProperty("reqSignAlgorithm")]
        public string ReqSignAlgorithm { get; set; }

        [JsonProperty("reqAbstractAlgorithm")]
        public string ReqAbstractAlgorithm { get; set; }

        [JsonProperty("reqSignPrivateKey")]
        public string ReqSignPrivateKey { get; set; }

        [JsonProperty("reqSignPrivateKeyPass")]
        public string ReqSignPrivateKeyPass { get; set; }

        [JsonProperty("reqSignPublicKey")]
        public string ReqSignPublicKey { get; set; }

        [JsonProperty("SPUrl")]
        public string SpUrl { get; set; }
        #endregion
    }
    #endregion

    #region SAMLDefaultIdentityProviderSettings
    public class SAMLDefaultIdentityProviderSettings
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("mappings")]
        public AssertionMap Mappings { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }
        #endregion
    }
    #endregion

    #region AssertionMap
    public class AssertionMap
    {
        #region members
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
        #endregion
    }
    #endregion

    #region AssertionConsumeService
    public class AssertionConsumeService
    {
        #region members
        [JsonProperty("binding")]
        public string Binding { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isDefault")]
        public bool? IsDefault { get; set; }
        #endregion
    }
    #endregion

    #region SAMLIdentityProviderClient
    public class SAMLIdentityProviderClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("appSecret")]
        public string AppSecret { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        [JsonProperty("attributeNameFormat")]
        public string AttributeNameFormat { get; set; }

        [JsonProperty("customAttributes")]
        public string CustomAttributes { get; set; }

        [JsonProperty("emailDomainTransformation")]
        public string EmailDomainTransformation { get; set; }

        [JsonProperty("authnContextClassRef")]
        public string AuthnContextClassRef { get; set; }

        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        [JsonProperty("assertionConsumerUrl")]
        public string AssertionConsumerUrl { get; set; }

        [JsonProperty("bindings")]
        public List<string> Bindings { get; set; }

        [JsonProperty("nameIds")]
        public List<string> NameIds { get; set; }

        [JsonProperty("attributes")]
        public List<string> Attributes { get; set; }

        [JsonProperty("enableSignRes")]
        public bool? EnableSignRes { get; set; }

        [JsonProperty("resSignAlgorithm")]
        public string ResSignAlgorithm { get; set; }

        [JsonProperty("resAbstractAlgorithm")]
        public string ResAbstractAlgorithm { get; set; }

        [JsonProperty("resSignPublicKey")]
        public string ResSignPublicKey { get; set; }

        [JsonProperty("resSignPrivateKey")]
        public string ResSignPrivateKey { get; set; }

        [JsonProperty("resSignPrivateKeyPass")]
        public string ResSignPrivateKeyPass { get; set; }

        [JsonProperty("enableSignReq")]
        public bool? EnableSignReq { get; set; }

        [JsonProperty("reqSignPublicKey")]
        public string ReqSignPublicKey { get; set; }

        [JsonProperty("enableEncryptRes")]
        public bool? EnableEncryptRes { get; set; }

        [JsonProperty("resEncryptPublicKey")]
        public string ResEncryptPublicKey { get; set; }

        [JsonProperty("css")]
        public string Css { get; set; }
        #endregion
    }
    #endregion

    #region SAMLDefaultIdentityProviderSettingsList
    public class SAMLDefaultIdentityProviderSettingsList
    {
        #region members
        [JsonProperty("list")]
        public List<SAMLDefaultIdentityProviderSettings> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region SAMLServiceProviderAppPagedList
    public class SAMLServiceProviderAppPagedList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<SAMLServiceProviderClient> List { get; set; }
        #endregion
    }
    #endregion

    #region SAMLIdentityProviderAppPagedList
    public class SAMLIdentityProviderAppPagedList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<SAMLIdentityProviderClient> List { get; set; }
        #endregion
    }
    #endregion

    #region LDAPServerList
    public class LDAPServerList
    {
        #region members
        [JsonProperty("list")]
        public List<LDAPSingleServer> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region LDAPSingleServer
    public class LDAPSingleServer
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("ldapLink")]
        public string LdapLink { get; set; }

        [JsonProperty("baseDN")]
        public string BaseDn { get; set; }

        [JsonProperty("searchStandard")]
        public string SearchStandard { get; set; }

        [JsonProperty("emailPostfix")]
        public string EmailPostfix { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region LDAPServerTesterType
    public class LDAPServerTesterType
    {
        #region members
        [JsonProperty("result")]
        public bool? Result { get; set; }
        #endregion
    }
    #endregion

    #region LDAPUserTesterType
    public class LDAPUserTesterType
    {
        #region members
        [JsonProperty("result")]
        public bool? Result { get; set; }
        #endregion
    }
    #endregion

    #region ClientHasLDAPConfigs
    public class ClientHasLDAPConfigs
    {
        #region members
        [JsonProperty("result")]
        public bool? Result { get; set; }
        #endregion
    }
    #endregion

    #region UserAuthorizedAppPagedList
    public class UserAuthorizedAppPagedList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("OAuthApps")]
        public List<OAuthProviderClient> OAuthApps { get; set; }

        [JsonProperty("OIDCApps")]
        public List<OIDCProviderClient> OidcApps { get; set; }
        #endregion
    }
    #endregion

    #region IsAppAuthorizedByUser
    public class IsAppAuthorizedByUser
    {
        #region members
        [JsonProperty("authorized")]
        public bool? Authorized { get; set; }
        #endregion
    }
    #endregion

    #region IsReservedDomain
    public class IsReservedDomain
    {
        #region members
        [JsonProperty("domainValue")]
        public string DomainValue { get; set; }

        [JsonProperty("isReserved")]
        public bool? IsReserved { get; set; }
        #endregion
    }
    #endregion

    #region PricingList
    public class PricingList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startNumber")]
        public int? StartNumber { get; set; }

        [JsonProperty("freeNumber")]
        public int? FreeNumber { get; set; }

        [JsonProperty("startPrice")]
        public int? StartPrice { get; set; }

        [JsonProperty("maxNumber")]
        public int? MaxNumber { get; set; }

        [JsonProperty("d")]
        public int? D { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }
        #endregion
    }
    #endregion

    #region PagedOrders
    public class PagedOrders
    {
        #region members
        [JsonProperty("list")]
        public List<OrderList> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region OrderList
    public class OrderList
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("timeOfPurchase")]
        public int? TimeOfPurchase { get; set; }

        [JsonProperty("flowNumber")]
        public int? FlowNumber { get; set; }

        [JsonProperty("price")]
        public float? Price { get; set; }

        [JsonProperty("pricing")]
        public OrderPricing Pricing { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("completed")]
        public bool? Completed { get; set; }

        [JsonProperty("payMethod")]
        public string PayMethod { get; set; }

        [JsonProperty("endAt")]
        public string EndAt { get; set; }

        [JsonProperty("clientInfo")]
        public OrderClient ClientInfo { get; set; }
        #endregion
    }
    #endregion

    #region OrderPricing
    public class OrderPricing
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startNumber")]
        public int? StartNumber { get; set; }

        [JsonProperty("freeNumber")]
        public int? FreeNumber { get; set; }

        [JsonProperty("startPrice")]
        public int? StartPrice { get; set; }

        [JsonProperty("maxNumber")]
        public int? MaxNumber { get; set; }

        [JsonProperty("d")]
        public int? D { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }
        #endregion
    }
    #endregion

    #region OrderClient
    public class OrderClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("jwtExpired")]
        public int? JwtExpired { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }
        #endregion
    }
    #endregion

    #region UserPricingType
    public class UserPricingType
    {
        #region members
        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("isFree")]
        public bool? IsFree { get; set; }

        [JsonProperty("pricing")]
        public UserPricingNotFreeType Pricing { get; set; }

        [JsonProperty("freeNumber")]
        public int? FreeNumber { get; set; }
        #endregion
    }
    #endregion

    #region UserPricingNotFreeType
    public class UserPricingNotFreeType
    {
        #region members
        [JsonProperty("number")]
        public int? Number { get; set; }
        #endregion
    }
    #endregion

    #region PagedUsers
    public class PagedUsers
    {
        #region members
        [JsonProperty("list")]
        public List<ExtendUser> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region ExtendUser
    public class ExtendUser
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        [JsonProperty("registerMethod")]
        public string RegisterMethod { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("tokenExpiredAt")]
        public string TokenExpiredAt { get; set; }

        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        [JsonProperty("signedUp")]
        public string SignedUp { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

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

        [JsonProperty("preferredUsername")]
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

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("clientType")]
        public UserClientType ClientType { get; set; }

        [JsonProperty("userLocation")]
        public List<UserLocation> UserLocation { get; set; }

        [JsonProperty("userLoginHistory")]
        public PagedUserLoginHistory UserLoginHistory { get; set; }

        [JsonProperty("systemApplicationType")]
        public SystemApplicationType SystemApplicationType { get; set; }

        [JsonProperty("thirdPartyIdentity")]
        public ThirdPartyIdentity ThirdPartyIdentity { get; set; }

        [JsonProperty("customData")]
        public string CustomData { get; set; }

        [JsonProperty("metadata")]
        public string Metadata { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }
        #endregion
    }
    #endregion

    #region Group
    public class Group
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region UserClientType
    public class UserClientType
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("example")]
        public string Example { get; set; }
        #endregion
    }
    #endregion

    #region UserLocation
    public class UserLocation
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("userPool")]
        public UserClient UserPool { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("where")]
        public string Where { get; set; }
        #endregion
    }
    #endregion

    #region UserClient
    public class UserClient
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("iamType")]
        public IamType? IamType { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("clientType")]
        public UserClientType ClientType { get; set; }

        [JsonProperty("userLimit")]
        public int? UserLimit { get; set; }

        [JsonProperty("userPoolTypes")]
        public List<UserClientType> UserPoolTypes { get; set; }

        [JsonProperty("usersCount")]
        public int? UsersCount { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("emailVerifiedDefault")]
        public bool? EmailVerifiedDefault { get; set; }

        [JsonProperty("sendWelcomeEmail")]
        public bool? SendWelcomeEmail { get; set; }

        [JsonProperty("registerDisabled")]
        public bool? RegisterDisabled { get; set; }

        [JsonProperty("showWXMPQRCode")]
        public bool? ShowWxmpqrCode { get; set; }

        [JsonProperty("useMiniLogin")]
        public bool? UseMiniLogin { get; set; }

        [JsonProperty("useSelfWxapp")]
        public bool? UseSelfWxapp { get; set; }

        [JsonProperty("allowedOrigins")]
        public string AllowedOrigins { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("jwtExpired")]
        public int? JwtExpired { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("frequentRegisterCheck")]
        public FrequentRegisterCheckConfig FrequentRegisterCheck { get; set; }

        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfig LoginFailCheck { get; set; }

        [JsonProperty("enableEmail")]
        public bool? EnableEmail { get; set; }

        [JsonProperty("changePhoneStrategy")]
        public ChangePhoneStrategy ChangePhoneStrategy { get; set; }

        [JsonProperty("changeEmailStrategy")]
        public ChangeEmailStrategy ChangeEmailStrategy { get; set; }

        [JsonProperty("qrcodeLoginStrategy")]
        public QrcodeLoginStrategy QrcodeLoginStrategy { get; set; }

        [JsonProperty("app2WxappLoginStrategy")]
        public App2WxappLoginStrategy App2WxappLoginStrategy { get; set; }
        #endregion
    }
    #endregion
    public enum IamType
    {
        [JsonProperty("EIAM")]
        EIAM,
        [JsonProperty("CIAM")]
        CIAM
    }


    #region FrequentRegisterCheckConfig
    public class FrequentRegisterCheckConfig
    {
        #region members
        [JsonProperty("timeInterval")]
        public int? TimeInterval { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }
        #endregion
    }
    #endregion

    #region LoginFailCheckConfig
    public class LoginFailCheckConfig
    {
        #region members
        [JsonProperty("timeInterval")]
        public int? TimeInterval { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }
        #endregion
    }
    #endregion

    #region ChangePhoneStrategy
    public class ChangePhoneStrategy
    {
        #region members
        [JsonProperty("verifyOldPhone")]
        public bool? VerifyOldPhone { get; set; }
        #endregion
    }
    #endregion

    #region ChangeEmailStrategy
    public class ChangeEmailStrategy
    {
        #region members
        [JsonProperty("verifyOldEmail")]
        public bool? VerifyOldEmail { get; set; }
        #endregion
    }
    #endregion

    #region QrcodeLoginStrategy
    public class QrcodeLoginStrategy
    {
        #region members
        [JsonProperty("qrcodeExpiresAfter")]
        public int? QrcodeExpiresAfter { get; set; }

        [JsonProperty("returnFullUserInfo")]
        public bool? ReturnFullUserInfo { get; set; }

        [JsonProperty("allowExchangeUserInfoFromBrowser")]
        public bool? AllowExchangeUserInfoFromBrowser { get; set; }

        [JsonProperty("ticketExpiresAfter")]
        public int? TicketExpiresAfter { get; set; }
        #endregion
    }
    #endregion

    #region App2WxappLoginStrategy
    public class App2WxappLoginStrategy
    {
        #region members
        [JsonProperty("ticketExpriresAfter")]
        public int? TicketExpriresAfter { get; set; }

        [JsonProperty("ticketExchangeUserInfoNeedSecret")]
        public bool? TicketExchangeUserInfoNeedSecret { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserLoginHistory
    public class PagedUserLoginHistory
    {
        #region members
        [JsonProperty("list")]
        public List<UserLoginHistory> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UserLoginHistory
    public class UserLoginHistory
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("client")]
        public UserClient Client { get; set; }

        [JsonProperty("success")]
        public bool? Success { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }
        #endregion
    }
    #endregion

    #region SystemApplicationType
    public class SystemApplicationType
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("price")]
        public int? Price { get; set; }
        #endregion
    }
    #endregion

    #region UserIds
    public class UserIds
    {
        #region members
        [JsonProperty("list")]
        public List<string> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UserAnalytics
    public class UserAnalytics
    {
        #region members
        [JsonProperty("usersAddedToday")]
        public UserAnalyticsItem UsersAddedToday { get; set; }

        [JsonProperty("usersAddedLastWeek")]
        public UserAnalyticsItem UsersAddedLastWeek { get; set; }

        [JsonProperty("usersLoginLastWeek")]
        public UserAnalyticsItem UsersLoginLastWeek { get; set; }

        [JsonProperty("totalUsers")]
        public UserAnalyticsItem TotalUsers { get; set; }

        [JsonProperty("allUsers")]
        public int? AllUsers { get; set; }

        [JsonProperty("totalApps")]
        public int? TotalApps { get; set; }
        #endregion
    }
    #endregion

    #region UserAnalyticsItem
    public class UserAnalyticsItem
    {
        #region members
        [JsonProperty("list")]
        public List<User> List { get; set; }

        [JsonProperty("length")]
        public int? Length { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserClients
    public class PagedUserClients
    {
        #region members
        [JsonProperty("list")]
        public List<UserClient> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UserLoginCount
    public class UserLoginCount
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("isError")]
        public bool? IsError { get; set; }

        [JsonProperty("totalNumber")]
        public int? TotalNumber { get; set; }
        #endregion
    }
    #endregion

    #region JwtDecodedData
    public class JwtDecodedData
    {
        #region members
        [JsonProperty("data")]
        public JwtPayloadData Data { get; set; }

        [JsonProperty("status")]
        public CommonMessage Status { get; set; }

        [JsonProperty("iat")]
        public string Iat { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }
        #endregion
    }
    #endregion

    #region JwtPayloadData
    public class JwtPayloadData
    {
        #region members
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }
        #endregion
    }
    #endregion

    #region CommonMessage
    public class CommonMessage
    {
        #region members
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }
        #endregion
    }
    #endregion

    #region JWTDecodedDataCheckLogin
    public class JWTDecodedDataCheckLogin
    {
        #region members
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("token")]
        public TokenWholeInfo Token { get; set; }
        #endregion
    }
    #endregion

    #region TokenWholeInfo
    public class TokenWholeInfo
    {
        #region members
        [JsonProperty("data")]
        public TokenMoreInfo Data { get; set; }

        [JsonProperty("iat")]
        public int? Iat { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }
        #endregion
    }
    #endregion

    #region TokenMoreInfo
    public class TokenMoreInfo
    {
        #region members
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }
        #endregion
    }
    #endregion

    #region AppSecretByClientId
    public class AppSecretByClientId
    {
        #region members
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("clientId")]
        public string ClientId { get; set; }
        #endregion
    }
    #endregion

    #region LoginHotDotPicData
    public class LoginHotDotPicData
    {
        #region members
        [JsonProperty("list")]
        public List<List<string>> List { get; set; }
        #endregion
    }
    #endregion

    #region RegisterEveryDayCount
    public class RegisterEveryDayCount
    {
        #region members
        [JsonProperty("list")]
        public List<List<string>> List { get; set; }
        #endregion
    }
    #endregion

    #region Statistic
    public class Statistic
    {
        #region members
        [JsonProperty("list")]
        public List<StatisticInfo> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region StatisticInfo
    public class StatisticInfo
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("appsCount")]
        public int? AppsCount { get; set; }

        [JsonProperty("OAuthCount")]
        public int? OAuthCount { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserClientList
    public class PagedUserClientList
    {
        #region members
        [JsonProperty("list")]
        public List<PagedUserClientListItem> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserClientListItem
    public class PagedUserClientListItem
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("usersCount")]
        public int? UsersCount { get; set; }

        [JsonProperty("user")]
        public UserBrief User { get; set; }
        #endregion
    }
    #endregion

    #region UserBrief
    public class UserBrief
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
        #endregion
    }
    #endregion

    #region UsersInGroup
    public class UsersInGroup
    {
        #region members
        [JsonProperty("list")]
        public List<UsersInGroupListItem> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UsersInGroupListItem
    public class UsersInGroupListItem
    {
        #region members
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("upgrade")]
        public bool? Upgrade { get; set; }
        #endregion
    }
    #endregion

    #region QpsByTime
    public class QpsByTime
    {
        #region members
        [JsonProperty("qps")]
        public float? Qps { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }
        #endregion
    }
    #endregion

    #region GeographicalDistributionList
    public class GeographicalDistributionList
    {
        #region members
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("size")]
        public float? Size { get; set; }

        [JsonProperty("point")]
        public List<float?> Point { get; set; }
        #endregion
    }
    #endregion

    #region DayServiceCallListOfAllServices
    public class DayServiceCallListOfAllServices
    {
        #region members
        [JsonProperty("userService")]
        public List<DayServiceCallList> UserService { get; set; }

        [JsonProperty("emailService")]
        public List<DayServiceCallList> EmailService { get; set; }

        [JsonProperty("oAuthService")]
        public List<DayServiceCallList> OAuthService { get; set; }

        [JsonProperty("payService")]
        public List<DayServiceCallList> PayService { get; set; }
        #endregion
    }
    #endregion

    #region DayServiceCallList
    public class DayServiceCallList
    {
        #region members
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
        #endregion
    }
    #endregion

    #region DayUserGrowth
    public class DayUserGrowth
    {
        #region members
        [JsonProperty("day")]
        public string Day { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
        #endregion
    }
    #endregion

    #region PagedRequestList
    public class PagedRequestList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Request> List { get; set; }
        #endregion
    }
    #endregion

    #region Request
    public class Request
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }

        [JsonProperty("where")]
        public string Where { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("size")]
        public int? Size { get; set; }

        [JsonProperty("responseTime")]
        public int? ResponseTime { get; set; }

        [JsonProperty("service")]
        public string Service { get; set; }
        #endregion
    }
    #endregion

    #region UserOAuthBind
    public class UserOAuthBind
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region PatchExtendUser
    public class PatchExtendUser
    {
        #region members
        [JsonProperty("list")]
        public List<ExtendUser> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region PermissionDescriptorsListInputType
    public class PermissionDescriptorsListInputType
    {
        #region members
        [JsonProperty("permissionId")]
        public string PermissionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operationAllow")]
        public int? OperationAllow { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region PagedRoles
    public class PagedRoles
    {
        #region members
        [JsonProperty("list")]
        public List<Group> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserGroup
    public class PagedUserGroup
    {
        #region members
        [JsonProperty("list")]
        public List<UserGroup> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UserGroup
    public class UserGroup
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("client")]
        public UserClient Client { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region ClientInfoAndAccessToken
    public class ClientInfoAndAccessToken
    {
        #region members
        [JsonProperty("clientInfo")]
        public UserClient ClientInfo { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        #endregion
    }
    #endregion

    #region ClientWebhook
    public class ClientWebhook
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("events")]
        public List<WebhookEvent> Events { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isLastTimeSuccess")]
        public bool? IsLastTimeSuccess { get; set; }

        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("enable")]
        public bool Enable { get; set; }
        #endregion
    }
    #endregion

    #region WebhookEvent
    public class WebhookEvent
    {
        #region members
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion
    }
    #endregion

    #region WebhookLog
    public class WebhookLog
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("request")]
        public WebhookRequestType Request { get; set; }

        [JsonProperty("response")]
        public WebhookResponseType Response { get; set; }

        [JsonProperty("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }
        #endregion
    }
    #endregion

    #region WebhookRequestType
    public class WebhookRequestType
    {
        #region members
        [JsonProperty("headers")]
        public string Headers { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }
        #endregion
    }
    #endregion

    #region WebhookResponseType
    public class WebhookResponseType
    {
        #region members
        [JsonProperty("headers")]
        public string Headers { get; set; }

        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("statusCode")]
        public int? StatusCode { get; set; }
        #endregion
    }
    #endregion

    #region WebhookSettingOptions
    public class WebhookSettingOptions
    {
        #region members
        [JsonProperty("webhookEvents")]
        public List<WebhookEvent> WebhookEvents { get; set; }

        [JsonProperty("contentTypes")]
        public List<WebhookContentType> ContentTypes { get; set; }
        #endregion
    }
    #endregion

    #region WebhookContentType
    public class WebhookContentType
    {
        #region members
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }
        #endregion
    }
    #endregion

    #region CollaborativeUserPoolList
    public class CollaborativeUserPoolList
    {
        #region members
        [JsonProperty("list")]
        public List<Collaboration> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region Collaboration
    public class Collaboration
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("owner")]
        public User Owner { get; set; }

        [JsonProperty("collaborator")]
        public User Collaborator { get; set; }

        [JsonProperty("userPool")]
        public UserClient UserPool { get; set; }

        [JsonProperty("permissionDescriptors")]
        public List<PermissionDescriptors> PermissionDescriptors { get; set; }
        #endregion
    }
    #endregion

    #region PermissionDescriptors
    public class PermissionDescriptors
    {
        #region members
        [JsonProperty("permissionId")]
        public string PermissionId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("operationAllow")]
        public int? OperationAllow { get; set; }
        #endregion
    }
    #endregion

    #region Collaborators
    public class Collaborators
    {
        #region members
        [JsonProperty("collaborationId")]
        public string CollaborationId { get; set; }

        [JsonProperty("list")]
        public List<Collaboration> List { get; set; }
        #endregion
    }
    #endregion

    #region CollaboratorPermissions
    public class CollaboratorPermissions
    {
        #region members
        [JsonProperty("collaborator")]
        public User Collaborator { get; set; }

        [JsonProperty("list")]
        public List<PermissionDescriptors> List { get; set; }
        #endregion
    }
    #endregion

    #region PasswordStrengthSettings
    public class PasswordStrengthSettings
    {
        #region members
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("pwdStrength")]
        public int? PwdStrength { get; set; }
        #endregion
    }
    #endregion

    #region PermissionList
    public class PermissionList
    {
        #region members
        [JsonProperty("list")]
        public List<Permission> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region Permission
    public class Permission
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("affect")]
        public string Affect { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion
    }
    #endregion

    #region BasicUserInfo
    public class BasicUserInfo
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
        #endregion
    }
    #endregion

    #region PaaswordFaas
    public class PaaswordFaas
    {
        #region members
        [JsonProperty("encryptUrl")]
        public string EncryptUrl { get; set; }

        [JsonProperty("decryptUrl")]
        public string DecryptUrl { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("logs")]
        public string Logs { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region LoginTopEmailList
    public class LoginTopEmailList
    {
        #region members
        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
        #endregion
    }
    #endregion

    #region RegisterMethodList
    public class RegisterMethodList
    {
        #region members
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
        #endregion
    }
    #endregion

    #region SMSCountInfo
    public class SMSCountInfo
    {
        #region members
        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("limitCount")]
        public int? LimitCount { get; set; }
        #endregion
    }
    #endregion

    #region Invitation
    public class Invitation
    {
        #region members
        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region InvitationState
    public class InvitationState
    {
        #region members
        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("enablePhone")]
        public bool? EnablePhone { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region MFA
    public class MFA
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }

        [JsonProperty("shareKey")]
        public string ShareKey { get; set; }
        #endregion
    }
    #endregion

    #region PagedUserPoolWithMFA
    public class PagedUserPoolWithMFA
    {
        #region members
        [JsonProperty("list")]
        public List<UserPoolWithMFA> List { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }
        #endregion
    }
    #endregion

    #region UserPoolWithMFA
    public class UserPoolWithMFA
    {
        #region members
        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("userPool")]
        public UserClient UserPool { get; set; }

        [JsonProperty("MFA")]
        public MFA Mfa { get; set; }
        #endregion
    }
    #endregion

    #region PagedCustomMFAList
    public class PagedCustomMFAList
    {
        #region members
        [JsonProperty("list")]
        public List<CustomMFA> List { get; set; }

        [JsonProperty("total")]
        public int? Total { get; set; }
        #endregion
    }
    #endregion

    #region CustomMFA
    public class CustomMFA
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("userIdInMiniLogin")]
        public string UserIdInMiniLogin { get; set; }

        [JsonProperty("userPoolId")]
        public UserClient UserPoolId { get; set; }

        [JsonProperty("remark")]
        public string Remark { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
        #endregion
    }
    #endregion

    #region ValidateResult
    public class ValidateResult
    {
        #region members
        [JsonProperty("isValid")]
        public bool? IsValid { get; set; }
        #endregion
    }
    #endregion

    #region AuthAuditRecordsList
    public class AuthAuditRecordsList
    {
        #region members
        [JsonProperty("list")]
        public List<AuthAuditRecord> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region AuthAuditRecord
    public class AuthAuditRecord
    {
        #region members
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("appType")]
        public string AppType { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("event")]
        public string Event { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region UserPoolCommonInfo
    public class UserPoolCommonInfo
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("iamType")]
        public IamType? IamType { get; set; }

        [JsonProperty("userLimit")]
        public int? UserLimit { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("changePhoneStrategy")]
        public ChangePhoneStrategy ChangePhoneStrategy { get; set; }

        [JsonProperty("changeEmailStrategy")]
        public ChangeEmailStrategy ChangeEmailStrategy { get; set; }

        [JsonProperty("qrcodeLoginStrategy")]
        public QrcodeLoginStrategy QrcodeLoginStrategy { get; set; }

        [JsonProperty("app2WxappLoginStrategy")]
        public App2WxappLoginStrategy App2WxappLoginStrategy { get; set; }
        #endregion
    }
    #endregion
    public enum ProviderType
    {
        [JsonProperty("OIDC")]
        OIDC,
        [JsonProperty("OAuth")]
        OAuth
    }


    #region ADConnctorCommonInfo
    public class ADConnctorCommonInfo
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }
        #endregion
    }
    #endregion

    #region isAdConenctorAlive
    public class isAdConenctorAlive
    {
        #region members
        [JsonProperty("isAlive")]
        public bool? IsAlive { get; set; }
        #endregion
    }
    #endregion

    #region ADConnector
    public class ADConnector
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region ADConnectorEnabledProvider
    public class ADConnectorEnabledProvider
    {
        #region members
        [JsonProperty("providerType")]
        public string ProviderType { get; set; }

        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }
        #endregion
    }
    #endregion

    #region SAMLFieldMappings
    public class SAMLFieldMappings
    {
        #region members
        [JsonProperty("sourceExpression")]
        public string SourceExpression { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("targetField")]
        public string TargetField { get; set; }
        #endregion
    }
    #endregion

    #region SAMLAvaliableFieldMappings
    public class SAMLAvaliableFieldMappings
    {
        #region members
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("editable")]
        public bool Editable { get; set; }
        #endregion
    }
    #endregion

    #region RBACRole
    public class RBACRole
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("permissions")]
        public PagedRBACPermission Permissions { get; set; }

        [JsonProperty("users")]
        public PagedUsers Users { get; set; }
        #endregion
    }
    #endregion

    #region PagedRBACPermission
    public class PagedRBACPermission
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACPermission> List { get; set; }
        #endregion
    }
    #endregion

    #region RBACPermission
    public class RBACPermission
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion
    }
    #endregion
    public enum SortByEnum
    {
        [JsonProperty("CREATEDAT_DESC")]
        CREATEDAT_DESC,
        [JsonProperty("CREATEDAT_ASC")]
        CREATEDAT_ASC,
        [JsonProperty("UPDATEDAT_DESC")]
        UPDATEDAT_DESC,
        [JsonProperty("UPDATEDAT_ASC")]
        UPDATEDAT_ASC
    }


    #region PagedRBACRole
    public class PagedRBACRole
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACRole> List { get; set; }
        #endregion
    }
    #endregion

    #region RBACGroup
    public class RBACGroup
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("roles")]
        public PagedRBACRole Roles { get; set; }

        [JsonProperty("permissions")]
        public PagedRBACPermission Permissions { get; set; }

        [JsonProperty("users")]
        public PagedUsers Users { get; set; }
        #endregion
    }
    #endregion

    #region PagedRBACGroup
    public class PagedRBACGroup
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACGroup> List { get; set; }
        #endregion
    }
    #endregion

    #region UserPermissionList
    public class UserPermissionList
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACPermission> List { get; set; }

        [JsonProperty("rawList")]
        public List<string> RawList { get; set; }
        #endregion
    }
    #endregion

    #region UserGroupList
    public class UserGroupList
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACGroup> List { get; set; }

        [JsonProperty("rawList")]
        public List<string> RawList { get; set; }
        #endregion
    }
    #endregion

    #region UserRoleList
    public class UserRoleList
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RBACRole> List { get; set; }

        [JsonProperty("rawList")]
        public List<string> RawList { get; set; }
        #endregion
    }
    #endregion

    #region Org
    public class Org
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("nodes")]
        public List<OrgNode> Nodes { get; set; }
        #endregion
    }
    #endregion

    #region OrgNode
    public class OrgNode
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("children")]
        public List<string> Children { get; set; }

        [JsonProperty("root")]
        public bool? Root { get; set; }

        [JsonProperty("depth")]
        public int? Depth { get; set; }
        #endregion
    }
    #endregion

    #region PagedOrg
    public class PagedOrg
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Org> List { get; set; }
        #endregion
    }
    #endregion

    #region OrgChildrenNodesInput
    public class OrgChildrenNodesInput
    {
        #region members
        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }

        [JsonProperty("orgId")]
        [JsonRequired]
        public string OrgId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OrgChildNode
    public class OrgChildNode
    {
        #region members
        [JsonProperty("group")]
        public RBACGroup Group { get; set; }

        [JsonProperty("depth")]
        public int Depth { get; set; }
        #endregion
    }
    #endregion

    #region IsRootNodeOfOrgInput
    public class IsRootNodeOfOrgInput
    {
        #region members
        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }

        [JsonProperty("orgId")]
        [JsonRequired]
        public string OrgId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region GroupMetadata
    public class GroupMetadata
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion

    #region KeyValuePair
    public class KeyValuePair
    {
        #region members
        [JsonProperty("key")]
        [JsonRequired]
        public string Key { get; set; }

        [JsonProperty("value")]
        [JsonRequired]
        public string Value { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region DingTalkCorp
    public class DingTalkCorp
    {
        #region members
        [JsonProperty("corpId")]
        public string CorpId { get; set; }

        [JsonProperty("twoWaySynchronizationOn")]
        public bool TwoWaySynchronizationOn { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("AESKey")]
        public string AesKey { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }
        #endregion
    }
    #endregion

    #region WechatWorkCorp
    public class WechatWorkCorp
    {
        #region members
        [JsonProperty("corpId")]
        public string CorpId { get; set; }

        [JsonProperty("corpName")]
        public string CorpName { get; set; }

        [JsonProperty("addressBookSyncHelperSecret")]
        public string AddressBookSyncHelperSecret { get; set; }

        [JsonProperty("addressBookSyncHelperToken")]
        public string AddressBookSyncHelperToken { get; set; }

        [JsonProperty("addressBookSyncHelperEncodingAESKey")]
        public string AddressBookSyncHelperEncodingAesKey { get; set; }

        [JsonProperty("twoWaySynchronizationOn")]
        public bool TwoWaySynchronizationOn { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }
        #endregion
    }
    #endregion

    #region Rule
    public class Rule
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public RuleTypes Type { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("faasUrl")]
        public string FaasUrl { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion
    public enum RuleTypes
    {
        [JsonProperty("PRE_REGISTER")]
        PRE_REGISTER,
        [JsonProperty("POST_REGISTER")]
        POST_REGISTER,
        [JsonProperty("POST_AUTHENTICATION")]
        POST_AUTHENTICATION,
        [JsonProperty("PRE_OIDCTOKENISSUED")]
        PRE_OIDCTOKENISSUED
    }


    #region PagedRules
    public class PagedRules
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Rule> List { get; set; }
        #endregion
    }
    #endregion

    #region PagedRuleEnvVariable
    public class PagedRuleEnvVariable
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<RuleEnvVariable> List { get; set; }
        #endregion
    }
    #endregion

    #region RuleEnvVariable
    public class RuleEnvVariable
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion

    #region OperationLogsList
    public class OperationLogsList
    {
        #region members
        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }

        [JsonProperty("list")]
        public List<OperationLog> List { get; set; }
        #endregion
    }
    #endregion

    #region OperationLog
    public class OperationLog
    {
        #region members
        [JsonProperty("operatorId")]
        public string OperatorId { get; set; }

        [JsonProperty("operatorName")]
        public string OperatorName { get; set; }

        [JsonProperty("operatorAvatar")]
        public string OperatorAvatar { get; set; }

        [JsonProperty("isAdmin")]
        public bool? IsAdmin { get; set; }

        [JsonProperty("isCollaborator")]
        public bool? IsCollaborator { get; set; }

        [JsonProperty("isOwner")]
        public bool? IsOwner { get; set; }

        [JsonProperty("operationType")]
        public string OperationType { get; set; }

        [JsonProperty("updatedFields")]
        public string UpdatedFields { get; set; }

        [JsonProperty("removedFields")]
        public List<string> RemovedFields { get; set; }

        [JsonProperty("operateAt")]
        public string OperateAt { get; set; }

        [JsonProperty("fullDocument")]
        public string FullDocument { get; set; }

        [JsonProperty("coll")]
        public string Coll { get; set; }
        #endregion
    }
    #endregion

    #region InterConnection
    public class InterConnection
    {
        #region members
        [JsonProperty("sourceUserPoolId")]
        public string SourceUserPoolId { get; set; }

        [JsonProperty("sourceUserId")]
        public string SourceUserId { get; set; }

        [JsonProperty("targetUserPoolId")]
        public string TargetUserPoolId { get; set; }

        [JsonProperty("targetUserId")]
        public string TargetUserId { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("expiresdAt")]
        public string ExpiresdAt { get; set; }
        #endregion
    }
    #endregion

    #region UserMetaDataList
    public class UserMetaDataList
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<UserMetaData> List { get; set; }
        #endregion
    }
    #endregion

    #region UserMetaData
    public class UserMetaData
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion

    #region Mutation
    public class Mutation
    {
        #region members
        [JsonProperty("SendEmail")]
        public EmailSentList SendEmail { get; set; }

        [JsonProperty("AddEmailProvider")]
        public EmailProviderList AddEmailProvider { get; set; }

        [JsonProperty("RemoveEmailProvider")]
        public List<EmailProviderList> RemoveEmailProvider { get; set; }

        [JsonProperty("UpdateEmailProvider")]
        public EmailProviderList UpdateEmailProvider { get; set; }

        [JsonProperty("SaveEmailProviderWithClient")]
        public EmailProviderWithClientList SaveEmailProviderWithClient { get; set; }

        [JsonProperty("UpdateEmailTemplateWithClient")]
        public EmailProviderWithClientList UpdateEmailTemplateWithClient { get; set; }

        [JsonProperty("SendEmailByType")]
        public EmailSentList SendEmailByType { get; set; }

        [JsonProperty("UseDefaultEmailProvider")]
        public bool? UseDefaultEmailProvider { get; set; }

        [JsonProperty("UpdateEmailTemplate")]
        public EmailTemplate UpdateEmailTemplate { get; set; }

        [JsonProperty("AddOAuthList")]
        public OAuthList AddOAuthList { get; set; }

        [JsonProperty("RemoveOAuthList")]
        public List<string> RemoveOAuthList { get; set; }

        [JsonProperty("RemoveOAuthProvider")]
        public OAuthProviderClient RemoveOAuthProvider { get; set; }

        [JsonProperty("UpdateOAuthList")]
        public OAuthList UpdateOAuthList { get; set; }

        [JsonProperty("UpdateApplicationOAuth")]
        public OAuthList UpdateApplicationOAuth { get; set; }

        [JsonProperty("SetApplicationOAuthEnableOrDisable")]
        public OAuthList SetApplicationOAuthEnableOrDisable { get; set; }

        [JsonProperty("CreateOAuthProvider")]
        public OAuthProviderClient CreateOAuthProvider { get; set; }

        [JsonProperty("UpdateOAuthProvider")]
        public OAuthProviderClient UpdateOAuthProvider { get; set; }

        [JsonProperty("CreateOIDCApp")]
        public OIDCProviderClient CreateOidcApp { get; set; }

        [JsonProperty("UpdateOIDCApp")]
        public OIDCProviderClient UpdateOidcApp { get; set; }

        [JsonProperty("RemoveOIDCApp")]
        public OIDCProviderClient RemoveOidcApp { get; set; }

        [JsonProperty("CreateSAMLServiceProvider")]
        public SAMLServiceProviderClient CreateSamlServiceProvider { get; set; }

        [JsonProperty("UpdateSAMLServiceProvider")]
        public SAMLServiceProviderClient UpdateSamlServiceProvider { get; set; }

        [JsonProperty("RemoveSAMLServiceProvider")]
        public SAMLServiceProviderClient RemoveSamlServiceProvider { get; set; }

        [JsonProperty("EnableSAMLServiceProvider")]
        public SAMLServiceProviderClient EnableSamlServiceProvider { get; set; }

        [JsonProperty("CreateSAMLIdentityProvider")]
        public SAMLIdentityProviderClient CreateSamlIdentityProvider { get; set; }

        [JsonProperty("UpdateSAMLIdentityProvider")]
        public SAMLIdentityProviderClient UpdateSamlIdentityProvider { get; set; }

        [JsonProperty("RemoveSAMLIdentityProvider")]
        public SAMLIdentityProviderClient RemoveSamlIdentityProvider { get; set; }

        [JsonProperty("EnableSAMLIdentityProvider")]
        public SAMLIdentityProviderClient EnableSamlIdentityProvider { get; set; }

        [JsonProperty("CreateDefaultSAMLIdentityProviderSettings")]
        public SAMLDefaultIdentityProviderSettings CreateDefaultSamlIdentityProviderSettings { get; set; }

        [JsonProperty("AddLDAPServer")]
        public LDAPSingleServer AddLdapServer { get; set; }

        [JsonProperty("UpdateLDAPServer")]
        public LDAPSingleServer UpdateLdapServer { get; set; }

        [JsonProperty("RemoveLDAPServer")]
        public LDAPSingleServer RemoveLdapServer { get; set; }

        [JsonProperty("LoginByLDAP")]
        public User LoginByLdap { get; set; }

        [JsonProperty("ClearAvatarSrc")]
        public OAuthList ClearAvatarSrc { get; set; }

        [JsonProperty("RevokeUserAuthorizedApp")]
        public UserAuthorizedApp RevokeUserAuthorizedApp { get; set; }

        [JsonProperty("UpdateSystemPricing")]
        public PricingList UpdateSystemPricing { get; set; }

        [JsonProperty("AddSystemPricing")]
        public PricingList AddSystemPricing { get; set; }

        [JsonProperty("order")]
        public OrderSuccess Order { get; set; }

        [JsonProperty("ContinuePay")]
        public OrderSuccess ContinuePay { get; set; }

        [JsonProperty("IncClientFlowNumber")]
        public OrderSuccess IncClientFlowNumber { get; set; }

        [JsonProperty("register")]
        public ExtendUser Register { get; set; }

        [JsonProperty("createUser")]
        public ExtendUser CreateUser { get; set; }

        [JsonProperty("login")]
        public ExtendUser Login { get; set; }

        [JsonProperty("updateUser")]
        public User UpdateUser { get; set; }

        [JsonProperty("removeUsers")]
        public List<User> RemoveUsers { get; set; }

        [JsonProperty("newClient")]
        public UserClient NewClient { get; set; }

        [JsonProperty("removeUserClients")]
        public List<UserClient> RemoveUserClients { get; set; }

        [JsonProperty("updateUserClient")]
        public UserClient UpdateUserClient { get; set; }

        [JsonProperty("changePassword")]
        public ExtendUser ChangePassword { get; set; }

        [JsonProperty("sendResetPasswordEmail")]
        public CommonMessage SendResetPasswordEmail { get; set; }

        [JsonProperty("verifyResetPasswordVerifyCode")]
        public CommonMessage VerifyResetPasswordVerifyCode { get; set; }

        [JsonProperty("sendVerifyEmail")]
        public CommonMessage SendVerifyEmail { get; set; }

        [JsonProperty("generateInvitationCode")]
        public InvitationCode GenerateInvitationCode { get; set; }

        [JsonProperty("refreshAppSecret")]
        public UserClient RefreshAppSecret { get; set; }

        [JsonProperty("updateSuperAdminUser")]
        public UsersInGroupListItem UpdateSuperAdminUser { get; set; }

        [JsonProperty("addSuperAdminUser")]
        public UsersInGroupListItem AddSuperAdminUser { get; set; }

        [JsonProperty("removeSuperAdminUser")]
        public UsersInGroupListItem RemoveSuperAdminUser { get; set; }

        [JsonProperty("recordRequest")]
        public CommonMessage RecordRequest { get; set; }

        [JsonProperty("bindOtherOAuth")]
        public UserOAuthBind BindOtherOAuth { get; set; }

        [JsonProperty("unbindOtherOAuth")]
        public UserOAuthBind UnbindOtherOAuth { get; set; }

        [JsonProperty("unbindEmail")]
        public User UnbindEmail { get; set; }

        [JsonProperty("oauthPasswordLogin")]
        public ExtendUser OauthPasswordLogin { get; set; }

        [JsonProperty("createRole")]
        public Group CreateRole { get; set; }

        [JsonProperty("updateRole")]
        public Group UpdateRole { get; set; }

        [JsonProperty("updatePermissions")]
        public Group UpdatePermissions { get; set; }

        [JsonProperty("assignUserToRole")]
        public PagedUserGroup AssignUserToRole { get; set; }

        [JsonProperty("removeUserFromGroup")]
        public UserGroup RemoveUserFromGroup { get; set; }

        [JsonProperty("addClientWebhook")]
        public ClientWebhook AddClientWebhook { get; set; }

        [JsonProperty("updateClientWebhook")]
        public ClientWebhook UpdateClientWebhook { get; set; }

        [JsonProperty("deleteClientWebhook")]
        public ClientWebhook DeleteClientWebhook { get; set; }

        [JsonProperty("SendWebhookTest")]
        public bool? SendWebhookTest { get; set; }

        [JsonProperty("refreshToken")]
        public RefreshToken RefreshToken { get; set; }

        [JsonProperty("addCollaborator")]
        public Collaboration AddCollaborator { get; set; }

        [JsonProperty("removeCollaborator")]
        public Collaboration RemoveCollaborator { get; set; }

        [JsonProperty("updateCollaborator")]
        public Collaboration UpdateCollaborator { get; set; }

        [JsonProperty("addPermission")]
        public Permission AddPermission { get; set; }

        [JsonProperty("updatePasswordStrengthSettingsByUserPoolId")]
        public PasswordStrengthSettings UpdatePasswordStrengthSettingsByUserPoolId { get; set; }

        [JsonProperty("resetUserPoolFromWechat")]
        public PagedUsers ResetUserPoolFromWechat { get; set; }

        [JsonProperty("encryptPassword")]
        public EncryptPassword EncryptPassword { get; set; }

        [JsonProperty("enablePasswordFaas")]
        public PaaswordFaas EnablePasswordFaas { get; set; }

        [JsonProperty("addToInvitation")]
        public Invitation AddToInvitation { get; set; }

        [JsonProperty("removeFromInvitation")]
        public Invitation RemoveFromInvitation { get; set; }

        [JsonProperty("setInvitationState")]
        public InvitationState SetInvitationState { get; set; }

        [JsonProperty("changeMFA")]
        public MFA ChangeMfa { get; set; }

        [JsonProperty("createCustomMFA")]
        public CustomMFA CreateCustomMfa { get; set; }

        [JsonProperty("removeCustomMFA")]
        public CustomMFA RemoveCustomMfa { get; set; }

        [JsonProperty("recordAuthAudit")]
        public CommonMessage RecordAuthAudit { get; set; }

        [JsonProperty("refreshAccessToken")]
        public RefreshAccessTokenData RefreshAccessToken { get; set; }

        [JsonProperty("passwordLessForceLogin")]
        public User PasswordLessForceLogin { get; set; }

        [JsonProperty("createUserWithoutAuthentication")]
        public User CreateUserWithoutAuthentication { get; set; }

        [JsonProperty("refreshThirdPartyToken")]
        public RefreshThirdPartyIdentityResult RefreshThirdPartyToken { get; set; }

        [JsonProperty("signIn")]
        public OidcPasswordModeUserInfo SignIn { get; set; }

        [JsonProperty("refreshSignInToken")]
        public RefreshedSignInToken RefreshSignInToken { get; set; }

        [JsonProperty("createAdConnector")]
        public ADConnector CreateAdConnector { get; set; }

        [JsonProperty("updateAdConnector")]
        public ADConnector UpdateAdConnector { get; set; }

        [JsonProperty("refreshAdConnectorSecret")]
        public ADConnector RefreshAdConnectorSecret { get; set; }

        [JsonProperty("removeAdConnector")]
        public bool? RemoveAdConnector { get; set; }

        [JsonProperty("enableAdConnector")]
        public bool? EnableAdConnector { get; set; }

        [JsonProperty("disableAdConnector")]
        public bool? DisableAdConnector { get; set; }

        [JsonProperty("enableAdConnectorForProvider")]
        public bool? EnableAdConnectorForProvider { get; set; }

        [JsonProperty("disableAdConnectorForProvider")]
        public bool? DisableAdConnectorForProvider { get; set; }

        [JsonProperty("loginByAd")]
        public User LoginByAd { get; set; }

        [JsonProperty("setSAMLIdPFieldMapping")]
        public SAMLFieldMappings SetSamlIdPFieldMapping { get; set; }

        [JsonProperty("removeSAMLIdpFieldMapping")]
        public CommonMessage RemoveSamlIdpFieldMapping { get; set; }

        [JsonProperty("createRBACPermission")]
        public RBACPermission CreateRbacPermission { get; set; }

        [JsonProperty("updateRBACPermission")]
        public RBACPermission UpdateRbacPermission { get; set; }

        [JsonProperty("deleteRBACPermission")]
        public CommonMessage DeleteRbacPermission { get; set; }

        [JsonProperty("deleteRBACPermissionBatch")]
        public CommonMessage DeleteRbacPermissionBatch { get; set; }

        [JsonProperty("createRBACRole")]
        public RBACRole CreateRbacRole { get; set; }

        [JsonProperty("updateRBACRole")]
        public RBACRole UpdateRbacRole { get; set; }

        [JsonProperty("deleteRBACRole")]
        public CommonMessage DeleteRbacRole { get; set; }

        [JsonProperty("deleteRBACRoleBatch")]
        public CommonMessage DeleteRbacRoleBatch { get; set; }

        [JsonProperty("createRBACGroup")]
        public RBACGroup CreateRbacGroup { get; set; }

        [JsonProperty("updateRBACGroup")]
        public RBACGroup UpdateRbacGroup { get; set; }

        [JsonProperty("deleteRBACGroup")]
        public CommonMessage DeleteRbacGroup { get; set; }

        [JsonProperty("deleteRBACGroupBatch")]
        public CommonMessage DeleteRbacGroupBatch { get; set; }

        [JsonProperty("assignRBACRoleToUser")]
        public RBACRole AssignRbacRoleToUser { get; set; }

        [JsonProperty("assignRBACRoleToUserBatch")]
        public RBACRole AssignRbacRoleToUserBatch { get; set; }

        [JsonProperty("revokeRBACRoleFromUser")]
        public RBACRole RevokeRbacRoleFromUser { get; set; }

        [JsonProperty("revokeRBACRoleFromUserBatch")]
        public RBACRole RevokeRbacRoleFromUserBatch { get; set; }

        [JsonProperty("addPermissionToRBACRole")]
        public RBACRole AddPermissionToRbacRole { get; set; }

        [JsonProperty("addPermissionToRBACRoleBatch")]
        public RBACRole AddPermissionToRbacRoleBatch { get; set; }

        [JsonProperty("removePermissionFromRBACRole")]
        public RBACRole RemovePermissionFromRbacRole { get; set; }

        [JsonProperty("removePermissionFromRBACRoleBatch")]
        public RBACRole RemovePermissionFromRbacRoleBatch { get; set; }

        [JsonProperty("addRoleToRBACGroup")]
        public RBACGroup AddRoleToRbacGroup { get; set; }

        [JsonProperty("addRoleToRBACGroupBatch")]
        public RBACGroup AddRoleToRbacGroupBatch { get; set; }

        [JsonProperty("removeRoleFromRBACGroup")]
        public RBACGroup RemoveRoleFromRbacGroup { get; set; }

        [JsonProperty("removeRoleFromRBACGroupBatch")]
        public RBACGroup RemoveRoleFromRbacGroupBatch { get; set; }

        [JsonProperty("addUserToRBACGroup")]
        public RBACGroup AddUserToRbacGroup { get; set; }

        [JsonProperty("addUserToRBACGroupBatch")]
        public RBACGroup AddUserToRbacGroupBatch { get; set; }

        [JsonProperty("removeUserFromRBACGroup")]
        public RBACGroup RemoveUserFromRbacGroup { get; set; }

        [JsonProperty("removeUserFromRBACGroupBatch")]
        public RBACGroup RemoveUserFromRbacGroupBatch { get; set; }

        [JsonProperty("createOrg")]
        public Org CreateOrg { get; set; }

        [JsonProperty("updateOrg")]
        public Org UpdateOrg { get; set; }

        [JsonProperty("deleteOrg")]
        public CommonMessage DeleteOrg { get; set; }

        [JsonProperty("addOrgNode")]
        public Org AddOrgNode { get; set; }

        [JsonProperty("removeOrgNode")]
        public Org RemoveOrgNode { get; set; }

        [JsonProperty("addGroupMetadata")]
        public List<GroupMetadata> AddGroupMetadata { get; set; }

        [JsonProperty("removeGroupMetadata")]
        public List<GroupMetadata> RemoveGroupMetadata { get; set; }

        [JsonProperty("addDingTalkCorp")]
        public DingTalkCorp AddDingTalkCorp { get; set; }

        [JsonProperty("startDingTalkCorpInitialSync")]
        public CorpSyncResult StartDingTalkCorpInitialSync { get; set; }

        [JsonProperty("addWechatWorkCorp")]
        public WechatWorkCorp AddWechatWorkCorp { get; set; }

        [JsonProperty("startWechatWorkCorpInitialSync")]
        public CorpSyncResult StartWechatWorkCorpInitialSync { get; set; }

        [JsonProperty("createRule")]
        public Rule CreateRule { get; set; }

        [JsonProperty("updateRule")]
        public Rule UpdateRule { get; set; }

        [JsonProperty("deleteRule")]
        public CommonMessage DeleteRule { get; set; }

        [JsonProperty("setRuleEnv")]
        public PagedRuleEnvVariable SetRuleEnv { get; set; }

        [JsonProperty("removeRuleEnv")]
        public PagedRuleEnvVariable RemoveRuleEnv { get; set; }

        [JsonProperty("updateRuleOrder")]
        public CommonMessage UpdateRuleOrder { get; set; }

        [JsonProperty("updatePhone")]
        public User UpdatePhone { get; set; }

        [JsonProperty("updateEmail")]
        public User UpdateEmail { get; set; }

        [JsonProperty("sendChangeEmailVerifyCode")]
        public CommonMessage SendChangeEmailVerifyCode { get; set; }

        [JsonProperty("createInterConnection")]
        public CommonMessage CreateInterConnection { get; set; }

        [JsonProperty("setUserMetadata")]
        public UserMetaDataList SetUserMetadata { get; set; }

        [JsonProperty("removeUserMetadata")]
        public UserMetaDataList RemoveUserMetadata { get; set; }
        #endregion
    }
    #endregion

    #region EmailProviderListInput
    public class EmailProviderListInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public List<EmailProviderFormInput> Fields { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EmailProviderFormInput
    public class EmailProviderFormInput
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EmailProviderWithClientAddInput
    public class EmailProviderWithClientAddInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("fields")]
        public List<EmailProviderFormAddInput> Fields { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EmailProviderFormAddInput
    public class EmailProviderFormAddInput
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("help")]
        public string Help { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("options")]
        public List<string> Options { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EmailTemplateWithClientInput
    public class EmailTemplateWithClientInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        [JsonProperty("URLExpireTime")]
        public int? UrlExpireTime { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EmailTemplateInput
    public class EmailTemplateInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sender")]
        public string Sender { get; set; }

        [JsonProperty("object")]
        public string Object { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        [JsonProperty("URLExpireTime")]
        public int? UrlExpireTime { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OAuthListUpdateInput
    public class OAuthListUpdateInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("oAuthUrl")]
        public string OAuthUrl { get; set; }

        [JsonProperty("wxappLogo")]
        public string WxappLogo { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OAuthListFieldsFormUpdateInput
    public class OAuthListFieldsFormUpdateInput
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("children")]
        public List<OAuthListFieldsFormRecursionInput> Children { get; set; }

        [JsonProperty("checked")]
        public List<string> Checked { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OAuthListFieldsFormRecursionInput
    public class OAuthListFieldsFormRecursionInput
    {
        #region members
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("children")]
        public List<OAuthListFieldsFormRecursionInput> Children { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OidcProviderCustomStylesInput
    public class OidcProviderCustomStylesInput
    {
        #region members
        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("hideQRCode")]
        public bool? HideQrCode { get; set; }

        [JsonProperty("hideUP")]
        public bool? HideUp { get; set; }

        [JsonProperty("hideUsername")]
        public bool? HideUsername { get; set; }

        [JsonProperty("hideRegister")]
        public bool? HideRegister { get; set; }

        [JsonProperty("hidePhone")]
        public bool? HidePhone { get; set; }

        [JsonProperty("hideSocial")]
        public bool? HideSocial { get; set; }

        [JsonProperty("hideClose")]
        public bool? HideClose { get; set; }

        [JsonProperty("hidePhonePassword")]
        public bool? HidePhonePassword { get; set; }

        [JsonProperty("placeholder")]
        public OidcProviderCustomStylesPlaceholderInput Placeholder { get; set; }

        [JsonProperty("qrcodeScanning")]
        public OidcProviderCustomStylesQrcodeScanningInput QrcodeScanning { get; set; }

        [JsonProperty("defaultLoginMethod")]
        public OidcProviderDefaultLoginMethod? DefaultLoginMethod { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OidcProviderCustomStylesPlaceholderInput
    public class OidcProviderCustomStylesPlaceholderInput
    {
        #region members
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("confirmPassword")]
        public string ConfirmPassword { get; set; }

        [JsonProperty("verfiyCode")]
        public string VerfiyCode { get; set; }

        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OidcProviderCustomStylesQrcodeScanningInput
    public class OidcProviderCustomStylesQrcodeScanningInput
    {
        #region members
        [JsonProperty("redirect")]
        public bool? Redirect { get; set; }

        [JsonProperty("interval")]
        public int? Interval { get; set; }

        [JsonProperty("tips")]
        public string Tips { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AssertionMapInputType
    public class AssertionMapInputType
    {
        #region members
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AssertionConsumeServiceInputType
    public class AssertionConsumeServiceInputType
    {
        #region members
        [JsonProperty("binding")]
        public string Binding { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("isDefault")]
        public bool? IsDefault { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UserAuthorizedApp
    public class UserAuthorizedApp
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("appId")]
        public string AppId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isRevoked")]
        public string IsRevoked { get; set; }

        [JsonProperty("when")]
        public string When { get; set; }
        #endregion
    }
    #endregion

    #region PricingFieldsInput
    public class PricingFieldsInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("startNumber")]
        public int? StartNumber { get; set; }

        [JsonProperty("freeNumber")]
        public int? FreeNumber { get; set; }

        [JsonProperty("startPrice")]
        public int? StartPrice { get; set; }

        [JsonProperty("maxNumber")]
        public int? MaxNumber { get; set; }

        [JsonProperty("d")]
        public int? D { get; set; }

        [JsonProperty("features")]
        public List<string> Features { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OrderAddInput
    public class OrderAddInput
    {
        #region members
        [JsonProperty("user")]
        [JsonRequired]
        public string User { get; set; }

        [JsonProperty("client")]
        [JsonRequired]
        public string Client { get; set; }

        [JsonProperty("pricing")]
        [JsonRequired]
        public string Pricing { get; set; }

        [JsonProperty("flowNumber")]
        [JsonRequired]
        public int FlowNumber { get; set; }

        [JsonProperty("price")]
        [JsonRequired]
        public float Price { get; set; }

        [JsonProperty("timeOfPurchase")]
        [JsonRequired]
        public int TimeOfPurchase { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region OrderSuccess
    public class OrderSuccess
    {
        #region members
        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("charge")]
        public string Charge { get; set; }
        #endregion
    }
    #endregion

    #region UserRegisterInput
    public class UserRegisterInput
    {
        #region members
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("salt")]
        public string Salt { get; set; }

        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        [JsonProperty("registerInClient")]
        [JsonRequired]
        public string RegisterInClient { get; set; }

        [JsonProperty("registerMethod")]
        public string RegisterMethod { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

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

        [JsonProperty("preferredUsername")]
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

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("signedUp")]
        public string SignedUp { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UserUpdateInput
    public class UserUpdateInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        [JsonProperty("registerMethod")]
        public string RegisterMethod { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("tokenExpiredAt")]
        public string TokenExpiredAt { get; set; }

        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        [JsonProperty("signedUp")]
        public string SignedUp { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

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

        [JsonProperty("preferredUsername")]
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

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region NewUserClientInput
    public class NewUserClientInput
    {
        #region members
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("clientTypeId")]
        public string ClientTypeId { get; set; }

        [JsonProperty("userPoolTypeList")]
        public List<string> UserPoolTypeList { get; set; }

        [JsonProperty("iamType")]
        public IamType? IamType { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateUserClientInput
    public class UpdateUserClientInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("clientType")]
        public string ClientType { get; set; }

        [JsonProperty("userPoolTypeList")]
        public List<string> UserPoolTypeList { get; set; }

        [JsonProperty("emailVerifiedDefault")]
        public bool? EmailVerifiedDefault { get; set; }

        [JsonProperty("sendWelcomeEmail")]
        public bool? SendWelcomeEmail { get; set; }

        [JsonProperty("registerDisabled")]
        public bool? RegisterDisabled { get; set; }

        [JsonProperty("showWXMPQRCode")]
        public bool? ShowWxmpqrCode { get; set; }

        [JsonProperty("useMiniLogin")]
        public bool? UseMiniLogin { get; set; }

        [JsonProperty("useSelfWxapp")]
        public bool? UseSelfWxapp { get; set; }

        [JsonProperty("enableEmail")]
        public bool? EnableEmail { get; set; }

        [JsonProperty("allowedOrigins")]
        public string AllowedOrigins { get; set; }

        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        [JsonProperty("jwtExpired")]
        public int? JwtExpired { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("frequentRegisterCheck")]
        public FrequentRegisterCheckConfigInput FrequentRegisterCheck { get; set; }

        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfigInput LoginFailCheck { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("changePhoneStrategy")]
        public ChangePhoneStrategyInput ChangePhoneStrategy { get; set; }

        [JsonProperty("changeEmailStrategy")]
        public ChangeEmailStrategyInput ChangeEmailStrategy { get; set; }

        [JsonProperty("qrcodeLoginStrategy")]
        public QrcodeLoginStrategyInput QrcodeLoginStrategy { get; set; }

        [JsonProperty("app2WxappLoginStrategy")]
        public App2WxappLoginStrategyInput App2WxappLoginStrategy { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region FrequentRegisterCheckConfigInput
    public class FrequentRegisterCheckConfigInput
    {
        #region members
        [JsonProperty("timeInterval")]
        public int? TimeInterval { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region LoginFailCheckConfigInput
    public class LoginFailCheckConfigInput
    {
        #region members
        [JsonProperty("timeInterval")]
        public int? TimeInterval { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region ChangePhoneStrategyInput
    public class ChangePhoneStrategyInput
    {
        #region members
        [JsonProperty("verifyOldPhone")]
        public bool? VerifyOldPhone { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region ChangeEmailStrategyInput
    public class ChangeEmailStrategyInput
    {
        #region members
        [JsonProperty("verifyOldEmail")]
        public bool? VerifyOldEmail { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region QrcodeLoginStrategyInput
    public class QrcodeLoginStrategyInput
    {
        #region members
        [JsonProperty("qrcodeExpiresAfter")]
        public int? QrcodeExpiresAfter { get; set; }

        [JsonProperty("returnFullUserInfo")]
        public bool? ReturnFullUserInfo { get; set; }

        [JsonProperty("allowExchangeUserInfoFromBrowser")]
        public bool? AllowExchangeUserInfoFromBrowser { get; set; }

        [JsonProperty("ticketExpiresAfter")]
        public int? TicketExpiresAfter { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region App2WxappLoginStrategyInput
    public class App2WxappLoginStrategyInput
    {
        #region members
        [JsonProperty("ticketExpriresAfter")]
        public int? TicketExpriresAfter { get; set; }

        [JsonProperty("ticketExchangeUserInfoNeedSecret")]
        public bool? TicketExchangeUserInfoNeedSecret { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region InvitationCode
    public class InvitationCode
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }
        #endregion
    }
    #endregion

    #region SuperAdminUpdateInput
    public class SuperAdminUpdateInput
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("username")]
        [JsonRequired]
        public string Username { get; set; }

        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RefreshToken
    public class RefreshToken
    {
        #region members
        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("iat")]
        public int? Iat { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }
        #endregion
    }
    #endregion

    #region PermissionDescriptorsInputType
    public class PermissionDescriptorsInputType
    {
        #region members
        [JsonProperty("permissionId")]
        public string PermissionId { get; set; }

        [JsonProperty("operationAllow")]
        public int? OperationAllow { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region EncryptPassword
    public class EncryptPassword
    {
        #region members
        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("encryptUrl")]
        public string EncryptUrl { get; set; }

        [JsonProperty("decryptUrl")]
        public string DecryptUrl { get; set; }

        [JsonProperty("client")]
        public string Client { get; set; }

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("logs")]
        public string Logs { get; set; }

        [JsonProperty("enable")]
        public bool? Enable { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
        #endregion
    }
    #endregion

    #region RefreshAccessTokenData
    public class RefreshAccessTokenData
    {
        #region members
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
        #endregion
    }
    #endregion

    #region RefreshThirdPartyIdentityResult
    public class RefreshThirdPartyIdentityResult
    {
        #region members
        [JsonProperty("refreshSuccess")]
        public bool? RefreshSuccess { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion
    }
    #endregion

    #region OidcPasswordModeUserInfo
    public class OidcPasswordModeUserInfo
    {
        #region members
        [JsonProperty("sub")]
        public string Sub { get; set; }

        [JsonProperty("birthdate")]
        public string Birthdate { get; set; }

        [JsonProperty("family_name")]
        public string Family_Name { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("given_name")]
        public string Given_Name { get; set; }

        [JsonProperty("locale")]
        public string Locale { get; set; }

        [JsonProperty("middle_name")]
        public string Middle_Name { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("picture")]
        public string Picture { get; set; }

        [JsonProperty("preferred_username")]
        public string Preferred_Username { get; set; }

        [JsonProperty("profile")]
        public string Profile { get; set; }

        [JsonProperty("updated_at")]
        public string Updated_At { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("zoneinfo")]
        public string Zoneinfo { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("_id")]
        public string _Id { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("logins_count")]
        public int? Logins_Count { get; set; }

        [JsonProperty("register_method")]
        public string Register_Method { get; set; }

        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        [JsonProperty("last_ip")]
        public string Last_Ip { get; set; }

        [JsonProperty("register_in_userpool")]
        public string Register_In_Userpool { get; set; }

        [JsonProperty("last_login")]
        public string Last_Login { get; set; }

        [JsonProperty("signed_up")]
        public string Signed_Up { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified")]
        public bool? Email_Verified { get; set; }

        [JsonProperty("phone_number")]
        public string Phone_Number { get; set; }

        [JsonProperty("phone_number_verified")]
        public bool? Phone_Number_Verified { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("access_token")]
        public string Access_Token { get; set; }

        [JsonProperty("id_token")]
        public string Id_Token { get; set; }

        [JsonProperty("refresh_token")]
        public string Refresh_Token { get; set; }

        [JsonProperty("expires_in")]
        public int? Expires_In { get; set; }

        [JsonProperty("token_type")]
        public string Token_Type { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
        #endregion
    }
    #endregion

    #region RefreshedSignInToken
    public class RefreshedSignInToken
    {
        #region members
        [JsonProperty("access_token")]
        public string Access_Token { get; set; }

        [JsonProperty("id_token")]
        public string Id_Token { get; set; }

        [JsonProperty("refresh_token")]
        public string Refresh_Token { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("expires_in")]
        public int? Expires_In { get; set; }
        #endregion
    }
    #endregion

    #region CreateRbacPermissionInput
    public class CreateRbacPermissionInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRbacPermissionInput
    public class UpdateRbacPermissionInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CreateRbacRoleInput
    public class CreateRbacRoleInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRbacRoleInput
    public class UpdateRbacRoleInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CreateRbacGroupInput
    public class CreateRbacGroupInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRbacGroupInput
    public class UpdateRbacGroupInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AssignUserToRbacRoleInput
    public class AssignUserToRbacRoleInput
    {
        #region members
        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AssignUserToRbacRoleBatchInput
    public class AssignUserToRbacRoleBatchInput
    {
        #region members
        [JsonProperty("userIdList")]
        [JsonRequired]
        public List<string> UserIdList { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RevokeRbacRoleFromUserInput
    public class RevokeRbacRoleFromUserInput
    {
        #region members
        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RevokeRbacRoleFromUserBatchInput
    public class RevokeRbacRoleFromUserBatchInput
    {
        #region members
        [JsonProperty("userIdList")]
        [JsonRequired]
        public List<string> UserIdList { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddPermissionToRbacRoleInput
    public class AddPermissionToRbacRoleInput
    {
        #region members
        [JsonProperty("permissionId")]
        [JsonRequired]
        public string PermissionId { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddPermissionToRbacRoleBatchInput
    public class AddPermissionToRbacRoleBatchInput
    {
        #region members
        [JsonProperty("permissionIdList")]
        [JsonRequired]
        public List<string> PermissionIdList { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemovePermissionFromRbacRoleInput
    public class RemovePermissionFromRbacRoleInput
    {
        #region members
        [JsonProperty("permissionId")]
        [JsonRequired]
        public string PermissionId { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemovePermissionFromRbacRoleBatchInput
    public class RemovePermissionFromRbacRoleBatchInput
    {
        #region members
        [JsonProperty("permissionIdList")]
        [JsonRequired]
        public List<string> PermissionIdList { get; set; }

        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddRoleToRbacGroupInput
    public class AddRoleToRbacGroupInput
    {
        #region members
        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddRoleToRbacGroupBatchInput
    public class AddRoleToRbacGroupBatchInput
    {
        #region members
        [JsonProperty("roleIdList")]
        [JsonRequired]
        public List<string> RoleIdList { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveRoleFromRbacGroupInput
    public class RemoveRoleFromRbacGroupInput
    {
        #region members
        [JsonProperty("roleId")]
        [JsonRequired]
        public string RoleId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveRoleFromRbacGroupBatchInput
    public class RemoveRoleFromRbacGroupBatchInput
    {
        #region members
        [JsonProperty("roleIdList")]
        [JsonRequired]
        public List<string> RoleIdList { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddUserToRbacGroupInput
    public class AddUserToRbacGroupInput
    {
        #region members
        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddUserToRbacGroupBatchInput
    public class AddUserToRbacGroupBatchInput
    {
        #region members
        [JsonProperty("userIdList")]
        [JsonRequired]
        public List<string> UserIdList { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveUserFromRbacGroupInput
    public class RemoveUserFromRbacGroupInput
    {
        #region members
        [JsonProperty("userId")]
        [JsonRequired]
        public string UserId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveUserFromRbacGroupBatchInput
    public class RemoveUserFromRbacGroupBatchInput
    {
        #region members
        [JsonProperty("userIdList")]
        [JsonRequired]
        public List<string> UserIdList { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CreateOrgInput
    public class CreateOrgInput
    {
        #region members
        [JsonProperty("rootGroupId")]
        [JsonRequired]
        public string RootGroupId { get; set; }

        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateOrgInput
    public class UpdateOrgInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("orgId")]
        [JsonRequired]
        public string OrgId { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AddOrgNodeInput
    public class AddOrgNodeInput
    {
        #region members
        [JsonProperty("orgId")]
        [JsonRequired]
        public string OrgId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }

        [JsonProperty("parentGroupId")]
        [JsonRequired]
        public string ParentGroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveOrgNodeInput
    public class RemoveOrgNodeInput
    {
        #region members
        [JsonProperty("orgId")]
        [JsonRequired]
        public string OrgId { get; set; }

        [JsonProperty("groupId")]
        [JsonRequired]
        public string GroupId { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CreateDingTalkCorpInput
    public class CreateDingTalkCorpInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("corpId")]
        [JsonRequired]
        public string CorpId { get; set; }

        [JsonProperty("twoWaySynchronizationOn")]
        [JsonRequired]
        public bool TwoWaySynchronizationOn { get; set; }

        [JsonProperty("appkey")]
        [JsonRequired]
        public string Appkey { get; set; }

        [JsonProperty("secret")]
        [JsonRequired]
        public string Secret { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CorpSyncResult
    public class CorpSyncResult
    {
        #region members
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("orgId")]
        public string OrgId { get; set; }
        #endregion
    }
    #endregion

    #region CreateWechatWorkCorpInput
    public class CreateWechatWorkCorpInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("corpId")]
        [JsonRequired]
        public string CorpId { get; set; }

        [JsonProperty("twoWaySynchronizationOn")]
        [JsonRequired]
        public bool TwoWaySynchronizationOn { get; set; }

        [JsonProperty("addressBookSyncHelperSecret")]
        [JsonRequired]
        public string AddressBookSyncHelperSecret { get; set; }

        [JsonProperty("addressBookSyncHelperToken")]
        [JsonRequired]
        public string AddressBookSyncHelperToken { get; set; }

        [JsonProperty("addressBookSyncHelperEncodingAESKey")]
        [JsonRequired]
        public string AddressBookSyncHelperEncodingAesKey { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region CreateRuleInput
    public class CreateRuleInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        [JsonRequired]
        public RuleTypes Type { get; set; }

        [JsonProperty("code")]
        [JsonRequired]
        public string Code { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRuleInput
    public class UpdateRuleInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public RuleTypes? Type { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("async")]
        public bool? Async { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region SetRuleEnvInput
    public class SetRuleEnvInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("key")]
        [JsonRequired]
        public string Key { get; set; }

        [JsonProperty("value")]
        [JsonRequired]
        public string Value { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveRuleEnvInput
    public class RemoveRuleEnvInput
    {
        #region members
        [JsonProperty("userPoolId")]
        [JsonRequired]
        public string UserPoolId { get; set; }

        [JsonProperty("key")]
        [JsonRequired]
        public string Key { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRuleOrderInput
    public class UpdateRuleOrderInput
    {
        #region members
        [JsonProperty("list")]
        [JsonRequired]
        public List<UpdateRuleOrderItem> List { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region UpdateRuleOrderItem
    public class UpdateRuleOrderItem
    {
        #region members
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        [JsonProperty("order")]
        [JsonRequired]
        public int Order { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region SetUserMetadataInput
    public class SetUserMetadataInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("key")]
        [JsonRequired]
        public string Key { get; set; }

        [JsonProperty("value")]
        [JsonRequired]
        public string Value { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region RemoveUserMetadataInput
    public class RemoveUserMetadataInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("key")]
        [JsonRequired]
        public string Key { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region AuthenticationContextInput
    public class AuthenticationContextInput
    {
        #region members
        [JsonProperty("protocol")]
        [JsonRequired]
        public string Protocol { get; set; }

        [JsonProperty("connection")]
        [JsonRequired]
        public string Connection { get; set; }

        [JsonProperty("ldapConfiguration")]
        public LdapConfigurationInput LdapConfiguration { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region LdapConfigurationInput
    public class LdapConfigurationInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }

        [JsonProperty("enabled")]
        [JsonRequired]
        public bool Enabled { get; set; }

        [JsonProperty("isDeleted")]
        [JsonRequired]
        public bool IsDeleted { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("ldapLink")]
        [JsonRequired]
        public string LdapLink { get; set; }

        [JsonProperty("baseDN")]
        [JsonRequired]
        public string BaseDn { get; set; }

        [JsonProperty("searchStandard")]
        [JsonRequired]
        public string SearchStandard { get; set; }

        [JsonProperty("username")]
        [JsonRequired]
        public string Username { get; set; }

        [JsonProperty("description")]
        [JsonRequired]
        public string Description { get; set; }

        [JsonProperty("createdAt")]
        [JsonRequired]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region DeleteOrgInput
    public class DeleteOrgInput
    {
        #region members
        [JsonProperty("_id")]
        [JsonRequired]
        public string _Id { get; set; }
        #endregion

        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;
                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion
    }
    #endregion

    #region DeleteRBACGroupBatchResult
    public class DeleteRBACGroupBatchResult
    {
        #region members
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
        #endregion
    }
    #endregion

    #region DeleteRBACRoleBatchResult
    public class DeleteRBACRoleBatchResult
    {
        #region members
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
        #endregion
    }
    #endregion

    #region DeleteRBACPermissionBatchResult
    public class DeleteRBACPermissionBatchResult
    {
        #region members
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("requestCount")]
        public int RequestCount { get; set; }

        [JsonProperty("deletedCount")]
        public int DeletedCount { get; set; }
        #endregion
    }
    #endregion
}

namespace Authing.ApiClient.Types
{


    public class AddEmailProviderResponse
    {

        [JsonProperty("AddEmailProvider")]
        public EmailProviderList Result { get; set; }
    }

    public class AddEmailProviderParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public EmailProviderListInput Options { get; set; }

        /// <summary>
        /// AddEmailProviderParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(EmailProviderListInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddEmailProviderDocument,
                OperationName = "AddEmailProvider",
                Variables = this
            };
        }


        public static string AddEmailProviderDocument = @"
        mutation AddEmailProvider($options: EmailProviderListInput) {
          AddEmailProvider(options: $options) {
            _id
            name
            image
            description
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            client
            user
            status
            provider {
              _id
              name
              image
              description
              client
              user
              status
            }
          }
        }
        ";
    }



    public class AddLdapServerResponse
    {

        [JsonProperty("AddLDAPServer")]
        public LDAPSingleServer Result { get; set; }
    }

    public class AddLdapServerParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapLink")]
        public string LdapLink { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("baseDN")]
        public string BaseDn { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("searchStandard")]
        public string SearchStandard { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("emailPostfix")]
        public string EmailPostfix { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// AddLdapServerParam.Request 
        /// <para>Required variables:<br/> { name=(string), clientId=(string), userId=(string), ldapLink=(string), baseDN=(string), searchStandard=(string), username=(string), password=(string) }</para>
        /// <para>Optional variables:<br/> { emailPostfix=(string), description=(string), enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddLdapServerDocument,
                OperationName = "AddLDAPServer",
                Variables = this
            };
        }


        public static string AddLdapServerDocument = @"
        mutation AddLDAPServer($name: String!, $clientId: String!, $userId: String!, $ldapLink: String!, $baseDN: String!, $searchStandard: String!, $username: String!, $password: String!, $emailPostfix: String, $description: String, $enabled: Boolean) {
          AddLDAPServer(name: $name, clientId: $clientId, userId: $userId, ldapLink: $ldapLink, baseDN: $baseDN, searchStandard: $searchStandard, username: $username, password: $password, emailPostfix: $emailPostfix, description: $description, enabled: $enabled) {
            _id
            name
            clientId
            userId
            ldapLink
            baseDN
            searchStandard
            emailPostfix
            username
            password
            description
            enabled
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class AddOAuthListResponse
    {

        [JsonProperty("AddOAuthList")]
        public OAuthList Result { get; set; }
    }

    public class AddOAuthListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public OAuthListUpdateInput Options { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fields")]
        public OAuthListFieldsFormUpdateInput Fields { get; set; }

        /// <summary>
        /// AddOAuthListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(OAuthListUpdateInput), fields=(OAuthListFieldsFormUpdateInput[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddOAuthListDocument,
                OperationName = "AddOAuthList",
                Variables = this
            };
        }


        public static string AddOAuthListDocument = @"
        mutation AddOAuthList($options: OAuthListUpdateInput, $fields: [OAuthListFieldsFormUpdateInput]) {
          AddOAuthList(options: $options, fields: $fields) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class AddSystemPricingResponse
    {

        [JsonProperty("AddSystemPricing")]
        public PricingList Result { get; set; }
    }

    public class AddSystemPricingParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public PricingFieldsInput Options { get; set; }

        /// <summary>
        /// AddSystemPricingParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(PricingFieldsInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddSystemPricingDocument,
                OperationName = "AddSystemPricing",
                Variables = this
            };
        }


        public static string AddSystemPricingDocument = @"
        mutation AddSystemPricing($options: PricingFieldsInput) {
          AddSystemPricing(options: $options) {
            _id
            type
            startNumber
            freeNumber
            startPrice
            maxNumber
            d
            features
          }
        }
        ";
    }



    public class ClearAvatarSrcResponse
    {

        [JsonProperty("ClearAvatarSrc")]
        public OAuthList Result { get; set; }
    }

    public class ClearAvatarSrcParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// ClearAvatarSrcParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string), oauth=(string), user=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ClearAvatarSrcDocument,
                OperationName = "ClearAvatarSrc",
                Variables = this
            };
        }


        public static string ClearAvatarSrcDocument = @"
        mutation ClearAvatarSrc($client: String, $oauth: String, $user: String) {
          ClearAvatarSrc(client: $client, oauth: $oauth, user: $user) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class ContinuePayResponse
    {

        [JsonProperty("ContinuePay")]
        public OrderSuccess Result { get; set; }
    }

    public class ContinuePayParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }

        /// <summary>
        /// ContinuePayParam.Request 
        /// <para>Required variables:<br/> { order=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ContinuePayDocument,
                OperationName = "ContinuePay",
                Variables = this
            };
        }


        public static string ContinuePayDocument = @"
        mutation ContinuePay($order: String!) {
          ContinuePay(order: $order) {
            code
            url
            charge
          }
        }
        ";
    }



    public class CreateDefaultSamlIdentityProviderSettingsResponse
    {

        [JsonProperty("CreateDefaultSAMLIdentityProviderSettings")]
        public SAMLDefaultIdentityProviderSettings Result { get; set; }
    }

    public class CreateDefaultSamlIdentityProviderSettingsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("mappings")]
        public AssertionMapInputType Mappings { get; set; }

        /// <summary>
        /// CreateDefaultSamlIdentityProviderSettingsParam.Request 
        /// <para>Required variables:<br/> { name=(string) }</para>
        /// <para>Optional variables:<br/> { image=(string), description=(string), mappings=(AssertionMapInputType) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateDefaultSamlIdentityProviderSettingsDocument,
                OperationName = "CreateDefaultSAMLIdentityProviderSettings",
                Variables = this
            };
        }


        public static string CreateDefaultSamlIdentityProviderSettingsDocument = @"
        mutation CreateDefaultSAMLIdentityProviderSettings($name: String!, $image: String, $description: String, $mappings: AssertionMapInputType) {
          CreateDefaultSAMLIdentityProviderSettings(name: $name, image: $image, description: $description, mappings: $mappings) {
            _id
            name
            image
            description
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            isDeleted
          }
        }
        ";
    }



    public class CreateOAuthProviderResponse
    {

        [JsonProperty("CreateOAuthProvider")]
        public OAuthProviderClient Result { get; set; }
    }

    public class CreateOAuthProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("redirectUris")]
        public string RedirectUris { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("grants")]
        public string Grants { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("casExpire")]
        public int CasExpire { get; set; }

        /// <summary>
        /// CreateOAuthProviderParam.Request 
        /// <para>Required variables:<br/> { name=(string), domain=(string), redirectUris=(string[]), grants=(string[]) }</para>
        /// <para>Optional variables:<br/> { clientId=(string), image=(string), description=(string), homepageURL=(string), casExpire=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateOAuthProviderDocument,
                OperationName = "CreateOAuthProvider",
                Variables = this
            };
        }


        public static string CreateOAuthProviderDocument = @"
        mutation CreateOAuthProvider($name: String!, $domain: String!, $redirectUris: [String]!, $grants: [String!]!, $clientId: String, $image: String, $description: String, $homepageURL: String, $casExpire: Int) {
          CreateOAuthProvider(name: $name, domain: $domain, redirectUris: $redirectUris, grants: $grants, clientId: $clientId, image: $image, description: $description, homepageURL: $homepageURL, casExpire: $casExpire) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class CreateOidcAppResponse
    {

        [JsonProperty("CreateOIDCApp")]
        public OIDCProviderClient Result { get; set; }
    }

    public class CreateOidcAppParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("redirect_uris")]
        public string Redirect_Uris { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("grant_types")]
        public string Grant_Types { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("response_types")]
        public string Response_Types { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client_id")]
        public string Client_Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token_endpoint_auth_method")]
        public string Token_Endpoint_Auth_Method { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_signed_response_alg")]
        public string Id_Token_Signed_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_encrypted_response_alg")]
        public string Id_Token_Encrypted_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_encrypted_response_enc")]
        public string Id_Token_Encrypted_Response_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_signed_response_alg")]
        public string Userinfo_Signed_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_encrypted_response_alg")]
        public string Userinfo_Encrypted_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_encrypted_response_enc")]
        public string Userinfo_Encrypted_Response_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_signing_alg")]
        public string Request_Object_Signing_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_encryption_alg")]
        public string Request_Object_Encryption_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_encryption_enc")]
        public string Request_Object_Encryption_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("jwks_uri")]
        public string Jwks_Uri { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_jwks_uri")]
        public string _Jwks_Uri { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("jwks")]
        public string Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_jwks")]
        public string _Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("custom_jwks")]
        public string Custom_Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("authorization_code_expire")]
        public string Authorization_Code_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_expire")]
        public string Id_Token_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("access_token_expire")]
        public string Access_Token_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("cas_expire")]
        public string Cas_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("customStyles")]
        public OidcProviderCustomStylesInput CustomStyles { get; set; }

        /// <summary>
        /// CreateOidcAppParam.Request 
        /// <para>Required variables:<br/> { name=(string), domain=(string), redirect_uris=(string[]), grant_types=(string[]), response_types=(string[]) }</para>
        /// <para>Optional variables:<br/> { clientId=(string), client_id=(string), token_endpoint_auth_method=(string), image=(string), isDefault=(bool), id_token_signed_response_alg=(string), id_token_encrypted_response_alg=(string), id_token_encrypted_response_enc=(string), userinfo_signed_response_alg=(string), userinfo_encrypted_response_alg=(string), userinfo_encrypted_response_enc=(string), request_object_signing_alg=(string), request_object_encryption_alg=(string), request_object_encryption_enc=(string), jwks_uri=(string), _jwks_uri=(string), jwks=(string), _jwks=(string), custom_jwks=(string), description=(string), homepageURL=(string), authorization_code_expire=(string), id_token_expire=(string), access_token_expire=(string), cas_expire=(string), customStyles=(OIDCProviderCustomStylesInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateOidcAppDocument,
                OperationName = "CreateOIDCApp",
                Variables = this
            };
        }


        public static string CreateOidcAppDocument = @"
        mutation CreateOIDCApp($name: String!, $domain: String!, $redirect_uris: [String]!, $grant_types: [String!]!, $response_types: [String!]!, $clientId: String, $client_id: String, $token_endpoint_auth_method: String, $image: String, $isDefault: Boolean, $id_token_signed_response_alg: String, $id_token_encrypted_response_alg: String, $id_token_encrypted_response_enc: String, $userinfo_signed_response_alg: String, $userinfo_encrypted_response_alg: String, $userinfo_encrypted_response_enc: String, $request_object_signing_alg: String, $request_object_encryption_alg: String, $request_object_encryption_enc: String, $jwks_uri: String, $_jwks_uri: String, $jwks: String, $_jwks: String, $custom_jwks: String, $description: String, $homepageURL: String, $authorization_code_expire: String, $id_token_expire: String, $access_token_expire: String, $cas_expire: String, $customStyles: OIDCProviderCustomStylesInput) {
          CreateOIDCApp(name: $name, domain: $domain, redirect_uris: $redirect_uris, grant_types: $grant_types, response_types: $response_types, clientId: $clientId, client_id: $client_id, token_endpoint_auth_method: $token_endpoint_auth_method, image: $image, isDefault: $isDefault, id_token_signed_response_alg: $id_token_signed_response_alg, id_token_encrypted_response_alg: $id_token_encrypted_response_alg, id_token_encrypted_response_enc: $id_token_encrypted_response_enc, userinfo_signed_response_alg: $userinfo_signed_response_alg, userinfo_encrypted_response_alg: $userinfo_encrypted_response_alg, userinfo_encrypted_response_enc: $userinfo_encrypted_response_enc, request_object_signing_alg: $request_object_signing_alg, request_object_encryption_alg: $request_object_encryption_alg, request_object_encryption_enc: $request_object_encryption_enc, jwks_uri: $jwks_uri, _jwks_uri: $_jwks_uri, jwks: $jwks, _jwks: $_jwks, custom_jwks: $custom_jwks, description: $description, homepageURL: $homepageURL, authorization_code_expire: $authorization_code_expire, id_token_expire: $id_token_expire, access_token_expire: $access_token_expire, cas_expire: $cas_expire, customStyles: $customStyles) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class CreateSamlIdentityProviderResponse
    {

        [JsonProperty("CreateSAMLIdentityProvider")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class CreateSamlIdentityProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        /// <summary>
        /// CreateSamlIdentityProviderParam.Request 
        /// <para>Required variables:<br/> { name=(string), domain=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> { image=(string), description=(string), SPMetadata=(string), IdPMetadata=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateSamlIdentityProviderDocument,
                OperationName = "CreateSAMLIdentityProvider",
                Variables = this
            };
        }


        public static string CreateSamlIdentityProviderDocument = @"
        mutation CreateSAMLIdentityProvider($name: String!, $domain: String!, $clientId: String!, $image: String, $description: String, $SPMetadata: String, $IdPMetadata: String) {
          CreateSAMLIdentityProvider(name: $name, domain: $domain, clientId: $clientId, image: $image, description: $description, SPMetadata: $SPMetadata, IdPMetadata: $IdPMetadata) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class CreateSamlServiceProviderResponse
    {

        [JsonProperty("CreateSAMLServiceProvider")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class CreateSamlServiceProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("mappings")]
        public AssertionMapInputType Mappings { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("defaultIdPMapId")]
        public string DefaultIdPMapId { get; set; }

        /// <summary>
        /// CreateSamlServiceProviderParam.Request 
        /// <para>Required variables:<br/> { name=(string), domain=(string), clientId=(string), redirectUrl=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string), SPMetadata=(string), IdPMetadata=(string), image=(string), mappings=(AssertionMapInputType), defaultIdPMapId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateSamlServiceProviderDocument,
                OperationName = "CreateSAMLServiceProvider",
                Variables = this
            };
        }


        public static string CreateSamlServiceProviderDocument = @"
        mutation CreateSAMLServiceProvider($name: String!, $domain: String!, $clientId: String!, $redirectUrl: String!, $description: String, $SPMetadata: String, $IdPMetadata: String, $image: String, $mappings: AssertionMapInputType, $defaultIdPMapId: String) {
          CreateSAMLServiceProvider(name: $name, domain: $domain, clientId: $clientId, redirectUrl: $redirectUrl, description: $description, SPMetadata: $SPMetadata, IdPMetadata: $IdPMetadata, image: $image, mappings: $mappings, defaultIdPMapId: $defaultIdPMapId) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class EnableSamlIdentityProviderResponse
    {

        [JsonProperty("EnableSAMLIdentityProvider")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class EnableSamlIdentityProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// EnableSamlIdentityProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> { enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableSamlIdentityProviderDocument,
                OperationName = "EnableSAMLIdentityProvider",
                Variables = this
            };
        }


        public static string EnableSamlIdentityProviderDocument = @"
        mutation EnableSAMLIdentityProvider($appId: String!, $clientId: String!, $enabled: Boolean) {
          EnableSAMLIdentityProvider(appId: $appId, clientId: $clientId, enabled: $enabled) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class EnableSamlServiceProviderResponse
    {

        [JsonProperty("EnableSAMLServiceProvider")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class EnableSamlServiceProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// EnableSamlServiceProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> { enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableSamlServiceProviderDocument,
                OperationName = "EnableSAMLServiceProvider",
                Variables = this
            };
        }


        public static string EnableSamlServiceProviderDocument = @"
        mutation EnableSAMLServiceProvider($appId: String!, $clientId: String!, $enabled: Boolean) {
          EnableSAMLServiceProvider(appId: $appId, clientId: $clientId, enabled: $enabled) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class IncClientFlowNumberResponse
    {

        [JsonProperty("IncClientFlowNumber")]
        public OrderSuccess Result { get; set; }
    }

    public class IncClientFlowNumberParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userInvitied")]
        public string UserInvitied { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("number")]
        public int Number { get; set; }

        /// <summary>
        /// IncClientFlowNumberParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { user=(string), userInvitied=(string), client=(string), number=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IncClientFlowNumberDocument,
                OperationName = "IncClientFlowNumber",
                Variables = this
            };
        }


        public static string IncClientFlowNumberDocument = @"
        mutation IncClientFlowNumber($user: String, $userInvitied: String, $client: String, $number: Int) {
          IncClientFlowNumber(user: $user, userInvitied: $userInvitied, client: $client, number: $number) {
            code
            url
            charge
          }
        }
        ";
    }



    public class LoginByLdapResponse
    {

        [JsonProperty("LoginByLDAP")]
        public User Result { get; set; }
    }

    public class LoginByLdapParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// LoginByLdapParam.Request 
        /// <para>Required variables:<br/> { username=(string), password=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> { browser=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByLdapDocument,
                OperationName = "LoginByLDAP",
                Variables = this
            };
        }


        public static string LoginByLdapDocument = @"
        mutation LoginByLDAP($username: String!, $password: String!, $clientId: String!, $browser: String) {
          LoginByLDAP(username: $username, password: $password, clientId: $clientId, browser: $browser) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class RemoveEmailProviderResponse
    {

        [JsonProperty("RemoveEmailProvider")]
        public IEnumerable<EmailProviderList> Result { get; set; }
    }

    public class RemoveEmailProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_ids")]
        public string _Ids { get; set; }

        /// <summary>
        /// RemoveEmailProviderParam.Request 
        /// <para>Required variables:<br/> { _ids=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveEmailProviderDocument,
                OperationName = "RemoveEmailProvider",
                Variables = this
            };
        }


        public static string RemoveEmailProviderDocument = @"
        mutation RemoveEmailProvider($_ids: [String]!) {
          RemoveEmailProvider(_ids: $_ids) {
            _id
            name
            image
            description
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            client
            user
            status
            provider {
              _id
              name
              image
              description
              client
              user
              status
            }
          }
        }
        ";
    }



    public class RemoveLdapServerResponse
    {

        [JsonProperty("RemoveLDAPServer")]
        public LDAPSingleServer Result { get; set; }
    }

    public class RemoveLdapServerParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapId")]
        public string LdapId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// RemoveLdapServerParam.Request 
        /// <para>Required variables:<br/> { ldapId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveLdapServerDocument,
                OperationName = "RemoveLDAPServer",
                Variables = this
            };
        }


        public static string RemoveLdapServerDocument = @"
        mutation RemoveLDAPServer($ldapId: String!, $clientId: String!) {
          RemoveLDAPServer(ldapId: $ldapId, clientId: $clientId) {
            _id
            name
            clientId
            userId
            ldapLink
            baseDN
            searchStandard
            emailPostfix
            username
            password
            description
            enabled
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class RemoveOAuthListResponse
    {

        [JsonProperty("RemoveOAuthList")]
        public IEnumerable<string> Result { get; set; }
    }

    public class RemoveOAuthListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// RemoveOAuthListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { ids=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveOAuthListDocument,
                OperationName = "RemoveOAuthList",
                Variables = this
            };
        }


        public static string RemoveOAuthListDocument = @"
        mutation RemoveOAuthList($ids: [String]) {
          RemoveOAuthList(ids: $ids)
        }
        ";
    }



    public class RemoveOAuthProviderResponse
    {

        [JsonProperty("RemoveOAuthProvider")]
        public OAuthProviderClient Result { get; set; }
    }

    public class RemoveOAuthProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// RemoveOAuthProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveOAuthProviderDocument,
                OperationName = "RemoveOAuthProvider",
                Variables = this
            };
        }


        public static string RemoveOAuthProviderDocument = @"
        mutation RemoveOAuthProvider($appId: String!, $clientId: String!) {
          RemoveOAuthProvider(appId: $appId, clientId: $clientId) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class RemoveOidcAppResponse
    {

        [JsonProperty("RemoveOIDCApp")]
        public OIDCProviderClient Result { get; set; }
    }

    public class RemoveOidcAppParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// RemoveOidcAppParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveOidcAppDocument,
                OperationName = "RemoveOIDCApp",
                Variables = this
            };
        }


        public static string RemoveOidcAppDocument = @"
        mutation RemoveOIDCApp($appId: String!, $clientId: String!) {
          RemoveOIDCApp(appId: $appId, clientId: $clientId) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class RemoveSamlIdentityProviderResponse
    {

        [JsonProperty("RemoveSAMLIdentityProvider")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class RemoveSamlIdentityProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// RemoveSamlIdentityProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveSamlIdentityProviderDocument,
                OperationName = "RemoveSAMLIdentityProvider",
                Variables = this
            };
        }


        public static string RemoveSamlIdentityProviderDocument = @"
        mutation RemoveSAMLIdentityProvider($appId: String!, $clientId: String!) {
          RemoveSAMLIdentityProvider(appId: $appId, clientId: $clientId) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class RemoveSamlServiceProviderResponse
    {

        [JsonProperty("RemoveSAMLServiceProvider")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class RemoveSamlServiceProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// RemoveSamlServiceProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveSamlServiceProviderDocument,
                OperationName = "RemoveSAMLServiceProvider",
                Variables = this
            };
        }


        public static string RemoveSamlServiceProviderDocument = @"
        mutation RemoveSAMLServiceProvider($appId: String!, $clientId: String!) {
          RemoveSAMLServiceProvider(appId: $appId, clientId: $clientId) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class RevokeUserAuthorizedAppResponse
    {

        [JsonProperty("RevokeUserAuthorizedApp")]
        public UserAuthorizedApp Result { get; set; }
    }

    public class RevokeUserAuthorizedAppParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// RevokeUserAuthorizedAppParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string), userPoolId=(string), userId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RevokeUserAuthorizedAppDocument,
                OperationName = "RevokeUserAuthorizedApp",
                Variables = this
            };
        }


        public static string RevokeUserAuthorizedAppDocument = @"
        mutation RevokeUserAuthorizedApp($appId: String, $userPoolId: String, $userId: String) {
          RevokeUserAuthorizedApp(appId: $appId, userPoolId: $userPoolId, userId: $userId) {
            _id
            appId
            userId
            scope
            type
            isRevoked
            when
          }
        }
        ";
    }



    public class SaveEmailProviderWithClientResponse
    {

        [JsonProperty("SaveEmailProviderWithClient")]
        public EmailProviderWithClientList Result { get; set; }
    }

    public class SaveEmailProviderWithClientParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public EmailProviderWithClientAddInput Options { get; set; }

        /// <summary>
        /// SaveEmailProviderWithClientParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(EmailProviderWithClientAddInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SaveEmailProviderWithClientDocument,
                OperationName = "SaveEmailProviderWithClient",
                Variables = this
            };
        }


        public static string SaveEmailProviderWithClientDocument = @"
        mutation SaveEmailProviderWithClient($options: EmailProviderWithClientAddInput) {
          SaveEmailProviderWithClient(options: $options) {
            _id
            user
            client
            status
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            provider {
              _id
              name
              image
              description
            }
          }
        }
        ";
    }



    public class SendEmailResponse
    {

        [JsonProperty("SendEmail")]
        public EmailSentList Result { get; set; }
    }

    public class SendEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("receivers")]
        public string Receivers { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("testAvailable")]
        public bool TestAvailable { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("providerName")]
        public string ProviderName { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sender")]
        public string Sender { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("meta_data")]
        public string Meta_Data { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// SendEmailParam.Request 
        /// <para>Required variables:<br/> { receivers=(string[]), subject=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { user=(string), testAvailable=(bool), providerName=(string), content=(string), sender=(string), meta_data=(string), secret=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendEmailDocument,
                OperationName = "SendEmail",
                Variables = this
            };
        }


        public static string SendEmailDocument = @"
        mutation SendEmail($receivers: [String]!, $subject: String!, $client: String!, $user: String, $testAvailable: Boolean, $providerName: String, $content: String, $sender: String, $meta_data: String, $secret: String) {
          SendEmail(receivers: $receivers, subject: $subject, client: $client, user: $user, testAvailable: $testAvailable, providerName: $providerName, content: $content, sender: $sender, meta_data: $meta_data, secret: $secret) {
            _id
            user
            subject
            content
            sender
            receivers
            post
            createdAt
            rejected
            isDeleted
            client
          }
        }
        ";
    }



    public class SendEmailByTypeResponse
    {

        [JsonProperty("SendEmailByType")]
        public EmailSentList Result { get; set; }
    }

    public class SendEmailByTypeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("receivers")]
        public string Receivers { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("meta_data")]
        public string Meta_Data { get; set; }

        /// <summary>
        /// SendEmailByTypeParam.Request 
        /// <para>Required variables:<br/> { user=(string), type=(string), client=(string), receivers=(string[]) }</para>
        /// <para>Optional variables:<br/> { meta_data=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendEmailByTypeDocument,
                OperationName = "SendEmailByType",
                Variables = this
            };
        }


        public static string SendEmailByTypeDocument = @"
        mutation SendEmailByType($user: String!, $type: String!, $client: String!, $receivers: [String]!, $meta_data: String) {
          SendEmailByType(user: $user, type: $type, client: $client, receivers: $receivers, meta_data: $meta_data) {
            _id
            user
            subject
            content
            sender
            receivers
            post
            createdAt
            rejected
            isDeleted
            client
          }
        }
        ";
    }



    public class SendWebhookTestResponse
    {

        [JsonProperty("SendWebhookTest")]
        public bool? Result { get; set; }
    }

    public class SendWebhookTestParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// SendWebhookTestParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendWebhookTestDocument,
                OperationName = "SendWebhookTest",
                Variables = this
            };
        }


        public static string SendWebhookTestDocument = @"
        mutation SendWebhookTest($id: String!) {
          SendWebhookTest(id: $id)
        }
        ";
    }



    public class SetApplicationOAuthEnableOrDisableResponse
    {

        [JsonProperty("SetApplicationOAuthEnableOrDisable")]
        public OAuthList Result { get; set; }
    }

    public class SetApplicationOAuthEnableOrDisableParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// SetApplicationOAuthEnableOrDisableParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string), oauth=(string), user=(string), enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SetApplicationOAuthEnableOrDisableDocument,
                OperationName = "SetApplicationOAuthEnableOrDisable",
                Variables = this
            };
        }


        public static string SetApplicationOAuthEnableOrDisableDocument = @"
        mutation SetApplicationOAuthEnableOrDisable($client: String, $oauth: String, $user: String, $enabled: Boolean) {
          SetApplicationOAuthEnableOrDisable(client: $client, oauth: $oauth, user: $user, enabled: $enabled) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class UpdateApplicationOAuthResponse
    {

        [JsonProperty("UpdateApplicationOAuth")]
        public OAuthList Result { get; set; }
    }

    public class UpdateApplicationOAuthParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fields")]
        public OAuthListFieldsFormUpdateInput Fields { get; set; }

        /// <summary>
        /// UpdateApplicationOAuthParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string), oauth=(string), user=(string), alias=(string), fields=(OAuthListFieldsFormUpdateInput[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateApplicationOAuthDocument,
                OperationName = "UpdateApplicationOAuth",
                Variables = this
            };
        }


        public static string UpdateApplicationOAuthDocument = @"
        mutation UpdateApplicationOAuth($client: String, $oauth: String, $user: String, $alias: String, $fields: [OAuthListFieldsFormUpdateInput]) {
          UpdateApplicationOAuth(client: $client, oauth: $oauth, user: $user, alias: $alias, fields: $fields) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class UpdateEmailProviderResponse
    {

        [JsonProperty("UpdateEmailProvider")]
        public EmailProviderList Result { get; set; }
    }

    public class UpdateEmailProviderParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public EmailProviderListInput Options { get; set; }

        /// <summary>
        /// UpdateEmailProviderParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(EmailProviderListInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateEmailProviderDocument,
                OperationName = "UpdateEmailProvider",
                Variables = this
            };
        }


        public static string UpdateEmailProviderDocument = @"
        mutation UpdateEmailProvider($options: EmailProviderListInput) {
          UpdateEmailProvider(options: $options) {
            _id
            name
            image
            description
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            client
            user
            status
            provider {
              _id
              name
              image
              description
              client
              user
              status
            }
          }
        }
        ";
    }



    public class UpdateEmailTemplateResponse
    {

        [JsonProperty("UpdateEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }

    public class UpdateEmailTemplateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public EmailTemplateInput Options { get; set; }

        /// <summary>
        /// UpdateEmailTemplateParam.Request 
        /// <para>Required variables:<br/> { options=(EmailTemplateInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateEmailTemplateDocument,
                OperationName = "UpdateEmailTemplate",
                Variables = this
            };
        }


        public static string UpdateEmailTemplateDocument = @"
        mutation UpdateEmailTemplate($options: EmailTemplateInput!) {
          UpdateEmailTemplate(options: $options) {
            _id
            type
            sender
            object
            hasURL
            URLExpireTime
            status
            redirectTo
            content
          }
        }
        ";
    }



    public class UpdateEmailTemplateWithClientResponse
    {

        [JsonProperty("UpdateEmailTemplateWithClient")]
        public EmailProviderWithClientList Result { get; set; }
    }

    public class UpdateEmailTemplateWithClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public EmailTemplateWithClientInput Options { get; set; }

        /// <summary>
        /// UpdateEmailTemplateWithClientParam.Request 
        /// <para>Required variables:<br/> { options=(EmailTemplateWithClientInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateEmailTemplateWithClientDocument,
                OperationName = "UpdateEmailTemplateWithClient",
                Variables = this
            };
        }


        public static string UpdateEmailTemplateWithClientDocument = @"
        mutation UpdateEmailTemplateWithClient($options: EmailTemplateWithClientInput!) {
          UpdateEmailTemplateWithClient(options: $options) {
            _id
            user
            client
            status
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            provider {
              _id
              name
              image
              description
            }
          }
        }
        ";
    }



    public class UpdateLdapServerResponse
    {

        [JsonProperty("UpdateLDAPServer")]
        public LDAPSingleServer Result { get; set; }
    }

    public class UpdateLdapServerParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapId")]
        public string LdapId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapLink")]
        public string LdapLink { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("baseDN")]
        public string BaseDn { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("searchStandard")]
        public string SearchStandard { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("emailPostfix")]
        public string EmailPostfix { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// UpdateLdapServerParam.Request 
        /// <para>Required variables:<br/> { ldapId=(string), name=(string), clientId=(string), userId=(string), ldapLink=(string), baseDN=(string), username=(string), searchStandard=(string), password=(string) }</para>
        /// <para>Optional variables:<br/> { emailPostfix=(string), description=(string), enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateLdapServerDocument,
                OperationName = "UpdateLDAPServer",
                Variables = this
            };
        }


        public static string UpdateLdapServerDocument = @"
        mutation UpdateLDAPServer($ldapId: String!, $name: String!, $clientId: String!, $userId: String!, $ldapLink: String!, $baseDN: String!, $username: String!, $searchStandard: String!, $password: String!, $emailPostfix: String, $description: String, $enabled: Boolean) {
          UpdateLDAPServer(ldapId: $ldapId, name: $name, clientId: $clientId, userId: $userId, ldapLink: $ldapLink, baseDN: $baseDN, username: $username, searchStandard: $searchStandard, password: $password, emailPostfix: $emailPostfix, description: $description, enabled: $enabled) {
            _id
            name
            clientId
            userId
            ldapLink
            baseDN
            searchStandard
            emailPostfix
            username
            password
            description
            enabled
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class UpdateOAuthListResponse
    {

        [JsonProperty("UpdateOAuthList")]
        public OAuthList Result { get; set; }
    }

    public class UpdateOAuthListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public OAuthListUpdateInput Options { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fields")]
        public OAuthListFieldsFormUpdateInput Fields { get; set; }

        /// <summary>
        /// UpdateOAuthListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(OAuthListUpdateInput), fields=(OAuthListFieldsFormUpdateInput[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateOAuthListDocument,
                OperationName = "UpdateOAuthList",
                Variables = this
            };
        }


        public static string UpdateOAuthListDocument = @"
        mutation UpdateOAuthList($options: OAuthListUpdateInput, $fields: [OAuthListFieldsFormUpdateInput]) {
          UpdateOAuthList(options: $options, fields: $fields) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class UpdateOAuthProviderResponse
    {

        [JsonProperty("UpdateOAuthProvider")]
        public OAuthProviderClient Result { get; set; }
    }

    public class UpdateOAuthProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("redirectUris")]
        public string RedirectUris { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("grants")]
        public string Grants { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("css")]
        public string Css { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("casExpire")]
        public int CasExpire { get; set; }

        /// <summary>
        /// UpdateOAuthProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> { domain=(string), name=(string), image=(string), redirectUris=(string[]), grants=(string[]), description=(string), homepageURL=(string), css=(string), casExpire=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateOAuthProviderDocument,
                OperationName = "UpdateOAuthProvider",
                Variables = this
            };
        }


        public static string UpdateOAuthProviderDocument = @"
        mutation UpdateOAuthProvider($appId: String!, $domain: String, $name: String, $image: String, $redirectUris: [String], $grants: [String], $description: String, $homepageURL: String, $css: String, $casExpire: Int) {
          UpdateOAuthProvider(appId: $appId, domain: $domain, name: $name, image: $image, redirectUris: $redirectUris, grants: $grants, description: $description, homepageURL: $homepageURL, css: $css, casExpire: $casExpire) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class UpdateOidcAppResponse
    {

        [JsonProperty("UpdateOIDCApp")]
        public OIDCProviderClient Result { get; set; }
    }

    public class UpdateOidcAppParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("redirect_uris")]
        public string Redirect_Uris { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token_endpoint_auth_method")]
        public string Token_Endpoint_Auth_Method { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("grant_types")]
        public string Grant_Types { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("response_types")]
        public string Response_Types { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_signed_response_alg")]
        public string Id_Token_Signed_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_encrypted_response_alg")]
        public string Id_Token_Encrypted_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_encrypted_response_enc")]
        public string Id_Token_Encrypted_Response_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_signed_response_alg")]
        public string Userinfo_Signed_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_encrypted_response_alg")]
        public string Userinfo_Encrypted_Response_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userinfo_encrypted_response_enc")]
        public string Userinfo_Encrypted_Response_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_signing_alg")]
        public string Request_Object_Signing_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_encryption_alg")]
        public string Request_Object_Encryption_Alg { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("request_object_encryption_enc")]
        public string Request_Object_Encryption_Enc { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("jwks_uri")]
        public string Jwks_Uri { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_jwks_uri")]
        public string _Jwks_Uri { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("custom_jwks")]
        public string Custom_Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("jwks")]
        public string Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_jwks")]
        public string _Jwks { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("homepageURL")]
        public string HomepageUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("css")]
        public string Css { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("authorization_code_expire")]
        public string Authorization_Code_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id_token_expire")]
        public string Id_Token_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("access_token_expire")]
        public string Access_Token_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("cas_expire")]
        public string Cas_Expire { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("customStyles")]
        public OidcProviderCustomStylesInput CustomStyles { get; set; }

        /// <summary>
        /// UpdateOidcAppParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> { domain=(string), name=(string), image=(string), redirect_uris=(string[]), token_endpoint_auth_method=(string), grant_types=(string[]), response_types=(string[]), id_token_signed_response_alg=(string), id_token_encrypted_response_alg=(string), id_token_encrypted_response_enc=(string), userinfo_signed_response_alg=(string), userinfo_encrypted_response_alg=(string), userinfo_encrypted_response_enc=(string), request_object_signing_alg=(string), request_object_encryption_alg=(string), request_object_encryption_enc=(string), jwks_uri=(string), _jwks_uri=(string), custom_jwks=(string), jwks=(string), _jwks=(string), description=(string), homepageURL=(string), css=(string), authorization_code_expire=(string), id_token_expire=(string), access_token_expire=(string), cas_expire=(string), customStyles=(OIDCProviderCustomStylesInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateOidcAppDocument,
                OperationName = "UpdateOIDCApp",
                Variables = this
            };
        }


        public static string UpdateOidcAppDocument = @"
        mutation UpdateOIDCApp($appId: String!, $domain: String, $name: String, $image: String, $redirect_uris: [String], $token_endpoint_auth_method: String, $grant_types: [String], $response_types: [String], $id_token_signed_response_alg: String, $id_token_encrypted_response_alg: String, $id_token_encrypted_response_enc: String, $userinfo_signed_response_alg: String, $userinfo_encrypted_response_alg: String, $userinfo_encrypted_response_enc: String, $request_object_signing_alg: String, $request_object_encryption_alg: String, $request_object_encryption_enc: String, $jwks_uri: String, $_jwks_uri: String, $custom_jwks: String, $jwks: String, $_jwks: String, $description: String, $homepageURL: String, $css: String, $authorization_code_expire: String, $id_token_expire: String, $access_token_expire: String, $cas_expire: String, $customStyles: OIDCProviderCustomStylesInput) {
          UpdateOIDCApp(appId: $appId, domain: $domain, name: $name, image: $image, redirect_uris: $redirect_uris, token_endpoint_auth_method: $token_endpoint_auth_method, grant_types: $grant_types, response_types: $response_types, id_token_signed_response_alg: $id_token_signed_response_alg, id_token_encrypted_response_alg: $id_token_encrypted_response_alg, id_token_encrypted_response_enc: $id_token_encrypted_response_enc, userinfo_signed_response_alg: $userinfo_signed_response_alg, userinfo_encrypted_response_alg: $userinfo_encrypted_response_alg, userinfo_encrypted_response_enc: $userinfo_encrypted_response_enc, request_object_signing_alg: $request_object_signing_alg, request_object_encryption_alg: $request_object_encryption_alg, request_object_encryption_enc: $request_object_encryption_enc, jwks_uri: $jwks_uri, _jwks_uri: $_jwks_uri, custom_jwks: $custom_jwks, jwks: $jwks, _jwks: $_jwks, description: $description, homepageURL: $homepageURL, css: $css, authorization_code_expire: $authorization_code_expire, id_token_expire: $id_token_expire, access_token_expire: $access_token_expire, cas_expire: $cas_expire, customStyles: $customStyles) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class UpdateSamlIdentityProviderResponse
    {

        [JsonProperty("UpdateSAMLIdentityProvider")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class UpdateSamlIdentityProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("attributeNameFormat")]
        public string AttributeNameFormat { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("customAttributes")]
        public string CustomAttributes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("emailDomainTransformation")]
        public string EmailDomainTransformation { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("authnContextClassRef")]
        public string AuthnContextClassRef { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("assertionConsumerUrl")]
        public string AssertionConsumerUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("bindings")]
        public string Bindings { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nameIds")]
        public string NameIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("attributes")]
        public string Attributes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enableSignRes")]
        public bool EnableSignRes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resSignAlgorithm")]
        public string ResSignAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resAbstractAlgorithm")]
        public string ResAbstractAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resSignPublicKey")]
        public string ResSignPublicKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resSignPrivateKey")]
        public string ResSignPrivateKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resSignPrivateKeyPass")]
        public string ResSignPrivateKeyPass { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enableSignReq")]
        public bool EnableSignReq { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqSignPublicKey")]
        public string ReqSignPublicKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enableEncryptRes")]
        public bool EnableEncryptRes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resEncryptPublicKey")]
        public string ResEncryptPublicKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("css")]
        public string Css { get; set; }

        /// <summary>
        /// UpdateSamlIdentityProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), clientId=(string) }</para>
        /// <para>Optional variables:<br/> { domain=(string), image=(string), name=(string), description=(string), SPMetadata=(string), attributeNameFormat=(string), customAttributes=(string), emailDomainTransformation=(string), authnContextClassRef=(string), IdPMetadata=(string), assertionConsumerUrl=(string), bindings=(string[]), nameIds=(string[]), attributes=(string[]), enableSignRes=(bool), resSignAlgorithm=(string), resAbstractAlgorithm=(string), resSignPublicKey=(string), resSignPrivateKey=(string), resSignPrivateKeyPass=(string), enableSignReq=(bool), reqSignPublicKey=(string), enableEncryptRes=(bool), resEncryptPublicKey=(string), css=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateSamlIdentityProviderDocument,
                OperationName = "UpdateSAMLIdentityProvider",
                Variables = this
            };
        }


        public static string UpdateSamlIdentityProviderDocument = @"
        mutation UpdateSAMLIdentityProvider($appId: String!, $clientId: String!, $domain: String, $image: String, $name: String, $description: String, $SPMetadata: String, $attributeNameFormat: String, $customAttributes: String, $emailDomainTransformation: String, $authnContextClassRef: String, $IdPMetadata: String, $assertionConsumerUrl: String, $bindings: [String], $nameIds: [String], $attributes: [String], $enableSignRes: Boolean, $resSignAlgorithm: String, $resAbstractAlgorithm: String, $resSignPublicKey: String, $resSignPrivateKey: String, $resSignPrivateKeyPass: String, $enableSignReq: Boolean, $reqSignPublicKey: String, $enableEncryptRes: Boolean, $resEncryptPublicKey: String, $css: String) {
          UpdateSAMLIdentityProvider(appId: $appId, clientId: $clientId, domain: $domain, image: $image, name: $name, description: $description, SPMetadata: $SPMetadata, attributeNameFormat: $attributeNameFormat, customAttributes: $customAttributes, emailDomainTransformation: $emailDomainTransformation, authnContextClassRef: $authnContextClassRef, IdPMetadata: $IdPMetadata, assertionConsumerUrl: $assertionConsumerUrl, bindings: $bindings, nameIds: $nameIds, attributes: $attributes, enableSignRes: $enableSignRes, resSignAlgorithm: $resSignAlgorithm, resAbstractAlgorithm: $resAbstractAlgorithm, resSignPublicKey: $resSignPublicKey, resSignPrivateKey: $resSignPrivateKey, resSignPrivateKeyPass: $resSignPrivateKeyPass, enableSignReq: $enableSignReq, reqSignPublicKey: $reqSignPublicKey, enableEncryptRes: $enableEncryptRes, resEncryptPublicKey: $resEncryptPublicKey, css: $css) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class UpdateSamlServiceProviderResponse
    {

        [JsonProperty("UpdateSAMLServiceProvider")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class UpdateSamlServiceProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("loginUrl")]
        public string LoginUrl { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("logoutUrl")]
        public string LogoutUrl { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("nameId")]
        public string NameId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("IdPEntityID")]
        public string IdPEntityId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("assertionConsumeService")]
        public AssertionConsumeServiceInputType AssertionConsumeService { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("mappings")]
        public AssertionMapInputType Mappings { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("defaultIdPMapId")]
        public string DefaultIdPMapId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("SPMetadata")]
        public string SpMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("IdPMetadata")]
        public string IdPMetadata { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enableSignRes")]
        public bool EnableSignRes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resSignPublicKey")]
        public string ResSignPublicKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("hasResEncrypted")]
        public bool HasResEncrypted { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resEncryptAlgorithm")]
        public string ResEncryptAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resAbstractAlgorithm")]
        public string ResAbstractAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resDecryptPrivateKey")]
        public string ResDecryptPrivateKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resDecryptPrivateKeyPass")]
        public string ResDecryptPrivateKeyPass { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("resEncryptPublicKey")]
        public string ResEncryptPublicKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enableSignReq")]
        public bool EnableSignReq { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqSignAlgorithm")]
        public string ReqSignAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqAbstractAlgorithm")]
        public string ReqAbstractAlgorithm { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqSignPrivateKey")]
        public string ReqSignPrivateKey { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqSignPrivateKeyPass")]
        public string ReqSignPrivateKeyPass { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("reqSignPublicKey")]
        public string ReqSignPublicKey { get; set; }

        /// <summary>
        /// UpdateSamlServiceProviderParam.Request 
        /// <para>Required variables:<br/> { appId=(string), name=(string), domain=(string), clientId=(string), redirectUrl=(string), loginUrl=(string), logoutUrl=(string), nameId=(string) }</para>
        /// <para>Optional variables:<br/> { IdPEntityID=(string), assertionConsumeService=(AssertionConsumeServiceInputType[]), image=(string), mappings=(AssertionMapInputType), defaultIdPMapId=(string), description=(string), SPMetadata=(string), IdPMetadata=(string), enableSignRes=(bool), resSignPublicKey=(string), hasResEncrypted=(bool), resEncryptAlgorithm=(string), resAbstractAlgorithm=(string), resDecryptPrivateKey=(string), resDecryptPrivateKeyPass=(string), resEncryptPublicKey=(string), enableSignReq=(bool), reqSignAlgorithm=(string), reqAbstractAlgorithm=(string), reqSignPrivateKey=(string), reqSignPrivateKeyPass=(string), reqSignPublicKey=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateSamlServiceProviderDocument,
                OperationName = "UpdateSAMLServiceProvider",
                Variables = this
            };
        }


        public static string UpdateSamlServiceProviderDocument = @"
        mutation UpdateSAMLServiceProvider($appId: String!, $name: String!, $domain: String!, $clientId: String!, $redirectUrl: String!, $loginUrl: String!, $logoutUrl: String!, $nameId: String!, $IdPEntityID: String, $assertionConsumeService: [AssertionConsumeServiceInputType], $image: String, $mappings: AssertionMapInputType, $defaultIdPMapId: String, $description: String, $SPMetadata: String, $IdPMetadata: String, $enableSignRes: Boolean, $resSignPublicKey: String, $hasResEncrypted: Boolean, $resEncryptAlgorithm: String, $resAbstractAlgorithm: String, $resDecryptPrivateKey: String, $resDecryptPrivateKeyPass: String, $resEncryptPublicKey: String, $enableSignReq: Boolean, $reqSignAlgorithm: String, $reqAbstractAlgorithm: String, $reqSignPrivateKey: String, $reqSignPrivateKeyPass: String, $reqSignPublicKey: String) {
          UpdateSAMLServiceProvider(appId: $appId, name: $name, domain: $domain, clientId: $clientId, redirectUrl: $redirectUrl, loginUrl: $loginUrl, logoutUrl: $logoutUrl, nameId: $nameId, IdPEntityID: $IdPEntityID, assertionConsumeService: $assertionConsumeService, image: $image, mappings: $mappings, defaultIdPMapId: $defaultIdPMapId, description: $description, SPMetadata: $SPMetadata, IdPMetadata: $IdPMetadata, enableSignRes: $enableSignRes, resSignPublicKey: $resSignPublicKey, hasResEncrypted: $hasResEncrypted, resEncryptAlgorithm: $resEncryptAlgorithm, resAbstractAlgorithm: $resAbstractAlgorithm, resDecryptPrivateKey: $resDecryptPrivateKey, resDecryptPrivateKeyPass: $resDecryptPrivateKeyPass, resEncryptPublicKey: $resEncryptPublicKey, enableSignReq: $enableSignReq, reqSignAlgorithm: $reqSignAlgorithm, reqAbstractAlgorithm: $reqAbstractAlgorithm, reqSignPrivateKey: $reqSignPrivateKey, reqSignPrivateKeyPass: $reqSignPrivateKeyPass, reqSignPublicKey: $reqSignPublicKey) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class UpdateSystemPricingResponse
    {

        [JsonProperty("UpdateSystemPricing")]
        public PricingList Result { get; set; }
    }

    public class UpdateSystemPricingParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public PricingFieldsInput Options { get; set; }

        /// <summary>
        /// UpdateSystemPricingParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { options=(PricingFieldsInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateSystemPricingDocument,
                OperationName = "UpdateSystemPricing",
                Variables = this
            };
        }


        public static string UpdateSystemPricingDocument = @"
        mutation UpdateSystemPricing($options: PricingFieldsInput) {
          UpdateSystemPricing(options: $options) {
            _id
            type
            startNumber
            freeNumber
            startPrice
            maxNumber
            d
            features
          }
        }
        ";
    }



    public class UseDefaultEmailProviderResponse
    {

        [JsonProperty("UseDefaultEmailProvider")]
        public bool? Result { get; set; }
    }

    public class UseDefaultEmailProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// UseDefaultEmailProviderParam.Request 
        /// <para>Required variables:<br/> { user=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UseDefaultEmailProviderDocument,
                OperationName = "UseDefaultEmailProvider",
                Variables = this
            };
        }


        public static string UseDefaultEmailProviderDocument = @"
        mutation UseDefaultEmailProvider($user: String!, $client: String!) {
          UseDefaultEmailProvider(user: $user, client: $client)
        }
        ";
    }



    public class AddClientWebhookResponse
    {

        [JsonProperty("addClientWebhook")]
        public ClientWebhook Result { get; set; }
    }

    public class AddClientWebhookParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("events")]
        public string Events { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("isLastTimeSuccess")]
        public bool IsLastTimeSuccess { get; set; }

        /// <summary>
        /// AddClientWebhookParam.Request 
        /// <para>Required variables:<br/> { client=(string), events=(string[]), url=(string), contentType=(string), enable=(bool) }</para>
        /// <para>Optional variables:<br/> { secret=(string), isLastTimeSuccess=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddClientWebhookDocument,
                OperationName = "addClientWebhook",
                Variables = this
            };
        }


        public static string AddClientWebhookDocument = @"
        mutation addClientWebhook($client: String!, $events: [String!]!, $url: String!, $contentType: String!, $enable: Boolean!, $secret: String, $isLastTimeSuccess: Boolean) {
          addClientWebhook(client: $client, events: $events, url: $url, contentType: $contentType, enable: $enable, secret: $secret, isLastTimeSuccess: $isLastTimeSuccess) {
            _id
            client
            events {
              name
              label
              description
            }
            url
            isLastTimeSuccess
            contentType
            secret
            enable
          }
        }
        ";
    }



    public class AddCollaboratorResponse
    {

        [JsonProperty("addCollaborator")]
        public Collaboration Result { get; set; }
    }

    public class AddCollaboratorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("collaboratorUserId")]
        public string CollaboratorUserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("permissionDescriptors")]
        public PermissionDescriptorsInputType PermissionDescriptors { get; set; }

        /// <summary>
        /// AddCollaboratorParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), collaboratorUserId=(string), permissionDescriptors=(PermissionDescriptorsInputType[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddCollaboratorDocument,
                OperationName = "addCollaborator",
                Variables = this
            };
        }


        public static string AddCollaboratorDocument = @"
        mutation addCollaborator($userPoolId: String!, $collaboratorUserId: String!, $permissionDescriptors: [PermissionDescriptorsInputType]!) {
          addCollaborator(userPoolId: $userPoolId, collaboratorUserId: $collaboratorUserId, permissionDescriptors: $permissionDescriptors) {
            _id
          }
        }
        ";
    }



    public class AddGroupMetadataResponse
    {

        [JsonProperty("addGroupMetadata")]
        public IEnumerable<GroupMetadata> Result { get; set; }
    }

    public class AddGroupMetadataParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// AddGroupMetadataParam.Request 
        /// <para>Required variables:<br/> { groupId=(string), key=(string), value=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddGroupMetadataDocument,
                OperationName = "addGroupMetadata",
                Variables = this
            };
        }


        public static string AddGroupMetadataDocument = @"
        mutation addGroupMetadata($groupId: String!, $key: String!, $value: String!) {
          addGroupMetadata(groupId: $groupId, key: $key, value: $value) {
            key
            value
          }
        }
        ";
    }



    public class AddOrgNodeResponse
    {

        [JsonProperty("addOrgNode")]
        public Org Result { get; set; }
    }

    public class AddOrgNodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddOrgNodeInput Input { get; set; }

        /// <summary>
        /// AddOrgNodeParam.Request 
        /// <para>Required variables:<br/> { input=(AddOrgNodeInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddOrgNodeDocument,
                OperationName = "addOrgNode",
                Variables = this
            };
        }


        public static string AddOrgNodeDocument = @"
        mutation addOrgNode($input: AddOrgNodeInput!) {
          addOrgNode(input: $input) {
            _id
            nodes {
              _id
              name
              description
              createdAt
              updatedAt
              children
              root
            }
          }
        }
        ";
    }



    public class AddPermissionResponse
    {

        [JsonProperty("addPermission")]
        public Permission Result { get; set; }
    }

    public class AddPermissionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// AddPermissionParam.Request 
        /// <para>Required variables:<br/> { name=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddPermissionDocument,
                OperationName = "addPermission",
                Variables = this
            };
        }


        public static string AddPermissionDocument = @"
        mutation addPermission($name: String!, $description: String) {
          addPermission(name: $name, description: $description) {
            _id
            name
            affect
            description
          }
        }
        ";
    }



    public class AddPermissionToRbacRoleResponse
    {

        [JsonProperty("addPermissionToRBACRole")]
        public RBACRole Result { get; set; }
    }

    public class AddPermissionToRbacRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddPermissionToRbacRoleInput Input { get; set; }

        /// <summary>
        /// AddPermissionToRbacRoleParam.Request 
        /// <para>Required variables:<br/> { input=(AddPermissionToRBACRoleInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddPermissionToRbacRoleDocument,
                OperationName = "addPermissionToRBACRole",
                Variables = this
            };
        }


        public static string AddPermissionToRbacRoleDocument = @"
        mutation addPermissionToRBACRole($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddPermissionToRBACRoleInput!) {
          addPermissionToRBACRole(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AddPermissionToRbacRoleBatchResponse
    {

        [JsonProperty("addPermissionToRBACRoleBatch")]
        public RBACRole Result { get; set; }
    }

    public class AddPermissionToRbacRoleBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("input")]
        public AddPermissionToRbacRoleBatchInput Input { get; set; }

        /// <summary>
        /// AddPermissionToRbacRoleBatchParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int), input=(AddPermissionToRBACRoleBatchInput) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddPermissionToRbacRoleBatchDocument,
                OperationName = "addPermissionToRBACRoleBatch",
                Variables = this
            };
        }


        public static string AddPermissionToRbacRoleBatchDocument = @"
        mutation addPermissionToRBACRoleBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddPermissionToRBACRoleBatchInput) {
          addPermissionToRBACRoleBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AddRoleToRbacGroupResponse
    {

        [JsonProperty("addRoleToRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class AddRoleToRbacGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddRoleToRbacGroupInput Input { get; set; }

        /// <summary>
        /// AddRoleToRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(AddRoleToRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddRoleToRbacGroupDocument,
                OperationName = "addRoleToRBACGroup",
                Variables = this
            };
        }


        public static string AddRoleToRbacGroupDocument = @"
        mutation addRoleToRBACGroup($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddRoleToRBACGroupInput!) {
          addRoleToRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AddRoleToRbacGroupBatchResponse
    {

        [JsonProperty("addRoleToRBACGroupBatch")]
        public RBACGroup Result { get; set; }
    }

    public class AddRoleToRbacGroupBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddRoleToRbacGroupBatchInput Input { get; set; }

        /// <summary>
        /// AddRoleToRbacGroupBatchParam.Request 
        /// <para>Required variables:<br/> { input=(AddRoleToRBACGroupBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddRoleToRbacGroupBatchDocument,
                OperationName = "addRoleToRBACGroupBatch",
                Variables = this
            };
        }


        public static string AddRoleToRbacGroupBatchDocument = @"
        mutation addRoleToRBACGroupBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddRoleToRBACGroupBatchInput!) {
          addRoleToRBACGroupBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AddSuperAdminUserResponse
    {

        [JsonProperty("addSuperAdminUser")]
        public UsersInGroupListItem Result { get; set; }
    }

    public class AddSuperAdminUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public SuperAdminUpdateInput Options { get; set; }

        /// <summary>
        /// AddSuperAdminUserParam.Request 
        /// <para>Required variables:<br/> { options=(SuperAdminUpdateInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddSuperAdminUserDocument,
                OperationName = "addSuperAdminUser",
                Variables = this
            };
        }


        public static string AddSuperAdminUserDocument = @"
        mutation addSuperAdminUser($options: SuperAdminUpdateInput!) {
          addSuperAdminUser(options: $options) {
            email
            username
            _id
            upgrade
          }
        }
        ";
    }



    public class AddToInvitationResponse
    {

        [JsonProperty("addToInvitation")]
        public Invitation Result { get; set; }
    }

    public class AddToInvitationParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// AddToInvitationParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddToInvitationDocument,
                OperationName = "addToInvitation",
                Variables = this
            };
        }


        public static string AddToInvitationDocument = @"
        mutation addToInvitation($client: String!, $phone: String) {
          addToInvitation(client: $client, phone: $phone) {
            client
            phone
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class AddUserToRbacGroupResponse
    {

        [JsonProperty("addUserToRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class AddUserToRbacGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddUserToRbacGroupInput Input { get; set; }

        /// <summary>
        /// AddUserToRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(AddUserToRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddUserToRbacGroupDocument,
                OperationName = "addUserToRBACGroup",
                Variables = this
            };
        }


        public static string AddUserToRbacGroupDocument = @"
        mutation addUserToRBACGroup($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddUserToRBACGroupInput!) {
          addUserToRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AddUserToRbacGroupBatchResponse
    {

        [JsonProperty("addUserToRBACGroupBatch")]
        public RBACGroup Result { get; set; }
    }

    public class AddUserToRbacGroupBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AddUserToRbacGroupBatchInput Input { get; set; }

        /// <summary>
        /// AddUserToRbacGroupBatchParam.Request 
        /// <para>Required variables:<br/> { input=(AddUserToRBACGroupBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddUserToRbacGroupBatchDocument,
                OperationName = "addUserToRBACGroupBatch",
                Variables = this
            };
        }


        public static string AddUserToRbacGroupBatchDocument = @"
        mutation addUserToRBACGroupBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: AddUserToRBACGroupBatchInput!) {
          addUserToRBACGroupBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AssignRbacRoleToUserResponse
    {

        [JsonProperty("assignRBACRoleToUser")]
        public RBACRole Result { get; set; }
    }

    public class AssignRbacRoleToUserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AssignUserToRbacRoleInput Input { get; set; }

        /// <summary>
        /// AssignRbacRoleToUserParam.Request 
        /// <para>Required variables:<br/> { input=(AssignUserToRBACRoleInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AssignRbacRoleToUserDocument,
                OperationName = "assignRBACRoleToUser",
                Variables = this
            };
        }


        public static string AssignRbacRoleToUserDocument = @"
        mutation assignRBACRoleToUser($sortBy: SortByEnum, $page: Int, $count: Int, $input: AssignUserToRBACRoleInput!) {
          assignRBACRoleToUser(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AssignRbacRoleToUserBatchResponse
    {

        [JsonProperty("assignRBACRoleToUserBatch")]
        public RBACRole Result { get; set; }
    }

    public class AssignRbacRoleToUserBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public AssignUserToRbacRoleBatchInput Input { get; set; }

        /// <summary>
        /// AssignRbacRoleToUserBatchParam.Request 
        /// <para>Required variables:<br/> { input=(AssignUserToRBACRoleBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AssignRbacRoleToUserBatchDocument,
                OperationName = "assignRBACRoleToUserBatch",
                Variables = this
            };
        }


        public static string AssignRbacRoleToUserBatchDocument = @"
        mutation assignRBACRoleToUserBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: AssignUserToRBACRoleBatchInput!) {
          assignRBACRoleToUserBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class AssignUserToRoleResponse
    {

        [JsonProperty("assignUserToRole")]
        public PagedUserGroup Result { get; set; }
    }

    public class AssignUserToRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// AssignUserToRoleParam.Request 
        /// <para>Required variables:<br/> { client=(string), user=(string), group=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AssignUserToRoleDocument,
                OperationName = "assignUserToRole",
                Variables = this
            };
        }


        public static string AssignUserToRoleDocument = @"
        mutation assignUserToRole($client: String!, $user: String!, $group: String!) {
          assignUserToRole(client: $client, user: $user, group: $group) {
            list {
              _id
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class BindOtherOAuthResponse
    {

        [JsonProperty("bindOtherOAuth")]
        public UserOAuthBind Result { get; set; }
    }

    public class BindOtherOAuthParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userInfo")]
        public string UserInfo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// BindOtherOAuthParam.Request 
        /// <para>Required variables:<br/> { type=(string), unionid=(string), userInfo=(string) }</para>
        /// <para>Optional variables:<br/> { client=(string), user=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = BindOtherOAuthDocument,
                OperationName = "bindOtherOAuth",
                Variables = this
            };
        }


        public static string BindOtherOAuthDocument = @"
        mutation bindOtherOAuth($type: String!, $unionid: String!, $userInfo: String!, $client: String, $user: String) {
          bindOtherOAuth(type: $type, unionid: $unionid, userInfo: $userInfo, client: $client, user: $user) {
            _id
            user
            client
            type
            unionid
            userInfo
            createdAt
          }
        }
        ";
    }



    public class ChangeMfaResponse
    {

        [JsonProperty("changeMFA")]
        public MFA Result { get; set; }
    }

    public class ChangeMfaParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("refreshKey")]
        public bool RefreshKey { get; set; }

        /// <summary>
        /// ChangeMfaParam.Request 
        /// <para>Required variables:<br/> { enable=(bool) }</para>
        /// <para>Optional variables:<br/> { userId=(string), userPoolId=(string), _id=(string), refreshKey=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ChangeMfaDocument,
                OperationName = "changeMFA",
                Variables = this
            };
        }


        public static string ChangeMfaDocument = @"
        mutation changeMFA($enable: Boolean!, $userId: String, $userPoolId: String, $_id: String, $refreshKey: Boolean) {
          changeMFA(enable: $enable, userId: $userId, userPoolId: $userPoolId, _id: $_id, refreshKey: $refreshKey) {
            _id
            userId
            userPoolId
            enable
            shareKey
          }
        }
        ";
    }



    public class ChangePasswordResponse
    {

        [JsonProperty("changePassword")]
        public ExtendUser Result { get; set; }
    }

    public class ChangePasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// ChangePasswordParam.Request 
        /// <para>Required variables:<br/> { password=(string), email=(string), client=(string), verifyCode=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ChangePasswordDocument,
                OperationName = "changePassword",
                Variables = this
            };
        }


        public static string ChangePasswordDocument = @"
        mutation changePassword($password: String!, $email: String!, $client: String!, $verifyCode: String!) {
          changePassword(password: $password, email: $email, client: $client, verifyCode: $verifyCode) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class CreateAdConnectorResponse
    {

        [JsonProperty("createAdConnector")]
        public ADConnector Result { get; set; }
    }

    public class CreateAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// CreateAdConnectorParam.Request 
        /// <para>Required variables:<br/> { name=(string), userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { logo=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateAdConnectorDocument,
                OperationName = "createAdConnector",
                Variables = this
            };
        }


        public static string CreateAdConnectorDocument = @"
        mutation createAdConnector($name: String!, $logo: String, $userPoolId: String!) {
          createAdConnector(name: $name, logo: $logo, userPoolId: $userPoolId) {
            _id
            name
            secret
            salt
            logo
            enabled
            userPoolId
            status
            createdAt
          }
        }
        ";
    }



    public class CreateCustomMfaResponse
    {

        [JsonProperty("createCustomMFA")]
        public CustomMFA Result { get; set; }
    }

    public class CreateCustomMfaParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIdInMiniLogin")]
        public string UserIdInMiniLogin { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// CreateCustomMfaParam.Request 
        /// <para>Required variables:<br/> { userIdInMiniLogin=(string), userPoolId=(string), name=(string), secret=(string) }</para>
        /// <para>Optional variables:<br/> { remark=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateCustomMfaDocument,
                OperationName = "createCustomMFA",
                Variables = this
            };
        }


        public static string CreateCustomMfaDocument = @"
        mutation createCustomMFA($userIdInMiniLogin: String!, $userPoolId: String!, $name: String!, $secret: String!, $remark: String) {
          createCustomMFA(userIdInMiniLogin: $userIdInMiniLogin, userPoolId: $userPoolId, name: $name, secret: $secret, remark: $remark) {
            _id
            userIdInMiniLogin
            userPoolId {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            remark
            name
            secret
          }
        }
        ";
    }



    public class CreateInterConnectionResponse
    {

        [JsonProperty("createInterConnection")]
        public CommonMessage Result { get; set; }
    }

    public class CreateInterConnectionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("sourceUserPoolId")]
        public string SourceUserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("sourceUserId")]
        public string SourceUserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetUserPoolId")]
        public string TargetUserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetUserId")]
        public string TargetUserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("maxAge")]
        public int MaxAge { get; set; }

        /// <summary>
        /// CreateInterConnectionParam.Request 
        /// <para>Required variables:<br/> { sourceUserPoolId=(string), sourceUserId=(string), targetUserPoolId=(string), targetUserId=(string), maxAge=(int) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateInterConnectionDocument,
                OperationName = "createInterConnection",
                Variables = this
            };
        }


        public static string CreateInterConnectionDocument = @"
        mutation createInterConnection($sourceUserPoolId: String!, $sourceUserId: String!, $targetUserPoolId: String!, $targetUserId: String!, $maxAge: Int!) {
          createInterConnection(sourceUserPoolId: $sourceUserPoolId, sourceUserId: $sourceUserId, targetUserId: $targetUserId, targetUserPoolId: $targetUserPoolId, maxAge: $maxAge) {
            message
            code
            status
          }
        }
        ";
    }



    public class CreateOrgResponse
    {

        [JsonProperty("createOrg")]
        public Org Result { get; set; }
    }

    public class CreateOrgParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateOrgInput Input { get; set; }

        /// <summary>
        /// CreateOrgParam.Request 
        /// <para>Required variables:<br/> { input=(CreateOrgInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateOrgDocument,
                OperationName = "createOrg",
                Variables = this
            };
        }


        public static string CreateOrgDocument = @"
        mutation createOrg($input: CreateOrgInput!) {
          createOrg(input: $input) {
            _id
            nodes {
              _id
              name
              description
              createdAt
              updatedAt
              children
              root
            }
          }
        }
        ";
    }



    public class CreateRbacGroupResponse
    {

        [JsonProperty("createRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class CreateRbacGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateRbacGroupInput Input { get; set; }

        /// <summary>
        /// CreateRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(CreateRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateRbacGroupDocument,
                OperationName = "createRBACGroup",
                Variables = this
            };
        }


        public static string CreateRbacGroupDocument = @"
        mutation createRBACGroup($input: CreateRBACGroupInput!) {
          createRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class CreateRbacPermissionResponse
    {

        [JsonProperty("createRBACPermission")]
        public RBACPermission Result { get; set; }
    }

    public class CreateRbacPermissionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateRbacPermissionInput Input { get; set; }

        /// <summary>
        /// CreateRbacPermissionParam.Request 
        /// <para>Required variables:<br/> { input=(CreateRBACPermissionInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateRbacPermissionDocument,
                OperationName = "createRBACPermission",
                Variables = this
            };
        }


        public static string CreateRbacPermissionDocument = @"
        mutation createRBACPermission($input: CreateRBACPermissionInput!) {
          createRBACPermission(input: $input) {
            _id
            name
            userPoolId
            createdAt
            updatedAt
            description
          }
        }
        ";
    }



    public class CreateRbacRoleResponse
    {

        [JsonProperty("createRBACRole")]
        public RBACRole Result { get; set; }
    }

    public class CreateRbacRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateRbacRoleInput Input { get; set; }

        /// <summary>
        /// CreateRbacRoleParam.Request 
        /// <para>Required variables:<br/> { input=(CreateRBACRoleInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateRbacRoleDocument,
                OperationName = "createRBACRole",
                Variables = this
            };
        }


        public static string CreateRbacRoleDocument = @"
        mutation createRBACRole($sortBy: SortByEnum, $page: Int, $count: Int, $input: CreateRBACRoleInput!) {
          createRBACRole(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class CreateRoleResponse
    {

        [JsonProperty("createRole")]
        public Group Result { get; set; }
    }

    public class CreateRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        /// <summary>
        /// CreateRoleParam.Request 
        /// <para>Required variables:<br/> { client=(string), name=(string) }</para>
        /// <para>Optional variables:<br/> { descriptions=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateRoleDocument,
                OperationName = "createRole",
                Variables = this
            };
        }


        public static string CreateRoleDocument = @"
        mutation createRole($client: String!, $name: String!, $descriptions: String) {
          createRole(client: $client, name: $name, descriptions: $descriptions) {
            _id
            name
            descriptions
            client
            permissions
            createdAt
          }
        }
        ";
    }



    public class CreateRuleResponse
    {

        [JsonProperty("createRule")]
        public Rule Result { get; set; }
    }

    public class CreateRuleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateRuleInput Input { get; set; }

        /// <summary>
        /// CreateRuleParam.Request 
        /// <para>Required variables:<br/> { input=(CreateRuleInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateRuleDocument,
                OperationName = "createRule",
                Variables = this
            };
        }


        public static string CreateRuleDocument = @"
        mutation createRule($input: CreateRuleInput!) {
          createRule(input: $input) {
            _id
            userPoolId
            name
            description
            type
            enabled
            faasUrl
            code
            order
            async
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class CreateUserResponse
    {

        [JsonProperty("createUser")]
        public ExtendUser Result { get; set; }
    }

    public class CreateUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userInfo")]
        public UserRegisterInput UserInfo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("invitationCode")]
        public string InvitationCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("keepPassword")]
        public bool KeepPassword { get; set; }

        /// <summary>
        /// CreateUserParam.Request 
        /// <para>Required variables:<br/> { userInfo=(UserRegisterInput) }</para>
        /// <para>Optional variables:<br/> { invitationCode=(string), keepPassword=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateUserDocument,
                OperationName = "createUser",
                Variables = this
            };
        }


        public static string CreateUserDocument = @"
        mutation createUser($userInfo: UserRegisterInput!, $invitationCode: String, $keepPassword: Boolean) {
          createUser(userInfo: $userInfo, invitationCode: $invitationCode, keepPassword: $keepPassword) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class CreateUserWithoutAuthenticationResponse
    {

        [JsonProperty("createUserWithoutAuthentication")]
        public User Result { get; set; }
    }

    public class CreateUserWithoutAuthenticationParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userInfo")]
        public UserRegisterInput UserInfo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("forceLogin")]
        public bool ForceLogin { get; set; }

        /// <summary>
        /// CreateUserWithoutAuthenticationParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), userInfo=(UserRegisterInput) }</para>
        /// <para>Optional variables:<br/> { forceLogin=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateUserWithoutAuthenticationDocument,
                OperationName = "createUserWithoutAuthentication",
                Variables = this
            };
        }


        public static string CreateUserWithoutAuthenticationDocument = @"
        mutation createUserWithoutAuthentication($userPoolId: String!, $userInfo: UserRegisterInput!, $forceLogin: Boolean) {
          createUserWithoutAuthentication(userPoolId: $userPoolId, userInfo: $userInfo, forceLogin: $forceLogin) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            metadata
          }
        }
        ";
    }



    public class DeleteClientWebhookResponse
    {

        [JsonProperty("deleteClientWebhook")]
        public ClientWebhook Result { get; set; }
    }

    public class DeleteClientWebhookParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// DeleteClientWebhookParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteClientWebhookDocument,
                OperationName = "deleteClientWebhook",
                Variables = this
            };
        }


        public static string DeleteClientWebhookDocument = @"
        mutation deleteClientWebhook($id: String!) {
          deleteClientWebhook(id: $id) {
            _id
            client
            events {
              name
              label
              description
            }
            url
            isLastTimeSuccess
            contentType
            secret
            enable
          }
        }
        ";
    }



    public class DeleteOrgResponse
    {

        [JsonProperty("deleteOrg")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteOrgParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DeleteOrgParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteOrgDocument,
                OperationName = "deleteOrg",
                Variables = this
            };
        }


        public static string DeleteOrgDocument = @"
        mutation deleteOrg($_id: String!) {
          deleteOrg(_id: $_id) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacGroupResponse
    {

        [JsonProperty("deleteRBACGroup")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DeleteRbacGroupParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacGroupDocument,
                OperationName = "deleteRBACGroup",
                Variables = this
            };
        }


        public static string DeleteRbacGroupDocument = @"
        mutation deleteRBACGroup($_id: String!) {
          deleteRBACGroup(_id: $_id) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacGroupBatchResponse
    {

        [JsonProperty("deleteRBACGroupBatch")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacGroupBatchParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("idList")]
        public string IdList { get; set; }

        /// <summary>
        /// DeleteRbacGroupBatchParam.Request 
        /// <para>Required variables:<br/> { idList=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacGroupBatchDocument,
                OperationName = "deleteRBACGroupBatch",
                Variables = this
            };
        }


        public static string DeleteRbacGroupBatchDocument = @"
        mutation deleteRBACGroupBatch($idList: [String!]!) {
          deleteRBACGroupBatch(idList: $idList) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacPermissionResponse
    {

        [JsonProperty("deleteRBACPermission")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacPermissionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DeleteRbacPermissionParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacPermissionDocument,
                OperationName = "deleteRBACPermission",
                Variables = this
            };
        }


        public static string DeleteRbacPermissionDocument = @"
        mutation deleteRBACPermission($_id: String!) {
          deleteRBACPermission(_id: $_id) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacPermissionBatchResponse
    {

        [JsonProperty("deleteRBACPermissionBatch")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacPermissionBatchParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("idList")]
        public string IdList { get; set; }

        /// <summary>
        /// DeleteRbacPermissionBatchParam.Request 
        /// <para>Required variables:<br/> { idList=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacPermissionBatchDocument,
                OperationName = "deleteRBACPermissionBatch",
                Variables = this
            };
        }


        public static string DeleteRbacPermissionBatchDocument = @"
        mutation deleteRBACPermissionBatch($idList: [String!]!) {
          deleteRBACPermissionBatch(idList: $idList) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacRoleResponse
    {

        [JsonProperty("deleteRBACRole")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DeleteRbacRoleParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacRoleDocument,
                OperationName = "deleteRBACRole",
                Variables = this
            };
        }


        public static string DeleteRbacRoleDocument = @"
        mutation deleteRBACRole($_id: String!) {
          deleteRBACRole(_id: $_id) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRbacRoleBatchResponse
    {

        [JsonProperty("deleteRBACRoleBatch")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRbacRoleBatchParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("idList")]
        public string IdList { get; set; }

        /// <summary>
        /// DeleteRbacRoleBatchParam.Request 
        /// <para>Required variables:<br/> { idList=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRbacRoleBatchDocument,
                OperationName = "deleteRBACRoleBatch",
                Variables = this
            };
        }


        public static string DeleteRbacRoleBatchDocument = @"
        mutation deleteRBACRoleBatch($idList: [String!]!) {
          deleteRBACRoleBatch(idList: $idList) {
            message
            code
            status
          }
        }
        ";
    }



    public class DeleteRuleResponse
    {

        [JsonProperty("deleteRule")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRuleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DeleteRuleParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRuleDocument,
                OperationName = "deleteRule",
                Variables = this
            };
        }


        public static string DeleteRuleDocument = @"
        mutation deleteRule($_id: String!) {
          deleteRule(_id: $_id) {
            message
            code
            status
          }
        }
        ";
    }



    public class DisableAdConnectorResponse
    {

        [JsonProperty("disableAdConnector")]
        public bool? Result { get; set; }
    }

    public class DisableAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// DisableAdConnectorParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DisableAdConnectorDocument,
                OperationName = "disableAdConnector",
                Variables = this
            };
        }


        public static string DisableAdConnectorDocument = @"
        mutation disableAdConnector($_id: String!) {
          disableAdConnector(_id: $_id)
        }
        ";
    }



    public class DisableAdConnectorForProviderResponse
    {

        [JsonProperty("disableAdConnectorForProvider")]
        public bool? Result { get; set; }
    }

    public class DisableAdConnectorForProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }

        /// <summary>
        /// DisableAdConnectorForProviderParam.Request 
        /// <para>Required variables:<br/> { providerId=(string), adConnectorId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DisableAdConnectorForProviderDocument,
                OperationName = "disableAdConnectorForProvider",
                Variables = this
            };
        }


        public static string DisableAdConnectorForProviderDocument = @"
        mutation disableAdConnectorForProvider($providerId: String!, $adConnectorId: String!) {
          disableAdConnectorForProvider(providerId: $providerId, adConnectorId: $adConnectorId)
        }
        ";
    }



    public class EnableAdConnectorResponse
    {

        [JsonProperty("enableAdConnector")]
        public bool? Result { get; set; }
    }

    public class EnableAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// EnableAdConnectorParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableAdConnectorDocument,
                OperationName = "enableAdConnector",
                Variables = this
            };
        }


        public static string EnableAdConnectorDocument = @"
        mutation enableAdConnector($_id: String!) {
          enableAdConnector(_id: $_id)
        }
        ";
    }



    public class EnableAdConnectorForProviderResponse
    {

        [JsonProperty("enableAdConnectorForProvider")]
        public bool? Result { get; set; }
    }

    public class EnableAdConnectorForProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("providerType")]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }

        /// <summary>
        /// EnableAdConnectorForProviderParam.Request 
        /// <para>Required variables:<br/> { providerType=(providerType), providerId=(string), adConnectorId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableAdConnectorForProviderDocument,
                OperationName = "enableAdConnectorForProvider",
                Variables = this
            };
        }


        public static string EnableAdConnectorForProviderDocument = @"
        mutation enableAdConnectorForProvider($providerType: providerType!, $providerId: String!, $adConnectorId: String!) {
          enableAdConnectorForProvider(providerType: $providerType, providerId: $providerId, adConnectorId: $adConnectorId)
        }
        ";
    }



    public class EnablePasswordFaasResponse
    {

        [JsonProperty("enablePasswordFaas")]
        public PaaswordFaas Result { get; set; }
    }

    public class EnablePasswordFaasParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// EnablePasswordFaasParam.Request 
        /// <para>Required variables:<br/> { client=(string), enable=(bool) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnablePasswordFaasDocument,
                OperationName = "enablePasswordFaas",
                Variables = this
            };
        }


        public static string EnablePasswordFaasDocument = @"
        mutation enablePasswordFaas($client: String!, $enable: Boolean!) {
          enablePasswordFaas(client: $client, enable: $enable) {
            encryptUrl
            decryptUrl
            user
            client
            logs
            enable
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class EncryptPasswordResponse
    {

        [JsonProperty("encryptPassword")]
        public EncryptPassword Result { get; set; }
    }

    public class EncryptPasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("isTest")]
        public bool IsTest { get; set; }

        /// <summary>
        /// EncryptPasswordParam.Request 
        /// <para>Required variables:<br/> { password=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { isTest=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EncryptPasswordDocument,
                OperationName = "encryptPassword",
                Variables = this
            };
        }


        public static string EncryptPasswordDocument = @"
        mutation encryptPassword($password: String!, $client: String!, $isTest: Boolean) {
          encryptPassword(password: $password, client: $client, isTest: $isTest) {
            _id
            encryptUrl
            decryptUrl
            client
            user
            logs
            enable
            createdAt
            updatedAt
            password
          }
        }
        ";
    }



    public class GenerateInvitationCodeResponse
    {

        [JsonProperty("generateInvitationCode")]
        public InvitationCode Result { get; set; }
    }

    public class GenerateInvitationCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// GenerateInvitationCodeParam.Request 
        /// <para>Required variables:<br/> { user=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GenerateInvitationCodeDocument,
                OperationName = "generateInvitationCode",
                Variables = this
            };
        }


        public static string GenerateInvitationCodeDocument = @"
        mutation generateInvitationCode($user: String!, $client: String!) {
          generateInvitationCode(user: $user, client: $client) {
            _id
            user
            client
            code
            createdAt
          }
        }
        ";
    }



    public class LoginResponse
    {

        [JsonProperty("login")]
        public ExtendUser Result { get; set; }
    }

    public class LoginParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phoneCode")]
        public int PhoneCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("MFACode")]
        public string MfaCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fromRegister")]
        public bool FromRegister { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("device")]
        public string Device { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// LoginParam.Request 
        /// <para>Required variables:<br/> { registerInClient=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string), phoneCode=(int), unionid=(string), openid=(string), username=(string), email=(string), password=(string), lastIP=(string), verifyCode=(string), MFACode=(string), fromRegister=(bool), device=(string), browser=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginDocument,
                OperationName = "login",
                Variables = this
            };
        }


        public static string LoginDocument = @"
        mutation login($registerInClient: String!, $phone: String, $phoneCode: Int, $unionid: String, $openid: String, $username: String, $email: String, $password: String, $lastIP: String, $verifyCode: String, $MFACode: String, $fromRegister: Boolean, $device: String, $browser: String) {
          login(registerInClient: $registerInClient, phone: $phone, phoneCode: $phoneCode, unionid: $unionid, openid: $openid, username: $username, email: $email, password: $password, lastIP: $lastIP, verifyCode: $verifyCode, MFACode: $MFACode, fromRegister: $fromRegister, device: $device, browser: $browser) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class LoginByAdResponse
    {

        [JsonProperty("loginByAd")]
        public User Result { get; set; }
    }

    public class LoginByAdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// LoginByAdParam.Request 
        /// <para>Required variables:<br/> { adConnectorId=(string), username=(string), password=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByAdDocument,
                OperationName = "loginByAd",
                Variables = this
            };
        }


        public static string LoginByAdDocument = @"
        mutation loginByAd($adConnectorId: String!, $username: String!, $password: String!) {
          loginByAd(adConnectorId: $adConnectorId, username: $username, password: $password) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class LoginByEmailResponse
    {

        [JsonProperty("login")]
        public ExtendUser Result { get; set; }
    }

    public class LoginByEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// LoginByEmailParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> { email=(string), password=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByEmailDocument,
                OperationName = "loginByEmail",
                Variables = this
            };
        }


        public static string LoginByEmailDocument = @"
        mutation loginByEmail($clientId: String!, $email: String, $password: String) {
          login(registerInClient: $clientId, email: $email, password: $password) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class LoginByPhoneCodeResponse
    {

        [JsonProperty("login")]
        public ExtendUser Result { get; set; }
    }

    public class LoginByPhoneCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phoneCode")]
        public int PhoneCode { get; set; }

        /// <summary>
        /// LoginByPhoneCodeParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string), phoneCode=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByPhoneCodeDocument,
                OperationName = "loginByPhoneCode",
                Variables = this
            };
        }


        public static string LoginByPhoneCodeDocument = @"
        mutation loginByPhoneCode($clientId: String!, $phone: String, $phoneCode: Int) {
          login(registerInClient: $clientId, phone: $phone, phoneCode: $phoneCode) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class LoginByPhonePasswordResponse
    {

        [JsonProperty("login")]
        public ExtendUser Result { get; set; }
    }

    public class LoginByPhonePasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// LoginByPhonePasswordParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string), password=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByPhonePasswordDocument,
                OperationName = "loginByPhonePassword",
                Variables = this
            };
        }


        public static string LoginByPhonePasswordDocument = @"
        mutation loginByPhonePassword($clientId: String!, $phone: String, $password: String) {
          login(registerInClient: $clientId, phone: $phone, password: $password) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class LoginByUsernameResponse
    {

        [JsonProperty("login")]
        public ExtendUser Result { get; set; }
    }

    public class LoginByUsernameParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// LoginByUsernameParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> { username=(string), password=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginByUsernameDocument,
                OperationName = "loginByUsername",
                Variables = this
            };
        }


        public static string LoginByUsernameDocument = @"
        mutation loginByUsername($clientId: String!, $username: String, $password: String) {
          login(registerInClient: $clientId, username: $username, password: $password) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class NewClientResponse
    {

        [JsonProperty("newClient")]
        public UserClient Result { get; set; }
    }

    public class NewClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public NewUserClientInput Client { get; set; }

        /// <summary>
        /// NewClientParam.Request 
        /// <para>Required variables:<br/> { client=(NewUserClientInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NewClientDocument,
                OperationName = "newClient",
                Variables = this
            };
        }


        public static string NewClientDocument = @"
        mutation newClient($client: NewUserClientInput!) {
          newClient(client: $client) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class OauthPasswordLoginResponse
    {

        [JsonProperty("oauthPasswordLogin")]
        public ExtendUser Result { get; set; }
    }

    public class OauthPasswordLoginParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// OauthPasswordLoginParam.Request 
        /// <para>Required variables:<br/> { registerInClient=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string), unionid=(string), email=(string), password=(string), lastIP=(string), verifyCode=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OauthPasswordLoginDocument,
                OperationName = "oauthPasswordLogin",
                Variables = this
            };
        }


        public static string OauthPasswordLoginDocument = @"
        mutation oauthPasswordLogin($registerInClient: String!, $phone: String, $unionid: String, $email: String, $password: String, $lastIP: String, $verifyCode: String) {
          oauthPasswordLogin(registerInClient: $registerInClient, phone: $phone, unionid: $unionid, email: $email, password: $password, lastIP: $lastIP, verifyCode: $verifyCode) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userLocation {
              _id
              when
              where
            }
            userLoginHistory {
              totalCount
            }
            systemApplicationType {
              _id
              name
              descriptions
              price
            }
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            customData
            metadata
          }
        }
        ";
    }



    public class OrderResponse
    {

        [JsonProperty("order")]
        public OrderSuccess Result { get; set; }
    }

    public class OrderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public OrderAddInput Options { get; set; }

        /// <summary>
        /// OrderParam.Request 
        /// <para>Required variables:<br/> { options=(OrderAddInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrderDocument,
                OperationName = "order",
                Variables = this
            };
        }


        public static string OrderDocument = @"
        mutation order($options: OrderAddInput!) {
          order(options: $options) {
            code
            url
            charge
          }
        }
        ";
    }



    public class PasswordLessForceLoginResponse
    {

        [JsonProperty("passwordLessForceLogin")]
        public User Result { get; set; }
    }

    public class PasswordLessForceLoginParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// PasswordLessForceLoginParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), userId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PasswordLessForceLoginDocument,
                OperationName = "passwordLessForceLogin",
                Variables = this
            };
        }


        public static string PasswordLessForceLoginDocument = @"
        mutation passwordLessForceLogin($userPoolId: String!, $userId: String!) {
          passwordLessForceLogin(userPoolId: $userPoolId, userId: $userId) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            metadata
          }
        }
        ";
    }



    public class RecordAuthAuditResponse
    {

        [JsonProperty("recordAuthAudit")]
        public CommonMessage Result { get; set; }
    }

    public class RecordAuthAuditParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appType")]
        public string AppType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// RecordAuthAuditParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), appType=(string), appId=(string), userId=(string), event=(string) }</para>
        /// <para>Optional variables:<br/> { message=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RecordAuthAuditDocument,
                OperationName = "recordAuthAudit",
                Variables = this
            };
        }


        public static string RecordAuthAuditDocument = @"
        mutation recordAuthAudit($userPoolId: String!, $appType: String!, $appId: String!, $userId: String!, $event: String!, $message: String) {
          recordAuthAudit(userPoolId: $userPoolId, appType: $appType, appId: $appId, userId: $userId, event: $event, message: $message) {
            message
            code
            status
          }
        }
        ";
    }



    public class RecordRequestResponse
    {

        [JsonProperty("recordRequest")]
        public CommonMessage Result { get; set; }
    }

    public class RecordRequestParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("when")]
        public string When { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("responseTime")]
        public int ResponseTime { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("from")]
        public string From { get; set; }

        /// <summary>
        /// RecordRequestParam.Request 
        /// <para>Required variables:<br/> { when=(string), ip=(string), responseTime=(int), size=(int) }</para>
        /// <para>Optional variables:<br/> { from=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RecordRequestDocument,
                OperationName = "recordRequest",
                Variables = this
            };
        }


        public static string RecordRequestDocument = @"
        mutation recordRequest($when: String!, $ip: String!, $responseTime: Int!, $size: Int!, $from: String) {
          recordRequest(when: $when, ip: $ip, responseTime: $responseTime, size: $size, from: $from) {
            message
            code
            status
          }
        }
        ";
    }



    public class RefreshAdConnectorSecretResponse
    {

        [JsonProperty("refreshAdConnectorSecret")]
        public ADConnector Result { get; set; }
    }

    public class RefreshAdConnectorSecretParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RefreshAdConnectorSecretParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { _id=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshAdConnectorSecretDocument,
                OperationName = "refreshAdConnectorSecret",
                Variables = this
            };
        }


        public static string RefreshAdConnectorSecretDocument = @"
        mutation refreshAdConnectorSecret($_id: String) {
          refreshAdConnectorSecret(_id: $_id) {
            _id
            name
            secret
            salt
            logo
            enabled
            userPoolId
            status
            createdAt
          }
        }
        ";
    }



    public class RefreshAppSecretResponse
    {

        [JsonProperty("refreshAppSecret")]
        public UserClient Result { get; set; }
    }

    public class RefreshAppSecretParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public UpdateUserClientInput Client { get; set; }

        /// <summary>
        /// RefreshAppSecretParam.Request 
        /// <para>Required variables:<br/> { client=(UpdateUserClientInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshAppSecretDocument,
                OperationName = "refreshAppSecret",
                Variables = this
            };
        }


        public static string RefreshAppSecretDocument = @"
        mutation refreshAppSecret($client: UpdateUserClientInput!) {
          refreshAppSecret(client: $client) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class RefreshSignInTokenResponse
    {

        [JsonProperty("refreshSignInToken")]
        public RefreshedSignInToken Result { get; set; }
    }

    public class RefreshSignInTokenParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oidcAppId")]
        public string OidcAppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// RefreshSignInTokenParam.Request 
        /// <para>Required variables:<br/> { refreshToken=(string) }</para>
        /// <para>Optional variables:<br/> { oidcAppId=(string), userPoolId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshSignInTokenDocument,
                OperationName = "refreshSignInToken",
                Variables = this
            };
        }


        public static string RefreshSignInTokenDocument = @"
        mutation refreshSignInToken($oidcAppId: String, $userPoolId: String, $refreshToken: String!) {
          refreshSignInToken(oidcAppId: $oidcAppId, userPoolId: $userPoolId, refreshToken: $refreshToken) {
            access_token
            id_token
            refresh_token
            scope
            expires_in
          }
        }
        ";
    }



    public class RefreshThirdPartyTokenResponse
    {

        [JsonProperty("refreshThirdPartyToken")]
        public RefreshThirdPartyIdentityResult Result { get; set; }
    }

    public class RefreshThirdPartyTokenParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// RefreshThirdPartyTokenParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), userId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshThirdPartyTokenDocument,
                OperationName = "refreshThirdPartyToken",
                Variables = this
            };
        }


        public static string RefreshThirdPartyTokenDocument = @"
        mutation refreshThirdPartyToken($userPoolId: String!, $userId: String!) {
          refreshThirdPartyToken(userPoolId: $userPoolId, userId: $userId) {
            refreshSuccess
            message
            provider
            refreshToken
            accessToken
            updatedAt
          }
        }
        ";
    }



    public class RefreshTokenResponse
    {

        [JsonProperty("refreshToken")]
        public RefreshToken Result { get; set; }
    }

    public class RefreshTokenParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// RefreshTokenParam.Request 
        /// <para>Required variables:<br/> { client=(string), user=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshTokenDocument,
                OperationName = "refreshToken",
                Variables = this
            };
        }


        public static string RefreshTokenDocument = @"
        mutation refreshToken($client: String!, $user: String!) {
          refreshToken(client: $client, user: $user) {
            token
            iat
            exp
          }
        }
        ";
    }



    public class RegisterResponse
    {

        [JsonProperty("register")]
        public ExtendUser Result { get; set; }
    }

    public class RegisterParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userInfo")]
        public UserRegisterInput UserInfo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("invitationCode")]
        public string InvitationCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("keepPassword")]
        public bool KeepPassword { get; set; }

        /// <summary>
        /// RegisterParam.Request 
        /// <para>Required variables:<br/> { userInfo=(UserRegisterInput) }</para>
        /// <para>Optional variables:<br/> { invitationCode=(string), keepPassword=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterDocument,
                OperationName = "register",
                Variables = this
            };
        }


        public static string RegisterDocument = @"
        mutation register($userInfo: UserRegisterInput!, $invitationCode: String, $keepPassword: Boolean) {
          register(userInfo: $userInfo, invitationCode: $invitationCode, keepPassword: $keepPassword) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            metadata
          }
        }
        ";
    }



    public class RemoveAdConnectorResponse
    {

        [JsonProperty("removeAdConnector")]
        public bool? Result { get; set; }
    }

    public class RemoveAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RemoveAdConnectorParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveAdConnectorDocument,
                OperationName = "removeAdConnector",
                Variables = this
            };
        }


        public static string RemoveAdConnectorDocument = @"
        mutation removeAdConnector($_id: String!) {
          removeAdConnector(_id: $_id)
        }
        ";
    }



    public class RemoveCollaboratorResponse
    {

        [JsonProperty("removeCollaborator")]
        public Collaboration Result { get; set; }
    }

    public class RemoveCollaboratorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("collaborationId")]
        public string CollaborationId { get; set; }

        /// <summary>
        /// RemoveCollaboratorParam.Request 
        /// <para>Required variables:<br/> { collaborationId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveCollaboratorDocument,
                OperationName = "removeCollaborator",
                Variables = this
            };
        }


        public static string RemoveCollaboratorDocument = @"
        mutation removeCollaborator($collaborationId: String!) {
          removeCollaborator(collaborationId: $collaborationId) {
            _id
            createdAt
            owner {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            collaborator {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            userPool {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            permissionDescriptors {
              permissionId
              name
              operationAllow
            }
          }
        }
        ";
    }



    public class RemoveCustomMfaResponse
    {

        [JsonProperty("removeCustomMFA")]
        public CustomMFA Result { get; set; }
    }

    public class RemoveCustomMfaParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RemoveCustomMfaParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveCustomMfaDocument,
                OperationName = "removeCustomMFA",
                Variables = this
            };
        }


        public static string RemoveCustomMfaDocument = @"
        mutation removeCustomMFA($_id: String!) {
          removeCustomMFA(_id: $_id) {
            _id
            userIdInMiniLogin
            userPoolId {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            remark
            name
            secret
          }
        }
        ";
    }



    public class RemoveFromInvitationResponse
    {

        [JsonProperty("removeFromInvitation")]
        public Invitation Result { get; set; }
    }

    public class RemoveFromInvitationParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// RemoveFromInvitationParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveFromInvitationDocument,
                OperationName = "removeFromInvitation",
                Variables = this
            };
        }


        public static string RemoveFromInvitationDocument = @"
        mutation removeFromInvitation($client: String!, $phone: String) {
          removeFromInvitation(client: $client, phone: $phone) {
            client
            phone
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class RemoveOrgNodeResponse
    {

        [JsonProperty("removeOrgNode")]
        public Org Result { get; set; }
    }

    public class RemoveOrgNodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveOrgNodeInput Input { get; set; }

        /// <summary>
        /// RemoveOrgNodeParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveOrgNodeInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveOrgNodeDocument,
                OperationName = "removeOrgNode",
                Variables = this
            };
        }


        public static string RemoveOrgNodeDocument = @"
        mutation removeOrgNode($input: RemoveOrgNodeInput!) {
          removeOrgNode(input: $input) {
            _id
            nodes {
              _id
              name
              description
              createdAt
              updatedAt
              children
              root
            }
          }
        }
        ";
    }



    public class RemovePermissionFromRbacRoleResponse
    {

        [JsonProperty("removePermissionFromRBACRole")]
        public RBACRole Result { get; set; }
    }

    public class RemovePermissionFromRbacRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemovePermissionFromRbacRoleInput Input { get; set; }

        /// <summary>
        /// RemovePermissionFromRbacRoleParam.Request 
        /// <para>Required variables:<br/> { input=(RemovePermissionFromRBACRoleInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemovePermissionFromRbacRoleDocument,
                OperationName = "removePermissionFromRBACRole",
                Variables = this
            };
        }


        public static string RemovePermissionFromRbacRoleDocument = @"
        mutation removePermissionFromRBACRole($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemovePermissionFromRBACRoleInput!) {
          removePermissionFromRBACRole(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemovePermissionFromRbacRoleBatchResponse
    {

        [JsonProperty("removePermissionFromRBACRoleBatch")]
        public RBACRole Result { get; set; }
    }

    public class RemovePermissionFromRbacRoleBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemovePermissionFromRbacRoleBatchInput Input { get; set; }

        /// <summary>
        /// RemovePermissionFromRbacRoleBatchParam.Request 
        /// <para>Required variables:<br/> { input=(RemovePermissionFromRBACRoleBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemovePermissionFromRbacRoleBatchDocument,
                OperationName = "removePermissionFromRBACRoleBatch",
                Variables = this
            };
        }


        public static string RemovePermissionFromRbacRoleBatchDocument = @"
        mutation removePermissionFromRBACRoleBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemovePermissionFromRBACRoleBatchInput!) {
          removePermissionFromRBACRoleBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemoveRoleFromRbacGroupResponse
    {

        [JsonProperty("removeRoleFromRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class RemoveRoleFromRbacGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveRoleFromRbacGroupInput Input { get; set; }

        /// <summary>
        /// RemoveRoleFromRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveRoleFromRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveRoleFromRbacGroupDocument,
                OperationName = "removeRoleFromRBACGroup",
                Variables = this
            };
        }


        public static string RemoveRoleFromRbacGroupDocument = @"
        mutation removeRoleFromRBACGroup($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemoveRoleFromRBACGroupInput!) {
          removeRoleFromRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemoveRoleFromRbacGroupBatchResponse
    {

        [JsonProperty("removeRoleFromRBACGroupBatch")]
        public RBACGroup Result { get; set; }
    }

    public class RemoveRoleFromRbacGroupBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveRoleFromRbacGroupBatchInput Input { get; set; }

        /// <summary>
        /// RemoveRoleFromRbacGroupBatchParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveRoleFromRBACGroupBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveRoleFromRbacGroupBatchDocument,
                OperationName = "removeRoleFromRBACGroupBatch",
                Variables = this
            };
        }


        public static string RemoveRoleFromRbacGroupBatchDocument = @"
        mutation removeRoleFromRBACGroupBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemoveRoleFromRBACGroupBatchInput!) {
          removeRoleFromRBACGroupBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemoveRuleEnvResponse
    {

        [JsonProperty("removeRuleEnv")]
        public PagedRuleEnvVariable Result { get; set; }
    }

    public class RemoveRuleEnvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveRuleEnvInput Input { get; set; }

        /// <summary>
        /// RemoveRuleEnvParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveRuleEnvInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveRuleEnvDocument,
                OperationName = "removeRuleEnv",
                Variables = this
            };
        }


        public static string RemoveRuleEnvDocument = @"
        mutation removeRuleEnv($input: RemoveRuleEnvInput!) {
          removeRuleEnv(input: $input) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class RemoveSuperAdminUserResponse
    {

        [JsonProperty("removeSuperAdminUser")]
        public UsersInGroupListItem Result { get; set; }
    }

    public class RemoveSuperAdminUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// RemoveSuperAdminUserParam.Request 
        /// <para>Required variables:<br/> { _id=(string), username=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveSuperAdminUserDocument,
                OperationName = "removeSuperAdminUser",
                Variables = this
            };
        }


        public static string RemoveSuperAdminUserDocument = @"
        mutation removeSuperAdminUser($_id: String!, $username: String!) {
          removeSuperAdminUser(_id: $_id, username: $username) {
            email
            username
            _id
            upgrade
          }
        }
        ";
    }



    public class RemoveUserClientsResponse
    {

        [JsonProperty("removeUserClients")]
        public IEnumerable<UserClient> Result { get; set; }
    }

    public class RemoveUserClientsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// RemoveUserClientsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { ids=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUserClientsDocument,
                OperationName = "removeUserClients",
                Variables = this
            };
        }


        public static string RemoveUserClientsDocument = @"
        mutation removeUserClients($ids: [String]) {
          removeUserClients(ids: $ids) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class RemoveUserFromGroupResponse
    {

        [JsonProperty("removeUserFromGroup")]
        public UserGroup Result { get; set; }
    }

    public class RemoveUserFromGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// RemoveUserFromGroupParam.Request 
        /// <para>Required variables:<br/> { client=(string), user=(string), group=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUserFromGroupDocument,
                OperationName = "removeUserFromGroup",
                Variables = this
            };
        }


        public static string RemoveUserFromGroupDocument = @"
        mutation removeUserFromGroup($client: String!, $user: String!, $group: String!) {
          removeUserFromGroup(client: $client, user: $user, group: $group) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            client {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            group {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            createdAt
          }
        }
        ";
    }



    public class RemoveUserFromRbacGroupResponse
    {

        [JsonProperty("removeUserFromRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class RemoveUserFromRbacGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveUserFromRbacGroupInput Input { get; set; }

        /// <summary>
        /// RemoveUserFromRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveUserFromRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUserFromRbacGroupDocument,
                OperationName = "removeUserFromRBACGroup",
                Variables = this
            };
        }


        public static string RemoveUserFromRbacGroupDocument = @"
        mutation removeUserFromRBACGroup($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemoveUserFromRBACGroupInput!) {
          removeUserFromRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemoveUserFromRbacGroupBatchResponse
    {

        [JsonProperty("removeUserFromRBACGroupBatch")]
        public RBACGroup Result { get; set; }
    }

    public class RemoveUserFromRbacGroupBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveUserFromRbacGroupBatchInput Input { get; set; }

        /// <summary>
        /// RemoveUserFromRbacGroupBatchParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveUserFromRBACGroupBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUserFromRbacGroupBatchDocument,
                OperationName = "removeUserFromRBACGroupBatch",
                Variables = this
            };
        }


        public static string RemoveUserFromRbacGroupBatchDocument = @"
        mutation removeUserFromRBACGroupBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: RemoveUserFromRBACGroupBatchInput!) {
          removeUserFromRBACGroupBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RemoveUserMetadataResponse
    {

        [JsonProperty("removeUserMetadata")]
        public UserMetaDataList Result { get; set; }
    }

    public class RemoveUserMetadataParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RemoveUserMetadataInput Input { get; set; }

        /// <summary>
        /// RemoveUserMetadataParam.Request 
        /// <para>Required variables:<br/> { input=(RemoveUserMetadataInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUserMetadataDocument,
                OperationName = "removeUserMetadata",
                Variables = this
            };
        }


        public static string RemoveUserMetadataDocument = @"
        mutation removeUserMetadata($input: RemoveUserMetadataInput!) {
          removeUserMetadata(input: $input) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class RemoveUsersResponse
    {

        [JsonProperty("removeUsers")]
        public IEnumerable<User> Result { get; set; }
    }

    public class RemoveUsersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// RemoveUsersParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { ids=(string[]), registerInClient=(string), operator=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUsersDocument,
                OperationName = "removeUsers",
                Variables = this
            };
        }


        public static string RemoveUsersDocument = @"
        mutation removeUsers($ids: [String], $registerInClient: String, $operator: String) {
          removeUsers(ids: $ids, registerInClient: $registerInClient, operator: $operator) {
            _id
          }
        }
        ";
    }



    public class ResetPasswordResponse
    {

        [JsonProperty("changePassword")]
        public ExtendUser Result { get; set; }
    }

    public class ResetPasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// ResetPasswordParam.Request 
        /// <para>Required variables:<br/> { email=(string), clientId=(string), password=(string), verifyCode=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ResetPasswordDocument,
                OperationName = "resetPassword",
                Variables = this
            };
        }


        public static string ResetPasswordDocument = @"
        mutation resetPassword($email: String!, $clientId: String!, $password: String!, $verifyCode: String!) {
          changePassword(email: $email, client: $clientId, password: $password, verifyCode: $verifyCode) {
            _id
            email
            emailVerified
            username
            nickname
            company
            photo
            browser
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
          }
        }
        ";
    }



    public class ResetUserPoolFromWechatResponse
    {

        [JsonProperty("resetUserPoolFromWechat")]
        public PagedUsers Result { get; set; }
    }

    public class ResetUserPoolFromWechatParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("registerMethod")]
        public string RegisterMethod { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// ResetUserPoolFromWechatParam.Request 
        /// <para>Required variables:<br/> { client=(string), registerMethod=(string), limit=(int) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ResetUserPoolFromWechatDocument,
                OperationName = "resetUserPoolFromWechat",
                Variables = this
            };
        }


        public static string ResetUserPoolFromWechatDocument = @"
        mutation resetUserPoolFromWechat($client: String!, $registerMethod: String!, $limit: Int!) {
          resetUserPoolFromWechat(client: $client, registerMethod: $registerMethod, limit: $limit) {
            list {
              _id
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              username
              nickname
              company
              photo
              browser
              device
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              customData
              metadata
            }
            totalCount
          }
        }
        ";
    }



    public class RevokeRbacRoleFromUserResponse
    {

        [JsonProperty("revokeRBACRoleFromUser")]
        public RBACRole Result { get; set; }
    }

    public class RevokeRbacRoleFromUserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RevokeRbacRoleFromUserInput Input { get; set; }

        /// <summary>
        /// RevokeRbacRoleFromUserParam.Request 
        /// <para>Required variables:<br/> { input=(RevokeRBACRoleFromUserInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RevokeRbacRoleFromUserDocument,
                OperationName = "revokeRBACRoleFromUser",
                Variables = this
            };
        }


        public static string RevokeRbacRoleFromUserDocument = @"
        mutation revokeRBACRoleFromUser($sortBy: SortByEnum, $page: Int, $count: Int, $input: RevokeRBACRoleFromUserInput!) {
          revokeRBACRoleFromUser(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RevokeRbacRoleFromUserBatchResponse
    {

        [JsonProperty("revokeRBACRoleFromUserBatch")]
        public RBACRole Result { get; set; }
    }

    public class RevokeRbacRoleFromUserBatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RevokeRbacRoleFromUserBatchInput Input { get; set; }

        /// <summary>
        /// RevokeRbacRoleFromUserBatchParam.Request 
        /// <para>Required variables:<br/> { input=(RevokeRBACRoleFromUserBatchInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RevokeRbacRoleFromUserBatchDocument,
                OperationName = "revokeRBACRoleFromUserBatch",
                Variables = this
            };
        }


        public static string RevokeRbacRoleFromUserBatchDocument = @"
        mutation revokeRBACRoleFromUserBatch($sortBy: SortByEnum, $page: Int, $count: Int, $input: RevokeRBACRoleFromUserBatchInput!) {
          revokeRBACRoleFromUserBatch(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class SendChangeEmailVerifyCodeResponse
    {

        [JsonProperty("sendChangeEmailVerifyCode")]
        public CommonMessage Result { get; set; }
    }

    public class SendChangeEmailVerifyCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// SendChangeEmailVerifyCodeParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), email=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendChangeEmailVerifyCodeDocument,
                OperationName = "sendChangeEmailVerifyCode",
                Variables = this
            };
        }


        public static string SendChangeEmailVerifyCodeDocument = @"
        mutation sendChangeEmailVerifyCode($userPoolId: String!, $email: String!) {
          sendChangeEmailVerifyCode(userPoolId: $userPoolId, email: $email) {
            message
            code
            status
          }
        }
        ";
    }



    public class SendResetPasswordEmailResponse
    {

        [JsonProperty("sendResetPasswordEmail")]
        public CommonMessage Result { get; set; }
    }

    public class SendResetPasswordEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// SendResetPasswordEmailParam.Request 
        /// <para>Required variables:<br/> { client=(string), email=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendResetPasswordEmailDocument,
                OperationName = "sendResetPasswordEmail",
                Variables = this
            };
        }


        public static string SendResetPasswordEmailDocument = @"
        mutation sendResetPasswordEmail($client: String!, $email: String!) {
          sendResetPasswordEmail(client: $client, email: $email) {
            message
            code
            status
          }
        }
        ";
    }



    public class SendVerifyEmailResponse
    {

        [JsonProperty("sendVerifyEmail")]
        public CommonMessage Result { get; set; }
    }

    public class SendVerifyEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// SendVerifyEmailParam.Request 
        /// <para>Required variables:<br/> { email=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { token=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendVerifyEmailDocument,
                OperationName = "sendVerifyEmail",
                Variables = this
            };
        }


        public static string SendVerifyEmailDocument = @"
        mutation sendVerifyEmail($email: String!, $client: String!, $token: String) {
          sendVerifyEmail(email: $email, client: $client, token: $token) {
            message
            code
            status
          }
        }
        ";
    }



    public class SetInvitationStateResponse
    {

        [JsonProperty("setInvitationState")]
        public InvitationState Result { get; set; }
    }

    public class SetInvitationStateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enablePhone")]
        public bool EnablePhone { get; set; }

        /// <summary>
        /// SetInvitationStateParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { enablePhone=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SetInvitationStateDocument,
                OperationName = "setInvitationState",
                Variables = this
            };
        }


        public static string SetInvitationStateDocument = @"
        mutation setInvitationState($client: String!, $enablePhone: Boolean) {
          setInvitationState(client: $client, enablePhone: $enablePhone) {
            client
            enablePhone
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class SetRuleEnvResponse
    {

        [JsonProperty("setRuleEnv")]
        public PagedRuleEnvVariable Result { get; set; }
    }

    public class SetRuleEnvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public SetRuleEnvInput Input { get; set; }

        /// <summary>
        /// SetRuleEnvParam.Request 
        /// <para>Required variables:<br/> { input=(SetRuleEnvInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SetRuleEnvDocument,
                OperationName = "setRuleEnv",
                Variables = this
            };
        }


        public static string SetRuleEnvDocument = @"
        mutation setRuleEnv($input: SetRuleEnvInput!) {
          setRuleEnv(input: $input) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class SetUserMetadataResponse
    {

        [JsonProperty("setUserMetadata")]
        public UserMetaDataList Result { get; set; }
    }

    public class SetUserMetadataParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public SetUserMetadataInput Input { get; set; }

        /// <summary>
        /// SetUserMetadataParam.Request 
        /// <para>Required variables:<br/> { input=(SetUserMetadataInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SetUserMetadataDocument,
                OperationName = "setUserMetadata",
                Variables = this
            };
        }


        public static string SetUserMetadataDocument = @"
        mutation setUserMetadata($input: SetUserMetadataInput!) {
          setUserMetadata(input: $input) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class SignInResponse
    {

        [JsonProperty("signIn")]
        public OidcPasswordModeUserInfo Result { get; set; }
    }

    public class SignInParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oidcAppId")]
        public string OidcAppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// SignInParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { oidcAppId=(string), userPoolId=(string), email=(string), password=(string), phone=(string), unionid=(string), username=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SignInDocument,
                OperationName = "signIn",
                Variables = this
            };
        }


        public static string SignInDocument = @"
        mutation signIn($oidcAppId: String, $userPoolId: String, $email: String, $password: String, $phone: String, $unionid: String, $username: String) {
          signIn(oidcAppId: $oidcAppId, userPoolId: $userPoolId, email: $email, password: $password, phone: $phone, unionid: $unionid, username: $username) {
            sub
            birthdate
            family_name
            gender
            given_name
            locale
            middle_name
            name
            nickname
            picture
            preferred_username
            profile
            updated_at
            website
            zoneinfo
            username
            _id
            company
            browser
            device
            logins_count
            register_method
            blocked
            last_ip
            register_in_userpool
            last_login
            signed_up
            email
            email_verified
            phone_number
            phone_number_verified
            token
            access_token
            id_token
            refresh_token
            expires_in
            token_type
            scope
          }
        }
        ";
    }



    public class UnbindEmailResponse
    {

        [JsonProperty("unbindEmail")]
        public User Result { get; set; }
    }

    public class UnbindEmailParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// UnbindEmailParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { user=(string), client=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UnbindEmailDocument,
                OperationName = "unbindEmail",
                Variables = this
            };
        }


        public static string UnbindEmailDocument = @"
        mutation unbindEmail($user: String, $client: String) {
          unbindEmail(user: $user, client: $client) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class UnbindOtherOAuthResponse
    {

        [JsonProperty("unbindOtherOAuth")]
        public UserOAuthBind Result { get; set; }
    }

    public class UnbindOtherOAuthParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// UnbindOtherOAuthParam.Request 
        /// <para>Required variables:<br/> { type=(string) }</para>
        /// <para>Optional variables:<br/> { client=(string), user=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UnbindOtherOAuthDocument,
                OperationName = "unbindOtherOAuth",
                Variables = this
            };
        }


        public static string UnbindOtherOAuthDocument = @"
        mutation unbindOtherOAuth($type: String!, $client: String, $user: String) {
          unbindOtherOAuth(type: $type, client: $client, user: $user) {
            _id
            user
            client
            type
            unionid
            userInfo
            createdAt
          }
        }
        ";
    }



    public class UpdateAdConnectorResponse
    {

        [JsonProperty("updateAdConnector")]
        public ADConnector Result { get; set; }
    }

    public class UpdateAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// UpdateAdConnectorParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> { name=(string), logo=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateAdConnectorDocument,
                OperationName = "updateAdConnector",
                Variables = this
            };
        }


        public static string UpdateAdConnectorDocument = @"
        mutation updateAdConnector($_id: String!, $name: String, $logo: String) {
          updateAdConnector(_id: $_id, name: $name, logo: $logo) {
            _id
            name
            secret
            salt
            logo
            enabled
            userPoolId
            status
            createdAt
          }
        }
        ";
    }



    public class UpdateClientWebhookResponse
    {

        [JsonProperty("updateClientWebhook")]
        public ClientWebhook Result { get; set; }
    }

    public class UpdateClientWebhookParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("events")]
        public string Events { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("contentType")]
        public string ContentType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("isLastTimeSuccess")]
        public bool IsLastTimeSuccess { get; set; }

        /// <summary>
        /// UpdateClientWebhookParam.Request 
        /// <para>Required variables:<br/> { id=(string), events=(string[]), url=(string), contentType=(string), enable=(bool) }</para>
        /// <para>Optional variables:<br/> { secret=(string), isLastTimeSuccess=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateClientWebhookDocument,
                OperationName = "updateClientWebhook",
                Variables = this
            };
        }


        public static string UpdateClientWebhookDocument = @"
        mutation updateClientWebhook($id: String!, $events: [String!]!, $url: String!, $contentType: String!, $enable: Boolean!, $secret: String, $isLastTimeSuccess: Boolean) {
          updateClientWebhook(id: $id, events: $events, url: $url, contentType: $contentType, enable: $enable, secret: $secret, isLastTimeSuccess: $isLastTimeSuccess) {
            _id
            client
            events {
              name
              label
              description
            }
            url
            isLastTimeSuccess
            contentType
            secret
            enable
          }
        }
        ";
    }



    public class UpdateCollaboratorResponse
    {

        [JsonProperty("updateCollaborator")]
        public Collaboration Result { get; set; }
    }

    public class UpdateCollaboratorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("collaborationId")]
        public string CollaborationId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("permissionDescriptors")]
        public PermissionDescriptorsInputType PermissionDescriptors { get; set; }

        /// <summary>
        /// UpdateCollaboratorParam.Request 
        /// <para>Required variables:<br/> { collaborationId=(string), permissionDescriptors=(PermissionDescriptorsInputType[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateCollaboratorDocument,
                OperationName = "updateCollaborator",
                Variables = this
            };
        }


        public static string UpdateCollaboratorDocument = @"
        mutation updateCollaborator($collaborationId: String!, $permissionDescriptors: [PermissionDescriptorsInputType]!) {
          updateCollaborator(collaborationId: $collaborationId, permissionDescriptors: $permissionDescriptors) {
            _id
            createdAt
            owner {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            collaborator {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            userPool {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            permissionDescriptors {
              permissionId
              name
              operationAllow
            }
          }
        }
        ";
    }



    public class UpdateEmailResponse
    {

        [JsonProperty("updateEmail")]
        public User Result { get; set; }
    }

    public class UpdateEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("emailCode")]
        public string EmailCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oldEmail")]
        public string OldEmail { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oldEmailCode")]
        public string OldEmailCode { get; set; }

        /// <summary>
        /// UpdateEmailParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), email=(string), emailCode=(string) }</para>
        /// <para>Optional variables:<br/> { oldEmail=(string), oldEmailCode=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateEmailDocument,
                OperationName = "updateEmail",
                Variables = this
            };
        }


        public static string UpdateEmailDocument = @"
        mutation updateEmail($userPoolId: String!, $email: String!, $emailCode: String!, $oldEmail: String, $oldEmailCode: String) {
          updateEmail(userPoolId: $userPoolId, email: $email, emailCode: $emailCode, oldEmail: $oldEmail, oldEmailCode: $oldEmailCode) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class UpdatePasswordStrengthSettingsByUserPoolIdResponse
    {

        [JsonProperty("updatePasswordStrengthSettingsByUserPoolId")]
        public PasswordStrengthSettings Result { get; set; }
    }

    public class UpdatePasswordStrengthSettingsByUserPoolIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("pwdStrength")]
        public int PwdStrength { get; set; }

        /// <summary>
        /// UpdatePasswordStrengthSettingsByUserPoolIdParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { pwdStrength=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdatePasswordStrengthSettingsByUserPoolIdDocument,
                OperationName = "updatePasswordStrengthSettingsByUserPoolId",
                Variables = this
            };
        }


        public static string UpdatePasswordStrengthSettingsByUserPoolIdDocument = @"
        mutation updatePasswordStrengthSettingsByUserPoolId($userPoolId: String!, $pwdStrength: Int) {
          updatePasswordStrengthSettingsByUserPoolId(userPoolId: $userPoolId, pwdStrength: $pwdStrength) {
            userPoolId
            pwdStrength
          }
        }
        ";
    }



    public class UpdatePermissionsResponse
    {

        [JsonProperty("updatePermissions")]
        public Group Result { get; set; }
    }

    public class UpdatePermissionsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// UpdatePermissionsParam.Request 
        /// <para>Required variables:<br/> { role=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { permissions=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdatePermissionsDocument,
                OperationName = "updatePermissions",
                Variables = this
            };
        }


        public static string UpdatePermissionsDocument = @"
        mutation updatePermissions($role: String!, $client: String!, $permissions: String) {
          updatePermissions(role: $role, client: $client, permissions: $permissions) {
            _id
            name
            descriptions
            client
            permissions
            createdAt
          }
        }
        ";
    }



    public class UpdatePhoneResponse
    {

        [JsonProperty("updatePhone")]
        public User Result { get; set; }
    }

    public class UpdatePhoneParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oldPhone")]
        public string OldPhone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oldPhoneCode")]
        public string OldPhoneCode { get; set; }

        /// <summary>
        /// UpdatePhoneParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), phone=(string), phoneCode=(string) }</para>
        /// <para>Optional variables:<br/> { oldPhone=(string), oldPhoneCode=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdatePhoneDocument,
                OperationName = "updatePhone",
                Variables = this
            };
        }


        public static string UpdatePhoneDocument = @"
        mutation updatePhone($userPoolId: String!, $phone: String!, $phoneCode: String!, $oldPhone: String, $oldPhoneCode: String) {
          updatePhone(userPoolId: $userPoolId, phone: $phone, phoneCode: $phoneCode, oldPhone: $oldPhone, oldPhoneCode: $oldPhoneCode) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class UpdateRbacGroupResponse
    {

        [JsonProperty("updateRBACGroup")]
        public RBACGroup Result { get; set; }
    }

    public class UpdateRbacGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateRbacGroupInput Input { get; set; }

        /// <summary>
        /// UpdateRbacGroupParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateRBACGroupInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRbacGroupDocument,
                OperationName = "updateRBACGroup",
                Variables = this
            };
        }


        public static string UpdateRbacGroupDocument = @"
        mutation updateRBACGroup($sortBy: SortByEnum, $page: Int, $count: Int, $input: UpdateRBACGroupInput!) {
          updateRBACGroup(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class UpdateRbacPermissionResponse
    {

        [JsonProperty("updateRBACPermission")]
        public RBACPermission Result { get; set; }
    }

    public class UpdateRbacPermissionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateRbacPermissionInput Input { get; set; }

        /// <summary>
        /// UpdateRbacPermissionParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateRBACPermissionInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRbacPermissionDocument,
                OperationName = "updateRBACPermission",
                Variables = this
            };
        }


        public static string UpdateRbacPermissionDocument = @"
        mutation updateRBACPermission($input: UpdateRBACPermissionInput!) {
          updateRBACPermission(input: $input) {
            _id
            name
            userPoolId
            createdAt
            updatedAt
            description
          }
        }
        ";
    }



    public class UpdateRbacRoleResponse
    {

        [JsonProperty("updateRBACRole")]
        public RBACRole Result { get; set; }
    }

    public class UpdateRbacRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateRbacRoleInput Input { get; set; }

        /// <summary>
        /// UpdateRbacRoleParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateRBACRoleInput) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRbacRoleDocument,
                OperationName = "updateRBACRole",
                Variables = this
            };
        }


        public static string UpdateRbacRoleDocument = @"
        mutation updateRBACRole($sortBy: SortByEnum, $page: Int, $count: Int, $input: UpdateRBACRoleInput!) {
          updateRBACRole(input: $input) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class UpdateRoleResponse
    {

        [JsonProperty("updateRole")]
        public Group Result { get; set; }
    }

    public class UpdateRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("descriptions")]
        public string Descriptions { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("permissions")]
        public string Permissions { get; set; }

        /// <summary>
        /// UpdateRoleParam.Request 
        /// <para>Required variables:<br/> { _id=(string), client=(string), name=(string) }</para>
        /// <para>Optional variables:<br/> { descriptions=(string), permissions=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRoleDocument,
                OperationName = "updateRole",
                Variables = this
            };
        }


        public static string UpdateRoleDocument = @"
        mutation updateRole($_id: String!, $client: String!, $name: String!, $descriptions: String, $permissions: String) {
          updateRole(_id: $_id, client: $client, name: $name, descriptions: $descriptions, permissions: $permissions) {
            _id
            name
            descriptions
            client
            permissions
            createdAt
          }
        }
        ";
    }



    public class UpdateRuleResponse
    {

        [JsonProperty("updateRule")]
        public Rule Result { get; set; }
    }

    public class UpdateRuleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateRuleInput Input { get; set; }

        /// <summary>
        /// UpdateRuleParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateRuleInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRuleDocument,
                OperationName = "updateRule",
                Variables = this
            };
        }


        public static string UpdateRuleDocument = @"
        mutation updateRule($input: UpdateRuleInput!) {
          updateRule(input: $input) {
            _id
            userPoolId
            name
            description
            type
            enabled
            faasUrl
            code
            order
            async
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class UpdateRuleOrderResponse
    {

        [JsonProperty("updateRuleOrder")]
        public CommonMessage Result { get; set; }
    }

    public class UpdateRuleOrderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateRuleOrderInput Input { get; set; }

        /// <summary>
        /// UpdateRuleOrderParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateRuleOrderInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateRuleOrderDocument,
                OperationName = "updateRuleOrder",
                Variables = this
            };
        }


        public static string UpdateRuleOrderDocument = @"
        mutation updateRuleOrder($input: UpdateRuleOrderInput!) {
          updateRuleOrder(input: $input) {
            message
            code
            status
          }
        }
        ";
    }



    public class UpdateSuperAdminUserResponse
    {

        [JsonProperty("updateSuperAdminUser")]
        public UsersInGroupListItem Result { get; set; }
    }

    public class UpdateSuperAdminUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public SuperAdminUpdateInput Options { get; set; }

        /// <summary>
        /// UpdateSuperAdminUserParam.Request 
        /// <para>Required variables:<br/> { options=(SuperAdminUpdateInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateSuperAdminUserDocument,
                OperationName = "updateSuperAdminUser",
                Variables = this
            };
        }


        public static string UpdateSuperAdminUserDocument = @"
        mutation updateSuperAdminUser($options: SuperAdminUpdateInput!) {
          updateSuperAdminUser(options: $options) {
            email
            username
            _id
            upgrade
          }
        }
        ";
    }



    public class UpdateUserResponse
    {

        [JsonProperty("updateUser")]
        public User Result { get; set; }
    }

    public class UpdateUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("options")]
        public UserUpdateInput Options { get; set; }

        /// <summary>
        /// UpdateUserParam.Request 
        /// <para>Required variables:<br/> { options=(UserUpdateInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateUserDocument,
                OperationName = "updateUser",
                Variables = this
            };
        }


        public static string UpdateUserDocument = @"
        mutation updateUser($options: UserUpdateInput!) {
          updateUser(options: $options) {
            _id
            username
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            nickname
            company
            photo
            browser
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            device
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            thirdPartyIdentity {
              provider
              refreshToken
              accessToken
              expiresIn
              updatedAt
            }
            oldPassword
            metadata
          }
        }
        ";
    }



    public class UpdateUserClientResponse
    {

        [JsonProperty("updateUserClient")]
        public UserClient Result { get; set; }
    }

    public class UpdateUserClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public UpdateUserClientInput Client { get; set; }

        /// <summary>
        /// UpdateUserClientParam.Request 
        /// <para>Required variables:<br/> { client=(UpdateUserClientInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateUserClientDocument,
                OperationName = "updateUserClient",
                Variables = this
            };
        }


        public static string UpdateUserClientDocument = @"
        mutation updateUserClient($client: UpdateUserClientInput!) {
          updateUserClient(client: $client) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class VerifyResetPasswordVerifyCodeResponse
    {

        [JsonProperty("verifyResetPasswordVerifyCode")]
        public CommonMessage Result { get; set; }
    }

    public class VerifyResetPasswordVerifyCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("verifyCode")]
        public string VerifyCode { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// VerifyResetPasswordVerifyCodeParam.Request 
        /// <para>Required variables:<br/> { verifyCode=(string), email=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = VerifyResetPasswordVerifyCodeDocument,
                OperationName = "verifyResetPasswordVerifyCode",
                Variables = this
            };
        }


        public static string VerifyResetPasswordVerifyCodeDocument = @"
        mutation verifyResetPasswordVerifyCode($verifyCode: String!, $email: String!, $client: String!) {
          verifyResetPasswordVerifyCode(verifyCode: $verifyCode, email: $email, client: $client) {
            message
            code
            status
          }
        }
        ";
    }



    public class GetOidcAppInfoResponse
    {

        [JsonProperty("GetOIDCAppInfo")]
        public OIDCProviderClient Result { get; set; }
    }

    public class GetOidcAppInfoParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// GetOidcAppInfoParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetOidcAppInfoDocument,
                OperationName = "GetOIDCAppInfo",
                Variables = this
            };
        }


        public static string GetOidcAppInfoDocument = @"
        query GetOIDCAppInfo($appId: String!) {
          GetOIDCAppInfo(appId: $appId) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class GetOidcAppListResponse
    {

        [JsonProperty("GetOIDCAppList")]
        public OIDCAppPagedList Result { get; set; }
    }

    public class GetOidcAppListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetOidcAppListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetOidcAppListDocument,
                OperationName = "GetOIDCAppList",
                Variables = this
            };
        }


        public static string GetOidcAppListDocument = @"
        query GetOIDCAppList($clientId: String, $page: Int, $count: Int) {
          GetOIDCAppList(clientId: $clientId, page: $page, count: $count) {
            totalCount
            list {
              _id
              name
              domain
              image
              redirect_uris
              client_id
              client_secret
              token_endpoint_auth_method
              id_token_signed_response_alg
              id_token_encrypted_response_alg
              id_token_encrypted_response_enc
              userinfo_signed_response_alg
              userinfo_encrypted_response_alg
              userinfo_encrypted_response_enc
              request_object_signing_alg
              request_object_encryption_alg
              request_object_encryption_enc
              jwks_uri
              _jwks_uri
              custom_jwks
              jwks
              _jwks
              clientId
              grant_types
              response_types
              description
              homepageURL
              isDeleted
              isDefault
              when
              css
              authorization_code_expire
              id_token_expire
              access_token_expire
              cas_expire
              loginUrl
            }
          }
        }
        ";
    }



    public class GetSamlIdentityProviderInfoResponse
    {

        [JsonProperty("GetSAMLIdentityProviderInfo")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class GetSamlIdentityProviderInfoParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// GetSamlIdentityProviderInfoParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetSamlIdentityProviderInfoDocument,
                OperationName = "GetSAMLIdentityProviderInfo",
                Variables = this
            };
        }


        public static string GetSamlIdentityProviderInfoDocument = @"
        query GetSAMLIdentityProviderInfo($appId: String!) {
          GetSAMLIdentityProviderInfo(appId: $appId) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class GetSamlIdentityProviderListResponse
    {

        [JsonProperty("GetSAMLIdentityProviderList")]
        public SAMLIdentityProviderAppPagedList Result { get; set; }
    }

    public class GetSamlIdentityProviderListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetSamlIdentityProviderListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetSamlIdentityProviderListDocument,
                OperationName = "GetSAMLIdentityProviderList",
                Variables = this
            };
        }


        public static string GetSamlIdentityProviderListDocument = @"
        query GetSAMLIdentityProviderList($clientId: String, $page: Int, $count: Int) {
          GetSAMLIdentityProviderList(clientId: $clientId, page: $page, count: $count) {
            totalCount
            list {
              _id
              name
              domain
              image
              appSecret
              appId
              clientId
              description
              isDeleted
              enabled
              when
              SPMetadata
              attributeNameFormat
              customAttributes
              emailDomainTransformation
              authnContextClassRef
              IdPMetadata
              assertionConsumerUrl
              bindings
              nameIds
              attributes
              enableSignRes
              resSignAlgorithm
              resAbstractAlgorithm
              resSignPublicKey
              resSignPrivateKey
              resSignPrivateKeyPass
              enableSignReq
              reqSignPublicKey
              enableEncryptRes
              resEncryptPublicKey
              css
            }
          }
        }
        ";
    }



    public class GetSamlServiceProviderInfoResponse
    {

        [JsonProperty("GetSAMLServiceProviderInfo")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class GetSamlServiceProviderInfoParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// GetSamlServiceProviderInfoParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetSamlServiceProviderInfoDocument,
                OperationName = "GetSAMLServiceProviderInfo",
                Variables = this
            };
        }


        public static string GetSamlServiceProviderInfoDocument = @"
        query GetSAMLServiceProviderInfo($appId: String!) {
          GetSAMLServiceProviderInfo(appId: $appId) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class GetSamlServiceProviderListResponse
    {

        [JsonProperty("GetSAMLServiceProviderList")]
        public SAMLServiceProviderAppPagedList Result { get; set; }
    }

    public class GetSamlServiceProviderListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetSamlServiceProviderListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetSamlServiceProviderListDocument,
                OperationName = "GetSAMLServiceProviderList",
                Variables = this
            };
        }


        public static string GetSamlServiceProviderListDocument = @"
        query GetSAMLServiceProviderList($clientId: String, $page: Int, $count: Int) {
          GetSAMLServiceProviderList(clientId: $clientId, page: $page, count: $count) {
            totalCount
            list {
              _id
              name
              domain
              image
              appSecret
              defaultIdPMapId
              appId
              clientId
              description
              isDeleted
              enabled
              when
              SPMetadata
              IdPMetadata
              IdPEntityID
              redirectUrl
              loginUrl
              logoutUrl
              nameId
              enableSignRes
              resSignPublicKey
              hasResEncrypted
              resEncryptAlgorithm
              resAbstractAlgorithm
              resDecryptPrivateKey
              resDecryptPrivateKeyPass
              resEncryptPublicKey
              enableSignReq
              reqSignAlgorithm
              reqAbstractAlgorithm
              reqSignPrivateKey
              reqSignPrivateKeyPass
              reqSignPublicKey
              SPUrl
            }
          }
        }
        ";
    }



    public class GetUserAuthorizedAppsResponse
    {

        [JsonProperty("GetUserAuthorizedApps")]
        public UserAuthorizedAppPagedList Result { get; set; }
    }

    public class GetUserAuthorizedAppsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetUserAuthorizedAppsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), userId=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetUserAuthorizedAppsDocument,
                OperationName = "GetUserAuthorizedApps",
                Variables = this
            };
        }


        public static string GetUserAuthorizedAppsDocument = @"
        query GetUserAuthorizedApps($clientId: String, $userId: String, $page: Int, $count: Int) {
          GetUserAuthorizedApps(clientId: $clientId, userId: $userId, page: $page, count: $count) {
            totalCount
            OAuthApps {
              _id
              name
              domain
              image
              redirectUris
              appSecret
              client_id
              clientId
              grants
              description
              homepageURL
              isDeleted
              when
              css
              loginUrl
              casExpire
            }
            OIDCApps {
              _id
              name
              domain
              image
              redirect_uris
              client_id
              client_secret
              token_endpoint_auth_method
              id_token_signed_response_alg
              id_token_encrypted_response_alg
              id_token_encrypted_response_enc
              userinfo_signed_response_alg
              userinfo_encrypted_response_alg
              userinfo_encrypted_response_enc
              request_object_signing_alg
              request_object_encryption_alg
              request_object_encryption_enc
              jwks_uri
              _jwks_uri
              custom_jwks
              jwks
              _jwks
              clientId
              grant_types
              response_types
              description
              homepageURL
              isDeleted
              isDefault
              when
              css
              authorization_code_expire
              id_token_expire
              access_token_expire
              cas_expire
              loginUrl
            }
          }
        }
        ";
    }



    public class PreviewEmailByTypeResponse
    {

        [JsonProperty("PreviewEmailByType")]
        public string Result { get; set; }
    }

    public class PreviewEmailByTypeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("meta_data")]
        public string Meta_Data { get; set; }

        /// <summary>
        /// PreviewEmailByTypeParam.Request 
        /// <para>Required variables:<br/> { type=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { meta_data=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PreviewEmailByTypeDocument,
                OperationName = "PreviewEmailByType",
                Variables = this
            };
        }


        public static string PreviewEmailByTypeDocument = @"
        query PreviewEmailByType($type: String!, $client: String!, $meta_data: String) {
          PreviewEmailByType(type: $type, client: $client, meta_data: $meta_data)
        }
        ";
    }



    public class QueryAppInfoByAppIdResponse
    {

        [JsonProperty("QueryAppInfoByAppID")]
        public OAuthProviderClient Result { get; set; }
    }

    public class QueryAppInfoByAppIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("responseType")]
        public string ResponseType { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// QueryAppInfoByAppIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string), responseType=(string), redirectUrl=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryAppInfoByAppIdDocument,
                OperationName = "QueryAppInfoByAppID",
                Variables = this
            };
        }


        public static string QueryAppInfoByAppIdDocument = @"
        query QueryAppInfoByAppID($appId: String, $responseType: String, $redirectUrl: String) {
          QueryAppInfoByAppID(appId: $appId, responseType: $responseType, redirectUrl: $redirectUrl) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class QueryAppInfoByDomainResponse
    {

        [JsonProperty("QueryAppInfoByDomain")]
        public OAuthProviderClient Result { get; set; }
    }

    public class QueryAppInfoByDomainParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// QueryAppInfoByDomainParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { domain=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryAppInfoByDomainDocument,
                OperationName = "QueryAppInfoByDomain",
                Variables = this
            };
        }


        public static string QueryAppInfoByDomainDocument = @"
        query QueryAppInfoByDomain($domain: String) {
          QueryAppInfoByDomain(domain: $domain) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class QueryClientHasLdapConfigsResponse
    {

        [JsonProperty("QueryClientHasLDAPConfigs")]
        public ClientHasLDAPConfigs Result { get; set; }
    }

    public class QueryClientHasLdapConfigsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// QueryClientHasLdapConfigsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryClientHasLdapConfigsDocument,
                OperationName = "QueryClientHasLDAPConfigs",
                Variables = this
            };
        }


        public static string QueryClientHasLdapConfigsDocument = @"
        query QueryClientHasLDAPConfigs($clientId: String) {
          QueryClientHasLDAPConfigs(clientId: $clientId) {
            result
          }
        }
        ";
    }



    public class QueryClientIdByAppIdResponse
    {

        [JsonProperty("QueryClientIdByAppId")]
        public OAuthProviderClient Result { get; set; }
    }

    public class QueryClientIdByAppIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// QueryClientIdByAppIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryClientIdByAppIdDocument,
                OperationName = "QueryClientIdByAppId",
                Variables = this
            };
        }


        public static string QueryClientIdByAppIdDocument = @"
        query QueryClientIdByAppId($appId: String) {
          QueryClientIdByAppId(appId: $appId) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class QueryDefaultSamlIdentityProviderSettingsListResponse
    {

        [JsonProperty("QueryDefaultSAMLIdentityProviderSettingsList")]
        public SAMLDefaultIdentityProviderSettingsList Result { get; set; }
    }

    public class QueryDefaultSamlIdentityProviderSettingsListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryDefaultSamlIdentityProviderSettingsListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryDefaultSamlIdentityProviderSettingsListDocument,
                OperationName = "QueryDefaultSAMLIdentityProviderSettingsList",
                Variables = this
            };
        }


        public static string QueryDefaultSamlIdentityProviderSettingsListDocument = @"
        query QueryDefaultSAMLIdentityProviderSettingsList($page: Int, $count: Int) {
          QueryDefaultSAMLIdentityProviderSettingsList(page: $page, count: $count) {
            list {
              _id
              name
              image
              description
              isDeleted
            }
            totalCount
          }
        }
        ";
    }



    public class QueryLdapServerListResponse
    {

        [JsonProperty("QueryLDAPServerList")]
        public LDAPServerList Result { get; set; }
    }

    public class QueryLdapServerListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryLdapServerListParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryLdapServerListDocument,
                OperationName = "QueryLDAPServerList",
                Variables = this
            };
        }


        public static string QueryLdapServerListDocument = @"
        query QueryLDAPServerList($clientId: String!, $page: Int, $count: Int) {
          QueryLDAPServerList(clientId: $clientId, page: $page, count: $count) {
            list {
              _id
              name
              clientId
              userId
              ldapLink
              baseDN
              searchStandard
              emailPostfix
              username
              password
              description
              enabled
              isDeleted
              createdAt
              updatedAt
            }
            totalCount
          }
        }
        ";
    }



    public class QueryOidcAppInfoByAppIdResponse
    {

        [JsonProperty("QueryOIDCAppInfoByAppID")]
        public OIDCProviderClient Result { get; set; }
    }

    public class QueryOidcAppInfoByAppIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("responseType")]
        public string ResponseType { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("redirectUrl")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// QueryOidcAppInfoByAppIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string), responseType=(string), redirectUrl=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryOidcAppInfoByAppIdDocument,
                OperationName = "QueryOIDCAppInfoByAppID",
                Variables = this
            };
        }


        public static string QueryOidcAppInfoByAppIdDocument = @"
        query QueryOIDCAppInfoByAppID($appId: String, $responseType: String, $redirectUrl: String) {
          QueryOIDCAppInfoByAppID(appId: $appId, responseType: $responseType, redirectUrl: $redirectUrl) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class QueryOidcAppInfoByDomainResponse
    {

        [JsonProperty("QueryOIDCAppInfoByDomain")]
        public OIDCProviderClient Result { get; set; }
    }

    public class QueryOidcAppInfoByDomainParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// QueryOidcAppInfoByDomainParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { domain=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryOidcAppInfoByDomainDocument,
                OperationName = "QueryOIDCAppInfoByDomain",
                Variables = this
            };
        }


        public static string QueryOidcAppInfoByDomainDocument = @"
        query QueryOIDCAppInfoByDomain($domain: String) {
          QueryOIDCAppInfoByDomain(domain: $domain) {
            _id
            name
            domain
            image
            redirect_uris
            client_id
            client_secret
            token_endpoint_auth_method
            id_token_signed_response_alg
            id_token_encrypted_response_alg
            id_token_encrypted_response_enc
            userinfo_signed_response_alg
            userinfo_encrypted_response_alg
            userinfo_encrypted_response_enc
            request_object_signing_alg
            request_object_encryption_alg
            request_object_encryption_enc
            jwks_uri
            _jwks_uri
            custom_jwks
            jwks
            _jwks
            clientId
            grant_types
            response_types
            description
            homepageURL
            isDeleted
            isDefault
            when
            css
            authorization_code_expire
            id_token_expire
            access_token_expire
            cas_expire
            loginUrl
            customStyles {
              forceLogin
              hideQRCode
              hideUP
              hideUsername
              hideRegister
              hidePhone
              hideSocial
              hideClose
              hidePhonePassword
              defaultLoginMethod
            }
          }
        }
        ";
    }



    public class QuerySamlIdentityProviderInfoByAppIdResponse
    {

        [JsonProperty("QuerySAMLIdentityProviderInfoByAppID")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class QuerySamlIdentityProviderInfoByAppIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// QuerySamlIdentityProviderInfoByAppIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySamlIdentityProviderInfoByAppIdDocument,
                OperationName = "QuerySAMLIdentityProviderInfoByAppID",
                Variables = this
            };
        }


        public static string QuerySamlIdentityProviderInfoByAppIdDocument = @"
        query QuerySAMLIdentityProviderInfoByAppID($appId: String) {
          QuerySAMLIdentityProviderInfoByAppID(appId: $appId) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class QuerySamlIdentityProviderInfoByDomainResponse
    {

        [JsonProperty("QuerySAMLIdentityProviderInfoByDomain")]
        public SAMLIdentityProviderClient Result { get; set; }
    }

    public class QuerySamlIdentityProviderInfoByDomainParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// QuerySamlIdentityProviderInfoByDomainParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { domain=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySamlIdentityProviderInfoByDomainDocument,
                OperationName = "QuerySAMLIdentityProviderInfoByDomain",
                Variables = this
            };
        }


        public static string QuerySamlIdentityProviderInfoByDomainDocument = @"
        query QuerySAMLIdentityProviderInfoByDomain($domain: String) {
          QuerySAMLIdentityProviderInfoByDomain(domain: $domain) {
            _id
            name
            domain
            image
            appSecret
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            attributeNameFormat
            customAttributes
            emailDomainTransformation
            authnContextClassRef
            IdPMetadata
            assertionConsumerUrl
            bindings
            nameIds
            attributes
            enableSignRes
            resSignAlgorithm
            resAbstractAlgorithm
            resSignPublicKey
            resSignPrivateKey
            resSignPrivateKeyPass
            enableSignReq
            reqSignPublicKey
            enableEncryptRes
            resEncryptPublicKey
            css
          }
        }
        ";
    }



    public class QuerySamlServiceProviderInfoByAppIdResponse
    {

        [JsonProperty("QuerySAMLServiceProviderInfoByAppID")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class QuerySamlServiceProviderInfoByAppIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// QuerySamlServiceProviderInfoByAppIdParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySamlServiceProviderInfoByAppIdDocument,
                OperationName = "QuerySAMLServiceProviderInfoByAppID",
                Variables = this
            };
        }


        public static string QuerySamlServiceProviderInfoByAppIdDocument = @"
        query QuerySAMLServiceProviderInfoByAppID($appId: String!) {
          QuerySAMLServiceProviderInfoByAppID(appId: $appId) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class QuerySamlServiceProviderInfoByDomainResponse
    {

        [JsonProperty("QuerySAMLServiceProviderInfoByDomain")]
        public SAMLServiceProviderClient Result { get; set; }
    }

    public class QuerySamlServiceProviderInfoByDomainParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// QuerySamlServiceProviderInfoByDomainParam.Request 
        /// <para>Required variables:<br/> { domain=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySamlServiceProviderInfoByDomainDocument,
                OperationName = "QuerySAMLServiceProviderInfoByDomain",
                Variables = this
            };
        }


        public static string QuerySamlServiceProviderInfoByDomainDocument = @"
        query QuerySAMLServiceProviderInfoByDomain($domain: String!) {
          QuerySAMLServiceProviderInfoByDomain(domain: $domain) {
            _id
            name
            domain
            image
            appSecret
            defaultIdPMap {
              _id
              name
              image
              description
              isDeleted
            }
            defaultIdPMapId
            appId
            clientId
            description
            isDeleted
            enabled
            when
            SPMetadata
            IdPMetadata
            IdPEntityID
            assertionConsumeService {
              binding
              url
              isDefault
            }
            mappings {
              username
              nickname
              photo
              company
              providerName
              email
            }
            redirectUrl
            loginUrl
            logoutUrl
            nameId
            enableSignRes
            resSignPublicKey
            hasResEncrypted
            resEncryptAlgorithm
            resAbstractAlgorithm
            resDecryptPrivateKey
            resDecryptPrivateKeyPass
            resEncryptPublicKey
            enableSignReq
            reqSignAlgorithm
            reqAbstractAlgorithm
            reqSignPrivateKey
            reqSignPrivateKeyPass
            reqSignPublicKey
            SPUrl
          }
        }
        ";
    }



    public class ReadEmailProviderResponse
    {

        [JsonProperty("ReadEmailProvider")]
        public IEnumerable<EmailProviderList> Result { get; set; }
    }

    public class ReadEmailProviderParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// ReadEmailProviderParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailProviderDocument,
                OperationName = "ReadEmailProvider",
                Variables = this
            };
        }


        public static string ReadEmailProviderDocument = @"
        query ReadEmailProvider($clientId: String) {
          ReadEmailProvider(clientId: $clientId) {
            _id
            name
            image
            description
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            client
            user
            status
            provider {
              _id
              name
              image
              description
              client
              user
              status
            }
          }
        }
        ";
    }



    public class ReadEmailProviderByClientAndNameResponse
    {

        [JsonProperty("ReadEmailProviderByClientAndName")]
        public IEnumerable<EmailProviderWithClientList> Result { get; set; }
    }

    public class ReadEmailProviderByClientAndNameParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// ReadEmailProviderByClientAndNameParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailProviderByClientAndNameDocument,
                OperationName = "ReadEmailProviderByClientAndName",
                Variables = this
            };
        }


        public static string ReadEmailProviderByClientAndNameDocument = @"
        query ReadEmailProviderByClientAndName($clientId: String) {
          ReadEmailProviderByClientAndName(clientId: $clientId) {
            _id
            user
            client
            status
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            provider {
              _id
              name
              image
              description
            }
          }
        }
        ";
    }



    public class ReadEmailProviderWithClientResponse
    {

        [JsonProperty("ReadEmailProviderWithClient")]
        public IEnumerable<EmailProviderWithClientList> Result { get; set; }
    }

    public class ReadEmailProviderWithClientParam
    {


        /// <summary>
        /// ReadEmailProviderWithClientParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailProviderWithClientDocument,
                OperationName = "ReadEmailProviderWithClient"
            };
        }


        public static string ReadEmailProviderWithClientDocument = @"
        query ReadEmailProviderWithClient {
          ReadEmailProviderWithClient {
            _id
            user
            client
            status
            fields {
              label
              type
              placeholder
              help
              value
              options
            }
            provider {
              _id
              name
              image
              description
            }
          }
        }
        ";
    }



    public class ReadEmailSentListResponse
    {

        [JsonProperty("ReadEmailSentList")]
        public Email Result { get; set; }
    }

    public class ReadEmailSentListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// ReadEmailSentListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int), sortBy=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailSentListDocument,
                OperationName = "ReadEmailSentList",
                Variables = this
            };
        }


        public static string ReadEmailSentListDocument = @"
        query ReadEmailSentList($page: Int, $count: Int, $sortBy: String) {
          ReadEmailSentList(page: $page, count: $count, sortBy: $sortBy) {
            list {
              _id
              subject
              content
              sender
              receivers
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class ReadEmailSentListByClientResponse
    {

        [JsonProperty("ReadEmailSentListByClient")]
        public EmailListPaged Result { get; set; }
    }

    public class ReadEmailSentListByClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// ReadEmailSentListByClientParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailSentListByClientDocument,
                OperationName = "ReadEmailSentListByClient",
                Variables = this
            };
        }


        public static string ReadEmailSentListByClientDocument = @"
        query ReadEmailSentListByClient($client: String!, $page: Int, $count: Int) {
          ReadEmailSentListByClient(client: $client, page: $page, count: $count) {
            totalCount
            list {
              _id
              user
              subject
              content
              sender
              receivers
              post
              createdAt
              rejected
              isDeleted
              client
            }
          }
        }
        ";
    }



    public class ReadEmailTemplateByClientAndTypeResponse
    {

        [JsonProperty("ReadEmailTemplateByClientAndType")]
        public EmailTemplate Result { get; set; }
    }

    public class ReadEmailTemplateByClientAndTypeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// ReadEmailTemplateByClientAndTypeParam.Request 
        /// <para>Required variables:<br/> { type=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailTemplateByClientAndTypeDocument,
                OperationName = "ReadEmailTemplateByClientAndType",
                Variables = this
            };
        }


        public static string ReadEmailTemplateByClientAndTypeDocument = @"
        query ReadEmailTemplateByClientAndType($type: String!, $client: String!) {
          ReadEmailTemplateByClientAndType(type: $type, client: $client) {
            _id
            type
            sender
            object
            hasURL
            URLExpireTime
            status
            redirectTo
            content
          }
        }
        ";
    }



    public class ReadEmailTemplatesByClientResponse
    {

        [JsonProperty("ReadEmailTemplatesByClient")]
        public IEnumerable<EmailTemplateWithClient> Result { get; set; }
    }

    public class ReadEmailTemplatesByClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// ReadEmailTemplatesByClientParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailTemplatesByClientDocument,
                OperationName = "ReadEmailTemplatesByClient",
                Variables = this
            };
        }


        public static string ReadEmailTemplatesByClientDocument = @"
        query ReadEmailTemplatesByClient($clientId: String!) {
          ReadEmailTemplatesByClient(clientId: $clientId) {
            _id
            user
            client
            template {
              _id
              type
              sender
              object
              hasURL
              URLExpireTime
              status
              redirectTo
              content
            }
            type
            sender
            object
            hasURL
            URLExpireTime
            redirectTo
            status
            content
          }
        }
        ";
    }



    public class ReadEmailTemplatesBySystemResponse
    {

        [JsonProperty("ReadEmailTemplatesBySystem")]
        public IEnumerable<EmailTemplateWithClient> Result { get; set; }
    }

    public class ReadEmailTemplatesBySystemParam
    {


        /// <summary>
        /// ReadEmailTemplatesBySystemParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadEmailTemplatesBySystemDocument,
                OperationName = "ReadEmailTemplatesBySystem"
            };
        }


        public static string ReadEmailTemplatesBySystemDocument = @"
        query ReadEmailTemplatesBySystem {
          ReadEmailTemplatesBySystem {
            _id
            user
            client
            template {
              _id
              type
              sender
              object
              hasURL
              URLExpireTime
              status
              redirectTo
              content
            }
            type
            sender
            object
            hasURL
            URLExpireTime
            redirectTo
            status
            content
          }
        }
        ";
    }



    public class ReadOauthListResponse
    {

        [JsonProperty("ReadOauthList")]
        public IEnumerable<OAuthList> Result { get; set; }
    }

    public class ReadOauthListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("dontGetURL")]
        public bool DontGetUrl { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("useGuard")]
        public bool UseGuard { get; set; }

        /// <summary>
        /// ReadOauthListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), dontGetURL=(bool), useGuard=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadOauthListDocument,
                OperationName = "ReadOauthList",
                Variables = this
            };
        }


        public static string ReadOauthListDocument = @"
        query ReadOauthList($clientId: String, $dontGetURL: Boolean, $useGuard: Boolean) {
          ReadOauthList(clientId: $clientId, dontGetURL: $dontGetURL, useGuard: $useGuard) {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class ReadOrdersResponse
    {

        [JsonProperty("ReadOrders")]
        public PagedOrders Result { get; set; }
    }

    public class ReadOrdersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// ReadOrdersParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { user=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadOrdersDocument,
                OperationName = "ReadOrders",
                Variables = this
            };
        }


        public static string ReadOrdersDocument = @"
        query ReadOrders($user: String, $page: Int, $count: Int) {
          ReadOrders(user: $user, page: $page, count: $count) {
            list {
              _id
              client
              user
              timeOfPurchase
              flowNumber
              price
              createdAt
              completed
              payMethod
              endAt
            }
            totalCount
          }
        }
        ";
    }



    public class ReadSamlspListResponse
    {

        [JsonProperty("ReadSAMLSPList")]
        public IEnumerable<SAMLSPListItem> Result { get; set; }
    }

    public class ReadSamlspListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// ReadSamlspListParam.Request 
        /// <para>Required variables:<br/> { clientId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadSamlspListDocument,
                OperationName = "ReadSAMLSPList",
                Variables = this
            };
        }


        public static string ReadSamlspListDocument = @"
        query ReadSAMLSPList($clientId: String!) {
          ReadSAMLSPList(clientId: $clientId) {
            providerName
            url
            logo
          }
        }
        ";
    }



    public class ReadSystemPricingResponse
    {

        [JsonProperty("ReadSystemPricing")]
        public IEnumerable<PricingList> Result { get; set; }
    }

    public class ReadSystemPricingParam
    {


        /// <summary>
        /// ReadSystemPricingParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadSystemPricingDocument,
                OperationName = "ReadSystemPricing"
            };
        }


        public static string ReadSystemPricingDocument = @"
        query ReadSystemPricing {
          ReadSystemPricing {
            _id
            type
            startNumber
            freeNumber
            startPrice
            maxNumber
            d
            features
          }
        }
        ";
    }



    public class ReadUserPricingResponse
    {

        [JsonProperty("ReadUserPricing")]
        public UserPricingType Result { get; set; }
    }

    public class ReadUserPricingParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// ReadUserPricingParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ReadUserPricingDocument,
                OperationName = "ReadUserPricing",
                Variables = this
            };
        }


        public static string ReadUserPricingDocument = @"
        query ReadUserPricing($userId: String, $clientId: String) {
          ReadUserPricing(userId: $userId, clientId: $clientId) {
            user
            client
            isFree
            pricing {
              number
            }
            freeNumber
          }
        }
        ";
    }



    public class TestLdapServerResponse
    {

        [JsonProperty("TestLDAPServer")]
        public LDAPServerTesterType Result { get; set; }
    }

    public class TestLdapServerParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapLink")]
        public string LdapLink { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("baseDN")]
        public string BaseDn { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("searchStandard")]
        public string SearchStandard { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("emailPostfix")]
        public string EmailPostfix { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// TestLdapServerParam.Request 
        /// <para>Required variables:<br/> { name=(string), clientId=(string), userId=(string), ldapLink=(string), baseDN=(string), searchStandard=(string), username=(string), password=(string) }</para>
        /// <para>Optional variables:<br/> { emailPostfix=(string), description=(string), enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = TestLdapServerDocument,
                OperationName = "TestLDAPServer",
                Variables = this
            };
        }


        public static string TestLdapServerDocument = @"
        query TestLDAPServer($name: String!, $clientId: String!, $userId: String!, $ldapLink: String!, $baseDN: String!, $searchStandard: String!, $username: String!, $password: String!, $emailPostfix: String, $description: String, $enabled: Boolean) {
          TestLDAPServer(name: $name, clientId: $clientId, userId: $userId, ldapLink: $ldapLink, baseDN: $baseDN, searchStandard: $searchStandard, username: $username, password: $password, emailPostfix: $emailPostfix, description: $description, enabled: $enabled) {
            result
          }
        }
        ";
    }



    public class TestLdapUserResponse
    {

        [JsonProperty("TestLDAPUser")]
        public LDAPUserTesterType Result { get; set; }
    }

    public class TestLdapUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("testUsername")]
        public string TestUsername { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("testPassword")]
        public string TestPassword { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ldapLink")]
        public string LdapLink { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("baseDN")]
        public string BaseDn { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("searchStandard")]
        public string SearchStandard { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("emailPostfix")]
        public string EmailPostfix { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// TestLdapUserParam.Request 
        /// <para>Required variables:<br/> { testUsername=(string), testPassword=(string), name=(string), clientId=(string), userId=(string), ldapLink=(string), baseDN=(string), searchStandard=(string), username=(string), password=(string) }</para>
        /// <para>Optional variables:<br/> { emailPostfix=(string), description=(string), enabled=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = TestLdapUserDocument,
                OperationName = "TestLDAPUser",
                Variables = this
            };
        }


        public static string TestLdapUserDocument = @"
        query TestLDAPUser($testUsername: String!, $testPassword: String!, $name: String!, $clientId: String!, $userId: String!, $ldapLink: String!, $baseDN: String!, $searchStandard: String!, $username: String!, $password: String!, $emailPostfix: String, $description: String, $enabled: Boolean) {
          TestLDAPUser(testUsername: $testUsername, testPassword: $testPassword, name: $name, clientId: $clientId, userId: $userId, ldapLink: $ldapLink, baseDN: $baseDN, searchStandard: $searchStandard, username: $username, password: $password, emailPostfix: $emailPostfix, description: $description, enabled: $enabled) {
            result
          }
        }
        ";
    }



    public class AdConnectorByProviderResponse
    {

        [JsonProperty("adConnectorByProvider")]
        public ADConnctorCommonInfo Result { get; set; }
    }

    public class AdConnectorByProviderParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("providerId")]
        public string ProviderId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("providerType")]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// AdConnectorByProviderParam.Request 
        /// <para>Required variables:<br/> { providerId=(string), providerType=(providerType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AdConnectorByProviderDocument,
                OperationName = "adConnectorByProvider",
                Variables = this
            };
        }


        public static string AdConnectorByProviderDocument = @"
        query adConnectorByProvider($providerId: String!, $providerType: providerType!) {
          adConnectorByProvider(providerId: $providerId, providerType: $providerType) {
            _id
            name
            logo
            status
          }
        }
        ";
    }



    public class AdConnectorListResponse
    {

        [JsonProperty("adConnectorList")]
        public IEnumerable<ADConnector> Result { get; set; }
    }

    public class AdConnectorListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("providerType")]
        public ProviderType ProviderType { get; set; }

        /// <summary>
        /// AdConnectorListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { providerType=(providerType) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AdConnectorListDocument,
                OperationName = "adConnectorList",
                Variables = this
            };
        }


        public static string AdConnectorListDocument = @"
        query adConnectorList($userPoolId: String!, $providerType: providerType) {
          adConnectorList(userPoolId: $userPoolId, providerType: $providerType) {
            _id
            name
            secret
            salt
            logo
            enabled
            userPoolId
            status
            createdAt
          }
        }
        ";
    }



    public class BindedOAuthListResponse
    {

        [JsonProperty("bindedOAuthList")]
        public IEnumerable<UserOAuthBind> Result { get; set; }
    }

    public class BindedOAuthListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// BindedOAuthListParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { user=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = BindedOAuthListDocument,
                OperationName = "bindedOAuthList",
                Variables = this
            };
        }


        public static string BindedOAuthListDocument = @"
        query bindedOAuthList($client: String!, $user: String) {
          bindedOAuthList(client: $client, user: $user) {
            _id
            user
            client
            type
            unionid
            userInfo
            createdAt
          }
        }
        ";
    }



    public class CheckAdConnectorStatusResponse
    {

        [JsonProperty("checkAdConnectorStatus")]
        public bool? Result { get; set; }
    }

    public class CheckAdConnectorStatusParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }

        /// <summary>
        /// CheckAdConnectorStatusParam.Request 
        /// <para>Required variables:<br/> { adConnectorId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CheckAdConnectorStatusDocument,
                OperationName = "checkAdConnectorStatus",
                Variables = this
            };
        }


        public static string CheckAdConnectorStatusDocument = @"
        query checkAdConnectorStatus($adConnectorId: String!) {
          checkAdConnectorStatus(adConnectorId: $adConnectorId)
        }
        ";
    }



    public class CheckIsReservedDomainResponse
    {

        [JsonProperty("checkIsReservedDomain")]
        public IsReservedDomain Result { get; set; }
    }

    public class CheckIsReservedDomainParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domainValue")]
        public string DomainValue { get; set; }

        /// <summary>
        /// CheckIsReservedDomainParam.Request 
        /// <para>Required variables:<br/> { domainValue=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CheckIsReservedDomainDocument,
                OperationName = "checkIsReservedDomain",
                Variables = this
            };
        }


        public static string CheckIsReservedDomainDocument = @"
        query checkIsReservedDomain($domainValue: String!) {
          checkIsReservedDomain(domainValue: $domainValue) {
            domainValue
            isReserved
          }
        }
        ";
    }



    public class CheckLoginStatusResponse
    {

        [JsonProperty("checkLoginStatus")]
        public JWTDecodedDataCheckLogin Result { get; set; }
    }

    public class CheckLoginStatusParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// CheckLoginStatusParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { token=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CheckLoginStatusDocument,
                OperationName = "checkLoginStatus",
                Variables = this
            };
        }


        public static string CheckLoginStatusDocument = @"
        query checkLoginStatus($token: String) {
          checkLoginStatus(token: $token) {
            message
            code
            status
            token {
              iat
              exp
            }
          }
        }
        ";
    }



    public class CheckPhoneCodeResponse
    {

        [JsonProperty("checkPhoneCode")]
        public CommonMessage Result { get; set; }
    }

    public class CheckPhoneCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("phoneCode")]
        public string PhoneCode { get; set; }

        /// <summary>
        /// CheckPhoneCodeParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), phone=(string), phoneCode=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CheckPhoneCodeDocument,
                OperationName = "checkPhoneCode",
                Variables = this
            };
        }


        public static string CheckPhoneCodeDocument = @"
        query checkPhoneCode($userPoolId: String!, $phone: String!, $phoneCode: String!) {
          checkPhoneCode(userPoolId: $userPoolId, phone: $phone, phoneCode: $phoneCode) {
            message
            code
            status
          }
        }
        ";
    }



    public class ClientResponse
    {

        [JsonProperty("client")]
        public UserClient Result { get; set; }
    }

    public class ClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fromAdmin")]
        public bool FromAdmin { get; set; }

        /// <summary>
        /// ClientParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> { userId=(string), fromAdmin=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ClientDocument,
                OperationName = "client",
                Variables = this
            };
        }


        public static string ClientDocument = @"
        query client($id: String!, $userId: String, $fromAdmin: Boolean) {
          client(id: $id, userId: $userId, fromAdmin: $fromAdmin) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class ClientRolesResponse
    {

        [JsonProperty("clientRoles")]
        public PagedRoles Result { get; set; }
    }

    public class ClientRolesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// ClientRolesParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ClientRolesDocument,
                OperationName = "clientRoles",
                Variables = this
            };
        }


        public static string ClientRolesDocument = @"
        query clientRoles($client: String!, $page: Int, $count: Int) {
          clientRoles(client: $client, page: $page, count: $count) {
            list {
              _id
              name
              descriptions
              client
              permissions
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class DecodeJwtTokenResponse
    {

        [JsonProperty("decodeJwtToken")]
        public JwtDecodedData Result { get; set; }
    }

    public class DecodeJwtTokenParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// DecodeJwtTokenParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { token=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DecodeJwtTokenDocument,
                OperationName = "decodeJwtToken",
                Variables = this
            };
        }


        public static string DecodeJwtTokenDocument = @"
        query decodeJwtToken($token: String) {
          decodeJwtToken(token: $token) {
            data {
              email
              id
              clientId
              unionid
            }
            status {
              message
              code
              status
            }
            iat
            exp
          }
        }
        ";
    }



    public class EmailDomainTopNListResponse
    {

        [JsonProperty("emailDomainTopNList")]
        public IEnumerable<LoginTopEmailList> Result { get; set; }
    }

    public class EmailDomainTopNListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// EmailDomainTopNListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EmailDomainTopNListDocument,
                OperationName = "emailDomainTopNList",
                Variables = this
            };
        }


        public static string EmailDomainTopNListDocument = @"
        query emailDomainTopNList($userPoolId: String!) {
          emailDomainTopNList(userPoolId: $userPoolId) {
            domain
            count
          }
        }
        ";
    }



    public class FindClientsByIdArrayResponse
    {

        [JsonProperty("findClientsByIdArray")]
        public PagedUserClientList Result { get; set; }
    }

    public class FindClientsByIdArrayParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientsId")]
        public string ClientsId { get; set; }

        /// <summary>
        /// FindClientsByIdArrayParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientsId=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = FindClientsByIdArrayDocument,
                OperationName = "findClientsByIdArray",
                Variables = this
            };
        }


        public static string FindClientsByIdArrayDocument = @"
        query findClientsByIdArray($clientsId: [String]) {
          findClientsByIdArray(clientsId: $clientsId) {
            list {
              _id
              name
              createdAt
              usersCount
            }
            totalCount
          }
        }
        ";
    }



    public class GetAccessTokenByAppSecretResponse
    {

        [JsonProperty("getAccessTokenByAppSecret")]
        public string Result { get; set; }
    }

    public class GetAccessTokenByAppSecretParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("retUserId")]
        public bool RetUserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nonce")]
        public int Nonce { get; set; }

        /// <summary>
        /// GetAccessTokenByAppSecretParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { secret=(string), clientId=(string), retUserId=(bool), timestamp=(string), signature=(string), nonce=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetAccessTokenByAppSecretDocument,
                OperationName = "getAccessTokenByAppSecret",
                Variables = this
            };
        }


        public static string GetAccessTokenByAppSecretDocument = @"
        query getAccessTokenByAppSecret($secret: String, $clientId: String, $retUserId: Boolean, $timestamp: String, $signature: String, $nonce: Int) {
          getAccessTokenByAppSecret(secret: $secret, clientId: $clientId, retUserId: $retUserId, timestamp: $timestamp, signature: $signature, nonce: $nonce)
        }
        ";
    }



    public class GetAllWebhooksResponse
    {

        [JsonProperty("getAllWebhooks")]
        public IEnumerable<ClientWebhook> Result { get; set; }
    }

    public class GetAllWebhooksParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// GetAllWebhooksParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetAllWebhooksDocument,
                OperationName = "getAllWebhooks",
                Variables = this
            };
        }


        public static string GetAllWebhooksDocument = @"
        query getAllWebhooks($client: String!) {
          getAllWebhooks(client: $client) {
            _id
            client
            events {
              name
              label
              description
            }
            url
            isLastTimeSuccess
            contentType
            secret
            enable
          }
        }
        ";
    }



    public class GetAppSecretByClientIdResponse
    {

        [JsonProperty("getAppSecretByClientId")]
        public AppSecretByClientId Result { get; set; }
    }

    public class GetAppSecretByClientIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// GetAppSecretByClientIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { token=(string), clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetAppSecretByClientIdDocument,
                OperationName = "getAppSecretByClientId",
                Variables = this
            };
        }


        public static string GetAppSecretByClientIdDocument = @"
        query getAppSecretByClientId($token: String, $clientId: String) {
          getAppSecretByClientId(token: $token, clientId: $clientId) {
            secret
            clientId
          }
        }
        ";
    }



    public class GetClientWhenSdkInitResponse
    {

        [JsonProperty("getClientWhenSdkInit")]
        public ClientInfoAndAccessToken Result { get; set; }
    }

    public class GetClientWhenSdkInitParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("retUserId")]
        public bool RetUserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("signature")]
        public string Signature { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nonce")]
        public int Nonce { get; set; }

        /// <summary>
        /// GetClientWhenSdkInitParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { secret=(string), clientId=(string), retUserId=(bool), timestamp=(string), signature=(string), nonce=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetClientWhenSdkInitDocument,
                OperationName = "getClientWhenSdkInit",
                Variables = this
            };
        }


        public static string GetClientWhenSdkInitDocument = @"
        query getClientWhenSdkInit($secret: String, $clientId: String, $retUserId: Boolean, $timestamp: String, $signature: String, $nonce: Int) {
          getClientWhenSdkInit(secret: $secret, clientId: $clientId, retUserId: $retUserId, timestamp: $timestamp, signature: $signature, nonce: $nonce) {
            clientInfo {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            accessToken
          }
        }
        ";
    }



    public class GetCustomMfaResponse
    {

        [JsonProperty("getCustomMFA")]
        public PagedCustomMFAList Result { get; set; }
    }

    public class GetCustomMfaParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIdInMiniLogin")]
        public string UserIdInMiniLogin { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetCustomMfaParam.Request 
        /// <para>Required variables:<br/> { userIdInMiniLogin=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetCustomMfaDocument,
                OperationName = "getCustomMFA",
                Variables = this
            };
        }


        public static string GetCustomMfaDocument = @"
        query getCustomMFA($userIdInMiniLogin: String!, $page: Int, $count: Int) {
          getCustomMFA(userIdInMiniLogin: $userIdInMiniLogin, page: $page, count: $count) {
            list {
              _id
              userIdInMiniLogin
              remark
              name
              secret
            }
            total
          }
        }
        ";
    }



    public class GetOAuthedAppInfoResponse
    {

        [JsonProperty("getOAuthedAppInfo")]
        public OAuthProviderClient Result { get; set; }
    }

    public class GetOAuthedAppInfoParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// GetOAuthedAppInfoParam.Request 
        /// <para>Required variables:<br/> { appId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetOAuthedAppInfoDocument,
                OperationName = "getOAuthedAppInfo",
                Variables = this
            };
        }


        public static string GetOAuthedAppInfoDocument = @"
        query getOAuthedAppInfo($appId: String!) {
          getOAuthedAppInfo(appId: $appId) {
            _id
            name
            domain
            image
            redirectUris
            appSecret
            client_id
            clientId
            grants
            description
            homepageURL
            isDeleted
            when
            css
            loginUrl
            casExpire
          }
        }
        ";
    }



    public class GetOAuthedAppListResponse
    {

        [JsonProperty("getOAuthedAppList")]
        public OAuthAppPagedList Result { get; set; }
    }

    public class GetOAuthedAppListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// GetOAuthedAppListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetOAuthedAppListDocument,
                OperationName = "getOAuthedAppList",
                Variables = this
            };
        }


        public static string GetOAuthedAppListDocument = @"
        query getOAuthedAppList($clientId: String, $page: Int, $count: Int) {
          getOAuthedAppList(clientId: $clientId, page: $page, count: $count) {
            totalCount
            list {
              _id
              name
              domain
              image
              redirectUris
              appSecret
              client_id
              clientId
              grants
              description
              homepageURL
              isDeleted
              when
              css
              loginUrl
              casExpire
            }
          }
        }
        ";
    }



    public class GetUserLoginAreaStatisticOfClientResponse
    {

        [JsonProperty("getUserLoginAreaStatisticOfClient")]
        public string Result { get; set; }
    }

    public class GetUserLoginAreaStatisticOfClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPool")]
        public string UserPool { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("start")]
        public string Start { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("end")]
        public string End { get; set; }

        /// <summary>
        /// GetUserLoginAreaStatisticOfClientParam.Request 
        /// <para>Required variables:<br/> { userPool=(string) }</para>
        /// <para>Optional variables:<br/> { start=(string), end=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetUserLoginAreaStatisticOfClientDocument,
                OperationName = "getUserLoginAreaStatisticOfClient",
                Variables = this
            };
        }


        public static string GetUserLoginAreaStatisticOfClientDocument = @"
        query getUserLoginAreaStatisticOfClient($userPool: String!, $start: String, $end: String) {
          getUserLoginAreaStatisticOfClient(userPool: $userPool, start: $start, end: $end)
        }
        ";
    }



    public class GetUserPoolSettingsResponse
    {

        [JsonProperty("getUserPoolSettings")]
        public UserClient Result { get; set; }
    }

    public class GetUserPoolSettingsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// GetUserPoolSettingsParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetUserPoolSettingsDocument,
                OperationName = "getUserPoolSettings",
                Variables = this
            };
        }


        public static string GetUserPoolSettingsDocument = @"
        query getUserPoolSettings($userPoolId: String!) {
          getUserPoolSettings(userPoolId: $userPoolId) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class GetWebhookDetailResponse
    {

        [JsonProperty("getWebhookDetail")]
        public ClientWebhook Result { get; set; }
    }

    public class GetWebhookDetailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// GetWebhookDetailParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetWebhookDetailDocument,
                OperationName = "getWebhookDetail",
                Variables = this
            };
        }


        public static string GetWebhookDetailDocument = @"
        query getWebhookDetail($client: String!) {
          getWebhookDetail(client: $client) {
            _id
            client
            events {
              name
              label
              description
            }
            url
            isLastTimeSuccess
            contentType
            secret
            enable
          }
        }
        ";
    }



    public class GetWebhookLogDetailResponse
    {

        [JsonProperty("getWebhookLogDetail")]
        public WebhookLog Result { get; set; }
    }

    public class GetWebhookLogDetailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// GetWebhookLogDetailParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetWebhookLogDetailDocument,
                OperationName = "getWebhookLogDetail",
                Variables = this
            };
        }


        public static string GetWebhookLogDetailDocument = @"
        query getWebhookLogDetail($id: String!) {
          getWebhookLogDetail(id: $id) {
            _id
            webhook
            client
            event
            request {
              headers
              payload
            }
            response {
              headers
              body
              statusCode
            }
            errorMessage
            when
          }
        }
        ";
    }



    public class GetWebhookLogsResponse
    {

        [JsonProperty("getWebhookLogs")]
        public IEnumerable<WebhookLog> Result { get; set; }
    }

    public class GetWebhookLogsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("webhook")]
        public string Webhook { get; set; }

        /// <summary>
        /// GetWebhookLogsParam.Request 
        /// <para>Required variables:<br/> { webhook=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetWebhookLogsDocument,
                OperationName = "getWebhookLogs",
                Variables = this
            };
        }


        public static string GetWebhookLogsDocument = @"
        query getWebhookLogs($webhook: String!) {
          getWebhookLogs(webhook: $webhook) {
            _id
            webhook
            client
            event
            request {
              headers
              payload
            }
            response {
              headers
              body
              statusCode
            }
            errorMessage
            when
          }
        }
        ";
    }



    public class GetWebhookSettingOptionsResponse
    {

        [JsonProperty("getWebhookSettingOptions")]
        public WebhookSettingOptions Result { get; set; }
    }

    public class GetWebhookSettingOptionsParam
    {


        /// <summary>
        /// GetWebhookSettingOptionsParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetWebhookSettingOptionsDocument,
                OperationName = "getWebhookSettingOptions"
            };
        }


        public static string GetWebhookSettingOptionsDocument = @"
        query getWebhookSettingOptions {
          getWebhookSettingOptions {
            webhookEvents {
              name
              label
              description
            }
            contentTypes {
              name
              label
            }
          }
        }
        ";
    }



    public class InterConnectionsResponse
    {

        [JsonProperty("interConnections")]
        public IEnumerable<InterConnection> Result { get; set; }
    }

    public class InterConnectionsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// InterConnectionsParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = InterConnectionsDocument,
                OperationName = "interConnections",
                Variables = this
            };
        }


        public static string InterConnectionsDocument = @"
        query interConnections($userPoolId: String!) {
          interConnections(userPoolId: $userPoolId) {
            sourceUserId
            sourceUserPoolId
            targetUserId
            targetUserPoolId
            enabled
            expiresdAt
          }
        }
        ";
    }



    public class IsAdConnectorAliveResponse
    {

        [JsonProperty("isAdConnectorAlive")]
        public isAdConenctorAlive Result { get; set; }
    }

    public class IsAdConnectorAliveParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("adConnectorId")]
        public string AdConnectorId { get; set; }

        /// <summary>
        /// IsAdConnectorAliveParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { adConnectorId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsAdConnectorAliveDocument,
                OperationName = "isAdConnectorAlive",
                Variables = this
            };
        }


        public static string IsAdConnectorAliveDocument = @"
        query isAdConnectorAlive($adConnectorId: String) {
          isAdConnectorAlive(adConnectorId: $adConnectorId) {
            isAlive
          }
        }
        ";
    }



    public class IsAppAuthorizedByUserResponse
    {

        [JsonProperty("isAppAuthorizedByUser")]
        public IsAppAuthorizedByUser Result { get; set; }
    }

    public class IsAppAuthorizedByUserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// IsAppAuthorizedByUserParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), appId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsAppAuthorizedByUserDocument,
                OperationName = "isAppAuthorizedByUser",
                Variables = this
            };
        }


        public static string IsAppAuthorizedByUserDocument = @"
        query isAppAuthorizedByUser($userId: String, $appId: String) {
          isAppAuthorizedByUser(userId: $userId, appId: $appId) {
            authorized
          }
        }
        ";
    }



    public class IsClientBelongToUserResponse
    {

        [JsonProperty("isClientBelongToUser")]
        public bool? Result { get; set; }
    }

    public class IsClientBelongToUserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("permissionDescriptors")]
        public PermissionDescriptorsListInputType PermissionDescriptors { get; set; }

        /// <summary>
        /// IsClientBelongToUserParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), clientId=(string), permissionDescriptors=(PermissionDescriptorsListInputType[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsClientBelongToUserDocument,
                OperationName = "isClientBelongToUser",
                Variables = this
            };
        }


        public static string IsClientBelongToUserDocument = @"
        query isClientBelongToUser($userId: String, $clientId: String, $permissionDescriptors: [PermissionDescriptorsListInputType]) {
          isClientBelongToUser(userId: $userId, clientId: $clientId, permissionDescriptors: $permissionDescriptors)
        }
        ";
    }



    public class IsClientOfUserResponse
    {

        [JsonProperty("isClientOfUser")]
        public bool? Result { get; set; }
    }

    public class IsClientOfUserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// IsClientOfUserParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { email=(string), password=(string), clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsClientOfUserDocument,
                OperationName = "isClientOfUser",
                Variables = this
            };
        }


        public static string IsClientOfUserDocument = @"
        query isClientOfUser($email: String, $password: String, $clientId: String) {
          isClientOfUser(email: $email, password: $password, clientId: $clientId)
        }
        ";
    }



    public class IsDomainAvaliableResponse
    {

        [JsonProperty("isDomainAvaliable")]
        public bool? Result { get; set; }
    }

    public class IsDomainAvaliableParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// IsDomainAvaliableParam.Request 
        /// <para>Required variables:<br/> { domain=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsDomainAvaliableDocument,
                OperationName = "isDomainAvaliable",
                Variables = this
            };
        }


        public static string IsDomainAvaliableDocument = @"
        query isDomainAvaliable($domain: String!) {
          isDomainAvaliable(domain: $domain)
        }
        ";
    }



    public class IsLoginExpiredResponse
    {

        [JsonProperty("isLoginExpired")]
        public bool? Result { get; set; }
    }

    public class IsLoginExpiredParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// IsLoginExpiredParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsLoginExpiredDocument,
                OperationName = "isLoginExpired",
                Variables = this
            };
        }


        public static string IsLoginExpiredDocument = @"
        query isLoginExpired($id: String!) {
          isLoginExpired(id: $id)
        }
        ";
    }



    public class IsRootNodeOfOrgResponse
    {

        [JsonProperty("isRootNodeOfOrg")]
        public bool? Result { get; set; }
    }

    public class IsRootNodeOfOrgParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public IsRootNodeOfOrgInput Input { get; set; }

        /// <summary>
        /// IsRootNodeOfOrgParam.Request 
        /// <para>Required variables:<br/> { input=(IsRootNodeOfOrgInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsRootNodeOfOrgDocument,
                OperationName = "isRootNodeOfOrg",
                Variables = this
            };
        }


        public static string IsRootNodeOfOrgDocument = @"
        query isRootNodeOfOrg($input: IsRootNodeOfOrgInput!) {
          isRootNodeOfOrg(input: $input)
        }
        ";
    }



    public class IsUserInGroupResponse
    {

        [JsonProperty("isUserInGroup")]
        public bool? Result { get; set; }
    }

    public class IsUserInGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("groupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// IsUserInGroupParam.Request 
        /// <para>Required variables:<br/> { groupId=(string), userId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsUserInGroupDocument,
                OperationName = "isUserInGroup",
                Variables = this
            };
        }


        public static string IsUserInGroupDocument = @"
        query isUserInGroup($groupId: String!, $userId: String!) {
          isUserInGroup(groupId: $groupId, userId: $userId)
        }
        ";
    }



    public class LoginBySecretResponse
    {

        [JsonProperty("getAccessTokenByAppSecret")]
        public string Result { get; set; }
    }

    public class LoginBySecretParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// LoginBySecretParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string), secret=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginBySecretDocument,
                OperationName = "loginBySecret",
                Variables = this
            };
        }


        public static string LoginBySecretDocument = @"
        query loginBySecret($clientId: String, $secret: String) {
          getAccessTokenByAppSecret(clientId: $clientId, secret: $secret)
        }
        ";
    }



    public class LoginCountResponse
    {

        [JsonProperty("loginCount")]
        public UserLoginCount Result { get; set; }
    }

    public class LoginCountParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }

        /// <summary>
        /// LoginCountParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), clientId=(string), month=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginCountDocument,
                OperationName = "loginCount",
                Variables = this
            };
        }


        public static string LoginCountDocument = @"
        query loginCount($userId: String, $clientId: String, $month: String) {
          loginCount(userId: $userId, clientId: $clientId, month: $month) {
            _id
            client
            count
            month
            isError
            totalNumber
          }
        }
        ";
    }



    public class LoginHotDotPicDataResponse
    {

        [JsonProperty("loginHotDotPicData")]
        public LoginHotDotPicData Result { get; set; }
    }

    public class LoginHotDotPicDataParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// LoginHotDotPicDataParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = LoginHotDotPicDataDocument,
                OperationName = "loginHotDotPicData",
                Variables = this
            };
        }


        public static string LoginHotDotPicDataDocument = @"
        query loginHotDotPicData($client: String) {
          loginHotDotPicData(client: $client) {
            list
          }
        }
        ";
    }



    public class NotBindOAuthListResponse
    {

        [JsonProperty("notBindOAuthList")]
        public IEnumerable<NotBindOAuth> Result { get; set; }
    }

    public class NotBindOAuthListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// NotBindOAuthListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string), user=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NotBindOAuthListDocument,
                OperationName = "notBindOAuthList",
                Variables = this
            };
        }


        public static string NotBindOAuthListDocument = @"
        query notBindOAuthList($client: String, $user: String) {
          notBindOAuthList(client: $client, user: $user) {
            type
            oAuthUrl
            image
            name
            binded
          }
        }
        ";
    }



    public class OrgResponse
    {

        [JsonProperty("org")]
        public Org Result { get; set; }
    }

    public class OrgParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// OrgParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrgDocument,
                OperationName = "org",
                Variables = this
            };
        }


        public static string OrgDocument = @"
        query org($_id: String!) {
          org(_id: $_id) {
            _id
            nodes {
              _id
              name
              description
              createdAt
              updatedAt
              children
              root
            }
          }
        }
        ";
    }



    public class OrgChildrenNodesResponse
    {

        [JsonProperty("orgChildrenNodes")]
        public IEnumerable<OrgChildNode> Result { get; set; }
    }

    public class OrgChildrenNodesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public OrgChildrenNodesInput Input { get; set; }

        /// <summary>
        /// OrgChildrenNodesParam.Request 
        /// <para>Required variables:<br/> { input=(OrgChildrenNodesInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrgChildrenNodesDocument,
                OperationName = "orgChildrenNodes",
                Variables = this
            };
        }


        public static string OrgChildrenNodesDocument = @"
        query orgChildrenNodes($input: OrgChildrenNodesInput!) {
          orgChildrenNodes(input: $input) {
            group {
              _id
              userPoolId
              name
              description
              createdAt
              updatedAt
            }
            depth
          }
        }
        ";
    }



    public class OrgNodeUserListResponse
    {

        [JsonProperty("orgNodeUserList")]
        public PagedUsers Result { get; set; }
    }

    public class OrgNodeUserListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// OrgNodeUserListParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), nodeId=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int), includeChildrenNodes=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrgNodeUserListDocument,
                OperationName = "orgNodeUserList",
                Variables = this
            };
        }


        public static string OrgNodeUserListDocument = @"
        query orgNodeUserList($orgId: String!, $nodeId: String!, $page: Int, $count: Int, $includeChildrenNodes: Boolean) {
          orgNodeUserList(orgId: $orgId, nodeId: $nodeId, page: $page, count: $count, includeChildrenNodes: $includeChildrenNodes) {
            list {
              _id
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              username
              nickname
              company
              photo
              browser
              device
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              customData
              metadata
            }
            totalCount
          }
        }
        ";
    }



    public class OrgRootNodeResponse
    {

        [JsonProperty("orgRootNode")]
        public RBACGroup Result { get; set; }
    }

    public class OrgRootNodeParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// OrgRootNodeParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrgRootNodeDocument,
                OperationName = "orgRootNode",
                Variables = this
            };
        }


        public static string OrgRootNodeDocument = @"
        query orgRootNode($sortBy: SortByEnum, $page: Int, $count: Int, $_id: String!) {
          orgRootNode(_id: $_id) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            roles {
              totalCount
            }
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class OrgsResponse
    {

        [JsonProperty("orgs")]
        public PagedOrg Result { get; set; }
    }

    public class OrgsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// OrgsParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = OrgsDocument,
                OperationName = "orgs",
                Variables = this
            };
        }


        public static string OrgsDocument = @"
        query orgs($userPoolId: String!) {
          orgs(userPoolId: $userPoolId) {
            totalCount
            list {
              _id
              logo
              nodes {
                _id
                name
                description
                createdAt
                updatedAt
                children
                root
              }
            }
          }
        }
        ";
    }



    public class PlatformUserGrowthTrendResponse
    {

        [JsonProperty("platformUserGrowthTrend")]
        public IEnumerable<DayUserGrowth> Result { get; set; }
    }

    public class PlatformUserGrowthTrendParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("today")]
        public string Today { get; set; }

        /// <summary>
        /// PlatformUserGrowthTrendParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { today=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PlatformUserGrowthTrendDocument,
                OperationName = "platformUserGrowthTrend",
                Variables = this
            };
        }


        public static string PlatformUserGrowthTrendDocument = @"
        query platformUserGrowthTrend($today: String) {
          platformUserGrowthTrend(today: $today) {
            day
            count
          }
        }
        ";
    }



    public class PreviewEmailTemplateResponse
    {

        [JsonProperty("previewEmailTemplate")]
        public CommonMessage Result { get; set; }
    }

    public class PreviewEmailTemplateParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// PreviewEmailTemplateParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { type=(string), client=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PreviewEmailTemplateDocument,
                OperationName = "previewEmailTemplate",
                Variables = this
            };
        }


        public static string PreviewEmailTemplateDocument = @"
        query previewEmailTemplate($type: String, $client: String) {
          previewEmailTemplate(type: $type, client: $client) {
            message
            code
            status
          }
        }
        ";
    }



    public class ProviderListByAdConnectorResponse
    {

        [JsonProperty("providerListByADConnector")]
        public IEnumerable<ADConnectorEnabledProvider> Result { get; set; }
    }

    public class ProviderListByAdConnectorParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// ProviderListByAdConnectorParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ProviderListByAdConnectorDocument,
                OperationName = "providerListByADConnector",
                Variables = this
            };
        }


        public static string ProviderListByAdConnectorDocument = @"
        query providerListByADConnector($_id: String!) {
          providerListByADConnector(_id: $_id) {
            providerType
            providerId
            userPoolId
            adConnectorId
          }
        }
        ";
    }



    public class QiNiuUploadTokenResponse
    {

        [JsonProperty("qiNiuUploadToken")]
        public string Result { get; set; }
    }

    public class QiNiuUploadTokenParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// QiNiuUploadTokenParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { type=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QiNiuUploadTokenDocument,
                OperationName = "qiNiuUploadToken",
                Variables = this
            };
        }


        public static string QiNiuUploadTokenDocument = @"
        query qiNiuUploadToken($type: String) {
          qiNiuUploadToken(type: $type)
        }
        ";
    }



    public class QpsByTimeResponse
    {

        [JsonProperty("qpsByTime")]
        public IEnumerable<QpsByTime> Result { get; set; }
    }

    public class QpsByTimeParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("startTime")]
        public string StartTime { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("endTime")]
        public string EndTime { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("currentTime")]
        public string CurrentTime { get; set; }

        /// <summary>
        /// QpsByTimeParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { startTime=(string), endTime=(string), currentTime=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QpsByTimeDocument,
                OperationName = "qpsByTime",
                Variables = this
            };
        }


        public static string QpsByTimeDocument = @"
        query qpsByTime($startTime: String, $endTime: String, $currentTime: String) {
          qpsByTime(startTime: $startTime, endTime: $endTime, currentTime: $currentTime) {
            qps
            time
          }
        }
        ";
    }



    public class QueryAuthAuditRecordsResponse
    {

        [JsonProperty("queryAuthAuditRecords")]
        public AuthAuditRecordsList Result { get; set; }
    }

    public class QueryAuthAuditRecordsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryAuthAuditRecordsParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryAuthAuditRecordsDocument,
                OperationName = "queryAuthAuditRecords",
                Variables = this
            };
        }


        public static string QueryAuthAuditRecordsDocument = @"
        query queryAuthAuditRecords($userPoolId: String!, $sortBy: String, $page: Int, $count: Int) {
          queryAuthAuditRecords(userPoolId: $userPoolId, sortBy: $sortBy, page: $page, count: $count) {
            list {
              userPoolId
              appType
              appId
              event
              userId
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class QueryAuthorizedUserPoolResponse
    {

        [JsonProperty("queryAuthorizedUserPool")]
        public PagedUserPoolWithMFA Result { get; set; }
    }

    public class QueryAuthorizedUserPoolParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryAuthorizedUserPoolParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { unionid=(string), phone=(string), openid=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryAuthorizedUserPoolDocument,
                OperationName = "queryAuthorizedUserPool",
                Variables = this
            };
        }


        public static string QueryAuthorizedUserPoolDocument = @"
        query queryAuthorizedUserPool($unionid: String, $phone: String, $openid: String, $page: Int, $count: Int) {
          queryAuthorizedUserPool(unionid: $unionid, phone: $phone, openid: $openid, page: $page, count: $count) {
            list {
              userId
            }
            total
          }
        }
        ";
    }



    public class QueryClientResponse
    {

        [JsonProperty("queryClient")]
        public UserClient Result { get; set; }
    }

    public class QueryClientParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// QueryClientParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryClientDocument,
                OperationName = "queryClient",
                Variables = this
            };
        }


        public static string QueryClientDocument = @"
        query queryClient($id: String!) {
          queryClient(id: $id) {
            _id
            user {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            clientType {
              _id
              name
              description
              image
              example
            }
            userPoolTypes {
              _id
              name
              description
              image
              example
            }
            usersCount
            logo
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWXMPQRCode
            useMiniLogin
            useSelfWxapp
            allowedOrigins
            name
            secret
            token
            descriptions
            jwtExpired
            createdAt
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enable
            }
            loginFailCheck {
              timeInterval
              limit
              enable
            }
            enableEmail
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
            qrcodeLoginStrategy {
              qrcodeExpiresAfter
              returnFullUserInfo
              allowExchangeUserInfoFromBrowser
              ticketExpiresAfter
            }
            app2WxappLoginStrategy {
              ticketExpriresAfter
              ticketExchangeUserInfoNeedSecret
            }
          }
        }
        ";
    }



    public class QueryCollaborationByUserPoolIdAndUserIdResponse
    {

        [JsonProperty("queryCollaborationByUserPoolIdAndUserId")]
        public Collaboration Result { get; set; }
    }

    public class QueryCollaborationByUserPoolIdAndUserIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QueryCollaborationByUserPoolIdAndUserIdParam.Request 
        /// <para>Required variables:<br/> { userId=(string), userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryCollaborationByUserPoolIdAndUserIdDocument,
                OperationName = "queryCollaborationByUserPoolIdAndUserId",
                Variables = this
            };
        }


        public static string QueryCollaborationByUserPoolIdAndUserIdDocument = @"
        query queryCollaborationByUserPoolIdAndUserId($userId: String!, $userPoolId: String!) {
          queryCollaborationByUserPoolIdAndUserId(userId: $userId, userPoolId: $userPoolId) {
            _id
            createdAt
            owner {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            collaborator {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            userPool {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            permissionDescriptors {
              permissionId
              name
              operationAllow
            }
          }
        }
        ";
    }



    public class QueryCollaborativeUserPoolByUserIdResponse
    {

        [JsonProperty("queryCollaborativeUserPoolByUserId")]
        public CollaborativeUserPoolList Result { get; set; }
    }

    public class QueryCollaborativeUserPoolByUserIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryCollaborativeUserPoolByUserIdParam.Request 
        /// <para>Required variables:<br/> { userId=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryCollaborativeUserPoolByUserIdDocument,
                OperationName = "queryCollaborativeUserPoolByUserId",
                Variables = this
            };
        }


        public static string QueryCollaborativeUserPoolByUserIdDocument = @"
        query queryCollaborativeUserPoolByUserId($userId: String!, $page: Int, $count: Int) {
          queryCollaborativeUserPoolByUserId(userId: $userId, page: $page, count: $count) {
            list {
              _id
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class QueryCollaboratorPermissionsResponse
    {

        [JsonProperty("queryCollaboratorPermissions")]
        public CollaboratorPermissions Result { get; set; }
    }

    public class QueryCollaboratorPermissionsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("collaborationId")]
        public string CollaborationId { get; set; }

        /// <summary>
        /// QueryCollaboratorPermissionsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), collaborationId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryCollaboratorPermissionsDocument,
                OperationName = "queryCollaboratorPermissions",
                Variables = this
            };
        }


        public static string QueryCollaboratorPermissionsDocument = @"
        query queryCollaboratorPermissions($userId: String, $collaborationId: String) {
          queryCollaboratorPermissions(userId: $userId, collaborationId: $collaborationId) {
            collaborator {
              _id
              username
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              nickname
              company
              photo
              browser
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              device
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              oldPassword
              metadata
            }
            list {
              permissionId
              name
              operationAllow
            }
          }
        }
        ";
    }



    public class QueryCollaboratorsByUserPoolIdResponse
    {

        [JsonProperty("queryCollaboratorsByUserPoolId")]
        public Collaborators Result { get; set; }
    }

    public class QueryCollaboratorsByUserPoolIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// QueryCollaboratorsByUserPoolIdParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { count=(int), page=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryCollaboratorsByUserPoolIdDocument,
                OperationName = "queryCollaboratorsByUserPoolId",
                Variables = this
            };
        }


        public static string QueryCollaboratorsByUserPoolIdDocument = @"
        query queryCollaboratorsByUserPoolId($userPoolId: String!, $count: Int, $page: Int) {
          queryCollaboratorsByUserPoolId(userPoolId: $userPoolId, count: $count, page: $page) {
            collaborationId
            list {
              _id
              createdAt
            }
          }
        }
        ";
    }



    public class QueryInvitationResponse
    {

        [JsonProperty("queryInvitation")]
        public IEnumerable<Invitation> Result { get; set; }
    }

    public class QueryInvitationParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// QueryInvitationParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryInvitationDocument,
                OperationName = "queryInvitation",
                Variables = this
            };
        }


        public static string QueryInvitationDocument = @"
        query queryInvitation($client: String!) {
          queryInvitation(client: $client) {
            client
            phone
            isDeleted
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class QueryInvitationStateResponse
    {

        [JsonProperty("queryInvitationState")]
        public InvitationState Result { get; set; }
    }

    public class QueryInvitationStateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// QueryInvitationStateParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryInvitationStateDocument,
                OperationName = "queryInvitationState",
                Variables = this
            };
        }


        public static string QueryInvitationStateDocument = @"
        query queryInvitationState($client: String!) {
          queryInvitationState(client: $client) {
            client
            enablePhone
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class QueryMfaResponse
    {

        [JsonProperty("queryMFA")]
        public MFA Result { get; set; }
    }

    public class QueryMfaParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QueryMfaParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { _id=(string), userId=(string), userPoolId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryMfaDocument,
                OperationName = "queryMFA",
                Variables = this
            };
        }


        public static string QueryMfaDocument = @"
        query queryMFA($_id: String, $userId: String, $userPoolId: String) {
          queryMFA(_id: $_id, userId: $userId, userPoolId: $userPoolId) {
            _id
            userId
            userPoolId
            enable
            shareKey
          }
        }
        ";
    }



    public class QueryOperationLogsResponse
    {

        [JsonProperty("queryOperationLogs")]
        public OperationLogsList Result { get; set; }
    }

    public class QueryOperationLogsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("coll")]
        public string Coll { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryOperationLogsParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), coll=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryOperationLogsDocument,
                OperationName = "queryOperationLogs",
                Variables = this
            };
        }


        public static string QueryOperationLogsDocument = @"
        query queryOperationLogs($userPoolId: String!, $coll: String!, $page: Int, $count: Int) {
          queryOperationLogs(userPoolId: $userPoolId, coll: $coll, page: $page, count: $count) {
            totalCount
            list {
              operatorId
              operatorName
              operatorAvatar
              isAdmin
              isCollaborator
              isOwner
              operationType
              updatedFields
              removedFields
              operateAt
              fullDocument
              coll
            }
          }
        }
        ";
    }



    public class QueryPasswordFaasEnabledResponse
    {

        [JsonProperty("queryPasswordFaasEnabled")]
        public PaaswordFaas Result { get; set; }
    }

    public class QueryPasswordFaasEnabledParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// QueryPasswordFaasEnabledParam.Request 
        /// <para>Required variables:<br/> { client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryPasswordFaasEnabledDocument,
                OperationName = "queryPasswordFaasEnabled",
                Variables = this
            };
        }


        public static string QueryPasswordFaasEnabledDocument = @"
        query queryPasswordFaasEnabled($client: String!) {
          queryPasswordFaasEnabled(client: $client) {
            encryptUrl
            decryptUrl
            user
            client
            logs
            enable
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class QueryPasswordStrengthSettingsByUserPoolIdResponse
    {

        [JsonProperty("queryPasswordStrengthSettingsByUserPoolId")]
        public PasswordStrengthSettings Result { get; set; }
    }

    public class QueryPasswordStrengthSettingsByUserPoolIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QueryPasswordStrengthSettingsByUserPoolIdParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryPasswordStrengthSettingsByUserPoolIdDocument,
                OperationName = "queryPasswordStrengthSettingsByUserPoolId",
                Variables = this
            };
        }


        public static string QueryPasswordStrengthSettingsByUserPoolIdDocument = @"
        query queryPasswordStrengthSettingsByUserPoolId($userPoolId: String!) {
          queryPasswordStrengthSettingsByUserPoolId(userPoolId: $userPoolId) {
            userPoolId
            pwdStrength
          }
        }
        ";
    }



    public class QueryPermissionListResponse
    {

        [JsonProperty("queryPermissionList")]
        public PermissionList Result { get; set; }
    }

    public class QueryPermissionListParam
    {


        /// <summary>
        /// QueryPermissionListParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryPermissionListDocument,
                OperationName = "queryPermissionList"
            };
        }


        public static string QueryPermissionListDocument = @"
        query queryPermissionList {
          queryPermissionList {
            list {
              _id
              name
              affect
              description
            }
            totalCount
          }
        }
        ";
    }



    public class QueryProviderInfoByAppIdResponse
    {

        [JsonProperty("queryProviderInfoByAppId")]
        public ProviderGeneralInfo Result { get; set; }
    }

    public class QueryProviderInfoByAppIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// QueryProviderInfoByAppIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { appId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryProviderInfoByAppIdDocument,
                OperationName = "queryProviderInfoByAppId",
                Variables = this
            };
        }


        public static string QueryProviderInfoByAppIdDocument = @"
        query queryProviderInfoByAppId($appId: String) {
          queryProviderInfoByAppId(appId: $appId) {
            _id
            type
            name
            image
            domain
            clientId
            client_id
            css
            redirect_uris
          }
        }
        ";
    }



    public class QueryProviderInfoByDomainResponse
    {

        [JsonProperty("queryProviderInfoByDomain")]
        public ProviderGeneralInfo Result { get; set; }
    }

    public class QueryProviderInfoByDomainParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// QueryProviderInfoByDomainParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { domain=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryProviderInfoByDomainDocument,
                OperationName = "queryProviderInfoByDomain",
                Variables = this
            };
        }


        public static string QueryProviderInfoByDomainDocument = @"
        query queryProviderInfoByDomain($domain: String) {
          queryProviderInfoByDomain(domain: $domain) {
            _id
            type
            name
            image
            domain
            clientId
            client_id
            css
            redirect_uris
          }
        }
        ";
    }



    public class QueryRbacGroupUserListResponse
    {

        [JsonProperty("rbacGroup")]
        public RBACGroup Result { get; set; }
    }

    public class QueryRbacGroupUserListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// QueryRbacGroupUserListParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryRbacGroupUserListDocument,
                OperationName = "QueryRBACGroupUserList",
                Variables = this
            };
        }


        public static string QueryRbacGroupUserListDocument = @"
        query QueryRBACGroupUserList($_id: String!, $sortBy: SortByEnum = CREATEDAT_DESC, $page: Int = 0, $count: Int = 10) {
          rbacGroup(_id: $_id) {
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
              list {
                _id
                unionid
                email
                emailVerified
                username
                nickname
                company
                photo
                phone
                browser
                registerInClient
                registerMethod
                oauth
                token
                tokenExpiredAt
                loginsCount
                lastLogin
                lastIP
                signedUp
                blocked
                isDeleted
                metadata
              }
            }
          }
        }
        ";
    }



    public class QueryRoleByUserIdResponse
    {

        [JsonProperty("queryRoleByUserId")]
        public PagedUserGroup Result { get; set; }
    }

    public class QueryRoleByUserIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("user")]
        public string User { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// QueryRoleByUserIdParam.Request 
        /// <para>Required variables:<br/> { user=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryRoleByUserIdDocument,
                OperationName = "queryRoleByUserId",
                Variables = this
            };
        }


        public static string QueryRoleByUserIdDocument = @"
        query queryRoleByUserId($user: String!, $client: String!) {
          queryRoleByUserId(user: $user, client: $client) {
            list {
              _id
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class QuerySmsSendCountResponse
    {

        [JsonProperty("querySMSSendCount")]
        public SMSCountInfo Result { get; set; }
    }

    public class QuerySmsSendCountParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QuerySmsSendCountParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySmsSendCountDocument,
                OperationName = "querySMSSendCount",
                Variables = this
            };
        }


        public static string QuerySmsSendCountDocument = @"
        query querySMSSendCount($userPoolId: String!) {
          querySMSSendCount(userPoolId: $userPoolId) {
            count
            limitCount
          }
        }
        ";
    }



    public class QuerySystemOAuthSettingResponse
    {

        [JsonProperty("querySystemOAuthSetting")]
        public IEnumerable<OAuthList> Result { get; set; }
    }

    public class QuerySystemOAuthSettingParam
    {


        /// <summary>
        /// QuerySystemOAuthSettingParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QuerySystemOAuthSettingDocument,
                OperationName = "querySystemOAuthSetting"
            };
        }


        public static string QuerySystemOAuthSettingDocument = @"
        query querySystemOAuthSetting {
          querySystemOAuthSetting {
            _id
            name
            alias
            image
            description
            enabled
            url
            client
            user
            oAuthUrl
            wxappLogo
            fields {
              label
              type
              placeholder
              value
              checked
            }
            oauth {
              _id
              name
              alias
              image
              description
              enabled
              url
              client
              user
              oAuthUrl
              wxappLogo
            }
          }
        }
        ";
    }



    public class QueryUserPoolCommonInfoResponse
    {

        [JsonProperty("queryUserPoolCommonInfo")]
        public UserPoolCommonInfo Result { get; set; }
    }

    public class QueryUserPoolCommonInfoParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QueryUserPoolCommonInfoParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryUserPoolCommonInfoDocument,
                OperationName = "queryUserPoolCommonInfo",
                Variables = this
            };
        }


        public static string QueryUserPoolCommonInfoDocument = @"
        query queryUserPoolCommonInfo($userPoolId: String!) {
          queryUserPoolCommonInfo(userPoolId: $userPoolId) {
            _id
            changePhoneStrategy {
              verifyOldPhone
            }
            changeEmailStrategy {
              verifyOldEmail
            }
          }
        }
        ";
    }



    public class RbacGroupListResponse
    {

        [JsonProperty("rbacGroupList")]
        public PagedRBACGroup Result { get; set; }
    }

    public class RbacGroupListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// RbacGroupListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RbacGroupListDocument,
                OperationName = "rbacGroupList",
                Variables = this
            };
        }


        public static string RbacGroupListDocument = @"
        query rbacGroupList($userPoolId: String!, $sortBy: SortByEnum, $page: Int, $count: Int) {
          rbacGroupList(userPoolId: $userPoolId, sortBy: $sortBy, page: $page, count: $count) {
            totalCount
            list {
              _id
              userPoolId
              name
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class RbacPermissionResponse
    {

        [JsonProperty("rbacPermission")]
        public RBACPermission Result { get; set; }
    }

    public class RbacPermissionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RbacPermissionParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RbacPermissionDocument,
                OperationName = "rbacPermission",
                Variables = this
            };
        }


        public static string RbacPermissionDocument = @"
        query rbacPermission($_id: String!) {
          rbacPermission(_id: $_id) {
            _id
            name
            userPoolId
            createdAt
            updatedAt
            description
          }
        }
        ";
    }



    public class RbacPermissionListResponse
    {

        [JsonProperty("rbacPermissionList")]
        public PagedRBACPermission Result { get; set; }
    }

    public class RbacPermissionListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// RbacPermissionListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RbacPermissionListDocument,
                OperationName = "rbacPermissionList",
                Variables = this
            };
        }


        public static string RbacPermissionListDocument = @"
        query rbacPermissionList($userPoolId: String!, $sortBy: SortByEnum, $page: Int, $count: Int) {
          rbacPermissionList(userPoolId: $userPoolId, sortBy: $sortBy, page: $page, count: $count) {
            totalCount
            list {
              _id
              name
              userPoolId
              createdAt
              updatedAt
              description
            }
          }
        }
        ";
    }



    public class RbacRoleResponse
    {

        [JsonProperty("rbacRole")]
        public RBACRole Result { get; set; }
    }

    public class RbacRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RbacRoleParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RbacRoleDocument,
                OperationName = "rbacRole",
                Variables = this
            };
        }


        public static string RbacRoleDocument = @"
        query rbacRole($sortBy: SortByEnum, $page: Int, $count: Int, $_id: String!) {
          rbacRole(_id: $_id) {
            _id
            userPoolId
            name
            description
            createdAt
            updatedAt
            permissions {
              totalCount
            }
            users(sortBy: $sortBy, page: $page, count: $count) {
              totalCount
            }
          }
        }
        ";
    }



    public class RbacRoleListResponse
    {

        [JsonProperty("rbacRoleList")]
        public PagedRBACRole Result { get; set; }
    }

    public class RbacRoleListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// RbacRoleListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { sortBy=(SortByEnum), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RbacRoleListDocument,
                OperationName = "rbacRoleList",
                Variables = this
            };
        }


        public static string RbacRoleListDocument = @"
        query rbacRoleList($userPoolId: String!, $sortBy: SortByEnum, $page: Int, $count: Int) {
          rbacRoleList(userPoolId: $userPoolId, sortBy: $sortBy, page: $page, count: $count) {
            totalCount
            list {
              _id
              userPoolId
              name
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class RecentServiceCallResponse
    {

        [JsonProperty("recentServiceCall")]
        public DayServiceCallListOfAllServices Result { get; set; }
    }

    public class RecentServiceCallParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("today")]
        public string Today { get; set; }

        /// <summary>
        /// RecentServiceCallParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { today=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RecentServiceCallDocument,
                OperationName = "recentServiceCall",
                Variables = this
            };
        }


        public static string RecentServiceCallDocument = @"
        query recentServiceCall($today: String) {
          recentServiceCall(today: $today) {
            userService {
              day
              count
            }
            emailService {
              day
              count
            }
            oAuthService {
              day
              count
            }
            payService {
              day
              count
            }
          }
        }
        ";
    }



    public class RegisterEveryDayCountResponse
    {

        [JsonProperty("registerEveryDayCount")]
        public RegisterEveryDayCount Result { get; set; }
    }

    public class RegisterEveryDayCountParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// RegisterEveryDayCountParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { client=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterEveryDayCountDocument,
                OperationName = "registerEveryDayCount",
                Variables = this
            };
        }


        public static string RegisterEveryDayCountDocument = @"
        query registerEveryDayCount($client: String) {
          registerEveryDayCount(client: $client) {
            list
          }
        }
        ";
    }



    public class RegisterMethodTopListResponse
    {

        [JsonProperty("registerMethodTopList")]
        public IEnumerable<RegisterMethodList> Result { get; set; }
    }

    public class RegisterMethodTopListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// RegisterMethodTopListParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterMethodTopListDocument,
                OperationName = "registerMethodTopList",
                Variables = this
            };
        }


        public static string RegisterMethodTopListDocument = @"
        query registerMethodTopList($userPoolId: String!) {
          registerMethodTopList(userPoolId: $userPoolId) {
            method
            count
          }
        }
        ";
    }



    public class RequestListResponse
    {

        [JsonProperty("requestList")]
        public PagedRequestList Result { get; set; }
    }

    public class RequestListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// RequestListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RequestListDocument,
                OperationName = "requestList",
                Variables = this
            };
        }


        public static string RequestListDocument = @"
        query requestList($page: Int, $count: Int) {
          requestList(page: $page, count: $count) {
            totalCount
            list {
              _id
              when
              where
              ip
              size
              responseTime
              service
            }
          }
        }
        ";
    }



    public class RuleByIdResponse
    {

        [JsonProperty("ruleById")]
        public Rule Result { get; set; }
    }

    public class RuleByIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// RuleByIdParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RuleByIdDocument,
                OperationName = "ruleById",
                Variables = this
            };
        }


        public static string RuleByIdDocument = @"
        query ruleById($_id: String!) {
          ruleById(_id: $_id) {
            _id
            userPoolId
            name
            description
            type
            enabled
            faasUrl
            code
            order
            async
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class RuleEnvResponse
    {

        [JsonProperty("ruleEnv")]
        public PagedRuleEnvVariable Result { get; set; }
    }

    public class RuleEnvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// RuleEnvParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RuleEnvDocument,
                OperationName = "ruleEnv",
                Variables = this
            };
        }


        public static string RuleEnvDocument = @"
        query ruleEnv($userPoolId: String!) {
          ruleEnv(userPoolId: $userPoolId) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class RulesResponse
    {

        [JsonProperty("rules")]
        public PagedRules Result { get; set; }
    }

    public class RulesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// RulesParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RulesDocument,
                OperationName = "rules",
                Variables = this
            };
        }


        public static string RulesDocument = @"
        query rules($userPoolId: String!) {
          rules(userPoolId: $userPoolId) {
            totalCount
            list {
              _id
              userPoolId
              name
              description
              type
              enabled
              faasUrl
              code
              order
              async
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class SearchOrgNodesResponse
    {

        [JsonProperty("searchOrgNodes")]
        public IEnumerable<RBACGroup> Result { get; set; }
    }

    public class SearchOrgNodesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("metadata")]
        public KeyValuePair Metadata { get; set; }

        /// <summary>
        /// SearchOrgNodesParam.Request 
        /// <para>Required variables:<br/> { orgId=(string) }</para>
        /// <para>Optional variables:<br/> { name=(string), metadata=(KeyValuePair[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SearchOrgNodesDocument,
                OperationName = "searchOrgNodes",
                Variables = this
            };
        }


        public static string SearchOrgNodesDocument = @"
        query searchOrgNodes($orgId: String!, $name: String, $metadata: [KeyValuePair!]) {
          searchOrgNodes(orgId: $orgId, name: $name, metadata: $metadata) {
            _id
            name
            description
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class SearchUserResponse
    {

        [JsonProperty("searchUser")]
        public PagedUsers Result { get; set; }
    }

    public class SearchUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// SearchUserParam.Request 
        /// <para>Required variables:<br/> { type=(string), value=(string), registerInClient=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SearchUserDocument,
                OperationName = "searchUser",
                Variables = this
            };
        }


        public static string SearchUserDocument = @"
        query searchUser($type: String!, $value: String!, $registerInClient: String!, $page: Int, $count: Int) {
          searchUser(type: $type, value: $value, registerInClient: $registerInClient, page: $page, count: $count) {
            list {
              _id
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              username
              nickname
              company
              photo
              browser
              device
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              customData
              metadata
            }
            totalCount
          }
        }
        ";
    }



    public class SearchUserBasicInfoByIdResponse
    {

        [JsonProperty("searchUserBasicInfoById")]
        public BasicUserInfo Result { get; set; }
    }

    public class SearchUserBasicInfoByIdParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// SearchUserBasicInfoByIdParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SearchUserBasicInfoByIdDocument,
                OperationName = "searchUserBasicInfoById",
                Variables = this
            };
        }


        public static string SearchUserBasicInfoByIdDocument = @"
        query searchUserBasicInfoById($userId: String) {
          searchUserBasicInfoById(userId: $userId) {
            _id
            username
            photo
            email
          }
        }
        ";
    }



    public class StatisticResponse
    {

        [JsonProperty("statistic")]
        public Statistic Result { get; set; }
    }

    public class StatisticParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// StatisticParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { sortBy=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = StatisticDocument,
                OperationName = "statistic",
                Variables = this
            };
        }


        public static string StatisticDocument = @"
        query statistic($sortBy: String, $page: Int, $count: Int) {
          statistic(sortBy: $sortBy, page: $page, count: $count) {
            list {
              _id
              username
              email
              loginsCount
              appsCount
              OAuthCount
            }
            totalCount
          }
        }
        ";
    }



    public class TodayGeoDistributionResponse
    {

        [JsonProperty("todayGeoDistribution")]
        public IEnumerable<GeographicalDistributionList> Result { get; set; }
    }

    public class TodayGeoDistributionParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("today")]
        public string Today { get; set; }

        /// <summary>
        /// TodayGeoDistributionParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { today=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = TodayGeoDistributionDocument,
                OperationName = "todayGeoDistribution",
                Variables = this
            };
        }


        public static string TodayGeoDistributionDocument = @"
        query todayGeoDistribution($today: String) {
          todayGeoDistribution(today: $today) {
            city
            size
            point
          }
        }
        ";
    }



    public class UserResponse
    {

        [JsonProperty("user")]
        public ExtendUser Result { get; set; }
    }

    public class UserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("auth")]
        public bool Auth { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userLoginHistoryPage")]
        public int UserLoginHistoryPage { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userLoginHistoryCount")]
        public int UserLoginHistoryCount { get; set; }

        /// <summary>
        /// UserParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { id=(string), registerInClient=(string), token=(string), auth=(bool), userLoginHistoryPage=(int), userLoginHistoryCount=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserDocument,
                OperationName = "user",
                Variables = this
            };
        }


        public static string UserDocument = @"
        query user($id: String, $registerInClient: String, $token: String, $auth: Boolean, $userLoginHistoryPage: Int, $userLoginHistoryCount: Int) {
          user(id: $id, registerInClient: $registerInClient, token: $token, auth: $auth, userLoginHistoryPage: $userLoginHistoryPage, userLoginHistoryCount: $userLoginHistoryCount) {
            _id
            email
            unionid
            openid
            emailVerified
            phone
            phoneVerified
            username
            nickname
            company
            photo
            browser
            device
            password
            registerInClient
            registerMethod
            oauth
            token
            tokenExpiredAt
            loginsCount
            lastLogin
            lastIP
            signedUp
            blocked
            isDeleted
            name
            givenName
            familyName
            middleName
            profile
            preferredUsername
            website
            gender
            birthdate
            zoneinfo
            locale
            address
            formatted
            streetAddress
            locality
            region
            postalCode
            country
            updatedAt
            metadata
          }
        }
        ";
    }



    public class UserAnalyticsResponse
    {

        [JsonProperty("userAnalytics")]
        public UserAnalytics Result { get; set; }
    }

    public class UserAnalyticsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// UserAnalyticsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { clientId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserAnalyticsDocument,
                OperationName = "userAnalytics",
                Variables = this
            };
        }


        public static string UserAnalyticsDocument = @"
        query userAnalytics($clientId: String) {
          userAnalytics(clientId: $clientId) {
            usersAddedToday {
              length
            }
            usersAddedLastWeek {
              length
            }
            usersLoginLastWeek {
              length
            }
            totalUsers {
              length
            }
            allUsers
            totalApps
          }
        }
        ";
    }



    public class UserClientListResponse
    {

        [JsonProperty("userClientList")]
        public PagedUserClientList Result { get; set; }
    }

    public class UserClientListParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// UserClientListParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int), sortBy=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserClientListDocument,
                OperationName = "userClientList",
                Variables = this
            };
        }


        public static string UserClientListDocument = @"
        query userClientList($page: Int, $count: Int, $sortBy: String) {
          userClientList(page: $page, count: $count, sortBy: $sortBy) {
            list {
              _id
              name
              createdAt
              usersCount
            }
            totalCount
          }
        }
        ";
    }



    public class UserClientTypesResponse
    {

        [JsonProperty("userClientTypes")]
        public IEnumerable<UserClientType> Result { get; set; }
    }

    public class UserClientTypesParam
    {


        /// <summary>
        /// UserClientTypesParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserClientTypesDocument,
                OperationName = "userClientTypes"
            };
        }


        public static string UserClientTypesDocument = @"
        query userClientTypes {
          userClientTypes {
            _id
            name
            description
            image
            example
          }
        }
        ";
    }



    public class UserClientsResponse
    {

        [JsonProperty("userClients")]
        public PagedUserClients Result { get; set; }
    }

    public class UserClientsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("computeUsersCount")]
        public bool ComputeUsersCount { get; set; }

        /// <summary>
        /// UserClientsParam.Request 
        /// <para>Required variables:<br/> { userId=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int), computeUsersCount=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserClientsDocument,
                OperationName = "userClients",
                Variables = this
            };
        }


        public static string UserClientsDocument = @"
        query userClients($userId: String!, $page: Int, $count: Int, $computeUsersCount: Boolean) {
          userClients(userId: $userId, page: $page, count: $count, computeUsersCount: $computeUsersCount) {
            list {
              _id
              usersCount
              logo
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWXMPQRCode
              useMiniLogin
              useSelfWxapp
              allowedOrigins
              name
              secret
              token
              descriptions
              jwtExpired
              createdAt
              isDeleted
              enableEmail
            }
            totalCount
          }
        }
        ";
    }



    public class UserExistResponse
    {

        [JsonProperty("userExist")]
        public bool? Result { get; set; }
    }

    public class UserExistParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// UserExistParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string) }</para>
        /// <para>Optional variables:<br/> { email=(string), phone=(string), username=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserExistDocument,
                OperationName = "userExist",
                Variables = this
            };
        }


        public static string UserExistDocument = @"
        query userExist($userPoolId: String!, $email: String, $phone: String, $username: String) {
          userExist(userPoolId: $userPoolId, email: $email, phone: $phone, username: $username)
        }
        ";
    }



    public class UserGroupResponse
    {

        [JsonProperty("userGroup")]
        public PagedUserGroup Result { get; set; }
    }

    public class UserGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("client")]
        public string Client { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// UserGroupParam.Request 
        /// <para>Required variables:<br/> { group=(string), client=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserGroupDocument,
                OperationName = "userGroup",
                Variables = this
            };
        }


        public static string UserGroupDocument = @"
        query userGroup($group: String!, $client: String!, $page: Int, $count: Int) {
          userGroup(group: $group, client: $client, page: $page, count: $count) {
            list {
              _id
              createdAt
            }
            totalCount
          }
        }
        ";
    }



    public class UserGroupListResponse
    {

        [JsonProperty("userGroupList")]
        public UserGroupList Result { get; set; }
    }

    public class UserGroupListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// UserGroupListParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserGroupListDocument,
                OperationName = "userGroupList",
                Variables = this
            };
        }


        public static string UserGroupListDocument = @"
        query userGroupList($_id: String!) {
          userGroupList(_id: $_id) {
            totalCount
            list {
              _id
              userPoolId
              name
              description
              createdAt
              updatedAt
            }
            rawList
          }
        }
        ";
    }



    public class UserMetadataResponse
    {

        [JsonProperty("userMetadata")]
        public UserMetaDataList Result { get; set; }
    }

    public class UserMetadataParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// UserMetadataParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserMetadataDocument,
                OperationName = "userMetadata",
                Variables = this
            };
        }


        public static string UserMetadataDocument = @"
        query userMetadata($_id: String!) {
          userMetadata(_id: $_id) {
            totalCount
            list {
              key
              value
            }
          }
        }
        ";
    }



    public class UserOAuthCountResponse
    {

        [JsonProperty("userOAuthCount")]
        public IEnumerable<int?> Result { get; set; }
    }

    public class UserOAuthCountParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// UserOAuthCountParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userIds=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserOAuthCountDocument,
                OperationName = "userOAuthCount",
                Variables = this
            };
        }


        public static string UserOAuthCountDocument = @"
        query userOAuthCount($userIds: [String]) {
          userOAuthCount(userIds: $userIds)
        }
        ";
    }



    public class UserPatchResponse
    {

        [JsonProperty("userPatch")]
        public PatchExtendUser Result { get; set; }
    }

    public class UserPatchParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// UserPatchParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { ids=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserPatchDocument,
                OperationName = "userPatch",
                Variables = this
            };
        }


        public static string UserPatchDocument = @"
        query userPatch($ids: String) {
          userPatch(ids: $ids) {
            list {
              _id
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              username
              nickname
              company
              photo
              browser
              device
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              customData
              metadata
            }
            totalCount
          }
        }
        ";
    }



    public class UserPermissionListResponse
    {

        [JsonProperty("userPermissionList")]
        public UserPermissionList Result { get; set; }
    }

    public class UserPermissionListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// UserPermissionListParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserPermissionListDocument,
                OperationName = "userPermissionList",
                Variables = this
            };
        }


        public static string UserPermissionListDocument = @"
        query userPermissionList($_id: String!) {
          userPermissionList(_id: $_id) {
            totalCount
            list {
              _id
              name
              userPoolId
              createdAt
              updatedAt
              description
            }
            rawList
          }
        }
        ";
    }



    public class UserRoleListResponse
    {

        [JsonProperty("userRoleList")]
        public UserRoleList Result { get; set; }
    }

    public class UserRoleListParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("_id")]
        public string _Id { get; set; }

        /// <summary>
        /// UserRoleListParam.Request 
        /// <para>Required variables:<br/> { _id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserRoleListDocument,
                OperationName = "userRoleList",
                Variables = this
            };
        }


        public static string UserRoleListDocument = @"
        query userRoleList($_id: String!) {
          userRoleList(_id: $_id) {
            totalCount
            list {
              _id
              userPoolId
              name
              description
              createdAt
              updatedAt
            }
            rawList
          }
        }
        ";
    }



    public class UsersResponse
    {

        [JsonProperty("users")]
        public PagedUsers Result { get; set; }
    }

    public class UsersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("registerInClient")]
        public string RegisterInClient { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("populate")]
        public bool Populate { get; set; }

        /// <summary>
        /// UsersParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { registerInClient=(string), page=(int), count=(int), populate=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UsersDocument,
                OperationName = "users",
                Variables = this
            };
        }


        public static string UsersDocument = @"
        query users($registerInClient: String, $page: Int, $count: Int, $populate: Boolean) {
          users(registerInClient: $registerInClient, page: $page, count: $count, populate: $populate) {
            list {
              _id
              email
              unionid
              openid
              emailVerified
              phone
              phoneVerified
              username
              nickname
              company
              photo
              browser
              device
              password
              registerInClient
              registerMethod
              oauth
              token
              tokenExpiredAt
              loginsCount
              lastLogin
              lastIP
              signedUp
              blocked
              isDeleted
              name
              givenName
              familyName
              middleName
              profile
              preferredUsername
              website
              gender
              birthdate
              zoneinfo
              locale
              address
              formatted
              streetAddress
              locality
              region
              postalCode
              country
              updatedAt
              customData
              metadata
            }
            totalCount
          }
        }
        ";
    }



    public class UsersByOidcAppResponse
    {

        [JsonProperty("usersByOidcApp")]
        public UserIds Result { get; set; }
    }

    public class UsersByOidcAppParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("appId")]
        public string AppId { get; set; }

        /// <summary>
        /// UsersByOidcAppParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userPoolId=(string), page=(int), count=(int), appId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UsersByOidcAppDocument,
                OperationName = "usersByOidcApp",
                Variables = this
            };
        }


        public static string UsersByOidcAppDocument = @"
        query usersByOidcApp($userPoolId: String, $page: Int, $count: Int, $appId: String) {
          usersByOidcApp(userPoolId: $userPoolId, page: $page, count: $count, appId: $appId) {
            list
            totalCount
          }
        }
        ";
    }



    public class UsersInGroupResponse
    {

        [JsonProperty("usersInGroup")]
        public UsersInGroup Result { get; set; }
    }

    public class UsersInGroupParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("group")]
        public string Group { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// UsersInGroupParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { group=(string), page=(int), count=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UsersInGroupDocument,
                OperationName = "usersInGroup",
                Variables = this
            };
        }


        public static string UsersInGroupDocument = @"
        query usersInGroup($group: String, $page: Int, $count: Int) {
          usersInGroup(group: $group, page: $page, count: $count) {
            list {
              email
              username
              _id
              upgrade
            }
            totalCount
          }
        }
        ";
    }



    public class ValidatePasswordResponse
    {

        [JsonProperty("validatePassword")]
        public ValidateResult Result { get; set; }
    }

    public class ValidatePasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPool")]
        public string UserPool { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("encryptedPassword")]
        public string EncryptedPassword { get; set; }

        /// <summary>
        /// ValidatePasswordParam.Request 
        /// <para>Required variables:<br/> { userPool=(string), password=(string), encryptedPassword=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ValidatePasswordDocument,
                OperationName = "validatePassword",
                Variables = this
            };
        }


        public static string ValidatePasswordDocument = @"
        query validatePassword($userPool: String!, $password: String!, $encryptedPassword: String!) {
          validatePassword(userPool: $userPool, password: $password, encryptedPassword: $encryptedPassword) {
            isValid
          }
        }
        ";
    }



    public class WxQrCodeLogResponse
    {

        [JsonProperty("wxQRCodeLog")]
        public WxQRCodeLog Result { get; set; }
    }

    public class WxQrCodeLogParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("count")]
        public int Count { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public string SortBy { get; set; }

        /// <summary>
        /// WxQrCodeLogParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), count=(int), clientId=(string), sortBy=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = WxQrCodeLogDocument,
                OperationName = "wxQRCodeLog",
                Variables = this
            };
        }


        public static string WxQrCodeLogDocument = @"
        query wxQRCodeLog($page: Int, $count: Int, $clientId: String, $sortBy: String) {
          wxQRCodeLog(page: $page, count: $count, clientId: $clientId, sortBy: $sortBy) {
            list {
              random
              expiredAt
              createdAt
              success
              qrcode
              used
              accessToken
              openid
              userInfo
              redirect
            }
            totalCount
          }
        }
        ";
    }

}