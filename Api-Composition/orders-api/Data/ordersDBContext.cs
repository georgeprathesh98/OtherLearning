using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using orders_api.Models;

    public class ordersDBContext : DbContext
    {
        public ordersDBContext (DbContextOptions<ordersDBContext> options)
            : base(options)
        {
        }

        public DbSet<orders_api.Models.Order> Order { get; set; }
    }
