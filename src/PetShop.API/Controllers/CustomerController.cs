using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.Customer;
using PetShop.Application.Interfaces.Customer;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var customers = await _customerService.GetAllAsync();
        return Ok(customers);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var customer = await _customerService.GetByIdAsync(id);

        if (customer is null)
            return NotFound();

        return Ok(customer);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateCustomerDto dto)
    {
        var createdCustomer = await _customerService.CreateAsync(dto);

        return CreatedAtAction(nameof(GetById), new { id = createdCustomer.Id }, createdCustomer);
    }
}