using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Services
{
    public class RedisCacheService : ICacheService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;
        public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public async Task<string> GetCacheValue(string key)
        {
            var db = _connectionMultiplexer.GetDatabase();
            return await db.StringGetAsync(key);
        }

        public async Task SetCacheValue(string key, string value, TimeSpan? expires)
        {
            var db = _connectionMultiplexer.GetDatabase();
            var timeLive = expires != null ? expires : TimeSpan.FromSeconds(60);
            await db.StringSetAsync(key, value, timeLive);
        }
    }
}
