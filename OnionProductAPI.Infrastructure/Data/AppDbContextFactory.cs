using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionProductAPI.Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            optionsBuilder.UseSqlServer("Data Source=LAPTOP-M79Q5NVL\\SQLEXPRESS;Database=OnionProductApi;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
            
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}
