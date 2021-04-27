using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Linq.Expressions;
using Authing.ApiClient.Auth.Types;
using Authing.ApiClient.Types;
using Newtonsoft.Json;

namespace Authing.ApiClient.Utils
{
    public static class AuthingUtils
    {
        public static ListParams ListParams { get; set; } = new ListParams()
        {
            Limit = 10,
            Page = 1,
        };
        
        public static JwtSecurityToken GetPayloadByToken(string token)
        {
            var tokenInfo = new JwtSecurityToken(token);
            return tokenInfo;
        }

        public static IEnumerable<ResUdv>  ConvertUdv(IEnumerable<UserDefinedData> udvList)
        {
            var resUdvList = new List<ResUdv>();
            foreach (var udv in udvList)
            {
                object value = udv.DataType switch
                {
                    UdfDataType.STRING => udv.Value,
                    UdfDataType.NUMBER => int.Parse(udv.Value),
                    UdfDataType.DATETIME => new DateTime(int.Parse(udv.Value), DateTimeKind.Utc),
                    UdfDataType.BOOLEAN => JsonConvert.DeserializeObject<bool>(udv.Value),
                    UdfDataType.OBJECT 
                        => JsonConvert.DeserializeObject<object>(udv.Value),
                    _ => throw new ArgumentOutOfRangeException()
                };
                
                resUdvList.Add(new ResUdv()
                {
                    DataType = udv.DataType,
                    Key = udv.Key,
                    Value = value,
                    Label = udv.Label,
                });
            }

            return resUdvList;
        }

        public static List<KeyValuePair<string, object>> ConverUdvToKeyValuePair(IEnumerable<UserDefinedData> udvList)
        {
            var resUdvList = new List<KeyValuePair<string, object>>();
            foreach (var udv in udvList)
            {
                object value = udv.DataType switch
                {
                    UdfDataType.STRING => udv.Value,
                    UdfDataType.NUMBER => int.Parse(udv.Value),
                    UdfDataType.DATETIME => new DateTime(int.Parse(udv.Value), DateTimeKind.Utc),
                    UdfDataType.BOOLEAN => JsonConvert.DeserializeObject<bool>(udv.Value),
                    UdfDataType.OBJECT 
                        => JsonConvert.DeserializeObject<object>(udv.Value),
                    _ => throw new ArgumentOutOfRangeException()
                };
                
                resUdvList.Add(new KeyValuePair<string, object>(udv.Key, value));
            }

            return resUdvList;
        }
        
        public static T Convert<T>(this object obj)
        {
            // 将这个对象先序列化成 json
            var json = JsonConvert.SerializeObject(obj);
            // 再通过 json 强转成对象
            var resObject = JsonConvert.DeserializeObject<T>(json);
            return resObject;
        }

        public static void FormatAuthorizedResources(ref IEnumerable<AuthorizedResource> list)
        {
            // list.Where(item => item.)
        }
        
        // [AttributeUsage(AttributeTargets.Parameter)  
        // ]  
        // public class SetListParamsAttribute : Attribute  
        // {  
        //     public SetListParamsAttribute(object value, string argumentName)  
        //     {
        //         if (value == null)
        //         {
        //             value = AuthingUtils.ListParams;
        //         }
        //     }  
        // } 
    }
}
