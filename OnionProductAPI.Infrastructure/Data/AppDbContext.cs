using Microsoft.EntityFrameworkCore;
using OnionProductAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionProductAPI.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Description = "Laptop 15 cali",
                    Price = 3500,
                    Quantity = 10,
                    Category = "Elektronika",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025, 05, 22)
                },
                new Product
                {
                    Id = 2,
                    Name = "Myszka",
                    Description = "Mysz bezprzewodowa",
                    Price = 75,
                    Quantity = 50,
                    Category = "Akcesoria",
                    IsAvailable = true,
                    CreatedAt = new DateTime(2025-05-22)
                }
                ) ; 
        }
    }
}
