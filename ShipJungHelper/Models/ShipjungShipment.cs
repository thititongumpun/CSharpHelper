using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungShipments
    {
        public string content { get; set; }
        public int total_parcel { get; set; }
        public double total_amount { get; set; }
        public double chargeable_weight { get; set; }
        public string description { get; set; }
        //public string amz_shipment_id { get; set; }
        public List<ShipjungParcel> parcels { get; set; }
    }
}
