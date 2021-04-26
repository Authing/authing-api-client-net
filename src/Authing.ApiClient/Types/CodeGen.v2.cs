using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Authing.ApiClient.GraphQL;

namespace Authing.ApiClient.Types
{

    #region Query
    public class Query
    {
        #region members
        [JsonProperty("isActionAllowed")]
        public bool IsActionAllowed { get; set; }

        [JsonProperty("isActionDenied")]
        public bool IsActionDenied { get; set; }

        [JsonProperty("authorizedTargets")]
        public PaginatedAuthorizedTargets AuthorizedTargets { get; set; }

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
        public IEnumerable<SocialConnection> SocialConnections { get; set; }

        /// <summary>
        /// 获取当前用户池的社会化登录配置
        /// </summary>
        [JsonProperty("socialConnectionInstance")]
        public SocialConnectionInstance SocialConnectionInstance { get; set; }

        /// <summary>
        /// 获取当前用户池的所有社会化登录配置
        /// </summary>
        [JsonProperty("socialConnectionInstances")]
        public IEnumerable<SocialConnectionInstance> SocialConnectionInstances { get; set; }

        [JsonProperty("emailTemplates")]
        public IEnumerable<EmailTemplate> EmailTemplates { get; set; }

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
        public IEnumerable<Node> ChildrenNodes { get; set; }

        [JsonProperty("rootNode")]
        public Node RootNode { get; set; }

        [JsonProperty("isRootNode")]
        public bool? IsRootNode { get; set; }

        [JsonProperty("searchNodes")]
        public IEnumerable<Node> SearchNodes { get; set; }

        [JsonProperty("checkPasswordStrength")]
        public CheckPasswordStrengthResult CheckPasswordStrength { get; set; }

        [JsonProperty("policy")]
        public Policy Policy { get; set; }

        [JsonProperty("policies")]
        public PaginatedPolicies Policies { get; set; }

        [JsonProperty("policyAssignments")]
        public PaginatedPolicyAssignments PolicyAssignments { get; set; }

        /// <summary>
        /// 获取一个对象被授权的资源列表
        /// </summary>
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources AuthorizedResources { get; set; }

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
        public IEnumerable<UserDefinedData> Udv { get; set; }

        /// <summary>
        /// 查询用户池定义的自定义字段
        /// </summary>
        [JsonProperty("udf")]
        public IEnumerable<UserDefinedField> Udf { get; set; }

        /// <summary>
        /// 批量查询多个对象的自定义数据
        /// </summary>
        [JsonProperty("udfValueBatch")]
        public IEnumerable<UserDefinedDataMap> UdfValueBatch { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("userBatch")]
        public IEnumerable<User> UserBatch { get; set; }

        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }

        /// <summary>
        /// 已归档的用户列表
        /// </summary>
        [JsonProperty("archivedUsers")]
        public PaginatedUsers ArchivedUsers { get; set; }

        [JsonProperty("searchUser")]
        public PaginatedUsers SearchUser { get; set; }

        [JsonProperty("checkLoginStatus")]
        public JWTTokenStatus CheckLoginStatus { get; set; }

        [JsonProperty("isUserExists")]
        public bool? IsUserExists { get; set; }

        [JsonProperty("findUser")]
        public User FindUser { get; set; }

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
        public IEnumerable<UserPoolType> UserpoolTypes { get; set; }

        /// <summary>
        /// 获取 accessToken ，如 SDK 初始化
        /// </summary>
        [JsonProperty("accessToken")]
        public AccessTokenRes AccessToken { get; set; }

