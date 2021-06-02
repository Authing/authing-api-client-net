using Newtonsoft.Json;

namespace Authing.ApiClient.Extensions
{
    public static class ConvertExtension
    {
        public static T Convert<T>(this object obj)
        {
            // 将这个对象先序列化成 json
            var json = JsonConvert.SerializeObject(obj);
            // 再通过 json 强转成对象
            var resObject = JsonConvert.DeserializeObject<T>(json);
            return resObject;
        }
    }
}