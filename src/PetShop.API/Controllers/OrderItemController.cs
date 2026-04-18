using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.OrderItem;
using PetShop.Application.Interfaces.OrderItem;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderItemController : ControllerBase
{
    private readonly IOrderItemService _service;

    public OrderItemController(IOrderItemService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok(await _service.GetAllAsync());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderItemDto dto)
    {
        var result = await _service.CreateAsync(dto);
        return Created("", result);
    }
}