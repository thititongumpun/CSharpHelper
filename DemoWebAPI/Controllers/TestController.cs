using DemoWebAPI.Extensions;
using DemoWebAPI.Models;
using DemoWebAPI.Services;
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
    public class TestController : Controller
    {
        private readonly ICacheService _cacheService;
        private readonly IDistributedCache _cache;
        public TestController(ICacheService cacheService, IDistributedCache cache)
        {
            _cacheService = cacheService;
            _cache = cache;
        }


        [HttpGet("cache/{key}")]
        public async Task<IActionResult> GetCacheValueDI([FromRoute] string key)
        {
            var value = await _cacheService.GetCacheValue(key);
            return string.IsNullOrEmpty(value) ? NotFound() : Ok(value);
        }

        [HttpPost("cache")]
        public async Task<IActionResult> SetCacheValueDI([FromBody] NewCacheRequest request)
        {
            var response = new BaseResponse<NewCacheRequest>();
            await _cacheService.SetCacheValue(request.Key, request.Value, null);
            response.Success = true;
            response.Data = request;
            return Ok(response);
        }

        //[HttpGet("cache/{key}")]
        //public async Task<IActionResult> GetCacheValueExtensions([FromRoute] string key)
        //{
        //    var value = await _cache.GetCacheAsync<CacheResponse>(key);
        //    return Ok(value);
        //}

        //[HttpPost("cache")]
        //public async Task<IActionResult> SetCacheValueExtensions([FromBody] NewCacheRequest request)
        //{
        //    var response = new BaseResponse<NewCacheRequest>();
        //    await _cache.SetCacheAsync("eiei", request);
        //    response.Success = true;
        //    response.Data = request;
        //    return Ok(response);
        //}
    }
}
