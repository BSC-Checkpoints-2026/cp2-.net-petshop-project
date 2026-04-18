using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.Service;
using PetShop.Application.Interfaces.Service;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ServiceController : ControllerBase
{
    private readonly IServiceService _serviceService;

    public ServiceController(IServiceService serviceService)
    {
        _serviceService = serviceService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var services = await _serviceService.GetAllAsync();
        return Ok(services);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var service = await _serviceService.GetByIdAsync(id);

        if (service is null)
            return NotFound();

        return Ok(service);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateServiceDto dto)
    {
        var createdService = await _serviceService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = createdService.Id }, createdService);
    }
}