        /// <summary>
        /// 用户池注册白名单列表
        /// </summary>
        [JsonProperty("whitelist")]
        public IEnumerable<WhiteList> Whitelist { get; set; }
        #endregion
    }
    #endregion
    public enum ResourceType
    {
        [JsonProperty("DATA")]
        DATA,
        [JsonProperty("API")]
        API,
        [JsonProperty("MENU")]
        MENU,
        [JsonProperty("UI")]
        UI,
        [JsonProperty("BUTTON")]
        BUTTON
    }

    public enum PolicyAssignmentTargetType
    {
        [JsonProperty("USER")]
        USER,
        [JsonProperty("ROLE")]
        ROLE,
        [JsonProperty("GROUP")]
        GROUP,
        [JsonProperty("ORG")]
        ORG,
        [JsonProperty("AK_SK")]
        AK_SK
    }


    #region AuthorizedTargetsActionsInput
    public class AuthorizedTargetsActionsInput
    {
        #region members
        [JsonProperty("op")]
        [JsonRequired]
        public Operator Op { get; set; }

        [JsonProperty("list")]
        [JsonRequired]
        public IEnumerable<string> List { get; set; }
        #endregion


        /// <summary>
        /// <param name="op">op</param>
        /// <param name="list">list</param>
        /// </summary>

        public AuthorizedTargetsActionsInput(Operator op, IEnumerable<string> list)
        {
            this.Op = op;
            this.List = list;
        }

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
    public enum Operator
    {
        [JsonProperty("AND")]
        AND,
        [JsonProperty("OR")]
        OR
    }


    #region PaginatedAuthorizedTargets
    public class PaginatedAuthorizedTargets
    {
        #region members
        [JsonProperty("list")]
        public IEnumerable<ResourcePermissionAssignment> List { get; set; }

        [JsonProperty("totalCount")]
        public int? TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region ResourcePermissionAssignment
    public class ResourcePermissionAssignment
    {
        #region members
        [JsonProperty("targetType")]
        public PolicyAssignmentTargetType? TargetType { get; set; }

        [JsonProperty("targetIdentifier")]
        public string TargetIdentifier { get; set; }

        [JsonProperty("actions")]
        public IEnumerable<string> Actions { get; set; }
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
        public IEnumerable<SocialConnectionField> Fields { get; set; }
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
        public IEnumerable<SocialConnectionField> Children { get; set; }
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
        public IEnumerable<SocialConnectionInstanceField> Fields { get; set; }
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
        public IEnumerable<Function> List { get; set; }

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

        /// <summary>
        /// 被授权访问的所有资源
        /// </summary>
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources AuthorizedResources { get; set; }
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
        public IEnumerable<User> List { get; set; }
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
        /// 用户在组织机构中的状态
        /// </summary>
        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

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
        public IEnumerable<Identity> Identities { get; set; }

        /// <summary>
        /// 昵称，该字段不唯一。
        /// </summary>
        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        /// <summary>
        /// 注册方式
        /// </summary>
        [JsonProperty("registerSource")]
        public IEnumerable<string> RegisterSource { get; set; }

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
        /// 用户所在的角色列表
        /// </summary>
        [JsonProperty("roles")]
        public PaginatedRoles Roles { get; set; }

        /// <summary>
        /// 用户所在的分组列表
        /// </summary>
        [JsonProperty("groups")]
        public PaginatedGroups Groups { get; set; }

        /// <summary>
        /// 用户所在的部门列表
        /// </summary>
        [JsonProperty("departments")]
        public PaginatedDepartments Departments { get; set; }

        /// <summary>
        /// 被授权访问的所有资源
        /// </summary>
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources AuthorizedResources { get; set; }

        /// <summary>
        /// 用户外部 ID
        /// </summary>
        [JsonProperty("externalId")]
        public string ExternalId { get; set; }
        #endregion
    }
    #endregion
    public enum UserStatus
    {
        /// <summary>
        /// 已停用
        /// </summary>
        [JsonProperty("Suspended")]
        Suspended,
        /// <summary>
        /// 已离职
        /// </summary>
        [JsonProperty("Resigned")]
        Resigned,
        /// <summary>
        /// 已激活（正常状态）
        /// </summary>
        [JsonProperty("Activated")]
        Activated,
        /// <summary>
        /// 已归档
        /// </summary>
        [JsonProperty("Archived")]
        Archived
    }


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

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("accessToken")]
        public string AccessToken { get; set; }
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
        public IEnumerable<Role> List { get; set; }
        #endregion
    }
    #endregion

    #region Role
    public class Role
    {
        #region members
        /// <summary>
        /// 权限组 code
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

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
        /// 被授权访问的所有资源
        /// </summary>
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources AuthorizedResources { get; set; }

        /// <summary>
        /// 父角色
        /// </summary>
        [JsonProperty("parent")]
        public Role Parent { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedAuthorizedResources
    public class PaginatedAuthorizedResources
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public IEnumerable<AuthorizedResource> List { get; set; }
        #endregion
    }
    #endregion

    #region AuthorizedResource
    public class AuthorizedResource
    {
        #region members
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("type")]
        public ResourceType? Type { get; set; }

        [JsonProperty("actions")]
        public IEnumerable<string> Actions { get; set; }
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
        public IEnumerable<Group> List { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedDepartments
    public class PaginatedDepartments
    {
        #region members
        [JsonProperty("list")]
        public IEnumerable<UserDepartment> List { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }
        #endregion
    }
    #endregion

    #region UserDepartment
    public class UserDepartment
    {
        #region members
        [JsonProperty("department")]
        public Node Department { get; set; }

        /// <summary>
        /// 是否为主部门
        /// </summary>
        [JsonProperty("isMainDepartment")]
        public bool IsMainDepartment { get; set; }

        /// <summary>
        /// 加入该部门的时间
        /// </summary>
        [JsonProperty("joinedAt")]
        public string JoinedAt { get; set; }
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
        /// 组织机构 ID
        /// </summary>
        [JsonProperty("orgId")]
        public string OrgId { get; set; }

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
        /// 距离父节点的深度（如果是查询整棵树，返回的 **depth** 为距离根节点的深度，如果是查询某个节点的子节点，返回的 **depth** 指的是距离该节点的深度。）
        /// </summary>
        [JsonProperty("depth")]
        public int? Depth { get; set; }

        [JsonProperty("path")]
        public IEnumerable<string> Path { get; set; }

        [JsonProperty("codePath")]
        public IEnumerable<string> CodePath { get; set; }

        [JsonProperty("namePath")]
        public IEnumerable<string> NamePath { get; set; }

        [JsonProperty("createdAt")]
        public string CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// 该节点的子节点 **ID** 列表
        /// </summary>
        [JsonProperty("children")]
        public IEnumerable<string> Children { get; set; }

        /// <summary>
        /// 节点的用户列表
        /// </summary>
        [JsonProperty("users")]
        public PaginatedUsers Users { get; set; }

        /// <summary>
        /// 被授权访问的所有资源
        /// </summary>
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources AuthorizedResources { get; set; }
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
        public IEnumerable<Node> Nodes { get; set; }
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
        public IEnumerable<Org> List { get; set; }
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
        /// <summary>
        /// 权限组 code
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("isDefault")]
        public bool IsDefault { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("statements")]
        public IEnumerable<PolicyStatement> Statements { get; set; }

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
        public IEnumerable<PolicyAssignment> Assignments { get; set; }
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
        public IEnumerable<string> Actions { get; set; }

        [JsonProperty("effect")]
        public PolicyEffect? Effect { get; set; }

        [JsonProperty("condition")]
        public IEnumerable<PolicyStatementCondition> Condition { get; set; }
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


    #region PolicyStatementCondition
    public class PolicyStatementCondition
    {
        #region members
        [JsonProperty("param")]
        public string Param { get; set; }

        [JsonProperty("operator")]
        public string Operator { get; set; }

        [JsonProperty("value")]
        public any Value { get; set; }
        #endregion
    }
    #endregion

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

    #region PaginatedPolicies
    public class PaginatedPolicies
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public IEnumerable<Policy> List { get; set; }
        #endregion
    }
    #endregion

    #region PaginatedPolicyAssignments
    public class PaginatedPolicyAssignments
    {
        #region members
        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("list")]
        public IEnumerable<PolicyAssignment> List { get; set; }
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

        [JsonProperty("label")]
        public string Label { get; set; }
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

    #region UserDefinedDataMap
    public class UserDefinedDataMap
    {
        #region members
        [JsonProperty("targetId")]
        public string TargetId { get; set; }

        [JsonProperty("data")]
        public IEnumerable<UserDefinedData> Data { get; set; }
        #endregion
    }
    #endregion

    #region SearchUserDepartmentOpt
    public class SearchUserDepartmentOpt
    {
        #region members
        [JsonProperty("departmentId")]
        public string DepartmentId { get; set; }

        [JsonProperty("includeChildrenDepartments")]
        public bool? IncludeChildrenDepartments { get; set; }
        #endregion



        public SearchUserDepartmentOpt()
        {

        }

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

    #region SearchUserGroupOpt
    public class SearchUserGroupOpt
    {
        #region members
        [JsonProperty("code")]
        public string Code { get; set; }
        #endregion



        public SearchUserGroupOpt()
        {

        }

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

    #region SearchUserRoleOpt
    public class SearchUserRoleOpt
    {
        #region members
        [JsonProperty("namespace")]
        public string Namespace { get; set; }

        [JsonProperty("code")]
        [JsonRequired]
        public string Code { get; set; }
        #endregion


        /// <summary>
        /// <param name="code">code</param>
        /// </summary>

        public SearchUserRoleOpt(string code)
        {
            this.Code = code;
        }

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

        [JsonProperty("ownerId")]
        public string OwnerId { get; set; }

        [JsonProperty("userpoolTypes")]
        public IEnumerable<UserPoolType> UserpoolTypes { get; set; }

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
        /// 是否开启用户池下应用间单点登录
        /// </summary>
        [JsonProperty("appSsoEnabled")]
        public bool AppSsoEnabled { get; set; }

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

        /// <summary>
        /// 自定义短信服务商配置
        /// </summary>
        [JsonProperty("customSMSProvider")]
        public CustomSMSProvider CustomSmsProvider { get; set; }

        /// <summary>
        /// 用户池套餐类型
        /// </summary>
        [JsonProperty("packageType")]
        public int? PackageType { get; set; }

        /// <summary>
        /// 是否使用自定义数据库 CUSTOM_USER_STORE 模式
        /// </summary>
        [JsonProperty("useCustomUserStore")]
        public bool? UseCustomUserStore { get; set; }

        /// <summary>
        /// 是否要求邮箱必须验证才能登录（如果是通过邮箱登录的话）
        /// </summary>
        [JsonProperty("loginRequireEmailVerified")]
        public bool? LoginRequireEmailVerified { get; set; }

        /// <summary>
        /// 短信验证码长度
        /// </summary>
        [JsonProperty("verifyCodeLength")]
        public int? VerifyCodeLength { get; set; }
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
        public IEnumerable<string> Sdks { get; set; }
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

    #region CustomSMSProvider
    public class CustomSMSProvider
    {
        #region members
        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("provider")]
        public string Provider { get; set; }

        [JsonProperty("config")]
        public string Config { get; set; }
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
        public IEnumerable<UserPool> List { get; set; }
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
        /// 允许操作某个资源
        /// </summary>
        [JsonProperty("allow")]
        public CommonMessage Allow { get; set; }

        /// <summary>
        /// 将一个（类）资源授权给用户、角色、分组、组织机构，且可以分别指定不同的操作权限。
        /// </summary>
        [JsonProperty("authorizeResource")]
        public CommonMessage AuthorizeResource { get; set; }

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
        /// 设置用户在某个组织机构内所在的主部门
        /// </summary>
        [JsonProperty("setMainDepartment")]
        public CommonMessage SetMainDepartment { get; set; }

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
        /// 添加子节点
        /// </summary>
        [JsonProperty("addNodeV2")]
        public Node AddNodeV2 { get; set; }

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

        /// <summary>
        /// 开启授权
        /// </summary>
        [JsonProperty("enablePolicyAssignment")]
        public CommonMessage EnablePolicyAssignment { get; set; }

        /// <summary>
        /// 开启授权
        /// </summary>
        [JsonProperty("disbalePolicyAssignment")]
        public CommonMessage DisbalePolicyAssignment { get; set; }

        [JsonProperty("removePolicyAssignments")]
        public CommonMessage RemovePolicyAssignments { get; set; }

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
        public CommonMessage DeleteRoles { get; set; }

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

        /// <summary>
        /// 使用子账号登录
        /// </summary>
        [JsonProperty("loginBySubAccount")]
        public User LoginBySubAccount { get; set; }

        [JsonProperty("setUdf")]
        public UserDefinedField SetUdf { get; set; }

        [JsonProperty("removeUdf")]
        public CommonMessage RemoveUdf { get; set; }

        [JsonProperty("setUdv")]
        public IEnumerable<UserDefinedData> SetUdv { get; set; }

        [JsonProperty("setUdfValueBatch")]
        public CommonMessage SetUdfValueBatch { get; set; }

        [JsonProperty("removeUdv")]
        public IEnumerable<UserDefinedData> RemoveUdv { get; set; }

        [JsonProperty("setUdvBatch")]
        public IEnumerable<UserDefinedData> SetUdvBatch { get; set; }

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
        /// 绑定邮箱
        /// </summary>
        [JsonProperty("bindEmail")]
        public User BindEmail { get; set; }

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
        public IEnumerable<WhiteList> AddWhitelist { get; set; }

        [JsonProperty("removeWhitelist")]
        public IEnumerable<WhiteList> RemoveWhitelist { get; set; }
        #endregion
    }
    #endregion

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

    #region AuthorizeResourceOpt
    public class AuthorizeResourceOpt
    {
        #region members
        [JsonProperty("targetType")]
        [JsonRequired]
        public PolicyAssignmentTargetType TargetType { get; set; }

        [JsonProperty("targetIdentifier")]
        [JsonRequired]
        public string TargetIdentifier { get; set; }

        [JsonProperty("actions")]
        public IEnumerable<string> Actions { get; set; }
        #endregion


        /// <summary>
        /// <param name="targetType">targetType</param>
        /// <param name="targetIdentifier">targetIdentifier</param>
        /// </summary>

        public AuthorizeResourceOpt(PolicyAssignmentTargetType targetType, string targetIdentifier)
        {
            this.TargetType = targetType;
            this.TargetIdentifier = targetIdentifier;
        }

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
        public IEnumerable<CreateSocialConnectionInstanceFieldInput> Fields { get; set; }
        #endregion


        /// <summary>
        /// <param name="provider">社会化登录 provider</param>
        /// </summary>

        public CreateSocialConnectionInstanceInput(string provider)
        {
            this.Provider = provider;
        }

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


        /// <summary>
        /// <param name="key">key</param>
        /// <param name="value">value</param>
        /// </summary>

        public CreateSocialConnectionInstanceFieldInput(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }

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


        /// <summary>
        /// <param name="type">邮件模版类型</param>
        /// <param name="name">模版名称</param>
        /// <param name="subject">邮件主题</param>
        /// <param name="sender">显示的邮件发送人</param>
        /// <param name="content">邮件模版内容</param>
        /// </summary>

        public ConfigEmailTemplateInput(EmailTemplateType type, string name, string subject, string sender, string content)
        {
            this.Type = type;
            this.Name = name;
            this.Subject = subject;
            this.Sender = sender;
            this.Content = content;
        }

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
  public enum EmailScene {
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
    CHANGE_EMAIL,
    /// <summary>
    /// 发送 MFA 验证邮件
    /// </summary>
    [JsonProperty("MFA_VERIFY")]
    MFA_VERIFY
  }
  
  
  #region CreateFunctionInput
  public class CreateFunctionInput {
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
  
    
  /// <summary>
  /// <param name="name">函数名称</param>
  /// <param name="sourceCode">源代码</param>
  /// </summary>
  
  public CreateFunctionInput(string name, string sourceCode) {
  this.Name = name;
  this.SourceCode = sourceCode;
  }
  
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
  public class UpdateFunctionInput {
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
  
    
  /// <summary>
  /// <param name="id">ID</param>
  /// </summary>
  
  public UpdateFunctionInput(string id) {
  this.Id = id;
  }
  
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
  public class LoginByEmailInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="email">email</param>
  /// <param name="password">password</param>
  /// </summary>
  
  public LoginByEmailInput(string email, string password) {
  this.Email = email;
  this.Password = password;
  }
  
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
  public class LoginByUsernameInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="username">username</param>
  /// <param name="password">password</param>
  /// </summary>
  
  public LoginByUsernameInput(string username, string password) {
  this.Username = username;
  this.Password = password;
  }
  
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
  public class LoginByPhoneCodeInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="phone">phone</param>
  /// <param name="code">code</param>
  /// </summary>
  
  public LoginByPhoneCodeInput(string phone, string code) {
  this.Phone = phone;
  this.Code = code;
  }
  
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
  public class LoginByPhonePasswordInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="phone">phone</param>
  /// <param name="password">password</param>
  /// </summary>
  
  public LoginByPhonePasswordInput(string phone, string password) {
  this.Phone = phone;
  this.Password = password;
  }
  
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
  public class PolicyStatementInput {
    #region members
    [JsonProperty("resource")]
    [JsonRequired]
    public string Resource { get; set; }
  
    [JsonProperty("actions")]
    [JsonRequired]
    public IEnumerable<string> Actions { get; set; }
  
    [JsonProperty("effect")]
    public PolicyEffect? Effect { get; set; }
  
    [JsonProperty("condition")]
    public IEnumerable<PolicyStatementConditionInput> Condition { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="resource">resource</param>
  /// <param name="actions">actions</param>
  /// </summary>
  
  public PolicyStatementInput(string resource, IEnumerable<string> actions) {
  this.Resource = resource;
  this.Actions = actions;
  }
  
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
  
  #region PolicyStatementConditionInput
  public class PolicyStatementConditionInput {
    #region members
    [JsonProperty("param")]
    [JsonRequired]
    public string Param { get; set; }
  
    [JsonProperty("operator")]
    [JsonRequired]
    public string Operator { get; set; }
  
    [JsonProperty("value")]
    [JsonRequired]
    public any Value { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="param">param</param>
  /// <param name="operator">operator</param>
  /// <param name="value">value</param>
  /// </summary>
  
  public PolicyStatementConditionInput(string param, string operator, any value) {
  this.Param = param;
  this.Operator = operator;
  this.Value = value;
  }
  
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
  public class RegisterByUsernameInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="username">username</param>
  /// <param name="password">password</param>
  /// </summary>
  
  public RegisterByUsernameInput(string username, string password) {
  this.Username = username;
  this.Password = password;
  }
  
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
  public class RegisterProfile {
    #region members
    [JsonProperty("ip")]
    public string Ip { get; set; }
  
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
  
    [JsonProperty("udf")]
    public IEnumerable<UserDdfInput> Udf { get; set; }
    #endregion
  
    
  
  public RegisterProfile() {
  
  }
  
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
  public class UserDdfInput {
    #region members
    [JsonProperty("key")]
    [JsonRequired]
    public string Key { get; set; }
  
    [JsonProperty("value")]
    [JsonRequired]
    public string Value { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="key">key</param>
  /// <param name="value">value</param>
  /// </summary>
  
  public UserDdfInput(string key, string value) {
  this.Key = key;
  this.Value = value;
  }
  
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
  public class RegisterByEmailInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="email">email</param>
  /// <param name="password">password</param>
  /// </summary>
  
  public RegisterByEmailInput(string email, string password) {
  this.Email = email;
  this.Password = password;
  }
  
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
  public class RegisterByPhoneCodeInput {
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
  
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
  
    /// <summary>
    /// 设置用户自定义字段，要求符合 Array<{ key: string; value: string }> 格式
    /// </summary>
    [JsonProperty("params")]
    public string Params { get; set; }
  
    /// <summary>
    /// 请求上下文信息，将会传递到 pipeline 中
    /// </summary>
    [JsonProperty("context")]
    public string Context { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="phone">phone</param>
  /// <param name="code">code</param>
  /// </summary>
  
  public RegisterByPhoneCodeInput(string phone, string code) {
  this.Phone = phone;
  this.Code = code;
  }
  
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
  
  #region SetUdfValueBatchInput
  public class SetUdfValueBatchInput {
    #region members
    [JsonProperty("targetId")]
    [JsonRequired]
    public string TargetId { get; set; }
  
    [JsonProperty("key")]
    [JsonRequired]
    public string Key { get; set; }
  
    [JsonProperty("value")]
    [JsonRequired]
    public string Value { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="targetId">targetId</param>
  /// <param name="key">key</param>
  /// <param name="value">value</param>
  /// </summary>
  
  public SetUdfValueBatchInput(string targetId, string key, string value) {
  this.TargetId = targetId;
  this.Key = key;
  this.Value = value;
  }
  
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
  
  #region UserDefinedDataInput
  public class UserDefinedDataInput {
    #region members
    [JsonProperty("key")]
    [JsonRequired]
    public string Key { get; set; }
  
    [JsonProperty("value")]
    public string Value { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="key">key</param>
  /// </summary>
  
  public UserDefinedDataInput(string key) {
  this.Key = key;
  }
  
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
  public class RefreshToken {
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
  public class CreateUserInput {
    #region members
    /// <summary>
    /// 用户名，用户池内唯一
    /// </summary>
    [JsonProperty("username")]
    public string Username { get; set; }
  
    /// <summary>
    /// 邮箱，不区分大小写，如 Bob@example.com 和 bob@example.com 会识别为同一个邮箱。用户池内唯一。
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
    public IEnumerable<string> RegisterSource { get; set; }
  
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
  
    [JsonProperty("externalId")]
    public string ExternalId { get; set; }
    #endregion
  
    
  
  public CreateUserInput() {
  
  }
  
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
  public class UpdateUserInput {
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
  
    [JsonProperty("externalId")]
    public string ExternalId { get; set; }
    #endregion
  
    
  
  public UpdateUserInput() {
  
  }
  
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
  public class UpdateUserpoolInput {
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
    public IEnumerable<string> UserpoolTypes { get; set; }
  
    [JsonProperty("emailVerifiedDefault")]
    public bool? EmailVerifiedDefault { get; set; }
  
    [JsonProperty("sendWelcomeEmail")]
    public bool? SendWelcomeEmail { get; set; }
  
    [JsonProperty("registerDisabled")]
    public bool? RegisterDisabled { get; set; }
  
    [JsonProperty("appSsoEnabled")]
    public bool? AppSsoEnabled { get; set; }
  
    [JsonProperty("allowedOrigins")]
    public string AllowedOrigins { get; set; }
  
    [JsonProperty("tokenExpiresAfter")]
    public int? TokenExpiresAfter { get; set; }
  
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
  
    /// <summary>
    /// 自定义短信服务商配置
    /// </summary>
    [JsonProperty("customSMSProvider")]
    public CustomSmsProviderInput CustomSmsProvider { get; set; }
  
    /// <summary>
    /// 是否要求邮箱必须验证才能登录（如果是通过邮箱登录的话）
    /// </summary>
    [JsonProperty("loginRequireEmailVerified")]
    public bool? LoginRequireEmailVerified { get; set; }
  
    [JsonProperty("verifyCodeLength")]
    public int? VerifyCodeLength { get; set; }
    #endregion
  
    
  
  public UpdateUserpoolInput() {
  
  }
  
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
  public class FrequentRegisterCheckConfigInput {
    #region members
    [JsonProperty("timeInterval")]
    public int? TimeInterval { get; set; }
  
    [JsonProperty("limit")]
    public int? Limit { get; set; }
  
    [JsonProperty("enabled")]
    public bool? Enabled { get; set; }
    #endregion
  
    
  
  public FrequentRegisterCheckConfigInput() {
  
  }
  
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
  public class LoginFailCheckConfigInput {
    #region members
    [JsonProperty("timeInterval")]
    public int? TimeInterval { get; set; }
  
    [JsonProperty("limit")]
    public int? Limit { get; set; }
  
    [JsonProperty("enabled")]
    public bool? Enabled { get; set; }
    #endregion
  
    
  
  public LoginFailCheckConfigInput() {
  
  }
  
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
  public class ChangePhoneStrategyInput {
    #region members
    [JsonProperty("verifyOldPhone")]
    public bool? VerifyOldPhone { get; set; }
    #endregion
  
    
  
  public ChangePhoneStrategyInput() {
  
  }
  
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
  public class ChangeEmailStrategyInput {
    #region members
    [JsonProperty("verifyOldEmail")]
    public bool? VerifyOldEmail { get; set; }
    #endregion
  
    
  
  public ChangeEmailStrategyInput() {
  
  }
  
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
  public class QrcodeLoginStrategyInput {
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
  
    
  
  public QrcodeLoginStrategyInput() {
  
  }
  
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
  public class App2WxappLoginStrategyInput {
    #region members
    [JsonProperty("ticketExpriresAfter")]
    public int? TicketExpriresAfter { get; set; }
  
    [JsonProperty("ticketExchangeUserInfoNeedSecret")]
    public bool? TicketExchangeUserInfoNeedSecret { get; set; }
    #endregion
  
    
  
  public App2WxappLoginStrategyInput() {
  
  }
  
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
  public class RegisterWhiteListConfigInput {
    #region members
    [JsonProperty("phoneEnabled")]
    public bool? PhoneEnabled { get; set; }
  
    [JsonProperty("emailEnabled")]
    public bool? EmailEnabled { get; set; }
  
    [JsonProperty("usernameEnabled")]
    public bool? UsernameEnabled { get; set; }
    #endregion
  
    
  
  public RegisterWhiteListConfigInput() {
  
  }
  
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
  
  #region CustomSmsProviderInput
  public class CustomSmsProviderInput {
    #region members
    [JsonProperty("enabled")]
    public bool? Enabled { get; set; }
  
    [JsonProperty("provider")]
    public string Provider { get; set; }
  
    [JsonProperty("config")]
    public string Config { get; set; }
    #endregion
  
    
  
  public CustomSmsProviderInput() {
  
  }
  
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
  public class RefreshAccessTokenRes {
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
  
  #region BatchOperationResult
  /// <summary>
  /// 批量删除返回结果
  /// </summary>
  public class BatchOperationResult {
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
    public IEnumerable<string> Errors { get; set; }
    #endregion
  }
  #endregion
  
  #region KeyValuePair
  public class KeyValuePair {
    #region members
    [JsonProperty("key")]
    public string Key { get; set; }
  
    [JsonProperty("value")]
    public string Value { get; set; }
    #endregion
  }
  #endregion
  
  #region SocialConnectionFieldInput
  public class SocialConnectionFieldInput {
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
    public IEnumerable<SocialConnectionFieldInput> Children { get; set; }
    #endregion
  
    
  
  public SocialConnectionFieldInput() {
  
  }
  
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
  
  #region CreateSocialConnectionInput
  public class CreateSocialConnectionInput {
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
    public IEnumerable<SocialConnectionFieldInput> Fields { get; set; }
    #endregion
  
    
  /// <summary>
  /// <param name="provider">provider</param>
  /// <param name="name">name</param>
  /// <param name="logo">logo</param>
  /// </summary>
  
  public CreateSocialConnectionInput(string provider, string name, string logo) {
  this.Provider = provider;
  this.Name = name;
  this.Logo = logo;
  }
  
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
}

namespace Authing.ApiClient.Types {

    
    public class AddMemberResponse {
        
        [JsonProperty("addMember")]
        public Node Result { get; set; }
    }
    
    public class AddMemberParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("includeChildrenNodes")]
    public bool? IncludeChildrenNodes { get; set; }

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
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("isLeader")]
    public bool? IsLeader { get; set; }
      
public AddMemberParam(IEnumerable<string> userIds) {
this.UserIds = userIds;
}
      /// <summary>
      /// AddMemberParam.Request 
      /// <para>Required variables:<br/> { userIds=(string[]) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), nodeId=(string), orgId=(string), nodeCode=(string), isLeader=(bool) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AddMemberDocument,
          OperationName = "addMember",
          Variables = this
        };
      }

      
      public static string AddMemberDocument = @"
        mutation addMember($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $nodeId: String, $orgId: String, $nodeCode: String, $userIds: [String!]!, $isLeader: Boolean) {
          addMember(nodeId: $nodeId, orgId: $orgId, nodeCode: $nodeCode, userIds: $userIds, isLeader: $isLeader) {
            id
            orgId
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
                status
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
                city
                province
                country
                createdAt
                updatedAt
                externalId
              }
            }
          }
        }
        ";
    }
    

    
    public class AddNodeResponse {
        
        [JsonProperty("addNode")]
        public Org Result { get; set; }
    }
    
    public class AddNodeParam {
      
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
    public int? Order { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public AddNodeParam(string orgId,string name) {
this.OrgId = orgId;
this.Name = name;
}
      /// <summary>
      /// AddNodeParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), name=(string) }</para>
      /// <para>Optional variables:<br/> { parentNodeId=(string), nameI18n=(string), description=(string), descriptionI18n=(string), order=(int), code=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              orgId
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
              orgId
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
    

    
    public class AddNodeV2Response {
        
        [JsonProperty("addNodeV2")]
        public Node Result { get; set; }
    }
    
    public class AddNodeV2Param {
      
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
    public int? Order { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public AddNodeV2Param(string orgId,string name) {
this.OrgId = orgId;
this.Name = name;
}
      /// <summary>
      /// AddNodeV2Param.Request 
      /// <para>Required variables:<br/> { orgId=(string), name=(string) }</para>
      /// <para>Optional variables:<br/> { parentNodeId=(string), nameI18n=(string), description=(string), descriptionI18n=(string), order=(int), code=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AddNodeV2Document,
          OperationName = "addNodeV2",
          Variables = this
        };
      }

      
      public static string AddNodeV2Document = @"
        mutation addNodeV2($orgId: String!, $parentNodeId: String, $name: String!, $nameI18n: String, $description: String, $descriptionI18n: String, $order: Int, $code: String) {
          addNodeV2(orgId: $orgId, parentNodeId: $parentNodeId, name: $name, nameI18n: $nameI18n, description: $description, descriptionI18n: $descriptionI18n, order: $order, code: $code) {
            id
            orgId
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
    

    
    public class AddPolicyAssignmentsResponse {
        
        [JsonProperty("addPolicyAssignments")]
        public CommonMessage Result { get; set; }
    }
    
    public class AddPolicyAssignmentsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("policies")]
    public IEnumerable<string> Policies { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType TargetType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetIdentifiers")]
    public IEnumerable<string> TargetIdentifiers { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("inheritByChildren")]
    public bool? InheritByChildren { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public AddPolicyAssignmentsParam(IEnumerable<string> policies,PolicyAssignmentTargetType targetType) {
this.Policies = policies;
this.TargetType = targetType;
}
      /// <summary>
      /// AddPolicyAssignmentsParam.Request 
      /// <para>Required variables:<br/> { policies=(string[]), targetType=(PolicyAssignmentTargetType) }</para>
      /// <para>Optional variables:<br/> { targetIdentifiers=(string[]), inheritByChildren=(bool), namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AddPolicyAssignmentsDocument,
          OperationName = "addPolicyAssignments",
          Variables = this
        };
      }

      
      public static string AddPolicyAssignmentsDocument = @"
        mutation addPolicyAssignments($policies: [String!]!, $targetType: PolicyAssignmentTargetType!, $targetIdentifiers: [String!], $inheritByChildren: Boolean, $namespace: String) {
          addPolicyAssignments(policies: $policies, targetType: $targetType, targetIdentifiers: $targetIdentifiers, inheritByChildren: $inheritByChildren, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class AddUserToGroupResponse {
        
        [JsonProperty("addUserToGroup")]
        public CommonMessage Result { get; set; }
    }
    
    public class AddUserToGroupParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("userIds")]
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public AddUserToGroupParam(IEnumerable<string> userIds) {
this.UserIds = userIds;
}
      /// <summary>
      /// AddUserToGroupParam.Request 
      /// <para>Required variables:<br/> { userIds=(string[]) }</para>
      /// <para>Optional variables:<br/> { code=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class AddWhitelistResponse {
        
        [JsonProperty("addWhitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }
    
    public class AddWhitelistParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public WhitelistType Type { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("list")]
    public IEnumerable<string> List { get; set; }
      
public AddWhitelistParam(WhitelistType type,IEnumerable<string> list) {
this.Type = type;
this.List = list;
}
      /// <summary>
      /// AddWhitelistParam.Request 
      /// <para>Required variables:<br/> { type=(WhitelistType), list=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class AllowResponse {
        
        [JsonProperty("allow")]
        public CommonMessage Result { get; set; }
    }
    
    public class AllowParam {
      
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
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCode")]
    public string RoleCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCodes")]
    public IEnumerable<string> RoleCodes { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public AllowParam(string resource,string action) {
this.Resource = resource;
this.Action = action;
}
      /// <summary>
      /// AllowParam.Request 
      /// <para>Required variables:<br/> { resource=(string), action=(string) }</para>
      /// <para>Optional variables:<br/> { userId=(string), userIds=(string[]), roleCode=(string), roleCodes=(string[]), namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AllowDocument,
          OperationName = "allow",
          Variables = this
        };
      }

      
      public static string AllowDocument = @"
        mutation allow($resource: String!, $action: String!, $userId: String, $userIds: [String!], $roleCode: String, $roleCodes: [String!], $namespace: String) {
          allow(resource: $resource, action: $action, userId: $userId, userIds: $userIds, roleCode: $roleCode, roleCodes: $roleCodes, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class AssignRoleResponse {
        
        [JsonProperty("assignRole")]
        public CommonMessage Result { get; set; }
    }
    
    public class AssignRoleParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCode")]
    public string RoleCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCodes")]
    public IEnumerable<string> RoleCodes { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("userIds")]
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("groupCodes")]
    public IEnumerable<string> GroupCodes { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("nodeCodes")]
    public IEnumerable<string> NodeCodes { get; set; }
      
public AssignRoleParam() {

}
      /// <summary>
      /// AssignRoleParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { namespace=(string), roleCode=(string), roleCodes=(string[]), userIds=(string[]), groupCodes=(string[]), nodeCodes=(string[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AssignRoleDocument,
          OperationName = "assignRole",
          Variables = this
        };
      }

      
      public static string AssignRoleDocument = @"
        mutation assignRole($namespace: String, $roleCode: String, $roleCodes: [String], $userIds: [String!], $groupCodes: [String!], $nodeCodes: [String!]) {
          assignRole(namespace: $namespace, roleCode: $roleCode, roleCodes: $roleCodes, userIds: $userIds, groupCodes: $groupCodes, nodeCodes: $nodeCodes) {
            message
            code
          }
        }
        ";
    }
    

    
    public class AuthorizeResourceResponse {
        
        [JsonProperty("authorizeResource")]
        public CommonMessage Result { get; set; }
    }
    
    public class AuthorizeResourceParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
[JsonConverter(typeof(StringEnumConverter))]
    public ResourceType? ResourceType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("opts")]
    public IEnumerable<AuthorizeResourceOpt> Opts { get; set; }
      
public AuthorizeResourceParam() {

}
      /// <summary>
      /// AuthorizeResourceParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resource=(string), resourceType=(ResourceType), opts=(AuthorizeResourceOpt[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AuthorizeResourceDocument,
          OperationName = "authorizeResource",
          Variables = this
        };
      }

      
      public static string AuthorizeResourceDocument = @"
        mutation authorizeResource($namespace: String, $resource: String, $resourceType: ResourceType, $opts: [AuthorizeResourceOpt]) {
          authorizeResource(namespace: $namespace, resource: $resource, resourceType: $resourceType, opts: $opts) {
            code
            message
          }
        }
        ";
    }
    

    
    public class BindEmailResponse {
        
        [JsonProperty("bindEmail")]
        public User Result { get; set; }
    }
    
    public class BindEmailParam {
      
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
      
public BindEmailParam(string email,string emailCode) {
this.Email = email;
this.EmailCode = emailCode;
}
      /// <summary>
      /// BindEmailParam.Request 
      /// <para>Required variables:<br/> { email=(string), emailCode=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = BindEmailDocument,
          OperationName = "bindEmail",
          Variables = this
        };
      }

      
      public static string BindEmailDocument = @"
        mutation bindEmail($email: String!, $emailCode: String!) {
          bindEmail(email: $email, emailCode: $emailCode) {
            id
            arn
            userPoolId
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class BindPhoneResponse {
        
        [JsonProperty("bindPhone")]
        public User Result { get; set; }
    }
    
    public class BindPhoneParam {
      
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
      
public BindPhoneParam(string phone,string phoneCode) {
this.Phone = phone;
this.PhoneCode = phoneCode;
}
      /// <summary>
      /// BindPhoneParam.Request 
      /// <para>Required variables:<br/> { phone=(string), phoneCode=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class ChangeMfaResponse {
        
        [JsonProperty("changeMfa")]
        public Mfa Result { get; set; }
    }
    
    public class ChangeMfaParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("enable")]
    public bool? Enable { get; set; }

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
    public bool? Refresh { get; set; }
      
public ChangeMfaParam() {

}
      /// <summary>
      /// ChangeMfaParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { enable=(bool), id=(string), userId=(string), userPoolId=(string), refresh=(bool) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class ConfigEmailTemplateResponse {
        
        [JsonProperty("configEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }
    
    public class ConfigEmailTemplateParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public ConfigEmailTemplateInput Input { get; set; }
      
public ConfigEmailTemplateParam(ConfigEmailTemplateInput input) {
this.Input = input;
}
      /// <summary>
      /// ConfigEmailTemplateParam.Request 
      /// <para>Required variables:<br/> { input=(ConfigEmailTemplateInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class CreateFunctionResponse {
        
        [JsonProperty("createFunction")]
        public Function Result { get; set; }
    }
    
    public class CreateFunctionParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public CreateFunctionInput Input { get; set; }
      
public CreateFunctionParam(CreateFunctionInput input) {
this.Input = input;
}
      /// <summary>
      /// CreateFunctionParam.Request 
      /// <para>Required variables:<br/> { input=(CreateFunctionInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class CreateGroupResponse {
        
        [JsonProperty("createGroup")]
        public Group Result { get; set; }
    }
    
    public class CreateGroupParam {
      
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
      
public CreateGroupParam(string code,string name) {
this.Code = code;
this.Name = name;
}
      /// <summary>
      /// CreateGroupParam.Request 
      /// <para>Required variables:<br/> { code=(string), name=(string) }</para>
      /// <para>Optional variables:<br/> { description=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class CreateOrgResponse {
        
        [JsonProperty("createOrg")]
        public Org Result { get; set; }
    }
    
    public class CreateOrgParam {
      
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
      
public CreateOrgParam(string name) {
this.Name = name;
}
      /// <summary>
      /// CreateOrgParam.Request 
      /// <para>Required variables:<br/> { name=(string) }</para>
      /// <para>Optional variables:<br/> { code=(string), description=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              orgId
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
              orgId
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
    

    
    public class CreatePolicyResponse {
        
        [JsonProperty("createPolicy")]
        public Policy Result { get; set; }
    }
    
    public class CreatePolicyParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

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
    public IEnumerable<PolicyStatementInput> Statements { get; set; }
      
public CreatePolicyParam(string code,IEnumerable<PolicyStatementInput> statements) {
this.Code = code;
this.Statements = statements;
}
      /// <summary>
      /// CreatePolicyParam.Request 
      /// <para>Required variables:<br/> { code=(string), statements=(PolicyStatementInput[]) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), description=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = CreatePolicyDocument,
          OperationName = "createPolicy",
          Variables = this
        };
      }

      
      public static string CreatePolicyDocument = @"
        mutation createPolicy($namespace: String, $code: String!, $description: String, $statements: [PolicyStatementInput!]!) {
          createPolicy(namespace: $namespace, code: $code, description: $description, statements: $statements) {
            namespace
            code
            isDefault
            description
            statements {
              resource
              actions
              effect
              condition {
                param
                operator
                value
              }
            }
            createdAt
            updatedAt
            assignmentsCount
          }
        }
        ";
    }
    

    
    public class CreateRoleResponse {
        
        [JsonProperty("createRole")]
        public Role Result { get; set; }
    }
    
    public class CreateRoleParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

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
      
public CreateRoleParam(string code) {
this.Code = code;
}
      /// <summary>
      /// CreateRoleParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), description=(string), parent=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = CreateRoleDocument,
          OperationName = "createRole",
          Variables = this
        };
      }

      
      public static string CreateRoleDocument = @"
        mutation createRole($namespace: String, $code: String!, $description: String, $parent: String) {
          createRole(namespace: $namespace, code: $code, description: $description, parent: $parent) {
            namespace
            code
            arn
            description
            createdAt
            updatedAt
            parent {
              namespace
              code
              arn
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }
    

    
    public class CreateSocialConnectionInstanceResponse {
        
        [JsonProperty("createSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }
    
    public class CreateSocialConnectionInstanceParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public CreateSocialConnectionInstanceInput Input { get; set; }
      
public CreateSocialConnectionInstanceParam(CreateSocialConnectionInstanceInput input) {
this.Input = input;
}
      /// <summary>
      /// CreateSocialConnectionInstanceParam.Request 
      /// <para>Required variables:<br/> { input=(CreateSocialConnectionInstanceInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class CreateUserResponse {
        
        [JsonProperty("createUser")]
        public User Result { get; set; }
    }
    
    public class CreateUserParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("userInfo")]
    public CreateUserInput UserInfo { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("keepPassword")]
    public bool? KeepPassword { get; set; }
      
public CreateUserParam(CreateUserInput userInfo) {
this.UserInfo = userInfo;
}
      /// <summary>
      /// CreateUserParam.Request 
      /// <para>Required variables:<br/> { userInfo=(CreateUserInput) }</para>
      /// <para>Optional variables:<br/> { keepPassword=(bool) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class CreateUserpoolResponse {
        
        [JsonProperty("createUserpool")]
        public UserPool Result { get; set; }
    }
    
    public class CreateUserpoolParam {
      
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
    public IEnumerable<string> UserpoolTypes { get; set; }
      
public CreateUserpoolParam(string name,string domain) {
this.Name = name;
this.Domain = domain;
}
      /// <summary>
      /// CreateUserpoolParam.Request 
      /// <para>Required variables:<br/> { name=(string), domain=(string) }</para>
      /// <para>Optional variables:<br/> { description=(string), logo=(string), userpoolTypes=(string[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            appSsoEnabled
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
            customSMSProvider {
              enabled
              provider
            }
            packageType
          }
        }
        ";
    }
    

    
    public class DeleteFunctionResponse {
        
        [JsonProperty("deleteFunction")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteFunctionParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public DeleteFunctionParam(string id) {
this.Id = id;
}
      /// <summary>
      /// DeleteFunctionParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeleteGroupsResponse {
        
        [JsonProperty("deleteGroups")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteGroupsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("codeList")]
    public IEnumerable<string> CodeList { get; set; }
      
public DeleteGroupsParam(IEnumerable<string> codeList) {
this.CodeList = codeList;
}
      /// <summary>
      /// DeleteGroupsParam.Request 
      /// <para>Required variables:<br/> { codeList=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeleteNodeResponse {
        
        [JsonProperty("deleteNode")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteNodeParam {
      
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
      
public DeleteNodeParam(string orgId,string nodeId) {
this.OrgId = orgId;
this.NodeId = nodeId;
}
      /// <summary>
      /// DeleteNodeParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), nodeId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeleteOrgResponse {
        
        [JsonProperty("deleteOrg")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteOrgParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public DeleteOrgParam(string id) {
this.Id = id;
}
      /// <summary>
      /// DeleteOrgParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeletePoliciesResponse {
        
        [JsonProperty("deletePolicies")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeletePoliciesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("codeList")]
    public IEnumerable<string> CodeList { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public DeletePoliciesParam(IEnumerable<string> codeList) {
this.CodeList = codeList;
}
      /// <summary>
      /// DeletePoliciesParam.Request 
      /// <para>Required variables:<br/> { codeList=(string[]) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = DeletePoliciesDocument,
          OperationName = "deletePolicies",
          Variables = this
        };
      }

      
      public static string DeletePoliciesDocument = @"
        mutation deletePolicies($codeList: [String!]!, $namespace: String) {
          deletePolicies(codeList: $codeList, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class DeletePolicyResponse {
        
        [JsonProperty("deletePolicy")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeletePolicyParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public DeletePolicyParam(string code) {
this.Code = code;
}
      /// <summary>
      /// DeletePolicyParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = DeletePolicyDocument,
          OperationName = "deletePolicy",
          Variables = this
        };
      }

      
      public static string DeletePolicyDocument = @"
        mutation deletePolicy($code: String!, $namespace: String) {
          deletePolicy(code: $code, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class DeleteRoleResponse {
        
        [JsonProperty("deleteRole")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteRoleParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public DeleteRoleParam(string code) {
this.Code = code;
}
      /// <summary>
      /// DeleteRoleParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = DeleteRoleDocument,
          OperationName = "deleteRole",
          Variables = this
        };
      }

      
      public static string DeleteRoleDocument = @"
        mutation deleteRole($code: String!, $namespace: String) {
          deleteRole(code: $code, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class DeleteRolesResponse {
        
        [JsonProperty("deleteRoles")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteRolesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("codeList")]
    public IEnumerable<string> CodeList { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public DeleteRolesParam(IEnumerable<string> codeList) {
this.CodeList = codeList;
}
      /// <summary>
      /// DeleteRolesParam.Request 
      /// <para>Required variables:<br/> { codeList=(string[]) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = DeleteRolesDocument,
          OperationName = "deleteRoles",
          Variables = this
        };
      }

      
      public static string DeleteRolesDocument = @"
        mutation deleteRoles($codeList: [String!]!, $namespace: String) {
          deleteRoles(codeList: $codeList, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class DeleteUserResponse {
        
        [JsonProperty("deleteUser")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteUserParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public DeleteUserParam(string id) {
this.Id = id;
}
      /// <summary>
      /// DeleteUserParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeleteUserpoolResponse {
        
        [JsonProperty("deleteUserpool")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteUserpoolParam {
      
      
      /// <summary>
      /// DeleteUserpoolParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DeleteUsersResponse {
        
        [JsonProperty("deleteUsers")]
        public CommonMessage Result { get; set; }
    }
    
    public class DeleteUsersParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("ids")]
    public IEnumerable<string> Ids { get; set; }
      
public DeleteUsersParam(IEnumerable<string> ids) {
this.Ids = ids;
}
      /// <summary>
      /// DeleteUsersParam.Request 
      /// <para>Required variables:<br/> { ids=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DisableEmailTemplateResponse {
        
        [JsonProperty("disableEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }
    
    public class DisableEmailTemplateParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public EmailTemplateType Type { get; set; }
      
public DisableEmailTemplateParam(EmailTemplateType type) {
this.Type = type;
}
      /// <summary>
      /// DisableEmailTemplateParam.Request 
      /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DisableSocialConnectionInstanceResponse {
        
        [JsonProperty("disableSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }
    
    public class DisableSocialConnectionInstanceParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("provider")]
    public string Provider { get; set; }
      
public DisableSocialConnectionInstanceParam(string provider) {
this.Provider = provider;
}
      /// <summary>
      /// DisableSocialConnectionInstanceParam.Request 
      /// <para>Required variables:<br/> { provider=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class DisbalePolicyAssignmentResponse {
        
        [JsonProperty("disbalePolicyAssignment")]
        public CommonMessage Result { get; set; }
    }
    
    public class DisbalePolicyAssignmentParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("policy")]
    public string Policy { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetIdentifier")]
    public string TargetIdentifier { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public DisbalePolicyAssignmentParam(string policy,PolicyAssignmentTargetType targetType,string targetIdentifier) {
this.Policy = policy;
this.TargetType = targetType;
this.TargetIdentifier = targetIdentifier;
}
      /// <summary>
      /// DisbalePolicyAssignmentParam.Request 
      /// <para>Required variables:<br/> { policy=(string), targetType=(PolicyAssignmentTargetType), targetIdentifier=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = DisbalePolicyAssignmentDocument,
          OperationName = "disbalePolicyAssignment",
          Variables = this
        };
      }

      
      public static string DisbalePolicyAssignmentDocument = @"
        mutation disbalePolicyAssignment($policy: String!, $targetType: PolicyAssignmentTargetType!, $targetIdentifier: String!, $namespace: String) {
          disbalePolicyAssignment(policy: $policy, targetType: $targetType, targetIdentifier: $targetIdentifier, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class EnableEmailTemplateResponse {
        
        [JsonProperty("enableEmailTemplate")]
        public EmailTemplate Result { get; set; }
    }
    
    public class EnableEmailTemplateParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public EmailTemplateType Type { get; set; }
      
public EnableEmailTemplateParam(EmailTemplateType type) {
this.Type = type;
}
      /// <summary>
      /// EnableEmailTemplateParam.Request 
      /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class EnablePolicyAssignmentResponse {
        
        [JsonProperty("enablePolicyAssignment")]
        public CommonMessage Result { get; set; }
    }
    
    public class EnablePolicyAssignmentParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("policy")]
    public string Policy { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetIdentifier")]
    public string TargetIdentifier { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public EnablePolicyAssignmentParam(string policy,PolicyAssignmentTargetType targetType,string targetIdentifier) {
this.Policy = policy;
this.TargetType = targetType;
this.TargetIdentifier = targetIdentifier;
}
      /// <summary>
      /// EnablePolicyAssignmentParam.Request 
      /// <para>Required variables:<br/> { policy=(string), targetType=(PolicyAssignmentTargetType), targetIdentifier=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = EnablePolicyAssignmentDocument,
          OperationName = "enablePolicyAssignment",
          Variables = this
        };
      }

      
      public static string EnablePolicyAssignmentDocument = @"
        mutation enablePolicyAssignment($policy: String!, $targetType: PolicyAssignmentTargetType!, $targetIdentifier: String!, $namespace: String) {
          enablePolicyAssignment(policy: $policy, targetType: $targetType, targetIdentifier: $targetIdentifier, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class EnableSocialConnectionInstanceResponse {
        
        [JsonProperty("enableSocialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }
    
    public class EnableSocialConnectionInstanceParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("provider")]
    public string Provider { get; set; }
      
public EnableSocialConnectionInstanceParam(string provider) {
this.Provider = provider;
}
      /// <summary>
      /// EnableSocialConnectionInstanceParam.Request 
      /// <para>Required variables:<br/> { provider=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class LoginByEmailResponse {
        
        [JsonProperty("loginByEmail")]
        public User Result { get; set; }
    }
    
    public class LoginByEmailParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public LoginByEmailInput Input { get; set; }
      
public LoginByEmailParam(LoginByEmailInput input) {
this.Input = input;
}
      /// <summary>
      /// LoginByEmailParam.Request 
      /// <para>Required variables:<br/> { input=(LoginByEmailInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class LoginByPhoneCodeResponse {
        
        [JsonProperty("loginByPhoneCode")]
        public User Result { get; set; }
    }
    
    public class LoginByPhoneCodeParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public LoginByPhoneCodeInput Input { get; set; }
      
public LoginByPhoneCodeParam(LoginByPhoneCodeInput input) {
this.Input = input;
}
      /// <summary>
      /// LoginByPhoneCodeParam.Request 
      /// <para>Required variables:<br/> { input=(LoginByPhoneCodeInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class LoginByPhonePasswordResponse {
        
        [JsonProperty("loginByPhonePassword")]
        public User Result { get; set; }
    }
    
    public class LoginByPhonePasswordParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public LoginByPhonePasswordInput Input { get; set; }
      
public LoginByPhonePasswordParam(LoginByPhonePasswordInput input) {
this.Input = input;
}
      /// <summary>
      /// LoginByPhonePasswordParam.Request 
      /// <para>Required variables:<br/> { input=(LoginByPhonePasswordInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class LoginBySubAccountResponse {
        
        [JsonProperty("loginBySubAccount")]
        public User Result { get; set; }
    }
    
    public class LoginBySubAccountParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("account")]
    public string Account { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("password")]
    public string Password { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("captchaCode")]
    public string CaptchaCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("clientIp")]
    public string ClientIp { get; set; }
      
public LoginBySubAccountParam(string account,string password) {
this.Account = account;
this.Password = password;
}
      /// <summary>
      /// LoginBySubAccountParam.Request 
      /// <para>Required variables:<br/> { account=(string), password=(string) }</para>
      /// <para>Optional variables:<br/> { captchaCode=(string), clientIp=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = LoginBySubAccountDocument,
          OperationName = "loginBySubAccount",
          Variables = this
        };
      }

      
      public static string LoginBySubAccountDocument = @"
        mutation loginBySubAccount($account: String!, $password: String!, $captchaCode: String, $clientIp: String) {
          loginBySubAccount(account: $account, password: $password, captchaCode: $captchaCode, clientIp: $clientIp) {
            id
            arn
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class LoginByUsernameResponse {
        
        [JsonProperty("loginByUsername")]
        public User Result { get; set; }
    }
    
    public class LoginByUsernameParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public LoginByUsernameInput Input { get; set; }
      
public LoginByUsernameParam(LoginByUsernameInput input) {
this.Input = input;
}
      /// <summary>
      /// LoginByUsernameParam.Request 
      /// <para>Required variables:<br/> { input=(LoginByUsernameInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class MoveNodeResponse {
        
        [JsonProperty("moveNode")]
        public Org Result { get; set; }
    }
    
    public class MoveNodeParam {
      
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
      
public MoveNodeParam(string orgId,string nodeId,string targetParentId) {
this.OrgId = orgId;
this.NodeId = nodeId;
this.TargetParentId = targetParentId;
}
      /// <summary>
      /// MoveNodeParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), nodeId=(string), targetParentId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              orgId
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
              orgId
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
    

    
    public class RefreshAccessTokenResponse {
        
        [JsonProperty("refreshAccessToken")]
        public RefreshAccessTokenRes Result { get; set; }
    }
    
    public class RefreshAccessTokenParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("accessToken")]
    public string AccessToken { get; set; }
      
public RefreshAccessTokenParam() {

}
      /// <summary>
      /// RefreshAccessTokenParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { accessToken=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RefreshTokenResponse {
        
        [JsonProperty("refreshToken")]
        public RefreshToken Result { get; set; }
    }
    
    public class RefreshTokenParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public RefreshTokenParam() {

}
      /// <summary>
      /// RefreshTokenParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { id=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RefreshUserpoolSecretResponse {
        
        [JsonProperty("refreshUserpoolSecret")]
        public string Result { get; set; }
    }
    
    public class RefreshUserpoolSecretParam {
      
      
      /// <summary>
      /// RefreshUserpoolSecretParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RegisterByEmailResponse {
        
        [JsonProperty("registerByEmail")]
        public User Result { get; set; }
    }
    
    public class RegisterByEmailParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public RegisterByEmailInput Input { get; set; }
      
public RegisterByEmailParam(RegisterByEmailInput input) {
this.Input = input;
}
      /// <summary>
      /// RegisterByEmailParam.Request 
      /// <para>Required variables:<br/> { input=(RegisterByEmailInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class RegisterByPhoneCodeResponse {
        
        [JsonProperty("registerByPhoneCode")]
        public User Result { get; set; }
    }
    
    public class RegisterByPhoneCodeParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public RegisterByPhoneCodeInput Input { get; set; }
      
public RegisterByPhoneCodeParam(RegisterByPhoneCodeInput input) {
this.Input = input;
}
      /// <summary>
      /// RegisterByPhoneCodeParam.Request 
      /// <para>Required variables:<br/> { input=(RegisterByPhoneCodeInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class RegisterByUsernameResponse {
        
        [JsonProperty("registerByUsername")]
        public User Result { get; set; }
    }
    
    public class RegisterByUsernameParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public RegisterByUsernameInput Input { get; set; }
      
public RegisterByUsernameParam(RegisterByUsernameInput input) {
this.Input = input;
}
      /// <summary>
      /// RegisterByUsernameParam.Request 
      /// <para>Required variables:<br/> { input=(RegisterByUsernameInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class RemoveMemberResponse {
        
        [JsonProperty("removeMember")]
        public Node Result { get; set; }
    }
    
    public class RemoveMemberParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("includeChildrenNodes")]
    public bool? IncludeChildrenNodes { get; set; }

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
    public IEnumerable<string> UserIds { get; set; }
      
public RemoveMemberParam(IEnumerable<string> userIds) {
this.UserIds = userIds;
}
      /// <summary>
      /// RemoveMemberParam.Request 
      /// <para>Required variables:<br/> { userIds=(string[]) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), nodeId=(string), orgId=(string), nodeCode=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
                status
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
                city
                province
                country
                createdAt
                updatedAt
              }
            }
          }
        }
        ";
    }
    

    
    public class RemovePolicyAssignmentsResponse {
        
        [JsonProperty("removePolicyAssignments")]
        public CommonMessage Result { get; set; }
    }
    
    public class RemovePolicyAssignmentsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("policies")]
    public IEnumerable<string> Policies { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType TargetType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetIdentifiers")]
    public IEnumerable<string> TargetIdentifiers { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public RemovePolicyAssignmentsParam(IEnumerable<string> policies,PolicyAssignmentTargetType targetType) {
this.Policies = policies;
this.TargetType = targetType;
}
      /// <summary>
      /// RemovePolicyAssignmentsParam.Request 
      /// <para>Required variables:<br/> { policies=(string[]), targetType=(PolicyAssignmentTargetType) }</para>
      /// <para>Optional variables:<br/> { targetIdentifiers=(string[]), namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RemovePolicyAssignmentsDocument,
          OperationName = "removePolicyAssignments",
          Variables = this
        };
      }

      
      public static string RemovePolicyAssignmentsDocument = @"
        mutation removePolicyAssignments($policies: [String!]!, $targetType: PolicyAssignmentTargetType!, $targetIdentifiers: [String!], $namespace: String) {
          removePolicyAssignments(policies: $policies, targetType: $targetType, targetIdentifiers: $targetIdentifiers, namespace: $namespace) {
            message
            code
          }
        }
        ";
    }
    

    
    public class RemoveUdfResponse {
        
        [JsonProperty("removeUdf")]
        public CommonMessage Result { get; set; }
    }
    
    public class RemoveUdfParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("key")]
    public string Key { get; set; }
      
public RemoveUdfParam(UdfTargetType targetType,string key) {
this.TargetType = targetType;
this.Key = key;
}
      /// <summary>
      /// RemoveUdfParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), key=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RemoveUdfDocument,
          OperationName = "removeUdf",
          Variables = this
        };
      }

      
      public static string RemoveUdfDocument = @"
        mutation removeUdf($targetType: UDFTargetType!, $key: String!) {
          removeUdf(targetType: $targetType, key: $key) {
            message
            code
          }
        }
        ";
    }
    

    
    public class RemoveUdvResponse {
        
        [JsonProperty("removeUdv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }
    
    public class RemoveUdvParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
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
      
public RemoveUdvParam(UdfTargetType targetType,string targetId,string key) {
this.TargetType = targetType;
this.TargetId = targetId;
this.Key = key;
}
      /// <summary>
      /// RemoveUdvParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string), key=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            label
          }
        }
        ";
    }
    

    
    public class RemoveUserFromGroupResponse {
        
        [JsonProperty("removeUserFromGroup")]
        public CommonMessage Result { get; set; }
    }
    
    public class RemoveUserFromGroupParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("userIds")]
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public RemoveUserFromGroupParam(IEnumerable<string> userIds) {
this.UserIds = userIds;
}
      /// <summary>
      /// RemoveUserFromGroupParam.Request 
      /// <para>Required variables:<br/> { userIds=(string[]) }</para>
      /// <para>Optional variables:<br/> { code=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RemoveWhitelistResponse {
        
        [JsonProperty("removeWhitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }
    
    public class RemoveWhitelistParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public WhitelistType Type { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("list")]
    public IEnumerable<string> List { get; set; }
      
public RemoveWhitelistParam(WhitelistType type,IEnumerable<string> list) {
this.Type = type;
this.List = list;
}
      /// <summary>
      /// RemoveWhitelistParam.Request 
      /// <para>Required variables:<br/> { type=(WhitelistType), list=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class ResetPasswordResponse {
        
        [JsonProperty("resetPassword")]
        public CommonMessage Result { get; set; }
    }
    
    public class ResetPasswordParam {
      
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
      
public ResetPasswordParam(string code,string newPassword) {
this.Code = code;
this.NewPassword = newPassword;
}
      /// <summary>
      /// ResetPasswordParam.Request 
      /// <para>Required variables:<br/> { code=(string), newPassword=(string) }</para>
      /// <para>Optional variables:<br/> { phone=(string), email=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RevokeRoleResponse {
        
        [JsonProperty("revokeRole")]
        public CommonMessage Result { get; set; }
    }
    
    public class RevokeRoleParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCode")]
    public string RoleCode { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleCodes")]
    public IEnumerable<string> RoleCodes { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("userIds")]
    public IEnumerable<string> UserIds { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("groupCodes")]
    public IEnumerable<string> GroupCodes { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("nodeCodes")]
    public IEnumerable<string> NodeCodes { get; set; }
      
public RevokeRoleParam() {

}
      /// <summary>
      /// RevokeRoleParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { namespace=(string), roleCode=(string), roleCodes=(string[]), userIds=(string[]), groupCodes=(string[]), nodeCodes=(string[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RevokeRoleDocument,
          OperationName = "revokeRole",
          Variables = this
        };
      }

      
      public static string RevokeRoleDocument = @"
        mutation revokeRole($namespace: String, $roleCode: String, $roleCodes: [String], $userIds: [String!], $groupCodes: [String!], $nodeCodes: [String!]) {
          revokeRole(namespace: $namespace, roleCode: $roleCode, roleCodes: $roleCodes, userIds: $userIds, groupCodes: $groupCodes, nodeCodes: $nodeCodes) {
            message
            code
          }
        }
        ";
    }
    

    
    public class SendEmailResponse {
        
        [JsonProperty("sendEmail")]
        public CommonMessage Result { get; set; }
    }
    
    public class SendEmailParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("email")]
    public string Email { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("scene")]
[JsonConverter(typeof(StringEnumConverter))]
    public EmailScene Scene { get; set; }
      
public SendEmailParam(string email,EmailScene scene) {
this.Email = email;
this.Scene = scene;
}
      /// <summary>
      /// SendEmailParam.Request 
      /// <para>Required variables:<br/> { email=(string), scene=(EmailScene) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class SetMainDepartmentResponse {
        
        [JsonProperty("setMainDepartment")]
        public CommonMessage Result { get; set; }
    }
    
    public class SetMainDepartmentParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("userId")]
    public string UserId { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("departmentId")]
    public string DepartmentId { get; set; }
      
public SetMainDepartmentParam(string userId) {
this.UserId = userId;
}
      /// <summary>
      /// SetMainDepartmentParam.Request 
      /// <para>Required variables:<br/> { userId=(string) }</para>
      /// <para>Optional variables:<br/> { departmentId=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SetMainDepartmentDocument,
          OperationName = "setMainDepartment",
          Variables = this
        };
      }

      
      public static string SetMainDepartmentDocument = @"
        mutation setMainDepartment($userId: String!, $departmentId: String) {
          setMainDepartment(userId: $userId, departmentId: $departmentId) {
            message
            code
          }
        }
        ";
    }
    

    
    public class SetUdfResponse {
        
        [JsonProperty("setUdf")]
        public UserDefinedField Result { get; set; }
    }
    
    public class SetUdfParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
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
[JsonConverter(typeof(StringEnumConverter))]
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
      
public SetUdfParam(UdfTargetType targetType,string key,UdfDataType dataType,string label) {
this.TargetType = targetType;
this.Key = key;
this.DataType = dataType;
this.Label = label;
}
      /// <summary>
      /// SetUdfParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), key=(string), dataType=(UDFDataType), label=(string) }</para>
      /// <para>Optional variables:<br/> { options=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SetUdfDocument,
          OperationName = "setUdf",
          Variables = this
        };
      }

      
      public static string SetUdfDocument = @"
        mutation setUdf($targetType: UDFTargetType!, $key: String!, $dataType: UDFDataType!, $label: String!, $options: String) {
          setUdf(targetType: $targetType, key: $key, dataType: $dataType, label: $label, options: $options) {
            targetType
            dataType
            key
            label
            options
          }
        }
        ";
    }
    

    
    public class SetUdfValueBatchResponse {
        
        [JsonProperty("setUdfValueBatch")]
        public CommonMessage Result { get; set; }
    }
    
    public class SetUdfValueBatchParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public IEnumerable<SetUdfValueBatchInput> Input { get; set; }
      
public SetUdfValueBatchParam(UdfTargetType targetType,IEnumerable<SetUdfValueBatchInput> input) {
this.TargetType = targetType;
this.Input = input;
}
      /// <summary>
      /// SetUdfValueBatchParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), input=(SetUdfValueBatchInput[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SetUdfValueBatchDocument,
          OperationName = "setUdfValueBatch",
          Variables = this
        };
      }

      
      public static string SetUdfValueBatchDocument = @"
        mutation setUdfValueBatch($targetType: UDFTargetType!, $input: [SetUdfValueBatchInput!]!) {
          setUdfValueBatch(targetType: $targetType, input: $input) {
            code
            message
          }
        }
        ";
    }
    

    
    public class SetUdvResponse {
        
        [JsonProperty("setUdv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }
    
    public class SetUdvParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
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
      
public SetUdvParam(UdfTargetType targetType,string targetId,string key,string value) {
this.TargetType = targetType;
this.TargetId = targetId;
this.Key = key;
this.Value = value;
}
      /// <summary>
      /// SetUdvParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string), key=(string), value=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            label
          }
        }
        ";
    }
    

    
    public class SetUdvBatchResponse {
        
        [JsonProperty("setUdvBatch")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }
    
    public class SetUdvBatchParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetId")]
    public string TargetId { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("udvList")]
    public IEnumerable<UserDefinedDataInput> UdvList { get; set; }
      
public SetUdvBatchParam(UdfTargetType targetType,string targetId) {
this.TargetType = targetType;
this.TargetId = targetId;
}
      /// <summary>
      /// SetUdvBatchParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string) }</para>
      /// <para>Optional variables:<br/> { udvList=(UserDefinedDataInput[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SetUdvBatchDocument,
          OperationName = "setUdvBatch",
          Variables = this
        };
      }

      
      public static string SetUdvBatchDocument = @"
        mutation setUdvBatch($targetType: UDFTargetType!, $targetId: String!, $udvList: [UserDefinedDataInput!]) {
          setUdvBatch(targetType: $targetType, targetId: $targetId, udvList: $udvList) {
            key
            dataType
            value
            label
          }
        }
        ";
    }
    

    
    public class UnbindEmailResponse {
        
        [JsonProperty("unbindEmail")]
        public User Result { get; set; }
    }
    
    public class UnbindEmailParam {
      
      
      /// <summary>
      /// UnbindEmailParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UnbindPhoneResponse {
        
        [JsonProperty("unbindPhone")]
        public User Result { get; set; }
    }
    
    public class UnbindPhoneParam {
      
      
      /// <summary>
      /// UnbindPhoneParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UpdateEmailResponse {
        
        [JsonProperty("updateEmail")]
        public User Result { get; set; }
    }
    
    public class UpdateEmailParam {
      
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
      
public UpdateEmailParam(string email,string emailCode) {
this.Email = email;
this.EmailCode = emailCode;
}
      /// <summary>
      /// UpdateEmailParam.Request 
      /// <para>Required variables:<br/> { email=(string), emailCode=(string) }</para>
      /// <para>Optional variables:<br/> { oldEmail=(string), oldEmailCode=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UpdateFunctionResponse {
        
        [JsonProperty("updateFunction")]
        public Function Result { get; set; }
    }
    
    public class UpdateFunctionParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public UpdateFunctionInput Input { get; set; }
      
public UpdateFunctionParam(UpdateFunctionInput input) {
this.Input = input;
}
      /// <summary>
      /// UpdateFunctionParam.Request 
      /// <para>Required variables:<br/> { input=(UpdateFunctionInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class UpdateGroupResponse {
        
        [JsonProperty("updateGroup")]
        public Group Result { get; set; }
    }
    
    public class UpdateGroupParam {
      
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
      
public UpdateGroupParam(string code) {
this.Code = code;
}
      /// <summary>
      /// UpdateGroupParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { name=(string), description=(string), newCode=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class UpdateNodeResponse {
        
        [JsonProperty("updateNode")]
        public Node Result { get; set; }
    }
    
    public class UpdateNodeParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("includeChildrenNodes")]
    public bool? IncludeChildrenNodes { get; set; }

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
      
public UpdateNodeParam(string id) {
this.Id = id;
}
      /// <summary>
      /// UpdateNodeParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool), name=(string), code=(string), description=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = UpdateNodeDocument,
          OperationName = "updateNode",
          Variables = this
        };
      }

      
      public static string UpdateNodeDocument = @"
        mutation updateNode($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $id: String!, $name: String, $code: String, $description: String) {
          updateNode(id: $id, name: $name, code: $code, description: $description) {
            id
            orgId
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
    

    
    public class UpdatePasswordResponse {
        
        [JsonProperty("updatePassword")]
        public User Result { get; set; }
    }
    
    public class UpdatePasswordParam {
      
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
      
public UpdatePasswordParam(string newPassword) {
this.NewPassword = newPassword;
}
      /// <summary>
      /// UpdatePasswordParam.Request 
      /// <para>Required variables:<br/> { newPassword=(string) }</para>
      /// <para>Optional variables:<br/> { oldPassword=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UpdatePhoneResponse {
        
        [JsonProperty("updatePhone")]
        public User Result { get; set; }
    }
    
    public class UpdatePhoneParam {
      
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
      
public UpdatePhoneParam(string phone,string phoneCode) {
this.Phone = phone;
this.PhoneCode = phoneCode;
}
      /// <summary>
      /// UpdatePhoneParam.Request 
      /// <para>Required variables:<br/> { phone=(string), phoneCode=(string) }</para>
      /// <para>Optional variables:<br/> { oldPhone=(string), oldPhoneCode=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UpdatePolicyResponse {
        
        [JsonProperty("updatePolicy")]
        public Policy Result { get; set; }
    }
    
    public class UpdatePolicyParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

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
    [JsonProperty("statements")]
    public IEnumerable<PolicyStatementInput> Statements { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("newCode")]
    public string NewCode { get; set; }
      
public UpdatePolicyParam(string code) {
this.Code = code;
}
      /// <summary>
      /// UpdatePolicyParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), description=(string), statements=(PolicyStatementInput[]), newCode=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = UpdatePolicyDocument,
          OperationName = "updatePolicy",
          Variables = this
        };
      }

      
      public static string UpdatePolicyDocument = @"
        mutation updatePolicy($namespace: String, $code: String!, $description: String, $statements: [PolicyStatementInput!], $newCode: String) {
          updatePolicy(namespace: $namespace, code: $code, description: $description, statements: $statements, newCode: $newCode) {
            namespace
            code
            description
            statements {
              resource
              actions
              effect
              condition {
                param
                operator
                value
              }
            }
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class UpdateRoleResponse {
        
        [JsonProperty("updateRole")]
        public Role Result { get; set; }
    }
    
    public class UpdateRoleParam {
      
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
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public UpdateRoleParam(string code) {
this.Code = code;
}
      /// <summary>
      /// UpdateRoleParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { description=(string), newCode=(string), namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = UpdateRoleDocument,
          OperationName = "updateRole",
          Variables = this
        };
      }

      
      public static string UpdateRoleDocument = @"
        mutation updateRole($code: String!, $description: String, $newCode: String, $namespace: String) {
          updateRole(code: $code, description: $description, newCode: $newCode, namespace: $namespace) {
            namespace
            code
            arn
            description
            createdAt
            updatedAt
            parent {
              namespace
              code
              arn
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }
    

    
    public class UpdateUserResponse {
        
        [JsonProperty("updateUser")]
        public User Result { get; set; }
    }
    
    public class UpdateUserParam {
      
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
      
public UpdateUserParam(UpdateUserInput input) {
this.Input = input;
}
      /// <summary>
      /// UpdateUserParam.Request 
      /// <para>Required variables:<br/> { input=(UpdateUserInput) }</para>
      /// <para>Optional variables:<br/> { id=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class UpdateUserpoolResponse {
        
        [JsonProperty("updateUserpool")]
        public UserPool Result { get; set; }
    }
    
    public class UpdateUserpoolParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("input")]
    public UpdateUserpoolInput Input { get; set; }
      
public UpdateUserpoolParam(UpdateUserpoolInput input) {
this.Input = input;
}
      /// <summary>
      /// UpdateUserpoolParam.Request 
      /// <para>Required variables:<br/> { input=(UpdateUserpoolInput) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            appSsoEnabled
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
            customSMSProvider {
              enabled
              provider
              config
            }
            packageType
            useCustomUserStore
            loginRequireEmailVerified
            verifyCodeLength
          }
        }
        ";
    }
    

    
    public class AccessTokenResponse {
        
        [JsonProperty("accessToken")]
        public AccessTokenRes Result { get; set; }
    }
    
    public class AccessTokenParam {
      
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
      
public AccessTokenParam(string userPoolId,string secret) {
this.UserPoolId = userPoolId;
this.Secret = secret;
}
      /// <summary>
      /// AccessTokenParam.Request 
      /// <para>Required variables:<br/> { userPoolId=(string), secret=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class ArchivedUsersResponse {
        
        [JsonProperty("archivedUsers")]
        public PaginatedUsers Result { get; set; }
    }
    
    public class ArchivedUsersParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }
      
