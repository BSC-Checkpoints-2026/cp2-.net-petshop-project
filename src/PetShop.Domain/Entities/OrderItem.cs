using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class OrderItem : BaseEntity
{
    public int Quantity { get; private set; }
    
    public decimal UnitPrice { get; private set; }
    
    // Relacionamentos N:1
    public List<Order> Order { get; private set; } = new List<Order>();

    public List<Product> Product { get; private set; } = new List<Product>();
    
    // Construtor

    public OrderItem(int quantity, decimal unitPrice)
    {
        Quantity = quantity;
        UnitPrice = unitPrice;
    }
}