using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces.Orders
{
    public interface IOrdersService
    {
        Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken);

        Task<int> CreateAsync(CreateOrderDto orderDto, CancellationToken cancellationToken);
    }
}