public ArchivedUsersParam() {

}
      /// <summary>
      /// ArchivedUsersParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ArchivedUsersDocument,
          OperationName = "archivedUsers",
          Variables = this
        };
      }

      
      public static string ArchivedUsersDocument = @"
        query archivedUsers($page: Int, $limit: Int) {
          archivedUsers(page: $page, limit: $limit) {
            totalCount
            list {
              id
              arn
              status
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
              city
              province
              country
              createdAt
              updatedAt
              externalId
            }
          }
        }
        ";
    }
    

    
    public class AuthorizedTargetsResponse {
        
        [JsonProperty("authorizedTargets")]
        public PaginatedAuthorizedTargets Result { get; set; }
    }
    
    public class AuthorizedTargetsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("resourceType")]
[JsonConverter(typeof(StringEnumConverter))]
    public ResourceType ResourceType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("resource")]
    public string Resource { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType? TargetType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("actions")]
    public AuthorizedTargetsActionsInput Actions { get; set; }
      
public AuthorizedTargetsParam(string namespace,ResourceType resourceType,string resource) {
this.Namespace = namespace;
this.ResourceType = resourceType;
this.Resource = resource;
}
      /// <summary>
      /// AuthorizedTargetsParam.Request 
      /// <para>Required variables:<br/> { namespace=(string), resourceType=(ResourceType), resource=(string) }</para>
      /// <para>Optional variables:<br/> { targetType=(PolicyAssignmentTargetType), actions=(AuthorizedTargetsActionsInput) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AuthorizedTargetsDocument,
          OperationName = "authorizedTargets",
          Variables = this
        };
      }

      
      public static string AuthorizedTargetsDocument = @"
        query authorizedTargets($namespace: String!, $resourceType: ResourceType!, $resource: String!, $targetType: PolicyAssignmentTargetType, $actions: AuthorizedTargetsActionsInput) {
          authorizedTargets(namespace: $namespace, resource: $resource, resourceType: $resourceType, targetType: $targetType, actions: $actions) {
            totalCount
            list {
              targetType
              targetIdentifier
              actions
            }
          }
        }
        ";
    }
    

    
    public class CheckLoginStatusResponse {
        
        [JsonProperty("checkLoginStatus")]
        public JWTTokenStatus Result { get; set; }
    }
    
    public class CheckLoginStatusParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("token")]
    public string Token { get; set; }
      
