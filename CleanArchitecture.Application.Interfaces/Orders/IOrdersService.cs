using CleanArchitecture.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Orders
{
    public interface IOrdersService
    {
        Task<Order> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<int> CreateAsync(CreateOrderDto orderDto, CancellationToken cancellationToken);
    }
}
