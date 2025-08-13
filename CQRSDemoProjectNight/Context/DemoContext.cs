using CQRSDemoProjectNight.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRSDemoProjectNight.Context
{
    public class DemoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; initial catalog=DemoCQRSNightDb; integrated security=true; trust server certificate=true;");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
