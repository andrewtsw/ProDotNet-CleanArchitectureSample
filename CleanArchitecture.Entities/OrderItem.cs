using CleanArchitecture.Entities.Base;

namespace CleanArchitecture.Entities
{
    public class OrderItem : EntityBase
    {
        protected OrderItem()
        {

        }

        public OrderItem(Product product, decimal quantity)
        {
            ProductId = product.Id;
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public decimal Price { get; set; }

        public decimal Quantity { get; set; }

        public decimal CalculateTotal()
            => Price * Quantity;
    }
}
