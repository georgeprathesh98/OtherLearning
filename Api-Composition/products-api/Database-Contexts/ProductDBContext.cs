using Microsoft.EntityFrameworkCore;
using products_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace products_api.Database_Contexts
{
    public class ProductDBContext : DbContext
    {
        public ProductDBContext(DbContextOptions<ProductDBContext> options)
      : base(options)
        { }

        public DbSet<Product> Products { get; set; }
    }
}
