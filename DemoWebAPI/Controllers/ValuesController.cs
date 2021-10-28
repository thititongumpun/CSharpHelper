using DemoWebAPI.Extensions;
using DemoWebAPI.Models;
using EasyCaching.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        //private readonly IEasyCachingProvider _provider;
        private readonly IDistributedCache _cache;
        public ValuesController(IDistributedCache cache)
        {
            _cache = cache;
        }
       

        [HttpPost("test")]
        public async Task<IActionResult> SetCacheValueExtensions([FromBody] NewCacheRequest request)
        {
            var response = new BaseResponse<NewCacheRequest>();
            await _cache.SetCacheAsync(request.Key, request);
            response.Success = true;
            response.Data = request;
            return Ok(response);
        }

        [HttpGet("test/{key}")]
        public async Task<IActionResult> GetCacheValueExtensions([FromRoute] string key)
        {
            var response = new BaseResponse<NewCacheRequest>();
            var value = await _cache.GetCacheAsync<NewCacheRequest>(key);
            //if (value is null)
            //{
            //    await _cache.SetCacheAsync("demo", new NewCacheRequest() {Key = "demo", Value = "demo" });
            //}
            response.Success = true;
            return Ok(value);
        }

    }
}
