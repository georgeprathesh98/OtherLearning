﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace orders_api.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public string OrderNumber { get; set; }

        public int QTY { get; set; }

        public string SkuNumber { get; set; }
    }
}
