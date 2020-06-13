using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_api.Models
{
    public class Product
    {
        public int ProductId { get; set; }

        public string SkuNo { get; set; }

        public string ProductDescription { get; set; }
    }
}