public CheckLoginStatusParam() {

}
      /// <summary>
      /// CheckLoginStatusParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { token=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class CheckPasswordStrengthResponse {
        
        [JsonProperty("checkPasswordStrength")]
        public CheckPasswordStrengthResult Result { get; set; }
    }
    
    public class CheckPasswordStrengthParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("password")]
    public string Password { get; set; }
      
public CheckPasswordStrengthParam(string password) {
this.Password = password;
}
      /// <summary>
      /// CheckPasswordStrengthParam.Request 
      /// <para>Required variables:<br/> { password=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class ChildrenNodesResponse {
        
        [JsonProperty("childrenNodes")]
        public IEnumerable<Node> Result { get; set; }
    }
    
    public class ChildrenNodesParam {
      
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
      
public ChildrenNodesParam(string orgId,string nodeId) {
this.OrgId = orgId;
this.NodeId = nodeId;
}
      /// <summary>
      /// ChildrenNodesParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), nodeId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ChildrenNodesDocument,
          OperationName = "childrenNodes",
          Variables = this
        };
      }

      
      public static string ChildrenNodesDocument = @"
        query childrenNodes($orgId: String!, $nodeId: String!) {
          childrenNodes(orgId: $orgId, nodeId: $nodeId) {
            id
            orgId
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
    

    
    public class EmailTemplatesResponse {
        
        [JsonProperty("emailTemplates")]
        public IEnumerable<EmailTemplate> Result { get; set; }
    }
    
    public class EmailTemplatesParam {
      
      
      /// <summary>
      /// EmailTemplatesParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class FindUserResponse {
        
        [JsonProperty("findUser")]
        public User Result { get; set; }
    }
    
    public class FindUserParam {
      
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
    /// Optional
    /// </summary>
    [JsonProperty("externalId")]
    public string ExternalId { get; set; }
      
public FindUserParam() {

}
      /// <summary>
      /// FindUserParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { email=(string), phone=(string), username=(string), externalId=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = FindUserDocument,
          OperationName = "findUser",
          Variables = this
        };
      }

      
      public static string FindUserDocument = @"
        query findUser($email: String, $phone: String, $username: String, $externalId: String) {
          findUser(email: $email, phone: $phone, username: $username, externalId: $externalId) {
            id
            arn
            userPoolId
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class FunctionResponse {
        
        [JsonProperty("function")]
        public Function Result { get; set; }
    }
    
    public class FunctionParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public FunctionParam() {

}
      /// <summary>
      /// FunctionParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { id=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class FunctionsResponse {
        
        [JsonProperty("functions")]
        public PaginatedFunctions Result { get; set; }
    }
    
    public class FunctionsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public FunctionsParam() {

}
      /// <summary>
      /// FunctionsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class GetUserDepartmentsResponse {
        
        [JsonProperty("user")]
        public User Result { get; set; }
    }
    
    public class GetUserDepartmentsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("orgId")]
    public string OrgId { get; set; }
      
