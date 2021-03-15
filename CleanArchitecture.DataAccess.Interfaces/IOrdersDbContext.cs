using CleanArchitecture.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.DataAccess.Interfaces
{
    public interface IOrdersDbContext
    {
        DbSet<Product> Products { get; }

        DbSet<Order> Orders { get; }

        DbSet<OrderItem> OrderItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
