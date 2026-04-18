using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.Employee;
using PetShop.Application.Interfaces.Employee;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var employee = await _employeeService.GetByIdAsync(id);

        if (employee is null)
            return NotFound();

        return Ok(employee);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateEmployeeDto dto)
    {
        var createdEmployee = await _employeeService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = createdEmployee.Id }, createdEmployee);
    }
}