public GetUserDepartmentsParam(string id) {
this.Id = id;
}
      /// <summary>
      /// GetUserDepartmentsParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { orgId=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = GetUserDepartmentsDocument,
          OperationName = "getUserDepartments",
          Variables = this
        };
      }

      
      public static string GetUserDepartmentsDocument = @"
        query getUserDepartments($id: String!, $orgId: String) {
          user(id: $id) {
            departments(orgId: $orgId) {
              totalCount
              list {
                department {
                  id
                  orgId
                  name
                  nameI18n
                  description
                  descriptionI18n
                  order
                  code
                  root
                  depth
                  path
                  codePath
                  namePath
                  createdAt
                  updatedAt
                  children
                }
                isMainDepartment
                joinedAt
              }
            }
          }
        }
        ";
    }
    

    
    public class GetUserGroupsResponse {
        
        [JsonProperty("user")]
        public User Result { get; set; }
    }
    
    public class GetUserGroupsParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public GetUserGroupsParam(string id) {
this.Id = id;
}
      /// <summary>
      /// GetUserGroupsParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = GetUserGroupsDocument,
          OperationName = "getUserGroups",
          Variables = this
        };
      }

      
      public static string GetUserGroupsDocument = @"
        query getUserGroups($id: String!) {
          user(id: $id) {
            groups {
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
        }
        ";
    }
    

    
    public class GetUserRolesResponse {
        
        [JsonProperty("user")]
        public User Result { get; set; }
    }
    
    public class GetUserRolesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public GetUserRolesParam(string id) {
this.Id = id;
}
      /// <summary>
      /// GetUserRolesParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = GetUserRolesDocument,
          OperationName = "getUserRoles",
          Variables = this
        };
      }

      
      public static string GetUserRolesDocument = @"
        query getUserRoles($id: String!, $namespace: String) {
          user(id: $id) {
            roles(namespace: $namespace) {
              totalCount
              list {
                code
                namespace
                arn
                description
                createdAt
                updatedAt
                parent {
                  code
                  namespace
                  arn
                  description
                  createdAt
                  updatedAt
                }
              }
            }
          }
        }
        ";
    }
    

    
    public class GroupResponse {
        
        [JsonProperty("group")]
        public Group Result { get; set; }
    }
    
    public class GroupParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public GroupParam(string code) {
this.Code = code;
}
      /// <summary>
      /// GroupParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
          }
        }
        ";
    }
    

    
    public class GroupWithUsersResponse {
        
        [JsonProperty("group")]
        public Group Result { get; set; }
    }
    
    public class GroupWithUsersParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }
      
