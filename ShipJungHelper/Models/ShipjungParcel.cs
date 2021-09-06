using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungParcel
    {
        public ShipjungDimension dimension { get; set; }
        public double weight { get; set; }
        //public int amount { get; set; }
        public string description { get; set; }
        //public string dg_code { get; set; }
        //public string hs_code { get; set; }
        //public List<object> images { get; set; }
        //public string inspect_note { get; set; }
        //public string referral_code { get; set; }
        public List<ShipjungItem> items { get; set; }
    }
}
