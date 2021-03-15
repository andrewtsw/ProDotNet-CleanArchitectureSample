namespace CleanArchitecture.Application.Interfaces.Orders
{
    public class CreateOrderDto
    {
        public CreateOrderItemDto[] Items { get; set; }
    }
}