public GroupWithUsersParam(string code) {
this.Code = code;
}
      /// <summary>
      /// GroupWithUsersParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
                city
                province
                country
                createdAt
                updatedAt
                externalId
              }
            }
          }
        }
        ";
    }
    

    
    public class GroupsResponse {
        
        [JsonProperty("groups")]
        public PaginatedGroups Result { get; set; }
    }
    
    public class GroupsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("userId")]
    public string UserId { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public GroupsParam() {

}
      /// <summary>
      /// GroupsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { userId=(string), page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class IsActionAllowedResponse {
        
        [JsonProperty("isActionAllowed")]
        public bool Result { get; set; }
    }
    
    public class IsActionAllowedParam {
      
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
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public IsActionAllowedParam(string resource,string action,string userId) {
this.Resource = resource;
this.Action = action;
this.UserId = userId;
}
      /// <summary>
      /// IsActionAllowedParam.Request 
      /// <para>Required variables:<br/> { resource=(string), action=(string), userId=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = IsActionAllowedDocument,
          OperationName = "isActionAllowed",
          Variables = this
        };
      }

      
      public static string IsActionAllowedDocument = @"
        query isActionAllowed($resource: String!, $action: String!, $userId: String!, $namespace: String) {
          isActionAllowed(resource: $resource, action: $action, userId: $userId, namespace: $namespace)
        }
        ";
    }
    

    
    public class IsActionDeniedResponse {
        
        [JsonProperty("isActionDenied")]
        public bool Result { get; set; }
    }
    
    public class IsActionDeniedParam {
      
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
      
public IsActionDeniedParam(string resource,string action,string userId) {
this.Resource = resource;
this.Action = action;
this.UserId = userId;
}
      /// <summary>
      /// IsActionDeniedParam.Request 
      /// <para>Required variables:<br/> { resource=(string), action=(string), userId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class IsDomainAvaliableResponse {
        
        [JsonProperty("isDomainAvaliable")]
        public bool? Result { get; set; }
    }
    
    public class IsDomainAvaliableParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("domain")]
    public string Domain { get; set; }
      
