using products_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_api.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProduts();

        void GetProduct(string skuName);

        void AddProduct(Product product);
    }
}
