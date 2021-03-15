using System;

namespace CleanArchitecture.Application.Interfaces.Orders
{
    public class OrderDto
    {
        public int Id { get; set; }

        public decimal Price { get; set; }

        public DateTime CreatedAt { get; set; }

        public OrderItemDto[] Items { get; set; }
    }
}
