namespace PetShop.Application.DTOs.Order;

public class CreateOrderDto
{
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public Guid CustomerId { get; set; }
}