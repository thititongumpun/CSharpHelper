using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Services
{
    public interface ICacheService
    {
        Task<string> GetCacheValue(string key);

        Task SetCacheValue(string key, string value, TimeSpan? expires);
    }
}