public IsDomainAvaliableParam(string domain) {
this.Domain = domain;
}
      /// <summary>
      /// IsDomainAvaliableParam.Request 
      /// <para>Required variables:<br/> { domain=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class IsRootNodeResponse {
        
        [JsonProperty("isRootNode")]
        public bool? Result { get; set; }
    }
    
    public class IsRootNodeParam {
      
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
      
public IsRootNodeParam(string nodeId,string orgId) {
this.NodeId = nodeId;
this.OrgId = orgId;
}
      /// <summary>
      /// IsRootNodeParam.Request 
      /// <para>Required variables:<br/> { nodeId=(string), orgId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class IsUserExistsResponse {
        
        [JsonProperty("isUserExists")]
        public bool? Result { get; set; }
    }
    
    public class IsUserExistsParam {
      
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
    /// Optional
    /// </summary>
    [JsonProperty("externalId")]
    public string ExternalId { get; set; }
      
public IsUserExistsParam() {

}
      /// <summary>
      /// IsUserExistsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { email=(string), phone=(string), username=(string), externalId=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = IsUserExistsDocument,
          OperationName = "isUserExists",
          Variables = this
        };
      }

      
      public static string IsUserExistsDocument = @"
        query isUserExists($email: String, $phone: String, $username: String, $externalId: String) {
          isUserExists(email: $email, phone: $phone, username: $username, externalId: $externalId)
        }
        ";
    }
    

    
    public class AuthorizedResourcesResponse {
        
        [JsonProperty("authorizedResources")]
        public PaginatedAuthorizedResources Result { get; set; }
    }
    
    public class AuthorizedResourcesParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType? TargetType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetIdentifier")]
    public string TargetIdentifier { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public AuthorizedResourcesParam() {

}
      /// <summary>
      /// AuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { targetType=(PolicyAssignmentTargetType), targetIdentifier=(string), namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = AuthorizedResourcesDocument,
          OperationName = "authorizedResources",
          Variables = this
        };
      }

      
      public static string AuthorizedResourcesDocument = @"
        query authorizedResources($targetType: PolicyAssignmentTargetType, $targetIdentifier: String, $namespace: String, $resourceType: String) {
          authorizedResources(targetType: $targetType, targetIdentifier: $targetIdentifier, namespace: $namespace, resourceType: $resourceType) {
            totalCount
            list {
              code
              type
              actions
            }
          }
        }
        ";
    }
    

    
    public class ListGroupAuthorizedResourcesResponse {
        
        [JsonProperty("group")]
        public Group Result { get; set; }
    }
    
    public class ListGroupAuthorizedResourcesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public ListGroupAuthorizedResourcesParam(string code) {
this.Code = code;
}
      /// <summary>
      /// ListGroupAuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ListGroupAuthorizedResourcesDocument,
          OperationName = "listGroupAuthorizedResources",
          Variables = this
        };
      }

      
      public static string ListGroupAuthorizedResourcesDocument = @"
        query listGroupAuthorizedResources($code: String!, $namespace: String, $resourceType: String) {
          group(code: $code) {
            authorizedResources(namespace: $namespace, resourceType: $resourceType) {
              totalCount
              list {
                code
                type
                actions
              }
            }
          }
        }
        ";
    }
    

    
    public class ListNodeByCodeAuthorizedResourcesResponse {
        
        [JsonProperty("nodeByCode")]
        public Node Result { get; set; }
    }
    
    public class ListNodeByCodeAuthorizedResourcesParam {
      
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
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public ListNodeByCodeAuthorizedResourcesParam(string orgId,string code) {
this.OrgId = orgId;
this.Code = code;
}
      /// <summary>
      /// ListNodeByCodeAuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ListNodeByCodeAuthorizedResourcesDocument,
          OperationName = "listNodeByCodeAuthorizedResources",
          Variables = this
        };
      }

      
      public static string ListNodeByCodeAuthorizedResourcesDocument = @"
        query listNodeByCodeAuthorizedResources($orgId: String!, $code: String!, $namespace: String, $resourceType: String) {
          nodeByCode(orgId: $orgId, code: $code) {
            authorizedResources(namespace: $namespace, resourceType: $resourceType) {
              totalCount
              list {
                code
                type
                actions
              }
            }
          }
        }
        ";
    }
    

    
    public class ListNodeByIdAuthorizedResourcesResponse {
        
        [JsonProperty("nodeById")]
        public Node Result { get; set; }
    }
    
    public class ListNodeByIdAuthorizedResourcesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public ListNodeByIdAuthorizedResourcesParam(string id) {
this.Id = id;
}
      /// <summary>
      /// ListNodeByIdAuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ListNodeByIdAuthorizedResourcesDocument,
          OperationName = "listNodeByIdAuthorizedResources",
          Variables = this
        };
      }

      
      public static string ListNodeByIdAuthorizedResourcesDocument = @"
        query listNodeByIdAuthorizedResources($id: String!, $namespace: String, $resourceType: String) {
          nodeById(id: $id) {
            authorizedResources(namespace: $namespace, resourceType: $resourceType) {
              totalCount
              list {
                code
                type
                actions
              }
            }
          }
        }
        ";
    }
    

    
    public class ListRoleAuthorizedResourcesResponse {
        
        [JsonProperty("role")]
        public Role Result { get; set; }
    }
    
    public class ListRoleAuthorizedResourcesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public ListRoleAuthorizedResourcesParam(string code) {
this.Code = code;
}
      /// <summary>
      /// ListRoleAuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ListRoleAuthorizedResourcesDocument,
          OperationName = "listRoleAuthorizedResources",
          Variables = this
        };
      }

      
      public static string ListRoleAuthorizedResourcesDocument = @"
        query listRoleAuthorizedResources($code: String!, $namespace: String, $resourceType: String) {
          role(code: $code, namespace: $namespace) {
            authorizedResources(resourceType: $resourceType) {
              totalCount
              list {
                code
                type
                actions
              }
            }
          }
        }
        ";
    }
    

    
    public class ListUserAuthorizedResourcesResponse {
        
        [JsonProperty("user")]
        public User Result { get; set; }
    }
    
    public class ListUserAuthorizedResourcesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("resourceType")]
    public string ResourceType { get; set; }
      
public ListUserAuthorizedResourcesParam(string id) {
this.Id = id;
}
      /// <summary>
      /// ListUserAuthorizedResourcesParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string), resourceType=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = ListUserAuthorizedResourcesDocument,
          OperationName = "listUserAuthorizedResources",
          Variables = this
        };
      }

      
      public static string ListUserAuthorizedResourcesDocument = @"
        query listUserAuthorizedResources($id: String!, $namespace: String, $resourceType: String) {
          user(id: $id) {
            authorizedResources(namespace: $namespace, resourceType: $resourceType) {
              totalCount
              list {
                code
                type
                actions
              }
            }
          }
        }
        ";
    }
    

    
    public class NodeByCodeResponse {
        
        [JsonProperty("nodeByCode")]
        public Node Result { get; set; }
    }
    
    public class NodeByCodeParam {
      
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
      
public NodeByCodeParam(string orgId,string code) {
this.OrgId = orgId;
this.Code = code;
}
      /// <summary>
      /// NodeByCodeParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), code=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = NodeByCodeDocument,
          OperationName = "nodeByCode",
          Variables = this
        };
      }

      
      public static string NodeByCodeDocument = @"
        query nodeByCode($orgId: String!, $code: String!) {
          nodeByCode(orgId: $orgId, code: $code) {
            id
            orgId
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
    

    
    public class NodeByCodeWithMembersResponse {
        
        [JsonProperty("nodeByCode")]
        public Node Result { get; set; }
    }
    
    public class NodeByCodeWithMembersParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("includeChildrenNodes")]
    public bool? IncludeChildrenNodes { get; set; }

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
      
public NodeByCodeWithMembersParam(string orgId,string code) {
this.OrgId = orgId;
this.Code = code;
}
      /// <summary>
      /// NodeByCodeWithMembersParam.Request 
      /// <para>Required variables:<br/> { orgId=(string), code=(string) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = NodeByCodeWithMembersDocument,
          OperationName = "nodeByCodeWithMembers",
          Variables = this
        };
      }

      
      public static string NodeByCodeWithMembersDocument = @"
        query nodeByCodeWithMembers($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $orgId: String!, $code: String!) {
          nodeByCode(orgId: $orgId, code: $code) {
            id
            orgId
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
                status
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
                city
                province
                country
                createdAt
                updatedAt
                externalId
              }
            }
          }
        }
        ";
    }
    

    
    public class NodeByIdResponse {
        
        [JsonProperty("nodeById")]
        public Node Result { get; set; }
    }
    
    public class NodeByIdParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public NodeByIdParam(string id) {
this.Id = id;
}
      /// <summary>
      /// NodeByIdParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = NodeByIdDocument,
          OperationName = "nodeById",
          Variables = this
        };
      }

      
      public static string NodeByIdDocument = @"
        query nodeById($id: String!) {
          nodeById(id: $id) {
            id
            orgId
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
    

    
    public class NodeByIdWithMembersResponse {
        
        [JsonProperty("nodeById")]
        public Node Result { get; set; }
    }
    
    public class NodeByIdWithMembersParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("includeChildrenNodes")]
    public bool? IncludeChildrenNodes { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public NodeByIdWithMembersParam(string id) {
this.Id = id;
}
      /// <summary>
      /// NodeByIdWithMembersParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum), includeChildrenNodes=(bool) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = NodeByIdWithMembersDocument,
          OperationName = "nodeByIdWithMembers",
          Variables = this
        };
      }

      
      public static string NodeByIdWithMembersDocument = @"
        query nodeByIdWithMembers($page: Int, $limit: Int, $sortBy: SortByEnum, $includeChildrenNodes: Boolean, $id: String!) {
          nodeById(id: $id) {
            id
            orgId
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
                status
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
                city
                province
                country
                createdAt
                updatedAt
                externalId
              }
            }
          }
        }
        ";
    }
    

    
    public class OrgResponse {
        
        [JsonProperty("org")]
        public Org Result { get; set; }
    }
    
    public class OrgParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public OrgParam(string id) {
this.Id = id;
}
      /// <summary>
      /// OrgParam.Request 
      /// <para>Required variables:<br/> { id=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              orgId
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
              orgId
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
    

    
    public class OrgsResponse {
        
        [JsonProperty("orgs")]
        public PaginatedOrgs Result { get; set; }
    }
    
    public class OrgsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public OrgsParam() {

}
      /// <summary>
      /// OrgsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class PoliciesResponse {
        
        [JsonProperty("policies")]
        public PaginatedPolicies Result { get; set; }
    }
    
    public class PoliciesParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public PoliciesParam() {

}
      /// <summary>
      /// PoliciesParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = PoliciesDocument,
          OperationName = "policies",
          Variables = this
        };
      }

      
      public static string PoliciesDocument = @"
        query policies($page: Int, $limit: Int, $namespace: String) {
          policies(page: $page, limit: $limit, namespace: $namespace) {
            totalCount
            list {
              namespace
              code
              description
              createdAt
              updatedAt
              statements {
                resource
                actions
                effect
                condition {
                  param
                  operator
                  value
                }
              }
            }
          }
        }
        ";
    }
    

    
    public class PolicyResponse {
        
        [JsonProperty("policy")]
        public Policy Result { get; set; }
    }
    
    public class PolicyParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public PolicyParam(string code) {
this.Code = code;
}
      /// <summary>
      /// PolicyParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = PolicyDocument,
          OperationName = "policy",
          Variables = this
        };
      }

      
      public static string PolicyDocument = @"
        query policy($namespace: String, $code: String!) {
          policy(code: $code, namespace: $namespace) {
            namespace
            code
            isDefault
            description
            statements {
              resource
              actions
              effect
              condition {
                param
                operator
                value
              }
            }
            createdAt
            updatedAt
          }
        }
        ";
    }
    

    
    public class PolicyAssignmentsResponse {
        
        [JsonProperty("policyAssignments")]
        public PaginatedPolicyAssignments Result { get; set; }
    }
    
    public class PolicyAssignmentsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public PolicyAssignmentTargetType? TargetType { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("targetIdentifier")]
    public string TargetIdentifier { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }
      
