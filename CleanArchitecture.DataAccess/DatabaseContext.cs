using CleanArchitecture.DataAccess.Interfaces;
using CleanArchitecture.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.DataAccess.SqlServer
{
    public class DatabaseContext : DbContext, IOrdersDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
        }
    }
}
