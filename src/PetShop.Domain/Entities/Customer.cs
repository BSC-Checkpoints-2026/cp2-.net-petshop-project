using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Customer : BaseEntity
{
    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public string Cpf { get; private set; }

    public string Email { get; private set; }

    public string PhoneNumber { get; private set; }

    public string Address { get; private set; }
    
    // Relacionamentos 
    public List<Pet> Pets { get; private set; } = new List<Pet>();
    public List<Order> Orders { get; private set; } = new List<Order>();
    
    public Customer(string firstName, string lastName, string cpf, string email, string phoneNumber, string address) 
    {
        FirstName = firstName;
        LastName = lastName;
        Cpf = cpf;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
    }
}