using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models.Shipping
{
    public class ShipjungShippingData
    {
        public ShipjungShipFrom ship_from { get; set; }
        public ShipjungShipTo ship_to { get; set; }
        public ShipjungShipments shipments { get; set; }
        public ShipjungShippingConfig config { get; set; }
        public ShipjungPayment payment { get; set; }
        public ShipjungReferral referral { get; set; }
    }

    public class ShipjungShippingConfig
    {
        public string preview { get; set; }
        public int return_mode { get; set; }
        public string insurance { get; set; }
        public string document { get; set; }
        public string currency { get; set; }
        public string unit_metric { get; set; }
        public string sort_mode { get; set; }
        public string auto_approve { get; set; }
        public int create_by { get; set; }
        public string order_type { get; set; }
        public string create_from { get; set; }
    }

    public class con
    {
        public string order_type { get; set; }
        public string insurance { get; set; }
        public string document { get; set; }
        public string currency { get; set; }
        public string unit_metric { get; set; }
        public string unique_order_number { get; set; }
    }
}
