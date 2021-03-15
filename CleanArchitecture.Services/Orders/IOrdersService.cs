using CleanArchitecture.Entities;
using CleanArchitecture.Services.Orders;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Services
{
    public interface IOrdersService
    {
        Task<Order> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<int> CreateAsync(CreateOrderDto orderDto, CancellationToken cancellationToken);
    }
}
