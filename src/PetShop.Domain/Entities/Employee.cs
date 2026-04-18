using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Employee : BaseEntity
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string Role { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public DateTime HireDate { get; private set; }

    public List<Appointment> Appointments { get; private set; } = new();

    public Employee(string firstName, string lastName, string role, string phoneNumber, string email, DateTime hireDate)
    {
        FirstName = firstName;
        LastName = lastName;
        Role = role;
        PhoneNumber = phoneNumber;
        Email = email;
        HireDate = hireDate;
    }
}