using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_endpoint.Services
{
    public class OrderDetails : IOrderDetail
    {
        Task<IEnumerable<OrderDetails>> IOrderDetail.OrderDetails()
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<OrderDetails>> IOrderDetail.OrderDetails(string OrderNumber)
        {
            throw new NotImplementedException();
        }
    }
}
