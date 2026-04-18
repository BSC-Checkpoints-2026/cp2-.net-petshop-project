namespace PetShop.Application.Interfaces.Appointment;

using PetShop.Application.DTOs.Appointment;

public interface IAppointmentService
{
    Task<IEnumerable<AppointmentResponseDto>> GetAllAsync();
    Task<AppointmentResponseDto?> GetByIdAsync(Guid id);
    Task<AppointmentResponseDto> CreateAsync(CreateAppointmentDto dto);
}