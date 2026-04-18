namespace PetShop.Application.Interfaces.Appointment;

using PetShop.Domain.Entities;

public interface IAppointmentRepository
{
    Task<IEnumerable<Appointment>> GetAllAsync();
    Task<Appointment?> GetByIdAsync(Guid id);
    Task AddAsync(Appointment appointment);
}