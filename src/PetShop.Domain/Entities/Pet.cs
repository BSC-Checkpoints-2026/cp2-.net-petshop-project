using PetShop.Domain.Commom;
using PetShop.Domain.Enums;

namespace PetShop.Domain.Entities;

public class Pet : BaseEntity
{
    public string Name { get; private set; }
    public string Species { get; private set; }
    public string Breed { get; private set; }
    public DateTime BirthDate { get; private set; }
    public decimal Weight { get; private set; }
    public GenderEnum Gender { get; private set; }

    // FK para o dono (Customer N:1)
    public Guid CustomerId { get; private set; }
    public Customer Customer { get; private set; } = null!;

    // 1:N com Appointment
    public List<Appointment> Appointments { get; private set; } = new List<Appointment>();

    public Pet(
        string name,
        string species,
        string breed,
        DateTime birthDate,
        decimal weight,
        GenderEnum gender,
        Guid customerId)
    {
        Name = name;
        Species = species;
        Breed = breed;
        BirthDate = birthDate;
        Weight = weight;
        Gender = gender;
        CustomerId = customerId;
    }
}