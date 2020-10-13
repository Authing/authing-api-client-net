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
        [JsonProperty("qiniuUptoken")]
        public string QiniuUptoken { get; set; }

        [JsonProperty("isDomainAvaliable")]
        public bool? IsDomainAvaliable { get; set; }

        /// <summary>
        /// 获取社会化登录定义
        /// </summary>
        [JsonProperty("socialConnection")]
        public SocialConnection SocialConnection { get; set; }

        /// <summary>
        /// 获取所有社会化登录定义
        /// </summary>
        [JsonProperty("socialConnections")]
        public List<SocialConnection> SocialConnections { get; set; }

        /// <summary>
        /// 获取当前用户池的社会化登录配置
        /// </summary>
        [JsonProperty("socialConnectionInstance")]
        public SocialConnectionInstance SocialConnectionInstance { get; set; }

        /// <summary>
        /// 获取当前用户池的所有社会化登录配置
        /// </summary>
        [JsonProperty("socialConnectionInstances")]
        public List<SocialConnectionInstance> SocialConnectionInstances { get; set; }

        [JsonProperty("emailTemplates")]
        public List<EmailTemplate> EmailTemplates { get; set; }

        [JsonProperty("previewEmail")]
        public string PreviewEmail { get; set; }

        /// <summary>
        /// 获取函数模版
        /// </summary>
        [JsonProperty("templateCode")]
        public string TemplateCode { get; set; }

        [JsonProperty("function")]
        public Function Function { get; set; }

        [JsonProperty("functions")]
        public PaginatedFunctions Functions { get; set; }

        [JsonProperty("group")]
        public Group Group { get; set; }

        [JsonProperty("groups")]
        public PaginatedGroups Groups { get; set; }

        /// <summary>
        /// 查询 MFA 信息
        /// </summary>
        [JsonProperty("queryMfa")]
        public Mfa QueryMfa { get; set; }

        [JsonProperty("nodeById")]
        public Node NodeById { get; set; }

        /// <summary>
        /// 通过 code 查询节点
        /// </summary>
        [JsonProperty("nodeByCode")]
        public Node NodeByCode { get; set; }

        /// <summary>
        /// 查询组织机构详情
        /// </summary>
        [JsonProperty("org")]
        public Org Org { get; set; }

        /// <summary>
        /// 查询用户池组织机构列表
        /// </summary>
        [JsonProperty("orgs")]
        public PaginatedOrgs Orgs { get; set; }

        /// <summary>
        /// 查询子节点列表
        /// </summary>
        [JsonProperty("childrenNodes")]
        public List<Node> ChildrenNodes { get; set; }

        [JsonProperty("rootNode")]
        public Node RootNode { get; set; }

        [JsonProperty("isRootNode")]
        public bool? IsRootNode { get; set; }

        [JsonProperty("checkPasswordStrength")]
        public CheckPasswordStrengthResult CheckPasswordStrength { get; set; }

        [JsonProperty("isActionAllowed")]
        public bool IsActionAllowed { get; set; }

        [JsonProperty("isActionDenied")]
        public bool IsActionDenied { get; set; }

        [JsonProperty("policy")]
        public Policy Policy { get; set; }

        [JsonProperty("policies")]
        public PaginatedPolicies Policies { get; set; }

        [JsonProperty("policyAssignments")]
        public PaginatedPolicyAssignment PolicyAssignments { get; set; }

        /// <summary>
        /// 通过 **code** 查询角色详情
        /// </summary>
        [JsonProperty("role")]
        public Role Role { get; set; }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        [JsonProperty("roles")]
        public PaginatedRoles Roles { get; set; }

        /// <summary>
        /// 查询某个实体定义的自定义数据
        /// </summary>
        [JsonProperty("udv")]
        public List<UserDefinedData> Udv { get; set; }

        /// <summary>
        /// 查询用户池定义的自定义字段
        /// </summary>
        [JsonProperty("udf")]
        public List<UserDefinedField> Udf { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("userBatch")]
        public List<User> UserBatch { get; set; }

        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }

        [JsonProperty("searchUser")]
        public PaginatedUsers SearchUser { get; set; }

        [JsonProperty("checkLoginStatus")]
        public JWTTokenStatus CheckLoginStatus { get; set; }

        [JsonProperty("isUserExists")]
        public bool? IsUserExists { get; set; }

        /// <summary>
        /// 查询用户池详情
        /// </summary>
        [JsonProperty("userpool")]
        public UserPool Userpool { get; set; }

        /// <summary>
        /// 查询用户池列表
        /// </summary>
        [JsonProperty("userpools")]
        public PaginatedUserpool Userpools { get; set; }

        [JsonProperty("userpoolTypes")]
        public List<UserPoolType> UserpoolTypes { get; set; }

        /// <summary>
        /// 获取 accessToken ，如 SDK 初始化
        /// </summary>
        [JsonProperty("accessToken")]
        public AccessTokenRes AccessToken { get; set; }

        /// <summary>
        /// 用户池注册白名单列表
        /// </summary>
        [JsonProperty("whitelist")]
        public List<WhiteList> Whitelist { get; set; }
        #endregion
    }
    #endregion

    #region SocialConnection
    public class SocialConnection
    {
        #region members
        /// <summary>
        /// 社会化登录服务商唯一标志
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// logo
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 表单字段
        /// </summary>
        [JsonProperty("fields")]
        public List<SocialConnectionField> Fields { get; set; }
        #endregion
    }
    #endregion

    #region SocialConnectionField
    public class SocialConnectionField
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("children")]
        public List<SocialConnectionField> Children { get; set; }
        #endregion
    }
    #endregion

    #region SocialConnectionInstance
    public class SocialConnectionInstance
    {
        #region members
        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("fields")]
        public List<SocialConnectionInstanceField> Fields { get; set; }
        #endregion
    }
    #endregion

    #region SocialConnectionInstanceField
    public class SocialConnectionInstanceField
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion

    #region EmailTemplate
    public class EmailTemplate
    {
        #region members
        /// <summary>
        /// 邮件模版类型
        /// </summary>
        [JsonProperty("type")]
        public EmailTemplateType Type { get; set; }

        /// <summary>
        /// 模版名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        [JsonProperty("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 显示的邮件发送人
        /// </summary>
        [JsonProperty("sender")]
        public string Sender { get; set; }

        /// <summary>
        /// 邮件模版内容
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 重定向链接，操作成功后，用户将被重定向到此 URL。
        /// </summary>
        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        /// <summary>
        /// 验证码过期时间（单位为秒）
        /// </summary>
        [JsonProperty("expiresIn")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// 是否开启（自定义模版）
        /// </summary>
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 是否是系统默认模版
        /// </summary>
        [JsonProperty("isSystem")]
        public bool? IsSystem { get; set; }
        #endregion
    }
    #endregion
    public enum EmailTemplateType
    {
        /// <summary>
        /// 重置密码确认
        /// </summary>
        [JsonProperty("RESET_PASSWORD")]
        RESET_PASSWORD,
        /// <summary>
        /// 重置密码通知
        /// </summary>
        [JsonProperty("PASSWORD_RESETED_NOTIFICATION")]
        PASSWORD_RESETED_NOTIFICATION,
        /// <summary>
        /// 修改密码验证码
        /// </summary>
        [JsonProperty("CHANGE_PASSWORD")]
        CHANGE_PASSWORD,
        /// <summary>
        /// 注册欢迎邮件
        /// </summary>
        [JsonProperty("WELCOME")]
        WELCOME,
        /// <summary>
        /// 验证邮箱
        /// </summary>
        [JsonProperty("VERIFY_EMAIL")]
        VERIFY_EMAIL,
        /// <summary>
        /// 修改绑定邮箱
        /// </summary>
        [JsonProperty("CHANGE_EMAIL")]
        CHANGE_EMAIL
    }


    #region Function
    /// <summary>
    /// 函数
    /// </summary>
    public class Function
    {
        #region members
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 源代码
        /// </summary>
        [JsonProperty("sourceCode")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 云函数链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        #endregion
    }
    #endregion
    public enum SortByEnum
    {
        /// <summary>
        /// 按照创建时间降序（后创建的在前面）
        /// </summary>
        [JsonProperty("CREATEDAT_DESC")]
        CREATEDAT_DESC,
        /// <summary>
        /// 按照创建时间升序（先创建的在前面）
        /// </summary>
        [JsonProperty("CREATEDAT_ASC")]
        CREATEDAT_ASC,
        /// <summary>
        /// 按照更新时间降序（最近更新的在前面）
        /// </summary>
        [JsonProperty("UPDATEDAT_DESC")]
        UPDATEDAT_DESC,
        /// <summary>
        /// 按照更新时间升序（最近更新的在后面）
        /// </summary>
        [JsonProperty("UPDATEDAT_ASC")]
        UPDATEDAT_ASC
    }


    #region PaginatedFunctions
    public class PaginatedFunctions
    {
        #region members
        [JsonProperty("list")]
        public List<Function> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region Group
    public class Group
    {
        #region members
        /// <summary>
        /// 唯一标志 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 包含的用户列表
        /// </summary>
        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedUsers
    public class PaginatedUsers
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<User> List { get; set; }
        #endregion
    }
    #endregion

    #region User
    public class User
    {
        #region members
        /// <summary>
        /// 用户 ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("arn")]
        public string Arn { get; set; }

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
        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 手机号，用户池内唯一
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机号是否已验证
        /// </summary>
        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 用户的身份信息
        /// </summary>
        [JsonProperty("identities")]
        public List<Identity> Identities { get; set; }

        /// <summary>
        /// 昵称，该字段不唯一。
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("registerSource")]
        public List<string> RegisterSource { get; set; }

        /// <summary>
        /// 头像链接，默认为 https://usercontents.authing.cn/authing-avatar.png
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 用户密码，数据库使用密钥加 salt 进行加密，非原文密码。
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 用户社会化登录第三方身份提供商返回的原始用户信息，非社会化登录方式注册的用户此字段为空。
        /// </summary>
        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        /// <summary>
        /// 用户登录凭证，开发者可以在后端检验该 token 的合法性，从而验证用户身份。详细文档请见：[验证 Token](https://docs.authing.co/advanced/verify-jwt-token.html)
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }

        /// <summary>
        /// token 过期时间
        /// </summary>
        [JsonProperty("tokenExpiredAt")]
        public string TokenExpiredAt { get; set; }

        /// <summary>
        /// 用户登录总次数
        /// </summary>
        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        /// <summary>
        /// 用户最近一次登录时间
        /// </summary>
        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        /// <summary>
        /// 用户上一次登录时使用的 IP
        /// </summary>
        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        /// <summary>
        /// 用户注册时间
        /// </summary>
        [JsonProperty("signedUp")]
        public string SignedUp { get; set; }

        /// <summary>
        /// 该账号是否被禁用
        /// </summary>
        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

        /// <summary>
        /// 账号是否被软删除
        /// </summary>
        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

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

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 自定义用户数据，是一个 JSON 序列化过后的字符串
        /// </summary>
        [JsonProperty("customData")]
        public string CustomData { get; set; }

        [JsonProperty("roles")]
        public PaginatedRoles Roles { get; set; }

        [JsonProperty("groups")]
        public PaginatedGroups Groups { get; set; }
        #endregion
    }
    #endregion

    #region Identity
    public class Identity
    {
        #region members
        [JsonProperty("openid")]
        public string Openid { get; set; }

        [JsonProperty("userIdInIdp")]
        public string UserIdInIdp { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("isSocial")]
        public bool? IsSocial { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedRoles
    public class PaginatedRoles
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Role> List { get; set; }
        #endregion
    }
    #endregion

    #region Role
    public class Role
    {
        #region members
        /// <summary>
        /// 唯一标志 code
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 资源描述符 arn
        /// </summary>
        [JsonProperty("arn")]
        public string Arn { get; set; }

        /// <summary>
        /// 角色描述
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 是否为系统内建，系统内建的角色不能删除
        /// </summary>
        [JsonProperty("isSystem")]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 被授予此角色的用户列表
        /// </summary>
        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }

        /// <summary>
        /// 父角色
        /// </summary>
        [JsonProperty("parent")]
        public Role Parent { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedGroups
    public class PaginatedGroups
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Group> List { get; set; }
        #endregion
    }
    #endregion

    #region Mfa
    public class Mfa
    {
        #region members
        /// <summary>
        /// MFA ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 用户 ID
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户池 ID
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// 是否开启 MFA
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// 密钥
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
        #endregion
    }
    #endregion

    #region Node
    public class Node
    {
        #region members
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 多语言名称，**key** 为标准 **i18n** 语言编码，**value** 为对应语言的名称。
        /// </summary>
        [JsonProperty("nameI18n")]
        public string NameI18n { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 多语言描述信息
        /// </summary>
        [JsonProperty("descriptionI18n")]
        public string DescriptionI18n { get; set; }

        /// <summary>
        /// 在父节点中的次序值。**order** 值大的排序靠前。有效的值范围是[0, 2^32)
        /// </summary>
        [JsonProperty("order")]
        public int? Order { get; set; }

        /// <summary>
        /// 节点唯一标志码，可以通过 code 进行搜索
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 是否为根节点
        /// </summary>
        [JsonProperty("root")]
        public bool? Root { get; set; }

        /// <summary>
        /// 距离父节点的深度（如果是查询整棵树，返回的 **depth** 为距离根节点的深度，如果是查询某个节点的子节点，返回的 **depath** 指的是距离该节点的深度。）
        /// </summary>
        [JsonProperty("depth")]
        public int? Depth { get; set; }

        [JsonProperty("path")]
        public List<string> Path { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 该节点的子节点 **ID** 列表
        /// </summary>
        [JsonProperty("children")]
        public List<string> Children { get; set; }

        /// <summary>
        /// 节点的用户列表
        /// </summary>
        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }
        #endregion
    }
    #endregion

    #region Org
    public class Org
    {
        #region members
        /// <summary>
        /// 组织机构 ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 根节点
        /// </summary>
        [JsonProperty("rootNode")]
        public Node RootNode { get; set; }

        /// <summary>
        /// 组织机构节点列表
        /// </summary>
        [JsonProperty("nodes")]
        public List<Node> Nodes { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedOrgs
    public class PaginatedOrgs
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Org> List { get; set; }
        #endregion
    }
    #endregion

    #region CheckPasswordStrengthResult
    public class CheckPasswordStrengthResult
    {
        #region members
        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
        #endregion
    }
    #endregion

    #region Policy
    public class Policy
    {
        #region members
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statements")]
        public List<PolicyStatement> Statements { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 被授权次数
        /// </summary>
        [JsonProperty("assignmentsCount")]
        public int AssignmentsCount { get; set; }

        /// <summary>
        /// 授权记录
        /// </summary>
        [JsonProperty("assignments")]
        public List<PolicyAssignment> Assignments { get; set; }
        #endregion
    }
    #endregion

    #region PolicyStatement
    public class PolicyStatement
    {
        #region members
        [JsonProperty("resource")]
        public string Resource { get; set; }

        [JsonProperty("actions")]
        public List<string> Actions { get; set; }

        [JsonProperty("effect")]
        public PolicyEffect? Effect { get; set; }
        #endregion
    }
    #endregion
    public enum PolicyEffect
    {
        [JsonProperty("ALLOW")]
        ALLOW,
        [JsonProperty("DENY")]
        DENY
    }


    #region PolicyAssignment
    public class PolicyAssignment
    {
        #region members
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType TargetType { get; set; }

        [JsonProperty("targetIdentifier")]
        public string TargetIdentifier { get; set; }
        #endregion
    }
    #endregion
    public enum PolicyAssignmentTargetType
    {
        [JsonProperty("USER")]
        USER,
        [JsonProperty("ROLE")]
        ROLE
    }


    #region PaginatedPolicies
    public class PaginatedPolicies
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<Policy> List { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedPolicyAssignment
    public class PaginatedPolicyAssignment
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<PolicyAssignment> List { get; set; }
        #endregion
    }
    #endregion
    public enum UdfTargetType
    {
        [JsonProperty("NODE")]
        NODE,
        [JsonProperty("ORG")]
        ORG,
        [JsonProperty("USER")]
        USER,
        [JsonProperty("USERPOOL")]
        USERPOOL,
        [JsonProperty("ROLE")]
        ROLE,
        [JsonProperty("PERMISSION")]
        PERMISSION,
        [JsonProperty("APPLICATION")]
        APPLICATION
    }


    #region UserDefinedData
    public class UserDefinedData
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("dataType")]
        public UdfDataType DataType { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion
    public enum UdfDataType
    {
        [JsonProperty("STRING")]
        STRING,
        [JsonProperty("NUMBER")]
        NUMBER,
        [JsonProperty("DATETIME")]
        DATETIME,
        [JsonProperty("BOOLEAN")]
        BOOLEAN,
        [JsonProperty("OBJECT")]
        OBJECT
    }


    #region UserDefinedField
    public class UserDefinedField
    {
        #region members
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        [JsonProperty("dataType")]
        public UdfDataType DataType { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("options")]
        public string Options { get; set; }
        #endregion
    }
    #endregion

    #region JWTTokenStatus
    public class JWTTokenStatus
    {
        #region members
        [JsonProperty("code")]
        public int? Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("status")]
        public bool? Status { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }

        [JsonProperty("iat")]
        public int? Iat { get; set; }

        [JsonProperty("data")]
        public JWTTokenStatusDetail Data { get; set; }
        #endregion
    }
    #endregion

    #region JWTTokenStatusDetail
    public class JWTTokenStatusDetail
    {
        #region members
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        [JsonProperty("arn")]
        public string Arn { get; set; }
        #endregion
    }
    #endregion

    #region UserPool
    public class UserPool
    {
        #region members
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("jwtSecret")]
        public string JwtSecret { get; set; }

        [JsonProperty("userpoolTypes")]
        public List<UserPoolType> UserpoolTypes { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 用户邮箱是否验证（用户的 emailVerified 字段）默认值，默认为 false
        /// </summary>
        [JsonProperty("emailVerifiedDefault")]
        public bool EmailVerifiedDefault { get; set; }

        /// <summary>
        /// 用户注册之后是否发送欢迎邮件
        /// </summary>
        [JsonProperty("sendWelcomeEmail")]
        public bool SendWelcomeEmail { get; set; }

        /// <summary>
        /// 是否关闭注册
        /// </summary>
        [JsonProperty("registerDisabled")]
        public bool RegisterDisabled { get; set; }

        /// <summary>
        /// 用户池禁止注册后，是否还显示微信小程序扫码登录。当 **showWXMPQRCode** 为 **true** 时，
        /// 前端显示小程序码，此时只有以前允许注册时，扫码登录过的用户可以继续登录；新用户扫码无法登录。
        /// </summary>
        [JsonProperty("showWxQRCodeWhenRegisterDisabled")]
        public bool? ShowWxQrCodeWhenRegisterDisabled { get; set; }

        /// <summary>
        /// 前端跨域请求白名单
        /// </summary>
        [JsonProperty("allowedOrigins")]
        public string AllowedOrigins { get; set; }

        /// <summary>
        /// 用户 **token** 有效时间，单位为秒，默认为 15 天。
        /// </summary>
        [JsonProperty("tokenExpiresAfter")]
        public int? TokenExpiresAfter { get; set; }

        /// <summary>
        /// 是否已删除
        /// </summary>
        [JsonProperty("isDeleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// 注册频繁检测
        /// </summary>
        [JsonProperty("frequentRegisterCheck")]
        public FrequentRegisterCheckConfig FrequentRegisterCheck { get; set; }

        /// <summary>
        /// 登录失败检测
        /// </summary>
        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfig LoginFailCheck { get; set; }

        /// <summary>
        /// 手机号修改策略
        /// </summary>
        [JsonProperty("changePhoneStrategy")]
        public ChangePhoneStrategy ChangePhoneStrategy { get; set; }

        /// <summary>
        /// 邮箱修改策略
        /// </summary>
        [JsonProperty("changeEmailStrategy")]
        public ChangeEmailStrategy ChangeEmailStrategy { get; set; }

        /// <summary>
        /// APP 扫码登录配置
        /// </summary>
        [JsonProperty("qrcodeLoginStrategy")]
        public QrcodeLoginStrategy QrcodeLoginStrategy { get; set; }

        /// <summary>
        /// APP 拉起小程序登录配置
        /// </summary>
        [JsonProperty("app2WxappLoginStrategy")]
        public App2WxappLoginStrategy App2WxappLoginStrategy { get; set; }

        /// <summary>
        /// 注册白名单配置
        /// </summary>
        [JsonProperty("whitelist")]
        public RegisterWhiteListConfig Whitelist { get; set; }
        #endregion
    }
    #endregion

    #region UserPoolType
    public class UserPoolType
    {
        #region members
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("sdks")]
        public List<string> Sdks { get; set; }
        #endregion
    }
    #endregion

    #region FrequentRegisterCheckConfig
    public class FrequentRegisterCheckConfig
    {
        #region members
        [JsonProperty("timeInterval")]
        public int? TimeInterval { get; set; }

        [JsonProperty("limit")]
        public int? Limit { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
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

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
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

    #region RegisterWhiteListConfig
    public class RegisterWhiteListConfig
    {
        #region members
        /// <summary>
        /// 是否开启手机号注册白名单
        /// </summary>
        [JsonProperty("phoneEnabled")]
        public bool? PhoneEnabled { get; set; }

        /// <summary>
        /// 是否开启邮箱注册白名单
        /// </summary>
        [JsonProperty("emailEnabled")]
        public bool? EmailEnabled { get; set; }

        /// <summary>
        /// 是否开用户名注册白名单
        /// </summary>
        [JsonProperty("usernameEnabled")]
        public bool? UsernameEnabled { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedUserpool
    public class PaginatedUserpool
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public List<UserPool> List { get; set; }
        #endregion
    }
    #endregion

    #region AccessTokenRes
    public class AccessTokenRes
    {
        #region members
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }

        [JsonProperty("iat")]
        public int? Iat { get; set; }
        #endregion
    }
    #endregion
    public enum WhitelistType
    {
        [JsonProperty("USERNAME")]
        USERNAME,
        [JsonProperty("EMAIL")]
        EMAIL,
        [JsonProperty("PHONE")]
        PHONE
    }


    #region WhiteList
    public class WhiteList
    {
        #region members
        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion

    #region Mutation
    public class Mutation
    {
        #region members
        /// <summary>
        /// 创建社会化登录服务商
        /// </summary>
        [JsonProperty("createSocialConnection")]
        public SocialConnection CreateSocialConnection { get; set; }

        /// <summary>
        /// 配置社会化登录
        /// </summary>
        [JsonProperty("createSocialConnectionInstance")]
        public SocialConnectionInstance CreateSocialConnectionInstance { get; set; }

        /// <summary>
        /// 开启社会化登录
        /// </summary>
        [JsonProperty("enableSocialConnectionInstance")]
        public SocialConnectionInstance EnableSocialConnectionInstance { get; set; }

        /// <summary>
        /// 关闭社会化登录
        /// </summary>
        [JsonProperty("disableSocialConnectionInstance")]
        public SocialConnectionInstance DisableSocialConnectionInstance { get; set; }

        /// <summary>
        /// 配置自定义邮件模版
        /// </summary>
        [JsonProperty("configEmailTemplate")]
        public EmailTemplate ConfigEmailTemplate { get; set; }

        /// <summary>
        /// 启用自定义邮件模版
        /// </summary>
        [JsonProperty("enableEmailTemplate")]
        public EmailTemplate EnableEmailTemplate { get; set; }

        /// <summary>
        /// 停用自定义邮件模版（将会使用系统默认邮件模版）
        /// </summary>
        [JsonProperty("disableEmailTemplate")]
        public EmailTemplate DisableEmailTemplate { get; set; }

        /// <summary>
        /// 发送邮件
        /// </summary>
        [JsonProperty("sendEmail")]
        public CommonMessage SendEmail { get; set; }

        /// <summary>
        /// 创建函数
        /// </summary>
        [JsonProperty("createFunction")]
        public Function CreateFunction { get; set; }

        /// <summary>
        /// 修改函数
        /// </summary>
        [JsonProperty("updateFunction")]
        public Function UpdateFunction { get; set; }

        [JsonProperty("deleteFunction")]
        public CommonMessage DeleteFunction { get; set; }

        [JsonProperty("addUserToGroup")]
        public CommonMessage AddUserToGroup { get; set; }

        [JsonProperty("removeUserFromGroup")]
        public CommonMessage RemoveUserFromGroup { get; set; }

        /// <summary>
        /// 创建角色
        /// </summary>
        [JsonProperty("createGroup")]
        public Group CreateGroup { get; set; }

        /// <summary>
        /// 修改角色
        /// </summary>
        [JsonProperty("updateGroup")]
        public Group UpdateGroup { get; set; }

        /// <summary>
        /// 批量删除角色
        /// </summary>
        [JsonProperty("deleteGroups")]
        public CommonMessage DeleteGroups { get; set; }

        [JsonProperty("loginByEmail")]
        public User LoginByEmail { get; set; }

        [JsonProperty("loginByUsername")]
        public User LoginByUsername { get; set; }

        [JsonProperty("loginByPhoneCode")]
        public User LoginByPhoneCode { get; set; }

        [JsonProperty("loginByPhonePassword")]
        public User LoginByPhonePassword { get; set; }

        /// <summary>
        /// 修改 MFA 信息
        /// </summary>
        [JsonProperty("changeMfa")]
        public Mfa ChangeMfa { get; set; }

        /// <summary>
        /// 创建组织机构
        /// </summary>
        [JsonProperty("createOrg")]
        public Org CreateOrg { get; set; }

        /// <summary>
        /// 删除组织机构
        /// </summary>
        [JsonProperty("deleteOrg")]
        public CommonMessage DeleteOrg { get; set; }

        /// <summary>
        /// 添加子节点
        /// </summary>
        [JsonProperty("addNode")]
        public Org AddNode { get; set; }

        /// <summary>
        /// 修改节点
        /// </summary>
        [JsonProperty("updateNode")]
        public Node UpdateNode { get; set; }

        /// <summary>
        /// 删除节点（会一并删掉子节点）
        /// </summary>
        [JsonProperty("deleteNode")]
        public CommonMessage DeleteNode { get; set; }

        /// <summary>
        /// （批量）将成员添加到节点中
        /// </summary>
        [JsonProperty("addMember")]
        public Node AddMember { get; set; }

        /// <summary>
        /// （批量）将成员从节点中移除
        /// </summary>
        [JsonProperty("removeMember")]
        public Node RemoveMember { get; set; }

        [JsonProperty("moveNode")]
        public Org MoveNode { get; set; }

        [JsonProperty("resetPassword")]
        public CommonMessage ResetPassword { get; set; }

        [JsonProperty("createPolicy")]
        public Policy CreatePolicy { get; set; }

        [JsonProperty("updatePolicy")]
        public Policy UpdatePolicy { get; set; }

        [JsonProperty("deletePolicy")]
        public CommonMessage DeletePolicy { get; set; }

        [JsonProperty("deletePolicies")]
        public CommonMessage DeletePolicies { get; set; }

        [JsonProperty("addPolicyAssignments")]
        public CommonMessage AddPolicyAssignments { get; set; }

        [JsonProperty("removePolicyAssignments")]
        public CommonMessage RemovePolicyAssignments { get; set; }

        /// <summary>
        /// 允许操作某个资源
        /// </summary>
        [JsonProperty("allow")]
        public CommonMessage Allow { get; set; }

        [JsonProperty("registerByUsername")]
        public User RegisterByUsername { get; set; }

        [JsonProperty("registerByEmail")]
        public User RegisterByEmail { get; set; }

        [JsonProperty("registerByPhoneCode")]
        public User RegisterByPhoneCode { get; set; }

        /// <summary>
        /// 创建角色
        /// </summary>
        [JsonProperty("createRole")]
        public Role CreateRole { get; set; }

        /// <summary>
        /// 修改角色
        /// </summary>
        [JsonProperty("updateRole")]
        public Role UpdateRole { get; set; }

        /// <summary>
        /// 删除角色
        /// </summary>
        [JsonProperty("deleteRole")]
        public CommonMessage DeleteRole { get; set; }

        /// <summary>
        /// 批量删除角色
        /// </summary>
        [JsonProperty("deleteRoles")]
        public BatchOperationResult DeleteRoles { get; set; }

        /// <summary>
        /// 给用户授权角色
        /// </summary>
        [JsonProperty("assignRole")]
        public CommonMessage AssignRole { get; set; }

        /// <summary>
        /// 撤销角色
        /// </summary>
        [JsonProperty("revokeRole")]
        public CommonMessage RevokeRole { get; set; }

        [JsonProperty("addUdf")]
        public List<UserDefinedField> AddUdf { get; set; }

        [JsonProperty("removeUdf")]
        public List<UserDefinedField> RemoveUdf { get; set; }

        [JsonProperty("setUdv")]
        public List<UserDefinedData> SetUdv { get; set; }

        [JsonProperty("removeUdv")]
        public List<UserDefinedData> RemoveUdv { get; set; }

        [JsonProperty("refreshToken")]
        public RefreshToken RefreshToken { get; set; }

        /// <summary>
        /// 创建用户。此接口需要管理员权限，普通用户注册请使用 **register** 接口。
        /// </summary>
        [JsonProperty("createUser")]
        public User CreateUser { get; set; }

        /// <summary>
        /// 更新用户信息。
        /// </summary>
        [JsonProperty("updateUser")]
        public User UpdateUser { get; set; }

        /// <summary>
        /// 修改用户密码，此接口需要验证原始密码，管理员直接修改请使用 **updateUser** 接口。
        /// </summary>
        [JsonProperty("updatePassword")]
        public User UpdatePassword { get; set; }

        /// <summary>
        /// 绑定手机号，调用此接口需要当前用户未绑定手机号
        /// </summary>
        [JsonProperty("bindPhone")]
        public User BindPhone { get; set; }

        /// <summary>
        /// 解绑定手机号，调用此接口需要当前用户已绑定手机号并且绑定了其他登录方式
        /// </summary>
        [JsonProperty("unbindPhone")]
        public User UnbindPhone { get; set; }

        /// <summary>
        /// 修改手机号。此接口需要验证手机号验证码，管理员直接修改请使用 **updateUser** 接口。
        /// </summary>
        [JsonProperty("updatePhone")]
        public User UpdatePhone { get; set; }

        /// <summary>
        /// 修改邮箱。此接口需要验证邮箱验证码，管理员直接修改请使用 updateUser 接口。
        /// </summary>
        [JsonProperty("updateEmail")]
        public User UpdateEmail { get; set; }

        /// <summary>
        /// 解绑定邮箱
        /// </summary>
        [JsonProperty("unbindEmail")]
        public User UnbindEmail { get; set; }

        /// <summary>
        /// 删除用户
        /// </summary>
        [JsonProperty("deleteUser")]
        public CommonMessage DeleteUser { get; set; }

        /// <summary>
        /// 批量删除用户
        /// </summary>
        [JsonProperty("deleteUsers")]
        public CommonMessage DeleteUsers { get; set; }

        /// <summary>
        /// 创建用户池
        /// </summary>
        [JsonProperty("createUserpool")]
        public UserPool CreateUserpool { get; set; }

        [JsonProperty("updateUserpool")]
        public UserPool UpdateUserpool { get; set; }

        [JsonProperty("refreshUserpoolSecret")]
        public string RefreshUserpoolSecret { get; set; }

        [JsonProperty("deleteUserpool")]
        public CommonMessage DeleteUserpool { get; set; }

        [JsonProperty("refreshAccessToken")]
        public RefreshAccessTokenRes RefreshAccessToken { get; set; }

        [JsonProperty("addWhitelist")]
        public List<WhiteList> AddWhitelist { get; set; }

        [JsonProperty("removeWhitelist")]
        public List<WhiteList> RemoveWhitelist { get; set; }
        #endregion
    }
    #endregion

    #region CreateSocialConnectionInput
    public class CreateSocialConnectionInput
    {
        #region members
        [JsonProperty("provider")]
        [JsonRequired]
        public string Provider { get; set; }

        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        [JsonProperty("logo")]
        [JsonRequired]
        public string Logo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("fields")]
        public List<SocialConnectionFieldInput> Fields { get; set; }
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

    #region SocialConnectionFieldInput
    public class SocialConnectionFieldInput
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        [JsonProperty("children")]
        public List<SocialConnectionFieldInput> Children { get; set; }
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

    #region CreateSocialConnectionInstanceInput
    public class CreateSocialConnectionInstanceInput
    {
        #region members
        /// <summary>
        /// 社会化登录 provider
        /// </summary>
        [JsonProperty("provider")]
        [JsonRequired]
        public string Provider { get; set; }

        [JsonProperty("fields")]
        public List<CreateSocialConnectionInstanceFieldInput> Fields { get; set; }
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

    #region CreateSocialConnectionInstanceFieldInput
    public class CreateSocialConnectionInstanceFieldInput
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

    #region ConfigEmailTemplateInput
    public class ConfigEmailTemplateInput
    {
        #region members
        /// <summary>
        /// 邮件模版类型
        /// </summary>
        [JsonProperty("type")]
        [JsonRequired]
        public EmailTemplateType Type { get; set; }

        /// <summary>
        /// 模版名称
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// 邮件主题
        /// </summary>
        [JsonProperty("subject")]
        [JsonRequired]
        public string Subject { get; set; }

        /// <summary>
        /// 显示的邮件发送人
        /// </summary>
        [JsonProperty("sender")]
        [JsonRequired]
        public string Sender { get; set; }

        /// <summary>
        /// 邮件模版内容
        /// </summary>
        [JsonProperty("content")]
        [JsonRequired]
        public string Content { get; set; }

        /// <summary>
        /// 重定向链接，操作成功后，用户将被重定向到此 URL。
        /// </summary>
        [JsonProperty("redirectTo")]
        public string RedirectTo { get; set; }

        [JsonProperty("hasURL")]
        public bool? HasUrl { get; set; }

        /// <summary>
        /// 验证码过期时间（单位为秒）
        /// </summary>
        [JsonProperty("expiresIn")]
        public int? ExpiresIn { get; set; }
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
    /// <summary>
    /// 邮件使用场景
    /// </summary>
    public enum EmailScene
    {
        /// <summary>
        /// 发送重置密码邮件，邮件中包含验证码
        /// </summary>
        [JsonProperty("RESET_PASSWORD")]
        RESET_PASSWORD,
        /// <summary>
        /// 发送验证邮箱的邮件
        /// </summary>
        [JsonProperty("VERIFY_EMAIL")]
        VERIFY_EMAIL,
        /// <summary>
        /// 发送修改邮箱邮件，邮件中包含验证码
        /// </summary>
        [JsonProperty("CHANGE_EMAIL")]
        CHANGE_EMAIL
    }


    #region CommonMessage
    public class CommonMessage
    {
        #region members
        /// <summary>
        /// 可读的接口响应说明，请以业务状态码 code 作为判断业务是否成功的标志
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }

        /// <summary>
        /// 业务状态码（与 HTTP 响应码不同），但且仅当为 200 的时候表示操作成功表示，详细说明请见：
        /// [Authing 错误代码列表](https://docs.authing.co/advanced/error-code.html)
        /// </summary>
        [JsonProperty("code")]
        public int? Code { get; set; }
        #endregion
    }
    #endregion

    #region CreateFunctionInput
    public class CreateFunctionInput
    {
        #region members
        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("name")]
        [JsonRequired]
        public string Name { get; set; }

        /// <summary>
        /// 源代码
        /// </summary>
        [JsonProperty("sourceCode")]
        [JsonRequired]
        public string SourceCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 云函数链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
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

    #region UpdateFunctionInput
    public class UpdateFunctionInput
    {
        #region members
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        [JsonRequired]
        public string Id { get; set; }

        /// <summary>
        /// 函数名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 源代码
        /// </summary>
        [JsonProperty("sourceCode")]
        public string SourceCode { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// 云函数链接
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
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

    #region LoginByEmailInput
    public class LoginByEmailInput
    {
        #region members
        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        /// <summary>
        /// 图形验证码
        /// </summary>
        [JsonProperty("captchaCode")]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// 如果用户不存在，是否自动创建一个账号
        /// </summary>
        [JsonProperty("autoRegister")]
        public bool? AutoRegister { get; set; }
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

    #region LoginByUsernameInput
    public class LoginByUsernameInput
    {
        #region members
        [JsonProperty("username")]
        [JsonRequired]
        public string Username { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        /// <summary>
        /// 图形验证码
        /// </summary>
        [JsonProperty("captchaCode")]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// 如果用户不存在，是否自动创建一个账号
        /// </summary>
        [JsonProperty("autoRegister")]
        public bool? AutoRegister { get; set; }
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

    #region LoginByPhoneCodeInput
    public class LoginByPhoneCodeInput
    {
        #region members
        [JsonProperty("phone")]
        [JsonRequired]
        public string Phone { get; set; }

        [JsonProperty("code")]
        [JsonRequired]
        public string Code { get; set; }

        /// <summary>
        /// 如果用户不存在，是否自动创建一个账号
        /// </summary>
        [JsonProperty("autoRegister")]
        public bool? AutoRegister { get; set; }
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

    #region LoginByPhonePasswordInput
    public class LoginByPhonePasswordInput
    {
        #region members
        [JsonProperty("phone")]
        [JsonRequired]
        public string Phone { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        /// <summary>
        /// 图形验证码
        /// </summary>
        [JsonProperty("captchaCode")]
        public string CaptchaCode { get; set; }

        /// <summary>
        /// 如果用户不存在，是否自动创建一个账号
        /// </summary>
        [JsonProperty("autoRegister")]
        public bool? AutoRegister { get; set; }
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

    #region PolicyStatementInput
    public class PolicyStatementInput
    {
        #region members
        [JsonProperty("resource")]
        [JsonRequired]
        public string Resource { get; set; }

        [JsonProperty("actions")]
        [JsonRequired]
        public List<string> Actions { get; set; }

        [JsonProperty("effect")]
        public PolicyEffect? Effect { get; set; }
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

    #region RegisterByUsernameInput
    public class RegisterByUsernameInput
    {
        #region members
        [JsonProperty("username")]
        [JsonRequired]
        public string Username { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        [JsonProperty("profile")]
        public RegisterProfile Profile { get; set; }

        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("generateToken")]
        public bool? GenerateToken { get; set; }
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

    #region RegisterProfile
    public class RegisterProfile
    {
        #region members
        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

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

        [JsonProperty("udf")]
        public List<UserDdfInput> Udf { get; set; }
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

    #region UserDdfInput
    public class UserDdfInput
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

    #region RegisterByEmailInput
    public class RegisterByEmailInput
    {
        #region members
        [JsonProperty("email")]
        [JsonRequired]
        public string Email { get; set; }

        [JsonProperty("password")]
        [JsonRequired]
        public string Password { get; set; }

        [JsonProperty("profile")]
        public RegisterProfile Profile { get; set; }

        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("generateToken")]
        public bool? GenerateToken { get; set; }
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

    #region RegisterByPhoneCodeInput
    public class RegisterByPhoneCodeInput
    {
        #region members
        [JsonProperty("phone")]
        [JsonRequired]
        public string Phone { get; set; }

        [JsonProperty("code")]
        [JsonRequired]
        public string Code { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("profile")]
        public RegisterProfile Profile { get; set; }

        [JsonProperty("forceLogin")]
        public bool? ForceLogin { get; set; }

        [JsonProperty("generateToken")]
        public bool? GenerateToken { get; set; }
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

    #region BatchOperationResult
    /// <summary>
    /// 批量删除返回结果
    /// </summary>
    public class BatchOperationResult
    {
        #region members
        /// <summary>
        /// 删除成功的个数
        /// </summary>
        [JsonProperty("succeedCount")]
        public int SucceedCount { get; set; }

        /// <summary>
        /// 删除失败的个数
        /// </summary>
        [JsonProperty("failedCount")]
        public int FailedCount { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public List<string> Errors { get; set; }
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

    #region CreateUserInput
    public class CreateUserInput
    {
        #region members
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
        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 手机号，用户池内唯一
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机号是否已验证
        /// </summary>
        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 昵称，该字段不唯一。
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 头像链接，默认为 https://usercontents.authing.cn/authing-avatar.png
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("registerSource")]
        public List<string> RegisterSource { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        /// <summary>
        /// 用户社会化登录第三方身份提供商返回的原始用户信息，非社会化登录方式注册的用户此字段为空。
        /// </summary>
        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        /// <summary>
        /// 用户累计登录次数，当你从你原有用户系统向 Authing 迁移的时候可以设置此字段。
        /// </summary>
        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        /// <summary>
        /// 用户注册时间，当你从你原有用户系统向 Authing 迁移的时候可以设置此字段。
        /// </summary>
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

    #region UpdateUserInput
    public class UpdateUserInput
    {
        #region members
        /// <summary>
        /// 邮箱。直接修改用户邮箱需要管理员权限，普通用户修改邮箱请使用 **updateEmail** 接口。
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("unionid")]
        public string Unionid { get; set; }

        [JsonProperty("openid")]
        public string Openid { get; set; }

        /// <summary>
        /// 邮箱是否已验证。直接修改 emailVerified 需要管理员权限。
        /// </summary>
        [JsonProperty("emailVerified")]
        public bool? EmailVerified { get; set; }

        /// <summary>
        /// 手机号。直接修改用户手机号需要管理员权限，普通用户修改邮箱请使用 **updatePhone** 接口。
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 手机号是否已验证。直接修改 **phoneVerified** 需要管理员权限。
        /// </summary>
        [JsonProperty("phoneVerified")]
        public bool? PhoneVerified { get; set; }

        /// <summary>
        /// 用户名，用户池内唯一
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// 昵称，该字段不唯一。
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 密码。直接修改用户密码需要管理员权限，普通用户修改邮箱请使用 **updatePassword** 接口。
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// 头像链接，默认为 https://usercontents.authing.cn/authing-avatar.png
        /// </summary>
        [JsonProperty("photo")]
        public string Photo { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("device")]
        public string Device { get; set; }

        [JsonProperty("oauth")]
        public string Oauth { get; set; }

        [JsonProperty("tokenExpiredAt")]
        public string TokenExpiredAt { get; set; }

        /// <summary>
        /// 用户累计登录次数，当你从你原有用户系统向 Authing 迁移的时候可以设置此字段。
        /// </summary>
        [JsonProperty("loginsCount")]
        public int? LoginsCount { get; set; }

        [JsonProperty("lastLogin")]
        public string LastLogin { get; set; }

        [JsonProperty("lastIP")]
        public string LastIp { get; set; }

        /// <summary>
        /// 用户注册时间，当你从你原有用户系统向 Authing 迁移的时候可以设置此字段。
        /// </summary>
        [JsonProperty("blocked")]
        public bool? Blocked { get; set; }

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

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("province")]
        public string Province { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
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

    #region UpdateUserpoolInput
    public class UpdateUserpoolInput
    {
        #region members
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("logo")]
        public string Logo { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("userpoolTypes")]
        public List<string> UserpoolTypes { get; set; }

        [JsonProperty("emailVerifiedDefault")]
        public bool? EmailVerifiedDefault { get; set; }

        [JsonProperty("sendWelcomeEmail")]
        public bool? SendWelcomeEmail { get; set; }

        [JsonProperty("registerDisabled")]
        public bool? RegisterDisabled { get; set; }

        [JsonProperty("allowedOrigins")]
        public string AllowedOrigins { get; set; }

        [JsonProperty("tokenExpiresAfter")]
        public int? TokenExpiresAfter { get; set; }

        [JsonProperty("emailWhitelistEnabled")]
        public bool? EmailWhitelistEnabled { get; set; }

        [JsonProperty("phoneWhitelistEnabled")]
        public bool? PhoneWhitelistEnabled { get; set; }

        [JsonProperty("frequentRegisterCheck")]
        public FrequentRegisterCheckConfigInput FrequentRegisterCheck { get; set; }

        [JsonProperty("loginFailCheck")]
        public LoginFailCheckConfigInput LoginFailCheck { get; set; }

        [JsonProperty("changePhoneStrategy")]
        public ChangePhoneStrategyInput ChangePhoneStrategy { get; set; }

        [JsonProperty("changeEmailStrategy")]
        public ChangeEmailStrategyInput ChangeEmailStrategy { get; set; }

        [JsonProperty("qrcodeLoginStrategy")]
        public QrcodeLoginStrategyInput QrcodeLoginStrategy { get; set; }

        [JsonProperty("app2WxappLoginStrategy")]
        public App2WxappLoginStrategyInput App2WxappLoginStrategy { get; set; }

        [JsonProperty("whitelist")]
        public RegisterWhiteListConfigInput Whitelist { get; set; }
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

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
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

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }
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

    #region RegisterWhiteListConfigInput
    public class RegisterWhiteListConfigInput
    {
        #region members
        [JsonProperty("phoneEnabled")]
        public bool? PhoneEnabled { get; set; }

        [JsonProperty("emailEnabled")]
        public bool? EmailEnabled { get; set; }

        [JsonProperty("usernameEnabled")]
        public bool? UsernameEnabled { get; set; }
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

    #region RefreshAccessTokenRes
    public class RefreshAccessTokenRes
    {
        #region members
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        [JsonProperty("exp")]
        public int? Exp { get; set; }

        [JsonProperty("iat")]
        public int? Iat { get; set; }
        #endregion
    }
    #endregion

    #region KeyValuePair
    public class KeyValuePair
    {
        #region members
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
        #endregion
    }
    #endregion
}

namespace Authing.ApiClient.Types
{


    public class AddMemberResponse
    {

        [JsonProperty("addMember")]
        public Node Result { get; set; }
    }

    public class AddMemberParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeCode")]
        public string NodeCode { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("isLeader")]
        public bool IsLeader { get; set; }

        /// <summary>
        /// AddMemberParam.Request 
        /// <para>Required variables:<br/> { userIds=(string[]) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), nodeId=(string), orgId=(string), nodeCode=(string), isLeader=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddMemberDocument,
                OperationName = "addMember",
                Variables = this
            };
        }


        public static string AddMemberDocument = @"
        mutation addMember($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $nodeId: String, $orgId: String, $nodeCode: String, $userIds: [String!]!, $isLeader: Boolean) {
          addMember(nodeId: $nodeId, orgId: $orgId, nodeCode: $nodeCode, userIds: $userIds, isLeader: $isLeader) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
              list {
                id
                arn
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
          }
        }
        ";
    }



    public class AddNodeResponse
    {

        [JsonProperty("addNode")]
        public Org Result { get; set; }
    }

    public class AddNodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("parentNodeId")]
        public string ParentNodeId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nameI18n")]
        public string NameI18n { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("descriptionI18n")]
        public string DescriptionI18n { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("order")]
        public int Order { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// AddNodeParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), name=(string) }</para>
        /// <para>Optional variables:<br/> { parentNodeId=(string), nameI18n=(string), description=(string), descriptionI18n=(string), order=(int), code=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddNodeDocument,
                OperationName = "addNode",
                Variables = this
            };
        }


        public static string AddNodeDocument = @"
        mutation addNode($orgId: String!, $parentNodeId: String, $name: String!, $nameI18n: String, $description: String, $descriptionI18n: String, $order: Int, $code: String) {
          addNode(orgId: $orgId, parentNodeId: $parentNodeId, name: $name, nameI18n: $nameI18n, description: $description, descriptionI18n: $descriptionI18n, order: $order, code: $code) {
            id
            rootNode {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
            nodes {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
          }
        }
        ";
    }



    public class AddPolicyAssignmentsResponse
    {

        [JsonProperty("addPolicyAssignments")]
        public CommonMessage Result { get; set; }
    }

    public class AddPolicyAssignmentsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("policies")]
        public string Policies { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType TargetType { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("targetIdentifiers")]
        public string TargetIdentifiers { get; set; }

        /// <summary>
        /// AddPolicyAssignmentsParam.Request 
        /// <para>Required variables:<br/> { policies=(string[]), targetType=(PolicyAssignmentTargetType) }</para>
        /// <para>Optional variables:<br/> { targetIdentifiers=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddPolicyAssignmentsDocument,
                OperationName = "addPolicyAssignments",
                Variables = this
            };
        }


        public static string AddPolicyAssignmentsDocument = @"
        mutation addPolicyAssignments($policies: [String!]!, $targetType: PolicyAssignmentTargetType!, $targetIdentifiers: [String!]) {
          addPolicyAssignments(policies: $policies, targetType: $targetType, targetIdentifiers: $targetIdentifiers) {
            message
            code
          }
        }
        ";
    }



    public class AddUdfResponse
    {

        [JsonProperty("addUdf")]
        public IEnumerable<UserDefinedField> Result { get; set; }
    }

    public class AddUdfParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("dataType")]
        public UdfDataType DataType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("options")]
        public string Options { get; set; }

        /// <summary>
        /// AddUdfParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType), key=(string), dataType=(UDFDataType), label=(string) }</para>
        /// <para>Optional variables:<br/> { options=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddUdfDocument,
                OperationName = "addUdf",
                Variables = this
            };
        }


        public static string AddUdfDocument = @"
        mutation addUdf($targetType: UDFTargetType!, $key: String!, $dataType: UDFDataType!, $label: String!, $options: String) {
          addUdf(targetType: $targetType, key: $key, dataType: $dataType, label: $label, options: $options) {
            targetType
            dataType
            key
            label
            options
          }
        }
        ";
    }



    public class AddUserToGroupResponse
    {

        [JsonProperty("addUserToGroup")]
        public CommonMessage Result { get; set; }
    }

    public class AddUserToGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// AddUserToGroupParam.Request 
        /// <para>Required variables:<br/> { userIds=(string[]) }</para>
        /// <para>Optional variables:<br/> { code=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddUserToGroupDocument,
                OperationName = "addUserToGroup",
                Variables = this
            };
        }


        public static string AddUserToGroupDocument = @"
        mutation addUserToGroup($userIds: [String!]!, $code: String) {
          addUserToGroup(userIds: $userIds, code: $code) {
            message
            code
          }
        }
        ";
    }



    public class AddWhitelistResponse
    {

        [JsonProperty("addWhitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }

    public class AddWhitelistParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public WhitelistType Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("list")]
        public string List { get; set; }

        /// <summary>
        /// AddWhitelistParam.Request 
        /// <para>Required variables:<br/> { type=(WhitelistType), list=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AddWhitelistDocument,
                OperationName = "addWhitelist",
                Variables = this
            };
        }


        public static string AddWhitelistDocument = @"
        mutation addWhitelist($type: WhitelistType!, $list: [String!]!) {
          addWhitelist(type: $type, list: $list) {
            createdAt
            updatedAt
            value
          }
        }
        ";
    }



    public class AllowResponse
    {

        [JsonProperty("allow")]
        public CommonMessage Result { get; set; }
    }

    public class AllowParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCode")]
        public string RoleCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCodes")]
        public string RoleCodes { get; set; }

        /// <summary>
        /// AllowParam.Request 
        /// <para>Required variables:<br/> { resource=(string), action=(string) }</para>
        /// <para>Optional variables:<br/> { userId=(string), userIds=(string[]), roleCode=(string), roleCodes=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AllowDocument,
                OperationName = "allow",
                Variables = this
            };
        }


        public static string AllowDocument = @"
        mutation allow($resource: String!, $action: String!, $userId: String, $userIds: [String!], $roleCode: String, $roleCodes: [String!]) {
          allow(resource: $resource, action: $action, userId: $userId, userIds: $userIds, roleCode: $roleCode, roleCodes: $roleCodes) {
            message
            code
          }
        }
        ";
    }



    public class AssignRoleResponse
    {

        [JsonProperty("assignRole")]
        public CommonMessage Result { get; set; }
    }

    public class AssignRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCode")]
        public string RoleCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCodes")]
        public string RoleCodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("groupCodes")]
        public string GroupCodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeCodes")]
        public string NodeCodes { get; set; }

        /// <summary>
        /// AssignRoleParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { roleCode=(string), roleCodes=(string[]), userIds=(string[]), groupCodes=(string[]), nodeCodes=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AssignRoleDocument,
                OperationName = "assignRole",
                Variables = this
            };
        }


        public static string AssignRoleDocument = @"
        mutation assignRole($roleCode: String, $roleCodes: [String], $userIds: [String!], $groupCodes: [String!], $nodeCodes: [String!]) {
          assignRole(roleCode: $roleCode, roleCodes: $roleCodes, userIds: $userIds, groupCodes: $groupCodes, nodeCodes: $nodeCodes) {
            message
            code
          }
        }
        ";
    }



    public class BindPhoneResponse
    {

        [JsonProperty("bindPhone")]
        public User Result { get; set; }
    }

    public class BindPhoneParam
    {

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
        /// BindPhoneParam.Request 
        /// <para>Required variables:<br/> { phone=(string), phoneCode=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = BindPhoneDocument,
                OperationName = "bindPhone",
                Variables = this
            };
        }


        public static string BindPhoneDocument = @"
        mutation bindPhone($phone: String!, $phoneCode: String!) {
          bindPhone(phone: $phone, phoneCode: $phoneCode) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class ChangeMfaResponse
    {

        [JsonProperty("changeMfa")]
        public Mfa Result { get; set; }
    }

    public class ChangeMfaParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("enable")]
        public bool Enable { get; set; }

        /// <summary>
        /// Optional
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
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("refresh")]
        public bool Refresh { get; set; }

        /// <summary>
        /// ChangeMfaParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { enable=(bool), id=(string), userId=(string), userPoolId=(string), refresh=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ChangeMfaDocument,
                OperationName = "changeMfa",
                Variables = this
            };
        }


        public static string ChangeMfaDocument = @"
        mutation changeMfa($enable: Boolean, $id: String, $userId: String, $userPoolId: String, $refresh: Boolean) {
          changeMfa(enable: $enable, id: $id, userId: $userId, userPoolId: $userPoolId, refresh: $refresh) {
            id
            userId
            userPoolId
            enable
            secret
          }
        }
        ";
    }



    public class ConfigEmailTemplateResponse
    {

        [JsonProperty("configEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }

    public class ConfigEmailTemplateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public ConfigEmailTemplateInput Input { get; set; }

        /// <summary>
        /// ConfigEmailTemplateParam.Request 
        /// <para>Required variables:<br/> { input=(ConfigEmailTemplateInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ConfigEmailTemplateDocument,
                OperationName = "configEmailTemplate",
                Variables = this
            };
        }


        public static string ConfigEmailTemplateDocument = @"
        mutation configEmailTemplate($input: ConfigEmailTemplateInput!) {
          configEmailTemplate(input: $input) {
            type
            name
            subject
            sender
            content
            redirectTo
            hasURL
            expiresIn
            enabled
            isSystem
          }
        }
        ";
    }



    public class CreateFunctionResponse
    {

        [JsonProperty("createFunction")]
        public Function Result { get; set; }
    }

    public class CreateFunctionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateFunctionInput Input { get; set; }

        /// <summary>
        /// CreateFunctionParam.Request 
        /// <para>Required variables:<br/> { input=(CreateFunctionInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateFunctionDocument,
                OperationName = "createFunction",
                Variables = this
            };
        }


        public static string CreateFunctionDocument = @"
        mutation createFunction($input: CreateFunctionInput!) {
          createFunction(input: $input) {
            id
            name
            sourceCode
            description
            url
          }
        }
        ";
    }



    public class CreateGroupResponse
    {

        [JsonProperty("createGroup")]
        public Group Result { get; set; }
    }

    public class CreateGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

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
        /// CreateGroupParam.Request 
        /// <para>Required variables:<br/> { code=(string), name=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateGroupDocument,
                OperationName = "createGroup",
                Variables = this
            };
        }


        public static string CreateGroupDocument = @"
        mutation createGroup($code: String!, $name: String!, $description: String) {
          createGroup(code: $code, name: $name, description: $description) {
            code
            name
            description
            createdAt
            updatedAt
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
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// CreateOrgParam.Request 
        /// <para>Required variables:<br/> { name=(string) }</para>
        /// <para>Optional variables:<br/> { code=(string), description=(string) }</para>
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
        mutation createOrg($name: String!, $code: String, $description: String) {
          createOrg(name: $name, code: $code, description: $description) {
            id
            rootNode {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
            nodes {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
          }
        }
        ";
    }



    public class CreatePolicyResponse
    {

        [JsonProperty("createPolicy")]
        public Policy Result { get; set; }
    }

    public class CreatePolicyParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("statements")]
        public PolicyStatementInput Statements { get; set; }

        /// <summary>
        /// CreatePolicyParam.Request 
        /// <para>Required variables:<br/> { code=(string), statements=(PolicyStatementInput[]) }</para>
        /// <para>Optional variables:<br/> { description=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreatePolicyDocument,
                OperationName = "createPolicy",
                Variables = this
            };
        }


        public static string CreatePolicyDocument = @"
        mutation createPolicy($code: String!, $description: String, $statements: [PolicyStatementInput!]!) {
          createPolicy(code: $code, description: $description, statements: $statements) {
            code
            assignmentsCount
            isDefault
            description
            statements {
              resource
              actions
              effect
            }
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class CreateRoleResponse
    {

        [JsonProperty("createRole")]
        public Role Result { get; set; }
    }

    public class CreateRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("parent")]
        public string Parent { get; set; }

        /// <summary>
        /// CreateRoleParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string), parent=(string) }</para>
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
        mutation createRole($code: String!, $description: String, $parent: String) {
          createRole(code: $code, description: $description, parent: $parent) {
            code
            arn
            description
            isSystem
            createdAt
            updatedAt
            users {
              totalCount
            }
            parent {
              code
              description
              isSystem
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class CreateSocialConnectionResponse
    {

        [JsonProperty("createSocialConnection")]
        public SocialConnection Result { get; set; }
    }

    public class CreateSocialConnectionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateSocialConnectionInput Input { get; set; }

        /// <summary>
        /// CreateSocialConnectionParam.Request 
        /// <para>Required variables:<br/> { input=(CreateSocialConnectionInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateSocialConnectionDocument,
                OperationName = "createSocialConnection",
                Variables = this
            };
        }


        public static string CreateSocialConnectionDocument = @"
        mutation createSocialConnection($input: CreateSocialConnectionInput!) {
          createSocialConnection(input: $input) {
            provider
            name
            logo
            description
            fields {
              key
              label
              type
              placeholder
            }
          }
        }
        ";
    }



    public class CreateSocialConnectionInstanceResponse
    {

        [JsonProperty("createSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }

    public class CreateSocialConnectionInstanceParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public CreateSocialConnectionInstanceInput Input { get; set; }

        /// <summary>
        /// CreateSocialConnectionInstanceParam.Request 
        /// <para>Required variables:<br/> { input=(CreateSocialConnectionInstanceInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateSocialConnectionInstanceDocument,
                OperationName = "createSocialConnectionInstance",
                Variables = this
            };
        }


        public static string CreateSocialConnectionInstanceDocument = @"
        mutation createSocialConnectionInstance($input: CreateSocialConnectionInstanceInput!) {
          createSocialConnectionInstance(input: $input) {
            provider
            enabled
            fields {
              key
              value
            }
          }
        }
        ";
    }



    public class CreateUserResponse
    {

        [JsonProperty("createUser")]
        public User Result { get; set; }
    }

    public class CreateUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userInfo")]
        public CreateUserInput UserInfo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("keepPassword")]
        public bool KeepPassword { get; set; }

        /// <summary>
        /// CreateUserParam.Request 
        /// <para>Required variables:<br/> { userInfo=(CreateUserInput) }</para>
        /// <para>Optional variables:<br/> { keepPassword=(bool) }</para>
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
        mutation createUser($userInfo: CreateUserInput!, $keepPassword: Boolean) {
          createUser(userInfo: $userInfo, keepPassword: $keepPassword) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class CreateUserpoolResponse
    {

        [JsonProperty("createUserpool")]
        public UserPool Result { get; set; }
    }

    public class CreateUserpoolParam
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
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userpoolTypes")]
        public string UserpoolTypes { get; set; }

        /// <summary>
        /// CreateUserpoolParam.Request 
        /// <para>Required variables:<br/> { name=(string), domain=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string), logo=(string), userpoolTypes=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CreateUserpoolDocument,
                OperationName = "createUserpool",
                Variables = this
            };
        }


        public static string CreateUserpoolDocument = @"
        mutation createUserpool($name: String!, $domain: String!, $description: String, $logo: String, $userpoolTypes: [String!]) {
          createUserpool(name: $name, domain: $domain, description: $description, logo: $logo, userpoolTypes: $userpoolTypes) {
            id
            name
            domain
            description
            secret
            userpoolTypes {
              code
              name
              description
              image
              sdks
            }
            logo
            createdAt
            updatedAt
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWxQRCodeWhenRegisterDisabled
            allowedOrigins
            tokenExpiresAfter
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enabled
            }
            loginFailCheck {
              timeInterval
              limit
              enabled
            }
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
            whitelist {
              phoneEnabled
              emailEnabled
              usernameEnabled
            }
          }
        }
        ";
    }



    public class DeleteFunctionResponse
    {

        [JsonProperty("deleteFunction")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteFunctionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// DeleteFunctionParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteFunctionDocument,
                OperationName = "deleteFunction",
                Variables = this
            };
        }


        public static string DeleteFunctionDocument = @"
        mutation deleteFunction($id: String!) {
          deleteFunction(id: $id) {
            message
            code
          }
        }
        ";
    }



    public class DeleteGroupsResponse
    {

        [JsonProperty("deleteGroups")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteGroupsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("codeList")]
        public string CodeList { get; set; }

        /// <summary>
        /// DeleteGroupsParam.Request 
        /// <para>Required variables:<br/> { codeList=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteGroupsDocument,
                OperationName = "deleteGroups",
                Variables = this
            };
        }


        public static string DeleteGroupsDocument = @"
        mutation deleteGroups($codeList: [String!]!) {
          deleteGroups(codeList: $codeList) {
            message
            code
          }
        }
        ";
    }



    public class DeleteNodeResponse
    {

        [JsonProperty("deleteNode")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteNodeParam
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
        /// DeleteNodeParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), nodeId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteNodeDocument,
                OperationName = "deleteNode",
                Variables = this
            };
        }


        public static string DeleteNodeDocument = @"
        mutation deleteNode($orgId: String!, $nodeId: String!) {
          deleteNode(orgId: $orgId, nodeId: $nodeId) {
            message
            code
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
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// DeleteOrgParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
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
        mutation deleteOrg($id: String!) {
          deleteOrg(id: $id) {
            message
            code
          }
        }
        ";
    }



    public class DeletePoliciesResponse
    {

        [JsonProperty("deletePolicies")]
        public CommonMessage Result { get; set; }
    }

    public class DeletePoliciesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("codes")]
        public string Codes { get; set; }

        /// <summary>
        /// DeletePoliciesParam.Request 
        /// <para>Required variables:<br/> { codes=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeletePoliciesDocument,
                OperationName = "deletePolicies",
                Variables = this
            };
        }


        public static string DeletePoliciesDocument = @"
        mutation deletePolicies($codes: [String!]!) {
          deletePolicies(codes: $codes) {
            message
            code
          }
        }
        ";
    }



    public class DeletePolicyResponse
    {

        [JsonProperty("deletePolicy")]
        public CommonMessage Result { get; set; }
    }

    public class DeletePolicyParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// DeletePolicyParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeletePolicyDocument,
                OperationName = "deletePolicy",
                Variables = this
            };
        }


        public static string DeletePolicyDocument = @"
        mutation deletePolicy($code: String!) {
          deletePolicy(code: $code) {
            message
            code
          }
        }
        ";
    }



    public class DeleteRoleResponse
    {

        [JsonProperty("deleteRole")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// DeleteRoleParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRoleDocument,
                OperationName = "deleteRole",
                Variables = this
            };
        }


        public static string DeleteRoleDocument = @"
        mutation deleteRole($code: String!) {
          deleteRole(code: $code) {
            message
            code
          }
        }
        ";
    }



    public class DeleteRolesResponse
    {

        [JsonProperty("deleteRoles")]
        public BatchOperationResult Result { get; set; }
    }

    public class DeleteRolesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("codes")]
        public string Codes { get; set; }

        /// <summary>
        /// DeleteRolesParam.Request 
        /// <para>Required variables:<br/> { codes=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteRolesDocument,
                OperationName = "deleteRoles",
                Variables = this
            };
        }


        public static string DeleteRolesDocument = @"
        mutation deleteRoles($codes: [String!]!) {
          deleteRoles(codes: $codes) {
            succeedCount
            failedCount
            message
            errors
          }
        }
        ";
    }



    public class DeleteUserResponse
    {

        [JsonProperty("deleteUser")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// DeleteUserParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteUserDocument,
                OperationName = "deleteUser",
                Variables = this
            };
        }


        public static string DeleteUserDocument = @"
        mutation deleteUser($id: String!) {
          deleteUser(id: $id) {
            message
            code
          }
        }
        ";
    }



    public class DeleteUserpoolResponse
    {

        [JsonProperty("deleteUserpool")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteUserpoolParam
    {


        /// <summary>
        /// DeleteUserpoolParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteUserpoolDocument,
                OperationName = "deleteUserpool"
            };
        }


        public static string DeleteUserpoolDocument = @"
        mutation deleteUserpool {
          deleteUserpool {
            message
            code
          }
        }
        ";
    }



    public class DeleteUsersResponse
    {

        [JsonProperty("deleteUsers")]
        public CommonMessage Result { get; set; }
    }

    public class DeleteUsersParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// DeleteUsersParam.Request 
        /// <para>Required variables:<br/> { ids=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DeleteUsersDocument,
                OperationName = "deleteUsers",
                Variables = this
            };
        }


        public static string DeleteUsersDocument = @"
        mutation deleteUsers($ids: [String!]!) {
          deleteUsers(ids: $ids) {
            message
            code
          }
        }
        ";
    }



    public class DisableEmailTemplateResponse
    {

        [JsonProperty("disableEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }

    public class DisableEmailTemplateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public EmailTemplateType Type { get; set; }

        /// <summary>
        /// DisableEmailTemplateParam.Request 
        /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DisableEmailTemplateDocument,
                OperationName = "disableEmailTemplate",
                Variables = this
            };
        }


        public static string DisableEmailTemplateDocument = @"
        mutation disableEmailTemplate($type: EmailTemplateType!) {
          disableEmailTemplate(type: $type) {
            type
            name
            subject
            sender
            content
            redirectTo
            hasURL
            expiresIn
            enabled
            isSystem
          }
        }
        ";
    }



    public class DisableSocialConnectionInstanceResponse
    {

        [JsonProperty("disableSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }

    public class DisableSocialConnectionInstanceParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// DisableSocialConnectionInstanceParam.Request 
        /// <para>Required variables:<br/> { provider=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = DisableSocialConnectionInstanceDocument,
                OperationName = "disableSocialConnectionInstance",
                Variables = this
            };
        }


        public static string DisableSocialConnectionInstanceDocument = @"
        mutation disableSocialConnectionInstance($provider: String!) {
          disableSocialConnectionInstance(provider: $provider) {
            provider
            enabled
            fields {
              key
              value
            }
          }
        }
        ";
    }



    public class EnableEmailTemplateResponse
    {

        [JsonProperty("enableEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }

    public class EnableEmailTemplateParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public EmailTemplateType Type { get; set; }

        /// <summary>
        /// EnableEmailTemplateParam.Request 
        /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableEmailTemplateDocument,
                OperationName = "enableEmailTemplate",
                Variables = this
            };
        }


        public static string EnableEmailTemplateDocument = @"
        mutation enableEmailTemplate($type: EmailTemplateType!) {
          enableEmailTemplate(type: $type) {
            type
            name
            subject
            sender
            content
            redirectTo
            hasURL
            expiresIn
            enabled
            isSystem
          }
        }
        ";
    }



    public class EnableSocialConnectionInstanceResponse
    {

        [JsonProperty("enableSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }

    public class EnableSocialConnectionInstanceParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// EnableSocialConnectionInstanceParam.Request 
        /// <para>Required variables:<br/> { provider=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EnableSocialConnectionInstanceDocument,
                OperationName = "enableSocialConnectionInstance",
                Variables = this
            };
        }


        public static string EnableSocialConnectionInstanceDocument = @"
        mutation enableSocialConnectionInstance($provider: String!) {
          enableSocialConnectionInstance(provider: $provider) {
            provider
            enabled
            fields {
              key
              value
            }
          }
        }
        ";
    }



    public class LoginByEmailResponse
    {

        [JsonProperty("loginByEmail")]
        public User Result { get; set; }
    }

    public class LoginByEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public LoginByEmailInput Input { get; set; }

        /// <summary>
        /// LoginByEmailParam.Request 
        /// <para>Required variables:<br/> { input=(LoginByEmailInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
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
        mutation loginByEmail($input: LoginByEmailInput!) {
          loginByEmail(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class LoginByPhoneCodeResponse
    {

        [JsonProperty("loginByPhoneCode")]
        public User Result { get; set; }
    }

    public class LoginByPhoneCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public LoginByPhoneCodeInput Input { get; set; }

        /// <summary>
        /// LoginByPhoneCodeParam.Request 
        /// <para>Required variables:<br/> { input=(LoginByPhoneCodeInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
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
        mutation loginByPhoneCode($input: LoginByPhoneCodeInput!) {
          loginByPhoneCode(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class LoginByPhonePasswordResponse
    {

        [JsonProperty("loginByPhonePassword")]
        public User Result { get; set; }
    }

    public class LoginByPhonePasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public LoginByPhonePasswordInput Input { get; set; }

        /// <summary>
        /// LoginByPhonePasswordParam.Request 
        /// <para>Required variables:<br/> { input=(LoginByPhonePasswordInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
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
        mutation loginByPhonePassword($input: LoginByPhonePasswordInput!) {
          loginByPhonePassword(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class LoginByUsernameResponse
    {

        [JsonProperty("loginByUsername")]
        public User Result { get; set; }
    }

    public class LoginByUsernameParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public LoginByUsernameInput Input { get; set; }

        /// <summary>
        /// LoginByUsernameParam.Request 
        /// <para>Required variables:<br/> { input=(LoginByUsernameInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
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
        mutation loginByUsername($input: LoginByUsernameInput!) {
          loginByUsername(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class MoveNodeResponse
    {

        [JsonProperty("moveNode")]
        public Org Result { get; set; }
    }

    public class MoveNodeParam
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
        /// Required
        /// </summary>
        [JsonProperty("targetParentId")]
        public string TargetParentId { get; set; }

        /// <summary>
        /// MoveNodeParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), nodeId=(string), targetParentId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = MoveNodeDocument,
                OperationName = "moveNode",
                Variables = this
            };
        }


        public static string MoveNodeDocument = @"
        mutation moveNode($orgId: String!, $nodeId: String!, $targetParentId: String!) {
          moveNode(orgId: $orgId, nodeId: $nodeId, targetParentId: $targetParentId) {
            id
            rootNode {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
            nodes {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
          }
        }
        ";
    }



    public class RefreshAccessTokenResponse
    {

        [JsonProperty("refreshAccessToken")]
        public RefreshAccessTokenRes Result { get; set; }
    }

    public class RefreshAccessTokenParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }

        /// <summary>
        /// RefreshAccessTokenParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { accessToken=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshAccessTokenDocument,
                OperationName = "refreshAccessToken",
                Variables = this
            };
        }


        public static string RefreshAccessTokenDocument = @"
        mutation refreshAccessToken($accessToken: String) {
          refreshAccessToken(accessToken: $accessToken) {
            accessToken
            exp
            iat
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
        /// Optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// RefreshTokenParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { id=(string) }</para>
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
        mutation refreshToken($id: String) {
          refreshToken(id: $id) {
            token
            iat
            exp
          }
        }
        ";
    }



    public class RefreshUserpoolSecretResponse
    {

        [JsonProperty("refreshUserpoolSecret")]
        public string Result { get; set; }
    }

    public class RefreshUserpoolSecretParam
    {


        /// <summary>
        /// RefreshUserpoolSecretParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RefreshUserpoolSecretDocument,
                OperationName = "refreshUserpoolSecret"
            };
        }


        public static string RefreshUserpoolSecretDocument = @"
        mutation refreshUserpoolSecret {
          refreshUserpoolSecret
        }
        ";
    }



    public class RegisterByEmailResponse
    {

        [JsonProperty("registerByEmail")]
        public User Result { get; set; }
    }

    public class RegisterByEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RegisterByEmailInput Input { get; set; }

        /// <summary>
        /// RegisterByEmailParam.Request 
        /// <para>Required variables:<br/> { input=(RegisterByEmailInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterByEmailDocument,
                OperationName = "registerByEmail",
                Variables = this
            };
        }


        public static string RegisterByEmailDocument = @"
        mutation registerByEmail($input: RegisterByEmailInput!) {
          registerByEmail(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class RegisterByPhoneCodeResponse
    {

        [JsonProperty("registerByPhoneCode")]
        public User Result { get; set; }
    }

    public class RegisterByPhoneCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RegisterByPhoneCodeInput Input { get; set; }

        /// <summary>
        /// RegisterByPhoneCodeParam.Request 
        /// <para>Required variables:<br/> { input=(RegisterByPhoneCodeInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterByPhoneCodeDocument,
                OperationName = "registerByPhoneCode",
                Variables = this
            };
        }


        public static string RegisterByPhoneCodeDocument = @"
        mutation registerByPhoneCode($input: RegisterByPhoneCodeInput!) {
          registerByPhoneCode(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class RegisterByUsernameResponse
    {

        [JsonProperty("registerByUsername")]
        public User Result { get; set; }
    }

    public class RegisterByUsernameParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public RegisterByUsernameInput Input { get; set; }

        /// <summary>
        /// RegisterByUsernameParam.Request 
        /// <para>Required variables:<br/> { input=(RegisterByUsernameInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RegisterByUsernameDocument,
                OperationName = "registerByUsername",
                Variables = this
            };
        }


        public static string RegisterByUsernameDocument = @"
        mutation registerByUsername($input: RegisterByUsernameInput!) {
          registerByUsername(input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class RemoveMemberResponse
    {

        [JsonProperty("removeMember")]
        public Node Result { get; set; }
    }

    public class RemoveMemberParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeCode")]
        public string NodeCode { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// RemoveMemberParam.Request 
        /// <para>Required variables:<br/> { userIds=(string[]) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), nodeId=(string), orgId=(string), nodeCode=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveMemberDocument,
                OperationName = "removeMember",
                Variables = this
            };
        }


        public static string RemoveMemberDocument = @"
        mutation removeMember($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $nodeId: String, $orgId: String, $nodeCode: String, $userIds: [String!]!) {
          removeMember(nodeId: $nodeId, orgId: $orgId, nodeCode: $nodeCode, userIds: $userIds) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
              list {
                id
                arn
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
          }
        }
        ";
    }



    public class RemovePolicyAssignmentsResponse
    {

        [JsonProperty("removePolicyAssignments")]
        public CommonMessage Result { get; set; }
    }

    public class RemovePolicyAssignmentsParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("policies")]
        public string Policies { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType TargetType { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("targetIdentifiers")]
        public string TargetIdentifiers { get; set; }

        /// <summary>
        /// RemovePolicyAssignmentsParam.Request 
        /// <para>Required variables:<br/> { policies=(string[]), targetType=(PolicyAssignmentTargetType) }</para>
        /// <para>Optional variables:<br/> { targetIdentifiers=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemovePolicyAssignmentsDocument,
                OperationName = "removePolicyAssignments",
                Variables = this
            };
        }


        public static string RemovePolicyAssignmentsDocument = @"
        mutation removePolicyAssignments($policies: [String!]!, $targetType: PolicyAssignmentTargetType!, $targetIdentifiers: [String!]) {
          removePolicyAssignments(policies: $policies, targetType: $targetType, targetIdentifiers: $targetIdentifiers) {
            message
            code
          }
        }
        ";
    }



    public class RemoveUdfResponse
    {

        [JsonProperty("removeUdf")]
        public IEnumerable<UserDefinedField> Result { get; set; }
    }

    public class RemoveUdfParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// RemoveUdfParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType), key=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUdfDocument,
                OperationName = "removeUdf",
                Variables = this
            };
        }


        public static string RemoveUdfDocument = @"
        mutation removeUdf($targetType: UDFTargetType!, $key: String!) {
          removeUdf(targetType: $targetType, key: $key) {
            targetType
            dataType
            key
            label
            options
          }
        }
        ";
    }



    public class RemoveUdvResponse
    {

        [JsonProperty("removeUdv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }

    public class RemoveUdvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// RemoveUdvParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string), key=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveUdvDocument,
                OperationName = "removeUdv",
                Variables = this
            };
        }


        public static string RemoveUdvDocument = @"
        mutation removeUdv($targetType: UDFTargetType!, $targetId: String!, $key: String!) {
          removeUdv(targetType: $targetType, targetId: $targetId, key: $key) {
            key
            dataType
            value
          }
        }
        ";
    }



    public class RemoveUserFromGroupResponse
    {

        [JsonProperty("removeUserFromGroup")]
        public CommonMessage Result { get; set; }
    }

    public class RemoveUserFromGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// RemoveUserFromGroupParam.Request 
        /// <para>Required variables:<br/> { userIds=(string[]) }</para>
        /// <para>Optional variables:<br/> { code=(string) }</para>
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
        mutation removeUserFromGroup($userIds: [String!]!, $code: String) {
          removeUserFromGroup(userIds: $userIds, code: $code) {
            message
            code
          }
        }
        ";
    }



    public class RemoveWhitelistResponse
    {

        [JsonProperty("removeWhitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }

    public class RemoveWhitelistParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public WhitelistType Type { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("list")]
        public string List { get; set; }

        /// <summary>
        /// RemoveWhitelistParam.Request 
        /// <para>Required variables:<br/> { type=(WhitelistType), list=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RemoveWhitelistDocument,
                OperationName = "removeWhitelist",
                Variables = this
            };
        }


        public static string RemoveWhitelistDocument = @"
        mutation removeWhitelist($type: WhitelistType!, $list: [String!]!) {
          removeWhitelist(type: $type, list: $list) {
            createdAt
            updatedAt
            value
          }
        }
        ";
    }



    public class ResetPasswordResponse
    {

        [JsonProperty("resetPassword")]
        public CommonMessage Result { get; set; }
    }

    public class ResetPasswordParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// ResetPasswordParam.Request 
        /// <para>Required variables:<br/> { code=(string), newPassword=(string) }</para>
        /// <para>Optional variables:<br/> { phone=(string), email=(string) }</para>
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
        mutation resetPassword($phone: String, $email: String, $code: String!, $newPassword: String!) {
          resetPassword(phone: $phone, email: $email, code: $code, newPassword: $newPassword) {
            message
            code
          }
        }
        ";
    }



    public class RevokeRoleResponse
    {

        [JsonProperty("revokeRole")]
        public CommonMessage Result { get; set; }
    }

    public class RevokeRoleParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCode")]
        public string RoleCode { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("roleCodes")]
        public string RoleCodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("userIds")]
        public string UserIds { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("groupCodes")]
        public string GroupCodes { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("nodeCodes")]
        public string NodeCodes { get; set; }

        /// <summary>
        /// RevokeRoleParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { roleCode=(string), roleCodes=(string[]), userIds=(string[]), groupCodes=(string[]), nodeCodes=(string[]) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RevokeRoleDocument,
                OperationName = "revokeRole",
                Variables = this
            };
        }


        public static string RevokeRoleDocument = @"
        mutation revokeRole($roleCode: String, $roleCodes: [String], $userIds: [String!], $groupCodes: [String!], $nodeCodes: [String!]) {
          revokeRole(roleCode: $roleCode, roleCodes: $roleCodes, userIds: $userIds, groupCodes: $groupCodes, nodeCodes: $nodeCodes) {
            message
            code
          }
        }
        ";
    }



    public class SendEmailResponse
    {

        [JsonProperty("sendEmail")]
        public CommonMessage Result { get; set; }
    }

    public class SendEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("scene")]
        public EmailScene Scene { get; set; }

        /// <summary>
        /// SendEmailParam.Request 
        /// <para>Required variables:<br/> { email=(string), scene=(EmailScene) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SendEmailDocument,
                OperationName = "sendEmail",
                Variables = this
            };
        }


        public static string SendEmailDocument = @"
        mutation sendEmail($email: String!, $scene: EmailScene!) {
          sendEmail(email: $email, scene: $scene) {
            message
            code
          }
        }
        ";
    }



    public class SetUdvResponse
    {

        [JsonProperty("setUdv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }

    public class SetUdvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId { get; set; }

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
        /// SetUdvParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string), key=(string), value=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SetUdvDocument,
                OperationName = "setUdv",
                Variables = this
            };
        }


        public static string SetUdvDocument = @"
        mutation setUdv($targetType: UDFTargetType!, $targetId: String!, $key: String!, $value: String!) {
          setUdv(targetType: $targetType, targetId: $targetId, key: $key, value: $value) {
            key
            dataType
            value
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
        /// UnbindEmailParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UnbindEmailDocument,
                OperationName = "unbindEmail"
            };
        }


        public static string UnbindEmailDocument = @"
        mutation unbindEmail {
          unbindEmail {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            city
            province
            country
            createdAt
            updatedAt
            customData
            roles {
              totalCount
            }
          }
        }
        ";
    }



    public class UnbindPhoneResponse
    {

        [JsonProperty("unbindPhone")]
        public User Result { get; set; }
    }

    public class UnbindPhoneParam
    {


        /// <summary>
        /// UnbindPhoneParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UnbindPhoneDocument,
                OperationName = "unbindPhone"
            };
        }


        public static string UnbindPhoneDocument = @"
        mutation unbindPhone {
          unbindPhone {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
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
        /// <para>Required variables:<br/> { email=(string), emailCode=(string) }</para>
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
        mutation updateEmail($email: String!, $emailCode: String!, $oldEmail: String, $oldEmailCode: String) {
          updateEmail(email: $email, emailCode: $emailCode, oldEmail: $oldEmail, oldEmailCode: $oldEmailCode) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class UpdateFunctionResponse
    {

        [JsonProperty("updateFunction")]
        public Function Result { get; set; }
    }

    public class UpdateFunctionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateFunctionInput Input { get; set; }

        /// <summary>
        /// UpdateFunctionParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateFunctionInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateFunctionDocument,
                OperationName = "updateFunction",
                Variables = this
            };
        }


        public static string UpdateFunctionDocument = @"
        mutation updateFunction($input: UpdateFunctionInput!) {
          updateFunction(input: $input) {
            id
            name
            sourceCode
            description
            url
          }
        }
        ";
    }



    public class UpdateGroupResponse
    {

        [JsonProperty("updateGroup")]
        public Group Result { get; set; }
    }

    public class UpdateGroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

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
        [JsonProperty("newCode")]
        public string NewCode { get; set; }

        /// <summary>
        /// UpdateGroupParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> { name=(string), description=(string), newCode=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateGroupDocument,
                OperationName = "updateGroup",
                Variables = this
            };
        }


        public static string UpdateGroupDocument = @"
        mutation updateGroup($code: String!, $name: String, $description: String, $newCode: String) {
          updateGroup(code: $code, name: $name, description: $description, newCode: $newCode) {
            code
            name
            description
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class UpdateNodeResponse
    {

        [JsonProperty("updateNode")]
        public Node Result { get; set; }
    }

    public class UpdateNodeParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// UpdateNodeParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), name=(string), code=(string), description=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateNodeDocument,
                OperationName = "updateNode",
                Variables = this
            };
        }


        public static string UpdateNodeDocument = @"
        mutation updateNode($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $id: String!, $name: String, $code: String, $description: String) {
          updateNode(id: $id, name: $name, code: $code, description: $description) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
            }
          }
        }
        ";
    }



    public class UpdatePasswordResponse
    {

        [JsonProperty("updatePassword")]
        public User Result { get; set; }
    }

    public class UpdatePasswordParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("newPassword")]
        public string NewPassword { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("oldPassword")]
        public string OldPassword { get; set; }

        /// <summary>
        /// UpdatePasswordParam.Request 
        /// <para>Required variables:<br/> { newPassword=(string) }</para>
        /// <para>Optional variables:<br/> { oldPassword=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdatePasswordDocument,
                OperationName = "updatePassword",
                Variables = this
            };
        }


        public static string UpdatePasswordDocument = @"
        mutation updatePassword($newPassword: String!, $oldPassword: String) {
          updatePassword(newPassword: $newPassword, oldPassword: $oldPassword) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
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
        /// <para>Required variables:<br/> { phone=(string), phoneCode=(string) }</para>
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
        mutation updatePhone($phone: String!, $phoneCode: String!, $oldPhone: String, $oldPhoneCode: String) {
          updatePhone(phone: $phone, phoneCode: $phoneCode, oldPhone: $oldPhone, oldPhoneCode: $oldPhoneCode) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class UpdatePolicyResponse
    {

        [JsonProperty("updatePolicy")]
        public Policy Result { get; set; }
    }

    public class UpdatePolicyParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("statements")]
        public PolicyStatementInput Statements { get; set; }

        /// <summary>
        /// UpdatePolicyParam.Request 
        /// <para>Required variables:<br/> { code=(string), statements=(PolicyStatementInput[]) }</para>
        /// <para>Optional variables:<br/> { description=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdatePolicyDocument,
                OperationName = "updatePolicy",
                Variables = this
            };
        }


        public static string UpdatePolicyDocument = @"
        mutation updatePolicy($code: String!, $description: String, $statements: [PolicyStatementInput!]!) {
          updatePolicy(code: $code, description: $description, statements: $statements) {
            code
            assignmentsCount
            isDefault
            description
            statements {
              resource
              actions
              effect
            }
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class UpdateRoleResponse
    {

        [JsonProperty("updateRole")]
        public Role Result { get; set; }
    }

    public class UpdateRoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("newCode")]
        public string NewCode { get; set; }

        /// <summary>
        /// UpdateRoleParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> { description=(string), newCode=(string) }</para>
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
        mutation updateRole($code: String!, $description: String, $newCode: String) {
          updateRole(code: $code, description: $description, newCode: $newCode) {
            code
            description
            isSystem
            createdAt
            updatedAt
            users {
              totalCount
            }
            parent {
              code
              description
              isSystem
              createdAt
              updatedAt
            }
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
        /// Optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateUserInput Input { get; set; }

        /// <summary>
        /// UpdateUserParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateUserInput) }</para>
        /// <para>Optional variables:<br/> { id=(string) }</para>
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
        mutation updateUser($id: String, $input: UpdateUserInput!) {
          updateUser(id: $id, input: $input) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class UpdateUserpoolResponse
    {

        [JsonProperty("updateUserpool")]
        public UserPool Result { get; set; }
    }

    public class UpdateUserpoolParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("input")]
        public UpdateUserpoolInput Input { get; set; }

        /// <summary>
        /// UpdateUserpoolParam.Request 
        /// <para>Required variables:<br/> { input=(UpdateUserpoolInput) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UpdateUserpoolDocument,
                OperationName = "updateUserpool",
                Variables = this
            };
        }


        public static string UpdateUserpoolDocument = @"
        mutation updateUserpool($input: UpdateUserpoolInput!) {
          updateUserpool(input: $input) {
            id
            name
            domain
            description
            secret
            userpoolTypes {
              code
              name
              description
              image
              sdks
            }
            logo
            createdAt
            updatedAt
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWxQRCodeWhenRegisterDisabled
            allowedOrigins
            tokenExpiresAfter
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enabled
            }
            loginFailCheck {
              timeInterval
              limit
              enabled
            }
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
            whitelist {
              phoneEnabled
              emailEnabled
              usernameEnabled
            }
          }
        }
        ";
    }



    public class AccessTokenResponse
    {

        [JsonProperty("accessToken")]
        public AccessTokenRes Result { get; set; }
    }

    public class AccessTokenParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }

        /// <summary>
        /// AccessTokenParam.Request 
        /// <para>Required variables:<br/> { userPoolId=(string), secret=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = AccessTokenDocument,
                OperationName = "accessToken",
                Variables = this
            };
        }


        public static string AccessTokenDocument = @"
        query accessToken($userPoolId: String!, $secret: String!) {
          accessToken(userPoolId: $userPoolId, secret: $secret) {
            accessToken
            exp
            iat
          }
        }
        ";
    }



    public class CheckLoginStatusResponse
    {

        [JsonProperty("checkLoginStatus")]
        public JWTTokenStatus Result { get; set; }
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
            code
            message
            status
            exp
            iat
            data {
              id
              userPoolId
              arn
            }
          }
        }
        ";
    }



    public class CheckPasswordStrengthResponse
    {

        [JsonProperty("checkPasswordStrength")]
        public CheckPasswordStrengthResult Result { get; set; }
    }

    public class CheckPasswordStrengthParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// CheckPasswordStrengthParam.Request 
        /// <para>Required variables:<br/> { password=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = CheckPasswordStrengthDocument,
                OperationName = "checkPasswordStrength",
                Variables = this
            };
        }


        public static string CheckPasswordStrengthDocument = @"
        query checkPasswordStrength($password: String!) {
          checkPasswordStrength(password: $password) {
            valid
            message
          }
        }
        ";
    }



    public class ChildrenNodesResponse
    {

        [JsonProperty("childrenNodes")]
        public IEnumerable<Node> Result { get; set; }
    }

    public class ChildrenNodesParam
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
        /// ChildrenNodesParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), nodeId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = ChildrenNodesDocument,
                OperationName = "childrenNodes",
                Variables = this
            };
        }


        public static string ChildrenNodesDocument = @"
        query childrenNodes($orgId: String!, $nodeId: String!) {
          childrenNodes(orgId: $orgId, nodeId: $nodeId) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
          }
        }
        ";
    }



    public class EmailTemplatesResponse
    {

        [JsonProperty("emailTemplates")]
        public IEnumerable<EmailTemplate> Result { get; set; }
    }

    public class EmailTemplatesParam
    {


        /// <summary>
        /// EmailTemplatesParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = EmailTemplatesDocument,
                OperationName = "emailTemplates"
            };
        }


        public static string EmailTemplatesDocument = @"
        query emailTemplates {
          emailTemplates {
            type
            name
            subject
            sender
            content
            redirectTo
            hasURL
            expiresIn
            enabled
            isSystem
          }
        }
        ";
    }



    public class FunctionResponse
    {

        [JsonProperty("function")]
        public Function Result { get; set; }
    }

    public class FunctionParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// FunctionParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { id=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = FunctionDocument,
                OperationName = "function",
                Variables = this
            };
        }


        public static string FunctionDocument = @"
        query function($id: String) {
          function(id: $id) {
            id
            name
            sourceCode
            description
            url
          }
        }
        ";
    }



    public class FunctionsResponse
    {

        [JsonProperty("functions")]
        public PaginatedFunctions Result { get; set; }
    }

    public class FunctionsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// FunctionsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = FunctionsDocument,
                OperationName = "functions",
                Variables = this
            };
        }


        public static string FunctionsDocument = @"
        query functions($page: Int, $limit: Int, $sortBy: SortByEnum) {
          functions(page: $page, limit: $limit, sortBy: $sortBy) {
            list {
              id
              name
              sourceCode
              description
              url
            }
            totalCount
          }
        }
        ";
    }



    public class GetUserRolesResponse
    {

        [JsonProperty("user")]
        public User Result { get; set; }
    }

    public class GetUserRolesParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// GetUserRolesParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GetUserRolesDocument,
                OperationName = "getUserRoles",
                Variables = this
            };
        }


        public static string GetUserRolesDocument = @"
        query getUserRoles($id: String!) {
          user(id: $id) {
            roles {
              totalCount
              list {
                code
                arn
                description
                isSystem
                createdAt
                updatedAt
                parent {
                  code
                  description
                  isSystem
                  createdAt
                  updatedAt
                }
              }
            }
          }
        }
        ";
    }



    public class GroupResponse
    {

        [JsonProperty("group")]
        public Group Result { get; set; }
    }

    public class GroupParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// GroupParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GroupDocument,
                OperationName = "group",
                Variables = this
            };
        }


        public static string GroupDocument = @"
        query group($code: String!) {
          group(code: $code) {
            code
            name
            description
            createdAt
            updatedAt
            users {
              totalCount
            }
          }
        }
        ";
    }



    public class GroupWithUsersResponse
    {

        [JsonProperty("group")]
        public Group Result { get; set; }
    }

    public class GroupWithUsersParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// GroupWithUsersParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GroupWithUsersDocument,
                OperationName = "groupWithUsers",
                Variables = this
            };
        }


        public static string GroupWithUsersDocument = @"
        query groupWithUsers($code: String!, $page: Int, $limit: Int) {
          group(code: $code) {
            users(page: $page, limit: $limit) {
              totalCount
              list {
                id
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
          }
        }
        ";
    }



    public class GroupsResponse
    {

        [JsonProperty("groups")]
        public PaginatedGroups Result { get; set; }
    }

    public class GroupsParam
    {

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
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// GroupsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { userId=(string), page=(int), limit=(int), sortBy=(SortByEnum) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = GroupsDocument,
                OperationName = "groups",
                Variables = this
            };
        }


        public static string GroupsDocument = @"
        query groups($userId: String, $page: Int, $limit: Int, $sortBy: SortByEnum) {
          groups(userId: $userId, page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              code
              name
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class IsActionAllowedResponse
    {

        [JsonProperty("isActionAllowed")]
        public bool Result { get; set; }
    }

    public class IsActionAllowedParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// IsActionAllowedParam.Request 
        /// <para>Required variables:<br/> { resource=(string), action=(string), userId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsActionAllowedDocument,
                OperationName = "isActionAllowed",
                Variables = this
            };
        }


        public static string IsActionAllowedDocument = @"
        query isActionAllowed($resource: String!, $action: String!, $userId: String!) {
          isActionAllowed(resource: $resource, action: $action, userId: $userId)
        }
        ";
    }



    public class IsActionDeniedResponse
    {

        [JsonProperty("isActionDenied")]
        public bool Result { get; set; }
    }

    public class IsActionDeniedParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("resource")]
        public string Resource { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("userId")]
        public string UserId { get; set; }

        /// <summary>
        /// IsActionDeniedParam.Request 
        /// <para>Required variables:<br/> { resource=(string), action=(string), userId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsActionDeniedDocument,
                OperationName = "isActionDenied",
                Variables = this
            };
        }


        public static string IsActionDeniedDocument = @"
        query isActionDenied($resource: String!, $action: String!, $userId: String!) {
          isActionDenied(resource: $resource, action: $action, userId: $userId)
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



    public class IsRootNodeResponse
    {

        [JsonProperty("isRootNode")]
        public bool? Result { get; set; }
    }

    public class IsRootNodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("nodeId")]
        public string NodeId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// IsRootNodeParam.Request 
        /// <para>Required variables:<br/> { nodeId=(string), orgId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsRootNodeDocument,
                OperationName = "isRootNode",
                Variables = this
            };
        }


        public static string IsRootNodeDocument = @"
        query isRootNode($nodeId: String!, $orgId: String!) {
          isRootNode(nodeId: $nodeId, orgId: $orgId)
        }
        ";
    }



    public class IsUserExistsResponse
    {

        [JsonProperty("isUserExists")]
        public bool? Result { get; set; }
    }

    public class IsUserExistsParam
    {

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
        /// IsUserExistsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { email=(string), phone=(string), username=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = IsUserExistsDocument,
                OperationName = "isUserExists",
                Variables = this
            };
        }


        public static string IsUserExistsDocument = @"
        query isUserExists($email: String, $phone: String, $username: String) {
          isUserExists(email: $email, phone: $phone, username: $username)
        }
        ";
    }



    public class NodeByCodeResponse
    {

        [JsonProperty("nodeByCode")]
        public Node Result { get; set; }
    }

    public class NodeByCodeParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// NodeByCodeParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NodeByCodeDocument,
                OperationName = "nodeByCode",
                Variables = this
            };
        }


        public static string NodeByCodeDocument = @"
        query nodeByCode($orgId: String!, $code: String!) {
          nodeByCode(orgId: $orgId, code: $code) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
          }
        }
        ";
    }



    public class NodeByCodeWithMembersResponse
    {

        [JsonProperty("nodeByCode")]
        public Node Result { get; set; }
    }

    public class NodeByCodeWithMembersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// NodeByCodeWithMembersParam.Request 
        /// <para>Required variables:<br/> { orgId=(string), code=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NodeByCodeWithMembersDocument,
                OperationName = "nodeByCodeWithMembers",
                Variables = this
            };
        }


        public static string NodeByCodeWithMembersDocument = @"
        query nodeByCodeWithMembers($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $orgId: String!, $code: String!) {
          nodeByCode(orgId: $orgId, code: $code) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
              list {
                id
                arn
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
          }
        }
        ";
    }



    public class NodeByIdResponse
    {

        [JsonProperty("nodeById")]
        public Node Result { get; set; }
    }

    public class NodeByIdParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// NodeByIdParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NodeByIdDocument,
                OperationName = "nodeById",
                Variables = this
            };
        }


        public static string NodeByIdDocument = @"
        query nodeById($id: String!) {
          nodeById(id: $id) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
          }
        }
        ";
    }



    public class NodeByIdWithMembersResponse
    {

        [JsonProperty("nodeById")]
        public Node Result { get; set; }
    }

    public class NodeByIdWithMembersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// NodeByIdWithMembersParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = NodeByIdWithMembersDocument,
                OperationName = "nodeByIdWithMembers",
                Variables = this
            };
        }


        public static string NodeByIdWithMembersDocument = @"
        query nodeByIdWithMembers($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $id: String!) {
          nodeById(id: $id) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
              list {
                id
                arn
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
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
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// OrgParam.Request 
        /// <para>Required variables:<br/> { id=(string) }</para>
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
        query org($id: String!) {
          org(id: $id) {
            id
            rootNode {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
            nodes {
              id
              name
              nameI18n
              description
              descriptionI18n
              order
              code
              root
              depth
              path
              createdAt
              updatedAt
              children
            }
          }
        }
        ";
    }



    public class OrgsResponse
    {

        [JsonProperty("orgs")]
        public PaginatedOrgs Result { get; set; }
    }

    public class OrgsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// OrgsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
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
        query orgs($page: Int, $limit: Int, $sortBy: SortByEnum) {
          orgs(page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              id
              rootNode {
                id
                name
                nameI18n
                path
                description
                descriptionI18n
                order
                code
                root
                depth
                createdAt
                updatedAt
                children
              }
              nodes {
                id
                name
                path
                nameI18n
                description
                descriptionI18n
                order
                code
                root
                depth
                createdAt
                updatedAt
                children
              }
            }
          }
        }
        ";
    }



    public class PoliciesResponse
    {

        [JsonProperty("policies")]
        public PaginatedPolicies Result { get; set; }
    }

    public class PoliciesParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// PoliciesParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PoliciesDocument,
                OperationName = "policies",
                Variables = this
            };
        }


        public static string PoliciesDocument = @"
        query policies($page: Int, $limit: Int) {
          policies(page: $page, limit: $limit) {
            totalCount
            list {
              code
              assignmentsCount
              isDefault
              description
              createdAt
              updatedAt
              statements {
                resource
                actions
                effect
              }
            }
          }
        }
        ";
    }



    public class PolicyResponse
    {

        [JsonProperty("policy")]
        public Policy Result { get; set; }
    }

    public class PolicyParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// PolicyParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PolicyDocument,
                OperationName = "policy",
                Variables = this
            };
        }


        public static string PolicyDocument = @"
        query policy($code: String!) {
          policy(code: $code) {
            code
            assignmentsCount
            isDefault
            description
            statements {
              resource
              actions
              effect
            }
            createdAt
            updatedAt
          }
        }
        ";
    }



    public class PolicyAssignmentsResponse
    {

        [JsonProperty("policyAssignments")]
        public PaginatedPolicyAssignment Result { get; set; }
    }

    public class PolicyAssignmentsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType TargetType { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("targetIdentifier")]
        public string TargetIdentifier { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// PolicyAssignmentsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { code=(string), targetType=(PolicyAssignmentTargetType), targetIdentifier=(string), page=(int), limit=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PolicyAssignmentsDocument,
                OperationName = "policyAssignments",
                Variables = this
            };
        }


        public static string PolicyAssignmentsDocument = @"
        query policyAssignments($code: String, $targetType: PolicyAssignmentTargetType, $targetIdentifier: String, $page: Int, $limit: Int) {
          policyAssignments(code: $code, targetType: $targetType, targetIdentifier: $targetIdentifier, page: $page, limit: $limit) {
            totalCount
            list {
              code
              targetType
              targetIdentifier
            }
          }
        }
        ";
    }



    public class PolicyWithAssignmentsResponse
    {

        [JsonProperty("policy")]
        public Policy Result { get; set; }
    }

    public class PolicyWithAssignmentsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// PolicyWithAssignmentsParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PolicyWithAssignmentsDocument,
                OperationName = "policyWithAssignments",
                Variables = this
            };
        }


        public static string PolicyWithAssignmentsDocument = @"
        query policyWithAssignments($page: Int, $limit: Int, $code: String!) {
          policy(code: $code) {
            code
            isDefault
            description
            statements {
              resource
              actions
              effect
            }
            createdAt
            updatedAt
            assignmentsCount
            assignments(page: $page, limit: $limit) {
              code
              targetType
              targetIdentifier
            }
          }
        }
        ";
    }



    public class PreviewEmailResponse
    {

        [JsonProperty("previewEmail")]
        public string Result { get; set; }
    }

    public class PreviewEmailParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public EmailTemplateType Type { get; set; }

        /// <summary>
        /// PreviewEmailParam.Request 
        /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = PreviewEmailDocument,
                OperationName = "previewEmail",
                Variables = this
            };
        }


        public static string PreviewEmailDocument = @"
        query previewEmail($type: EmailTemplateType!) {
          previewEmail(type: $type)
        }
        ";
    }



    public class QiniuUptokenResponse
    {

        [JsonProperty("qiniuUptoken")]
        public string Result { get; set; }
    }

    public class QiniuUptokenParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// QiniuUptokenParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { type=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QiniuUptokenDocument,
                OperationName = "qiniuUptoken",
                Variables = this
            };
        }


        public static string QiniuUptokenDocument = @"
        query qiniuUptoken($type: String) {
          qiniuUptoken(type: $type)
        }
        ";
    }



    public class QueryMfaResponse
    {

        [JsonProperty("queryMfa")]
        public Mfa Result { get; set; }
    }

    public class QueryMfaParam
    {

        /// <summary>
        /// Optional
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
        [JsonProperty("userPoolId")]
        public string UserPoolId { get; set; }

        /// <summary>
        /// QueryMfaParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { id=(string), userId=(string), userPoolId=(string) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = QueryMfaDocument,
                OperationName = "queryMfa",
                Variables = this
            };
        }


        public static string QueryMfaDocument = @"
        query queryMfa($id: String, $userId: String, $userPoolId: String) {
          queryMfa(id: $id, userId: $userId, userPoolId: $userPoolId) {
            id
            userId
            userPoolId
            enable
            secret
          }
        }
        ";
    }



    public class RoleResponse
    {

        [JsonProperty("role")]
        public Role Result { get; set; }
    }

    public class RoleParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// RoleParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RoleDocument,
                OperationName = "role",
                Variables = this
            };
        }


        public static string RoleDocument = @"
        query role($code: String!) {
          role(code: $code) {
            code
            arn
            description
            isSystem
            createdAt
            updatedAt
            users {
              totalCount
            }
            parent {
              code
              arn
              description
              isSystem
              createdAt
              updatedAt
            }
          }
        }
        ";
    }



    public class RoleWithUsersResponse
    {

        [JsonProperty("role")]
        public Role Result { get; set; }
    }

    public class RoleWithUsersParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// RoleWithUsersParam.Request 
        /// <para>Required variables:<br/> { code=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RoleWithUsersDocument,
                OperationName = "roleWithUsers",
                Variables = this
            };
        }


        public static string RoleWithUsersDocument = @"
        query roleWithUsers($code: String!) {
          role(code: $code) {
            users {
              totalCount
              list {
                id
                userPoolId
                username
                email
                emailVerified
                phone
                phoneVerified
                unionid
                openid
                nickname
                registerSource
                photo
                password
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
                browser
                company
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
              }
            }
          }
        }
        ";
    }



    public class RolesResponse
    {

        [JsonProperty("roles")]
        public PaginatedRoles Result { get; set; }
    }

    public class RolesParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// RolesParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RolesDocument,
                OperationName = "roles",
                Variables = this
            };
        }


        public static string RolesDocument = @"
        query roles($page: Int, $limit: Int, $sortBy: SortByEnum) {
          roles(page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              code
              arn
              description
              isSystem
              createdAt
              updatedAt
              parent {
                code
                description
                isSystem
                createdAt
                updatedAt
              }
            }
          }
        }
        ";
    }



    public class RootNodeResponse
    {

        [JsonProperty("rootNode")]
        public Node Result { get; set; }
    }

    public class RootNodeParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("includeChildrenNodes")]
        public bool IncludeChildrenNodes { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

        /// <summary>
        /// RootNodeParam.Request 
        /// <para>Required variables:<br/> { orgId=(string) }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = RootNodeDocument,
                OperationName = "rootNode",
                Variables = this
            };
        }


        public static string RootNodeDocument = @"
        query rootNode($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $orgId: String!) {
          rootNode(orgId: $orgId) {
            id
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            createdAt
            updatedAt
            children
            users(page: $page, limit: $limit, sortBy: $sortBy, includeChildrenNodes: $includeChildrenNodes) {
              totalCount
            }
          }
        }
        ";
    }



    public class SearchUserResponse
    {

        [JsonProperty("searchUser")]
        public PaginatedUsers Result { get; set; }
    }

    public class SearchUserParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("query")]
        public string Query { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// SearchUserParam.Request 
        /// <para>Required variables:<br/> { query=(string) }</para>
        /// <para>Optional variables:<br/> { fields=(string[]), page=(int), limit=(int) }</para>
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
        query searchUser($query: String!, $fields: [String], $page: Int, $limit: Int) {
          searchUser(query: $query, fields: $fields, page: $page, limit: $limit) {
            totalCount
            list {
              id
              arn
              userPoolId
              username
              email
              emailVerified
              phone
              phoneVerified
              unionid
              openid
              nickname
              registerSource
              photo
              password
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
              browser
              company
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
              createdAt
              updatedAt
              customData
            }
          }
        }
        ";
    }



    public class SocialConnectionResponse
    {

        [JsonProperty("socialConnection")]
        public SocialConnection Result { get; set; }
    }

    public class SocialConnectionParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// SocialConnectionParam.Request 
        /// <para>Required variables:<br/> { provider=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SocialConnectionDocument,
                OperationName = "socialConnection",
                Variables = this
            };
        }


        public static string SocialConnectionDocument = @"
        query socialConnection($provider: String!) {
          socialConnection(provider: $provider) {
            provider
            name
            logo
            description
            fields {
              key
              label
              type
              placeholder
            }
          }
        }
        ";
    }



    public class SocialConnectionInstanceResponse
    {

        [JsonProperty("socialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }

    public class SocialConnectionInstanceParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// SocialConnectionInstanceParam.Request 
        /// <para>Required variables:<br/> { provider=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SocialConnectionInstanceDocument,
                OperationName = "socialConnectionInstance",
                Variables = this
            };
        }


        public static string SocialConnectionInstanceDocument = @"
        query socialConnectionInstance($provider: String!) {
          socialConnectionInstance(provider: $provider) {
            provider
            enabled
            fields {
              key
              value
            }
          }
        }
        ";
    }



    public class SocialConnectionInstancesResponse
    {

        [JsonProperty("socialConnectionInstances")]
        public IEnumerable<SocialConnectionInstance> Result { get; set; }
    }

    public class SocialConnectionInstancesParam
    {


        /// <summary>
        /// SocialConnectionInstancesParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SocialConnectionInstancesDocument,
                OperationName = "socialConnectionInstances"
            };
        }


        public static string SocialConnectionInstancesDocument = @"
        query socialConnectionInstances {
          socialConnectionInstances {
            provider
            enabled
            fields {
              key
              value
            }
          }
        }
        ";
    }



    public class SocialConnectionsResponse
    {

        [JsonProperty("socialConnections")]
        public IEnumerable<SocialConnection> Result { get; set; }
    }

    public class SocialConnectionsParam
    {


        /// <summary>
        /// SocialConnectionsParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = SocialConnectionsDocument,
                OperationName = "socialConnections"
            };
        }


        public static string SocialConnectionsDocument = @"
        query socialConnections {
          socialConnections {
            provider
            name
            logo
            description
            fields {
              key
              label
              type
              placeholder
            }
          }
        }
        ";
    }



    public class TemplateCodeResponse
    {

        [JsonProperty("templateCode")]
        public string Result { get; set; }
    }

    public class TemplateCodeParam
    {


        /// <summary>
        /// TemplateCodeParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = TemplateCodeDocument,
                OperationName = "templateCode"
            };
        }


        public static string TemplateCodeDocument = @"
        query templateCode {
          templateCode
        }
        ";
    }



    public class UdfResponse
    {

        [JsonProperty("udf")]
        public IEnumerable<UserDefinedField> Result { get; set; }
    }

    public class UdfParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// UdfParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UdfDocument,
                OperationName = "udf",
                Variables = this
            };
        }


        public static string UdfDocument = @"
        query udf($targetType: UDFTargetType!) {
          udf(targetType: $targetType) {
            targetType
            dataType
            key
            label
            options
          }
        }
        ";
    }



    public class UdvResponse
    {

        [JsonProperty("udv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }

    public class UdvParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetType")]
        public UdfTargetType TargetType { get; set; }

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// UdvParam.Request 
        /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UdvDocument,
                OperationName = "udv",
                Variables = this
            };
        }


        public static string UdvDocument = @"
        query udv($targetType: UDFTargetType!, $targetId: String!) {
          udv(targetType: $targetType, targetId: $targetId) {
            key
            dataType
            value
          }
        }
        ";
    }



    public class UserResponse
    {

        [JsonProperty("user")]
        public User Result { get; set; }
    }

    public class UserParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// UserParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { id=(string) }</para>
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
        query user($id: String) {
          user(id: $id) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class UserBatchResponse
    {

        [JsonProperty("userBatch")]
        public IEnumerable<User> Result { get; set; }
    }

    public class UserBatchParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("ids")]
        public string Ids { get; set; }

        /// <summary>
        /// UserBatchParam.Request 
        /// <para>Required variables:<br/> { ids=(string[]) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserBatchDocument,
                OperationName = "userBatch",
                Variables = this
            };
        }


        public static string UserBatchDocument = @"
        query userBatch($ids: [String!]!) {
          userBatch(ids: $ids) {
            id
            arn
            userPoolId
            username
            email
            emailVerified
            phone
            phoneVerified
            unionid
            openid
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
            nickname
            registerSource
            photo
            password
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
            browser
            company
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
            createdAt
            updatedAt
            customData
          }
        }
        ";
    }



    public class UserpoolResponse
    {

        [JsonProperty("userpool")]
        public UserPool Result { get; set; }
    }

    public class UserpoolParam
    {


        /// <summary>
        /// UserpoolParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserpoolDocument,
                OperationName = "userpool"
            };
        }


        public static string UserpoolDocument = @"
        query userpool {
          userpool {
            id
            name
            domain
            description
            secret
            jwtSecret
            userpoolTypes {
              code
              name
              description
              image
              sdks
            }
            logo
            createdAt
            updatedAt
            emailVerifiedDefault
            sendWelcomeEmail
            registerDisabled
            showWxQRCodeWhenRegisterDisabled
            allowedOrigins
            tokenExpiresAfter
            isDeleted
            frequentRegisterCheck {
              timeInterval
              limit
              enabled
            }
            loginFailCheck {
              timeInterval
              limit
              enabled
            }
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
            whitelist {
              phoneEnabled
              emailEnabled
              usernameEnabled
            }
          }
        }
        ";
    }



    public class UserpoolTypesResponse
    {

        [JsonProperty("userpoolTypes")]
        public IEnumerable<UserPoolType> Result { get; set; }
    }

    public class UserpoolTypesParam
    {


        /// <summary>
        /// UserpoolTypesParam.Request 
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserpoolTypesDocument,
                OperationName = "userpoolTypes"
            };
        }


        public static string UserpoolTypesDocument = @"
        query userpoolTypes {
          userpoolTypes {
            code
            name
            description
            image
            sdks
          }
        }
        ";
    }



    public class UserpoolsResponse
    {

        [JsonProperty("userpools")]
        public PaginatedUserpool Result { get; set; }
    }

    public class UserpoolsParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// UserpoolsParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = UserpoolsDocument,
                OperationName = "userpools",
                Variables = this
            };
        }


        public static string UserpoolsDocument = @"
        query userpools($page: Int, $limit: Int, $sortBy: SortByEnum) {
          userpools(page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              id
              name
              domain
              description
              secret
              jwtSecret
              logo
              createdAt
              updatedAt
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              showWxQRCodeWhenRegisterDisabled
              allowedOrigins
              tokenExpiresAfter
              isDeleted
            }
          }
        }
        ";
    }



    public class UsersResponse
    {

        [JsonProperty("users")]
        public PaginatedUsers Result { get; set; }
    }

    public class UsersParam
    {

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Optional
        /// </summary>
        [JsonProperty("sortBy")]
        public SortByEnum SortBy { get; set; }

        /// <summary>
        /// UsersParam.Request 
        /// <para>Required variables:<br/> {  }</para>
        /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
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
        query users($page: Int, $limit: Int, $sortBy: SortByEnum) {
          users(page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              id
              arn
              userPoolId
              username
              email
              emailVerified
              phone
              phoneVerified
              unionid
              openid
              nickname
              registerSource
              photo
              password
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
              browser
              company
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
              createdAt
              updatedAt
              customData
            }
          }
        }
        ";
    }



    public class WhitelistResponse
    {

        [JsonProperty("whitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }

    public class WhitelistParam
    {

        /// <summary>
        /// Required
        /// </summary>
        [JsonProperty("type")]
        public WhitelistType Type { get; set; }

        /// <summary>
        /// WhitelistParam.Request 
        /// <para>Required variables:<br/> { type=(WhitelistType) }</para>
        /// <para>Optional variables:<br/> {  }</para>
        /// </summary>
        public GraphQLRequest CreateRequest()
        {
            return new GraphQLRequest
            {
                Query = WhitelistDocument,
                OperationName = "whitelist",
                Variables = this
            };
        }


        public static string WhitelistDocument = @"
        query whitelist($type: WhitelistType!) {
          whitelist(type: $type) {
            createdAt
            updatedAt
            value
          }
        }
        ";
    }

}