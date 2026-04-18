namespace PetShop.Application.DTOs.Appointment;

public class CreateAppointmentDto
{
    public DateTime AppointmentDate { get; set; }
    public int Status { get; set; }
    public Guid PetId { get; set; }
    public Guid ServiceId { get; set; }
    public Guid EmployeeId { get; set; }
}