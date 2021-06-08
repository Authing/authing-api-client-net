namespace Authing.ApiClient.Types
{
    public class TokenPayload
    {
        public string Sub;
        public string Iat;
        public int Exp;
        public UserData Data;
    }

    public class UserData
    {
        public string Email;
        public string Id;
    }
}