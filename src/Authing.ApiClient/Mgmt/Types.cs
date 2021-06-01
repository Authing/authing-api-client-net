using System.Collections.Generic;
using Authing.ApiClient.Types;

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
    }

    public class FindUserOption : ExistsOption
    {
        public string? ExternalId { get; set; }
    }

    public class SearchOption
    {
        public string []? Fields { get; set; }

        public int Page { get; set; } = 1;

        public int Limit { get; set; } = 10;

        public SearchUserDepartmentOpt [] ? DepartmentOpts { get; set; }
        // public IEnumerable<SearchUserDepartmentOpt>? DepartmentOpts { get; set; }

        public SearchUserGroupOpt [] ? GroupOpts { get; set; }

        public SearchUserRoleOpt [] ? RoleOpts { get; set; }
    }

    public interface ListAuthorizedResourcesOption
    {
        public ResourceType? ResourceType { get; set; }
    }
}