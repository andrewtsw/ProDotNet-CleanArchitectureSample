using CleanArchitecture.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitecture.Entities
{
    public class Order : EntityBase
    {
        public Guid CustomerId { get; set; }

        public decimal Price { get; set; }

        public DateTimeOffset CreatedAtUtc { get; set; }

        public ICollection<OrderItem> Items { get; private set; } = new List<OrderItem>();

        public void UpdatePrice()
            => Price = CalculatePrice();

        public decimal CalculatePrice()
            => Items.Sum(item => item.CalculateTotal());
    }
}
