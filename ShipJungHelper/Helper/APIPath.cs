using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Helper
{
    public static class APIPath
    {
        public const string CreateOrderAPI =  "/api/v1/courier/pricing/create_order";
        public const string AddressAPI = "/api/v1/locations/lookup-zipcode/TH/";
        public const string CalculateShippingAPI = "/api/v1/courier/pricing/calculate";
        public const string ApproveOrderAPI = "/api/v1/orders/approve/";
        public const string CancelOrderAPI = "/api/v1/orders/cancel/";
        public const string GetTrackAPI = "/api/v1/orders/info/";
        public const string GetLabelAPI = "/api/v1/orders/generate-awb-label/";
        public const string AddPickupAPI = "/api/v1/sellers/addresses/";
        public const string ShipjungDomain = "/api/v1/courier/pricing/create_order";
    }
}
