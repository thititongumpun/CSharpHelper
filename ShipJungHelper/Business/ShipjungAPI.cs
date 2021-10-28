using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using ShipJungHelper.Helper;
using ShipJungHelper.Models;
using ShipJungHelper.Models.Address;
using ShipJungHelper.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Method = ShipJungHelper.Models.Method;

namespace ShipJungHelper.Business
{
    public interface IShipjungAPI
    {
        T Portal<T>(RequestModel requestModel);
        ShipjungResultOrder ShipjungCreateOrder(ShipjungOrderData shipjungShipping);
        ShipjungAddressResult ShipjungGetAddressInfo(string zipcode);
        ShipjungResultShipping ShipjungGetCalculateShipping(ShipjungShippingData shipjungShipping);
    }
    public class ShipjungAPI : IShipjungAPI
    {
        private readonly IConfiguration _config;
        public ShipjungAPI(IConfiguration config)
        {
            _config = config;
        }
        public T Portal<T>(RequestModel requestModel)
        {

            try
            {
                var client = new RestClient($"{_config.GetValue<string>("ShipjungDomain")}{requestModel.Path}");
                client.Timeout = -1;
                var request = new RestRequest((RestSharp.Method)requestModel.Method);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Authorization", _config.GetValue<string>("ShipjungAPIKEY"));
                request.AddParameter("application/json", requestModel.RequestBody, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                var responseObj = JsonConvert.DeserializeObject<T>(response.Content);
                return responseObj;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.Message);
                Debug.WriteLine(ex.StackTrace);
                Debug.WriteLine(ex.Message);
                return default;

            }
        }

        public ShipjungResultOrder ShipjungCreateOrder(ShipjungOrderData shipjungShipping)
        {
            var requestModel = new RequestModel
            {
                Method = Method.POST,
                Path = APIPath.CreateOrderAPI,
                Authorization = _config.GetValue<string>("ShipjungAPIKEY"),
                RequestBody = JsonConvert.SerializeObject(shipjungShipping)
            };

            ShipjungResultOrder result = Portal<ShipjungResultOrder>(requestModel);
            return result;
        }

        public ShipjungAddressResult ShipjungGetAddressInfo(string zipcode)
        {

            var requestModel = new RequestModel
            {
                Method = Method.GET,
                Path = $"{APIPath.AddressAPI}{zipcode}/",
                Authorization = _config.GetValue<string>("ShipjungAPIKEY"),
                RequestBody = ""
            };

            ShipjungAddressResult result = Portal<ShipjungAddressResult>(requestModel);
            return result;
        }

        public ShipjungResultShipping ShipjungGetCalculateShipping(ShipjungShippingData shipjungShipping)
        {

            var requestModel = new RequestModel
            {
                Method = Method.POST,
                Path = $"{APIPath.CalculateShippingAPI}",
                Authorization = _config.GetValue<string>("ShipjungAPIKEY"),
                RequestBody = JsonConvert.SerializeObject(shipjungShipping)
            };

            ShipjungResultShipping result = Portal<ShipjungResultShipping>(requestModel);
            return result;
        }
    }
}
