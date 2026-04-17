using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Order : BaseEntity
{
    public DateTime OrderDate { get; private set; }
    
    public decimal TotalAmount { get; private set; }
    
    public Guid CustomerId { get; private set; }

    public Customer Customer { get; private set; } = null!;

    // Relacionamento 1:N
    public List<OrderItem> OrderItems { get; private set; } = new();

    public Order(DateTime orderDate, decimal totalAmount)
    {
        OrderDate = orderDate;
        TotalAmount = totalAmount;
    }
}