public PolicyAssignmentsParam() {

}
      /// <summary>
      /// PolicyAssignmentsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { namespace=(string), code=(string), targetType=(PolicyAssignmentTargetType), targetIdentifier=(string), page=(int), limit=(int) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = PolicyAssignmentsDocument,
          OperationName = "policyAssignments",
          Variables = this
        };
      }

      
      public static string PolicyAssignmentsDocument = @"
        query policyAssignments($namespace: String, $code: String, $targetType: PolicyAssignmentTargetType, $targetIdentifier: String, $page: Int, $limit: Int) {
          policyAssignments(namespace: $namespace, code: $code, targetType: $targetType, targetIdentifier: $targetIdentifier, page: $page, limit: $limit) {
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
    

    
    public class PolicyWithAssignmentsResponse {
        
        [JsonProperty("policy")]
        public Policy Result { get; set; }
    }
    
    public class PolicyWithAssignmentsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }
      
public PolicyWithAssignmentsParam(string code) {
this.Code = code;
}
      /// <summary>
      /// PolicyWithAssignmentsParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class PreviewEmailResponse {
        
        [JsonProperty("previewEmail")]
        public string Result { get; set; }
    }
    
    public class PreviewEmailParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public EmailTemplateType Type { get; set; }
      
public PreviewEmailParam(EmailTemplateType type) {
this.Type = type;
}
      /// <summary>
      /// PreviewEmailParam.Request 
      /// <para>Required variables:<br/> { type=(EmailTemplateType) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class QiniuUptokenResponse {
        
        [JsonProperty("qiniuUptoken")]
        public string Result { get; set; }
    }
    
    public class QiniuUptokenParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("type")]
    public string Type { get; set; }
      
public QiniuUptokenParam() {

}
      /// <summary>
      /// QiniuUptokenParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { type=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class QueryMfaResponse {
        
        [JsonProperty("queryMfa")]
        public Mfa Result { get; set; }
    }
    
    public class QueryMfaParam {
      
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
      
public QueryMfaParam() {

}
      /// <summary>
      /// QueryMfaParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { id=(string), userId=(string), userPoolId=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class RoleResponse {
        
        [JsonProperty("role")]
        public Role Result { get; set; }
    }
    
    public class RoleParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public RoleParam(string code) {
this.Code = code;
}
      /// <summary>
      /// RoleParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RoleDocument,
          OperationName = "role",
          Variables = this
        };
      }

      
      public static string RoleDocument = @"
        query role($code: String!, $namespace: String) {
          role(code: $code, namespace: $namespace) {
            namespace
            code
            arn
            description
            createdAt
            updatedAt
            parent {
              namespace
              code
              arn
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }
    

    
    public class RoleWithUsersResponse {
        
        [JsonProperty("role")]
        public Role Result { get; set; }
    }
    
    public class RoleWithUsersParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("code")]
    public string Code { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }
      
public RoleWithUsersParam(string code) {
this.Code = code;
}
      /// <summary>
      /// RoleWithUsersParam.Request 
      /// <para>Required variables:<br/> { code=(string) }</para>
      /// <para>Optional variables:<br/> { namespace=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RoleWithUsersDocument,
          OperationName = "roleWithUsers",
          Variables = this
        };
      }

      
      public static string RoleWithUsersDocument = @"
        query roleWithUsers($code: String!, $namespace: String) {
          role(code: $code, namespace: $namespace) {
            users {
              totalCount
              list {
                id
                arn
                status
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
                city
                province
                country
                createdAt
                updatedAt
                externalId
              }
            }
          }
        }
        ";
    }
    

    
    public class RolesResponse {
        
        [JsonProperty("roles")]
        public PaginatedRoles Result { get; set; }
    }
    
    public class RolesParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public RolesParam() {

}
      /// <summary>
      /// RolesParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { namespace=(string), page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RolesDocument,
          OperationName = "roles",
          Variables = this
        };
      }

      
      public static string RolesDocument = @"
        query roles($namespace: String, $page: Int, $limit: Int, $sortBy: SortByEnum) {
          roles(namespace: $namespace, page: $page, limit: $limit, sortBy: $sortBy) {
            totalCount
            list {
              namespace
              code
              arn
              description
              createdAt
              updatedAt
            }
          }
        }
        ";
    }
    

    
    public class RootNodeResponse {
        
        [JsonProperty("rootNode")]
        public Node Result { get; set; }
    }
    
    public class RootNodeParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("orgId")]
    public string OrgId { get; set; }
      
public RootNodeParam(string orgId) {
this.OrgId = orgId;
}
      /// <summary>
      /// RootNodeParam.Request 
      /// <para>Required variables:<br/> { orgId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = RootNodeDocument,
          OperationName = "rootNode",
          Variables = this
        };
      }

      
      public static string RootNodeDocument = @"
        query rootNode($orgId: String!) {
          rootNode(orgId: $orgId) {
            id
            orgId
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            codePath
            namePath
            createdAt
            updatedAt
            children
          }
        }
        ";
    }
    

    
    public class SearchNodesResponse {
        
        [JsonProperty("searchNodes")]
        public IEnumerable<Node> Result { get; set; }
    }
    
    public class SearchNodesParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("keyword")]
    public string Keyword { get; set; }
      
public SearchNodesParam(string keyword) {
this.Keyword = keyword;
}
      /// <summary>
      /// SearchNodesParam.Request 
      /// <para>Required variables:<br/> { keyword=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SearchNodesDocument,
          OperationName = "searchNodes",
          Variables = this
        };
      }

      
      public static string SearchNodesDocument = @"
        query searchNodes($keyword: String!) {
          searchNodes(keyword: $keyword) {
            id
            orgId
            name
            nameI18n
            description
            descriptionI18n
            order
            code
            root
            depth
            path
            codePath
            namePath
            createdAt
            updatedAt
            children
          }
        }
        ";
    }
    

    
    public class SearchUserResponse {
        
        [JsonProperty("searchUser")]
        public PaginatedUsers Result { get; set; }
    }
    
    public class SearchUserParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("query")]
    public string Query { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("fields")]
    public IEnumerable<string> Fields { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("departmentOpts")]
    public IEnumerable<SearchUserDepartmentOpt> DepartmentOpts { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("groupOpts")]
    public IEnumerable<SearchUserGroupOpt> GroupOpts { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("roleOpts")]
    public IEnumerable<SearchUserRoleOpt> RoleOpts { get; set; }
      
public SearchUserParam(string query) {
this.Query = query;
}
      /// <summary>
      /// SearchUserParam.Request 
      /// <para>Required variables:<br/> { query=(string) }</para>
      /// <para>Optional variables:<br/> { fields=(string[]), page=(int), limit=(int), departmentOpts=(SearchUserDepartmentOpt[]), groupOpts=(SearchUserGroupOpt[]), roleOpts=(SearchUserRoleOpt[]) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = SearchUserDocument,
          OperationName = "searchUser",
          Variables = this
        };
      }

      
      public static string SearchUserDocument = @"
        query searchUser($query: String!, $fields: [String], $page: Int, $limit: Int, $departmentOpts: [SearchUserDepartmentOpt], $groupOpts: [SearchUserGroupOpt], $roleOpts: [SearchUserRoleOpt]) {
          searchUser(query: $query, fields: $fields, page: $page, limit: $limit, departmentOpts: $departmentOpts, groupOpts: $groupOpts, roleOpts: $roleOpts) {
            totalCount
            list {
              id
              arn
              userPoolId
              status
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
              city
              province
              country
              createdAt
              updatedAt
              externalId
            }
          }
        }
        ";
    }
    

    
    public class SocialConnectionResponse {
        
        [JsonProperty("socialConnection")]
        public SocialConnection Result { get; set; }
    }
    
    public class SocialConnectionParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("provider")]
    public string Provider { get; set; }
      
public SocialConnectionParam(string provider) {
this.Provider = provider;
}
      /// <summary>
      /// SocialConnectionParam.Request 
      /// <para>Required variables:<br/> { provider=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class SocialConnectionInstanceResponse {
        
        [JsonProperty("socialConnectionInstance")]
        public SocialConnectionInstance Result { get; set; }
    }
    
    public class SocialConnectionInstanceParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("provider")]
    public string Provider { get; set; }
      
public SocialConnectionInstanceParam(string provider) {
this.Provider = provider;
}
      /// <summary>
      /// SocialConnectionInstanceParam.Request 
      /// <para>Required variables:<br/> { provider=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class SocialConnectionInstancesResponse {
        
        [JsonProperty("socialConnectionInstances")]
        public IEnumerable<SocialConnectionInstance> Result { get; set; }
    }
    
    public class SocialConnectionInstancesParam {
      
      
      /// <summary>
      /// SocialConnectionInstancesParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class SocialConnectionsResponse {
        
        [JsonProperty("socialConnections")]
        public IEnumerable<SocialConnection> Result { get; set; }
    }
    
    public class SocialConnectionsParam {
      
      
      /// <summary>
      /// SocialConnectionsParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class TemplateCodeResponse {
        
        [JsonProperty("templateCode")]
        public string Result { get; set; }
    }
    
    public class TemplateCodeParam {
      
      
      /// <summary>
      /// TemplateCodeParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class UdfResponse {
        
        [JsonProperty("udf")]
        public IEnumerable<UserDefinedField> Result { get; set; }
    }
    
    public class UdfParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }
      
public UdfParam(UdfTargetType targetType) {
this.TargetType = targetType;
}
      /// <summary>
      /// UdfParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class UdfValueBatchResponse {
        
        [JsonProperty("udfValueBatch")]
        public IEnumerable<UserDefinedDataMap> Result { get; set; }
    }
    
    public class UdfValueBatchParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetIds")]
    public IEnumerable<string> TargetIds { get; set; }
      
public UdfValueBatchParam(UdfTargetType targetType,IEnumerable<string> targetIds) {
this.TargetType = targetType;
this.TargetIds = targetIds;
}
      /// <summary>
      /// UdfValueBatchParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetIds=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
          Query = UdfValueBatchDocument,
          OperationName = "udfValueBatch",
          Variables = this
        };
      }

      
      public static string UdfValueBatchDocument = @"
        query udfValueBatch($targetType: UDFTargetType!, $targetIds: [String!]!) {
          udfValueBatch(targetType: $targetType, targetIds: $targetIds) {
            targetId
            data {
              key
              dataType
              value
              label
            }
          }
        }
        ";
    }
    

    
    public class UdvResponse {
        
        [JsonProperty("udv")]
        public IEnumerable<UserDefinedData> Result { get; set; }
    }
    
    public class UdvParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetType")]
[JsonConverter(typeof(StringEnumConverter))]
    public UdfTargetType TargetType { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("targetId")]
    public string TargetId { get; set; }
      
public UdvParam(UdfTargetType targetType,string targetId) {
this.TargetType = targetType;
this.TargetId = targetId;
}
      /// <summary>
      /// UdvParam.Request 
      /// <para>Required variables:<br/> { targetType=(UDFTargetType), targetId=(string) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            label
          }
        }
        ";
    }
    

    
    public class UserResponse {
        
        [JsonProperty("user")]
        public User Result { get; set; }
    }
    
    public class UserParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("id")]
    public string Id { get; set; }
      
public UserParam() {

}
      /// <summary>
      /// UserParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { id=(string) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
            username
            email
            emailVerified
            phone
            phoneVerified
            identities {
              openid
              userIdInIdp
              userId
              connectionId
              isSocial
              provider
              userPoolId
            }
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class UserBatchResponse {
        
        [JsonProperty("userBatch")]
        public IEnumerable<User> Result { get; set; }
    }
    
    public class UserBatchParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("ids")]
    public IEnumerable<string> Ids { get; set; }
      
public UserBatchParam(IEnumerable<string> ids) {
this.Ids = ids;
}
      /// <summary>
      /// UserBatchParam.Request 
      /// <para>Required variables:<br/> { ids=(string[]) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            status
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
            city
            province
            country
            createdAt
            updatedAt
            externalId
          }
        }
        ";
    }
    

    
    public class UserpoolResponse {
        
        [JsonProperty("userpool")]
        public UserPool Result { get; set; }
    }
    
    public class UserpoolParam {
      
      
      /// <summary>
      /// UserpoolParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
            ownerId
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
            appSsoEnabled
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
            customSMSProvider {
              enabled
              provider
              config
            }
            packageType
            useCustomUserStore
            loginRequireEmailVerified
            verifyCodeLength
          }
        }
        ";
    }
    

    
    public class UserpoolTypesResponse {
        
        [JsonProperty("userpoolTypes")]
        public IEnumerable<UserPoolType> Result { get; set; }
    }
    
    public class UserpoolTypesParam {
      
      
      /// <summary>
      /// UserpoolTypesParam.Request 
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
    

    
    public class UserpoolsResponse {
        
        [JsonProperty("userpools")]
        public PaginatedUserpool Result { get; set; }
    }
    
    public class UserpoolsParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public UserpoolsParam() {

}
      /// <summary>
      /// UserpoolsParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              ownerId
              description
              secret
              jwtSecret
              logo
              createdAt
              updatedAt
              emailVerifiedDefault
              sendWelcomeEmail
              registerDisabled
              appSsoEnabled
              showWxQRCodeWhenRegisterDisabled
              allowedOrigins
              tokenExpiresAfter
              isDeleted
              packageType
              useCustomUserStore
              loginRequireEmailVerified
              verifyCodeLength
            }
          }
        }
        ";
    }
    

    
    public class UsersResponse {
        
        [JsonProperty("users")]
        public PaginatedUsers Result { get; set; }
    }
    
    public class UsersParam {
      
    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("page")]
    public int? Page { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Optional
    /// </summary>
    [JsonProperty("sortBy")]
[JsonConverter(typeof(StringEnumConverter))]
    public SortByEnum? SortBy { get; set; }
      
public UsersParam() {

}
      /// <summary>
      /// UsersParam.Request 
      /// <para>Required variables:<br/> {  }</para>
      /// <para>Optional variables:<br/> { page=(int), limit=(int), sortBy=(SortByEnum) }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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
              status
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
              city
              province
              country
              createdAt
              updatedAt
              externalId
            }
          }
        }
        ";
    }
    

    
    public class WhitelistResponse {
        
        [JsonProperty("whitelist")]
        public IEnumerable<WhiteList> Result { get; set; }
    }
    
    public class WhitelistParam {
      
    /// <summary>
    /// Required
    /// </summary>
    [JsonProperty("type")]
[JsonConverter(typeof(StringEnumConverter))]
    public WhitelistType Type { get; set; }
      
public WhitelistParam(WhitelistType type) {
this.Type = type;
}
      /// <summary>
      /// WhitelistParam.Request 
      /// <para>Required variables:<br/> { type=(WhitelistType) }</para>
      /// <para>Optional variables:<br/> {  }</para>
      /// </summary>
      public GraphQLRequest CreateRequest() {
        return new GraphQLRequest {
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