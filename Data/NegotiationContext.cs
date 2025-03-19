using Microsoft.EntityFrameworkCore;
using PriceNegotiationApp.Entities;

namespace PriceNegotiationApp.Data
{
    public class NegotiationContext(DbContextOptions<NegotiationContext> options):DbContext(options)
    {
        public DbSet<Negotiation> Negotiations => Set<Negotiation>();
        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
    }
}
