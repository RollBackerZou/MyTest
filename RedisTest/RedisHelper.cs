using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;

namespace RedisTest
{
    public class RedisHelper
    {
        private static string host = "127.0.0.1";
        private static string password = "";
        static readonly RedisClient client = new RedisClient(host,6379);
        
        public static T Get<T>(string token) where T:class ,new()
        {
            return client.Get<T>(token);
        }

        public static void Set<T>(string token,T obj) where T:class,new()
        {
             client.Set<T>(token,obj);
        }

        /// <summary>
        ///  设置Key过期时间
        /// </summary>
        /// <param name="token">Key值</param>
        /// <param name="seconds">过期时间，单位：秒</param>
        public static void Expires(string token,int seconds)
        {
            client.Expire(token,seconds);
        }
    }
}
