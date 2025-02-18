using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace DataAccess
{
    public class RedisHelper
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase db;

        static RedisHelper()
        {
            redis = ConnectionMultiplexer.Connect("localhost:6379");
            db = redis.GetDatabase();
        }
        public static void Set(string key, string value, TimeSpan? expiry = null)
        {
            db.StringSet(key, value, expiry);
        }

        public static string Get(string key)
        {
            return db.StringGet(key);
        }

        //public static void Remove(string key)
        //{
        //    db.KeyDelete(key);
        //}
    }
}
