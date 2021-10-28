using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungResultData
    {
        public string tracking_number { get; set; }
        public double cod_value { get; set; }
        public ShipjungResultFee fee { get; set; }
    }
}
