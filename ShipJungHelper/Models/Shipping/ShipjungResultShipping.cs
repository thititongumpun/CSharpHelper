using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models.Shipping
{
    public class ShipjungResultShipping
    {
        public ShipjungCourierData data { get; set; }
        public bool error { get; set; }
        public string error_code { get; set; }
        public string messages { get; set; }
        public int request_id { get; set; }
        public int total { get; set; }
    }

    public class ShipjungCourierData
    {
        public List<ShipjungCourier> couriers { get; set; }
    }

    public class ShipjungCourier
    {
        public double total_fee { get; set; }
        public double cod_value { get; set; }
        public double shipping_fee { get; set; }
        public double tax { get; set; }
        public double duty { get; set; }
        public string sorting_hub { get; set; }
        public ShipjungVas vas { get; set; }
        public ShipjungFulfillment fulfillment { get; set; }
        public ShipjungDiscountDetail discount_detail { get; set; }
        public double discount { get; set; }
        public int chargeable_weight { get; set; }
        public double min_delivery_time { get; set; }
        public double max_delivery_time { get; set; }
        public string currency { get; set; }
        public string handover_options { get; set; }
        public string handover_policy { get; set; }
        public string courier_name { get; set; }
        public int courier_id { get; set; }
        public string courier_logo { get; set; }
        public int service_id { get; set; }
        public string service_code { get; set; }
        public string service_name { get; set; }
        public string insurance_policy { get; set; }
        public string dropoff_point { get; set; }
        public int pickup_id { get; set; }
        public int delivery_time_rank { get; set; }
        public int fee_rank { get; set; }
        public int rating { get; set; }
    }

    public class ShipjungVas
    {
        public double cod { get; set; }
        public double tracking { get; set; }
        public double pod { get; set; }
        public double insurance { get; set; }
        public double checking { get; set; }
        public double remote { get; set; }
        public double customs { get; set; }
        public double line_haul { get; set; }
    }

    public class ShipjungFulfillment
    {
        public double handling { get; set; }
        public double material { get; set; }
        public double special { get; set; }
    }

    public class ShipjungDiscountDetail
    {
        public double courier_discount { get; set; }
        public double coupon_discount { get; set; }
    }
}
