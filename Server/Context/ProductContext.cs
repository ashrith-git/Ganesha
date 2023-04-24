using EPASBlazor.Server.Context.Configuration;
using EPASBlazor.Shared;
using Microsoft.EntityFrameworkCore;

namespace EPASBlazor.Server.Context
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options)
           : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        public DbSet<Product> Products { get; set; }
    }
}
