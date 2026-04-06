using PetShop.Domain.Commom;
using PetShop.Domain.Enums;

namespace PetShop.Domain.Entities;

public class Appointment : BaseEntity
{
    
    public DateTime AppointmentDate { get; private set; }
    
    public  StatusEnum Status { get; private set; }
    
    public Guid PetId { get; private set; }
    
    public Guid ServiceId { get; private set; }
    
    public Guid EmployeeId {get; private set;}
    
    // Relacionementos N:1

    public List<Pet> Pets { get; private set; } = new List<Pet>();
    public List<Service> Services { get; private set; } = new List<Service>();
    public List<Employee> Employee { get; private set; } = new List<Employee>();
    
    // Construtor

    public Appointment(DateTime appointmentDate, StatusEnum status, Guid petId, Guid serviceId, Guid employeeId)
    {
        AppointmentDate = appointmentDate;
        Status = status;
        PetId = petId;
        ServiceId = serviceId;
        EmployeeId = employeeId;
    }
}