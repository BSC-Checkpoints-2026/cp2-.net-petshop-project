namespace PetShop.Application.DTOs.Order;

public class OrderResponseDto
{
    public Guid Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public Guid CustomerId { get; set; }
}