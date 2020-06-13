using api_endpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_endpoint.Services
{
    public interface IOrderDetail
    {
        Task<IEnumerable<OrderDetails>> OrderDetails();

        Task<IEnumerable<OrderDetails>> OrderDetails(string OrderNumber);
    }
}
