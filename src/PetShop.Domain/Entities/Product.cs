using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Product : BaseEntity
{
    public string Name { get; private set; }
    
    public string Description { get; private set; }
    
    public decimal Price { get; private set; }
    
    public int StockQuantity { get; private set; }
    
    // Relacionamento 1:N
    public List<OrderItem> OrderItems { get; private set; } = new List<OrderItem>();

    public Product(string name, string description, decimal price, int stockQuantity)
    {
        Name = name;
        Description = description;
        Price = price;
        StockQuantity = stockQuantity;
    }
}