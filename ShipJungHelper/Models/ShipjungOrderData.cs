using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Models
{
    public class ShipjungOrderData
    {
        public ShipjungShipFrom ship_from { get; set; }
        public ShipjungShipTo ship_to { get; set; }
        public ShipjungShipments shipments { get; set; }
        public ShipjungConfig config { get; set; }
        public ShipjungPayment payment { get; set; }
        public ShipjungReferral referral { get; set; }
    }

    public class ShipjungProduct
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
