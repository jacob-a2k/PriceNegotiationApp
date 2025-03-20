using Microsoft.EntityFrameworkCore;
using PriceNegotiationApp.Entities;

namespace PriceNegotiationApp.Data
{
    public class NegotiationDbContext(DbContextOptions<NegotiationDbContext> options):DbContext(options)
    {
        public DbSet<Negotiation> Negotiations => Set<Negotiation>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Bike", Price = 99.99m },
                new Product { Id = 2, Name = "Scooter", Price = 59.59m },
                new Product { Id = 3, Name = "Skateboard", Price = 49.49m }
            );
        }
    }
}
