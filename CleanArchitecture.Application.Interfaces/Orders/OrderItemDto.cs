﻿namespace CleanArchitecture.Application.Interfaces.Orders
{
    public class OrderItemDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }
    }
}
