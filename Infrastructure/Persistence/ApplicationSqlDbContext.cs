using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class ApplicationSqlDbContext : DbContext, IApplicationSqlDbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationSqlDbContext(DbContextOptions options) : base(options) 
        { 
        }
    }
}
