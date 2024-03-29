﻿using DemoWebAPI.Extensions;
using DemoWebAPI.Models;
using DemoWebAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : Controller
    {
        //private readonly ICacheService _cacheService;
        //private readonly IDistributedCache _cache;
        private readonly IMessageService _messageService;
        public TestController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        //[HttpGet("cache/{key}")]
        //public async Task<IActionResult> GetCacheValueExtensions([FromRoute] string key)
        //{
        //    var response = new BaseResponse<NewCacheRequest>();
        //    var value = await _cache.GetCacheAsync<NewCacheRequest>(key);
        //    response.Success = true;
        //    response.Data = value;
        //    return Ok(response);
        //}

        //[HttpPost("cache")]
        //public async Task<IActionResult> SetCacheValueExtensions([FromBody] NewCacheRequest request)
        //{
        //    var response = new BaseResponse<NewCacheRequest>();
        //    await _cache.SetCacheAsync(Regex.Replace(request.Key, @"\s+", string.Empty).Trim(), request);
        //    response.Success = true;
        //    response.Data = request;
        //    return Ok(Regex.Replace(request.Key, @"\s+", string.Empty).Trim());
        //}

        [HttpPost]
        public IActionResult Post([FromBody] Payload payload)
        {
            Console.WriteLine($"recieved {payload.payload}");
            _messageService.Enqueue(payload);

            return Ok($"{payload.payload}");
        }

        public class Payload
        {
            public string payload { get;set; }
        }
    }
}
