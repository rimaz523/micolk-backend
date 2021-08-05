using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationCosmosDbContext : DbContext, IApplicationCosmosDbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationCosmosDbContext(DbContextOptions<ApplicationCosmosDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .ToContainer("Products");
        }
    }
}
