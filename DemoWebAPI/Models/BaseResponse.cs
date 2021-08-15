using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoWebAPI.Models
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public T Data { get; set; }
    }
}
