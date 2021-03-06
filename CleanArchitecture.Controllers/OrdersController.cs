using CleanArchitecture.Application.Interfaces.Orders;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Controllers
{
    [Route("api/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrdersService _ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            _ordersService = ordersService;
        }

        [HttpGet("{id}")]
        public async Task<OrderDto> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _ordersService.GetByIdAsync(id, cancellationToken);
        }

        [HttpPost()]
        public async Task<int> CreateAsync(CreateOrderDto orderDto, CancellationToken cancellationToken)
        {
            return await _ordersService.CreateAsync(orderDto, cancellationToken);
        }
    }
}
