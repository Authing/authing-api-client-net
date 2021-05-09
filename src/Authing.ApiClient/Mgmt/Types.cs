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
}