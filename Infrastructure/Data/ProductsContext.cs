using System;
using Microsoft.EntityFrameworkCore;
using Core.Entities;

namespace Infrastructure.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> dbContextOptions): base(dbContextOptions)
        {
        }

        public DbSet<Products> Products { get; set; }

    }
}
