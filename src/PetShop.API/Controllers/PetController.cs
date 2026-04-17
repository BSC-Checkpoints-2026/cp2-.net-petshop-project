using Microsoft.AspNetCore.Mvc;
using PetShop.Application.DTOs.Pet;
using PetShop.Application.Interfaces.Pet;

namespace PetShop.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;

    public PetController(IPetService petService)
    {
        _petService = petService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var pets = await _petService.GetAllAsync();
        return Ok(pets);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var pet = await _petService.GetByIdAsync(id);

        if (pet is null)
            return NotFound();

        return Ok(pet);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreatePetDto dto)
    {
        var createdPet = await _petService.CreateAsync(dto);
        return CreatedAtAction(nameof(GetById), new { id = createdPet.Id }, createdPet);
    }
}