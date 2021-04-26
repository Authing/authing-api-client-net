namespace Authing.ApiClient.Types
{
    public class TokenPayload
    {
        public string sub;
        public string iat;
        public int exp;
        public UserData data;
    }

    public class UserData
    {
        public string email;
        public string id;
    }
}