using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Service : BaseEntity
{
    public string Name { get; private set; }
    
    public string Description { get; private set; }
    
    public decimal Price { get; private set; }
    
    public int DurationInMinutes { get; private set; }
    
    // Relacionamento 1:N
    public List<Appointment> Appointments { get; private set; } = new List<Appointment>();


    public Service(string name, string description, decimal price, int durationInMinutes)
    {
        Name = name;
        Description = description;
        Price = price;
        DurationInMinutes = durationInMinutes;
    }
}