namespace CleanArchitecture.Services.Orders
{
    public class CreateOrderItemDto
    {
        public int ProductId { get; set; }

        public decimal Quantity { get; set; }
    }
}
