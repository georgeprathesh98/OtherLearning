using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using products_api.Models;
using products_api.Services;

namespace products_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<ActionResult<List<Product>>> ProductsGetAllAsync()
        {
            return await _productService.GetProduts();
        }
    }
}
