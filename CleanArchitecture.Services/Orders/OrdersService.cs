using CleanArchitecture.Application.Interfaces.Orders;
using CleanArchitecture.DataAccess.Interfaces;
using CleanArchitecture.Entities;
using CleanArchitecture.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Orders
{
    internal class OrdersService : IOrdersService
    {
        private readonly IOrdersDbContext _context;
        private readonly ICurrentUserService _currentUserService;

        public OrdersService(IOrdersDbContext context, ICurrentUserService currentUserService)
        {
            _context = context;
            _currentUserService = currentUserService;
        }

        public async Task<int> CreateAsync(CreateOrderDto orderDto, CancellationToken cancellationToken)
        {
            var order = new Order
            {
                CreatedAtUtc = DateTime.UtcNow,
                CustomerId = _currentUserService.UserId,
            };

            foreach (var itemDto in orderDto.Items)
            {
                var product = await _context.Products.FindAsync(new object[] { itemDto.ProductId }, cancellationToken);
                var item = new OrderItem(product, itemDto.Quantity);
                order.Items.Add(item);
            }

            order.UpdatePrice();

            _context.Orders.Add(order);
            await _context.SaveChangesAsync(cancellationToken);

            return order.Id;
        }

        public async Task<Order> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _context.Orders
                 .Include(order => order.Items)
                 .ThenInclude(item => item.Product)
                 .SingleOrDefaultAsync(order => order.Id == id, cancellationToken);
        }
    }
}
