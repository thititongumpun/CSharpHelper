using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models.Address
{
    public class ShipjungAddressResult
    {
        public List<ShipjungAddressData> data { get; set; }
        public bool error { get; set; }
        public string error_code { get; set; }
        public string messages { get; set; }
        public int request_id { get; set; }
        public int total { get; set; }
    }

    public class ShipjungAddressData
    {
        public int id { get; set; }
        public string country_code { get; set; }
        public int province { get; set; }
        public string province_code { get; set; }
        public string province_name { get; set; }
        public int district { get; set; }
        public string district_name { get; set; }
        public string zipcode { get; set; }
        public int is_remote { get; set; }
    }
}
