using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungResultOrder
    {
        public ShipjungResultData data { get; set; }
        public bool error { get; set; }
        public string error_code { get; set; }
        public string messages { get; set; }
        public int total { get; set; }
    }
}
