using Microsoft.AspNetCore.Mvc;
using ShipJungHelper.Business;
using ShipJungHelper.Models;
using ShipJungHelper.Models.Shipping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShipJungHelper.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IShipjungAPI _shipjungAPI;
        public TestController(IShipjungAPI shipjungAPI)
        {
            _shipjungAPI = shipjungAPI;
        }
        [HttpGet("{zipcode}")]
        public IActionResult GetAddr(string zipcode)
        {
            return Ok(_shipjungAPI.ShipjungGetAddressInfo(zipcode));
        }

        [HttpPost("create")]
        public IActionResult CalculateShipping(ShipjungOrderData shipjungShipping)
        {
            return Ok(_shipjungAPI.ShipjungCreateOrder(shipjungShipping));
        }

        [HttpPost("calculate")]
        public IActionResult CalculateShipping(ShipjungShippingData shipjungShippingData)
        {
            return Ok(_shipjungAPI.ShipjungGetCalculateShipping(shipjungShippingData));
        }
    }
}
