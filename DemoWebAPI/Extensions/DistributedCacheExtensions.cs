using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DemoWebAPI.Extensions
{
    public static class DistributedCacheExtensions
    {
        public static async Task SetCacheAsync<T>(this IDistributedCache cache,
            string key, T data, TimeSpan? absoluteExprieTime = null, TimeSpan? unusedExpireTime = null)
        {

            var options = new DistributedCacheEntryOptions();
            options.AbsoluteExpirationRelativeToNow = absoluteExprieTime ?? TimeSpan.FromSeconds(60);
            options.SlidingExpiration = unusedExpireTime;

            var jsonData = JsonSerializer.Serialize(data);
            await cache.SetStringAsync(key, jsonData, options);
        }

        public static async Task<T> GetCacheAsync<T>(this IDistributedCache cache, string record)
        {
            var jsonData = await cache.GetStringAsync(record);

            if (jsonData is null) return default(T);

            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
