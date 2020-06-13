using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_endpoint.Models;
using api_endpoint.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderDetails = api_endpoint.Models.OrderDetails;

namespace api_endpoint.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public readonly IOrderDetail _orderDetail;
        public ReportController(IOrderDetail orderDetail)
        {
            _orderDetail = orderDetail;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDetails>>> GetOrderDetails()
        {
            var orderDetails = new List<OrderDetails>();
            var orders = await _orderDetail.OrderDetails();
            return orderDetails;
        }
    }
}
