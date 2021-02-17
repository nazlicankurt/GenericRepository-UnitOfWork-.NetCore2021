using GenericRepository.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        // ModelBuilder ve onModelCreatinge ayrıca bak
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
