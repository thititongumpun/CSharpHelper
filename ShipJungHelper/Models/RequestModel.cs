using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class RequestModel
    {
        public string Authorization { get; set; }
        public string RequestBody { get; set; }
        public string Path { get; set; }
        public Method Method { get; set; }
        public string Type { get; set; } = string.Empty;
    }
}
