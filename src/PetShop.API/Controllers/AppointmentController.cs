using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.Appointment;
using PetShop.Application.Interfaces.Appointment;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AppointmentController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;

    public AppointmentController(IAppointmentService appointmentService)
    {
        _appointmentService = appointmentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var appointments = await _appointmentService.GetAllAsync();
        return Ok(appointments);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var appointment = await _appointmentService.GetByIdAsync(id);

        if (appointment is null)
            return NotFound();

        return Ok(appointment);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateAppointmentDto dto)
    {
        var createdAppointment = await _appointmentService.CreateAsync(dto);

        return CreatedAtAction(nameof(GetById), new { id = createdAppointment.Id }, createdAppointment);
    }
}