using Newtonsoft.Json;

namespace Authing.ApiClient.Extensions
{
    public static class ObjectConvertJson
    {
        public static string ConvertJson(this object _object)
        {
            var resObj = JsonConvert.SerializeObject(_object);
            return resObj;
        }
    }
}