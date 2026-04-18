namespace PetShop.Application.DTOs.OrderItem;

public class CreateOrderItemDto
{
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
}