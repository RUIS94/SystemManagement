using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace DataAccess
{
    public class RedisHelper
    {
        private static ConnectionMultiplexer redis;
        private static IDatabase db;
        //private readonly IDatabase db;
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

        public static void Remove(string key)
        {
            db.KeyDelete(key);
        }

        //public RedisHelper(IConnectionMultiplexer redis)
        //{
        //    redis = ConnectionMultiplexer.Connect("localhost:6379");
        //    db = redis.GetDatabase();
        //}
        public async Task SetAsync<T>(string key, T value, TimeSpan? expiry = null)
        {
            var json = JsonSerializer.Serialize(value);
            await db.StringSetAsync(key, json, expiry);
        }

        public  async Task<T> GetAsync<T>(string key)
        {
            var value = await db.StringGetAsync(key);
            return !string.IsNullOrEmpty(value) ? JsonSerializer.Deserialize<T>(value) : default;
        }

        //public async Task Remove(string key)
        //{
        //    await db.KeyDeleteAsync(key);
        //}
    }
}
