using PetShop.Application.DTOs.Appointment;
using PetShop.Application.Interfaces.Appointment;
using PetShop.Domain.Entities;
using PetShop.Domain.Enums;

namespace PetShop.Application.Services;

public class AppointmentService : IAppointmentService
{
    private readonly IAppointmentRepository _appointmentRepository;

    public AppointmentService(IAppointmentRepository appointmentRepository)
    {
        _appointmentRepository = appointmentRepository;
    }

    public async Task<IEnumerable<AppointmentResponseDto>> GetAllAsync()
    {
        var appointments = await _appointmentRepository.GetAllAsync();

        return appointments.Select(a => new AppointmentResponseDto
        {
            Id = a.Id,
            AppointmentDate = a.AppointmentDate,
            Status = (int)a.Status,
            PetId = a.PetId,
            ServiceId = a.ServiceId,
            EmployeeId = a.EmployeeId
        });
    }

    public async Task<AppointmentResponseDto?> GetByIdAsync(Guid id)
    {
        var appointment = await _appointmentRepository.GetByIdAsync(id);

        if (appointment is null)
            return null;

        return new AppointmentResponseDto
        {
            Id = appointment.Id,
            AppointmentDate = appointment.AppointmentDate,
            Status = (int)appointment.Status,
            PetId = appointment.PetId,
            ServiceId = appointment.ServiceId,
            EmployeeId = appointment.EmployeeId
        };
    }

    public async Task<AppointmentResponseDto> CreateAsync(CreateAppointmentDto dto)
    {
        var appointment = new Appointment(
            dto.AppointmentDate,
            (StatusEnum)dto.Status,
            dto.PetId,
            dto.ServiceId,
            dto.EmployeeId
        );

        await _appointmentRepository.AddAsync(appointment);

        return new AppointmentResponseDto
        {
            Id = appointment.Id,
            AppointmentDate = appointment.AppointmentDate,
            Status = (int)appointment.Status,
            PetId = appointment.PetId,
            ServiceId = appointment.ServiceId,
            EmployeeId = appointment.EmployeeId
        };
    }
}