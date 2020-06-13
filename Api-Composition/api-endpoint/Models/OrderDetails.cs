using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_endpoint.Models
{
    public class OrderDetails
    {
        public string OrderNo { get; set; }

        public int QTY { get; set; }

        public string SKUNo { get; set; }

        public string ProductName { get; set; }
    }
}
