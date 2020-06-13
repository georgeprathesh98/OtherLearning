using Microsoft.EntityFrameworkCore;
using products_api.Database_Contexts;
using products_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_api.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductDBContext _productDBContext;
        public ProductService(ProductDBContext productDBContext)
        {
            _productDBContext = productDBContext;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(string skuName)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Product>> GetProduts()
        {
          return  await _productDBContext.Products.ToListAsync();
        }
    }
}
