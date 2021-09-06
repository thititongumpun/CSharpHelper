using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungItem
    {
        public string sku { get; set; }
        public string label_code { get; set; }
        public string origin_country { get; set; }
        public string name { get; set; }
        public string desciption { get; set; }
        public double weight { get; set; }
        public int amount { get; set; }
        public int quantity { get; set; }
    }
}
