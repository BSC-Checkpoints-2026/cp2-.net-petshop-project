using PetShop.Application.DTOs.Pet;
using PetShop.Application.Interfaces.Pet;
using PetShop.Domain.Entities;
using PetShop.Domain.Enums;

namespace PetShop.Application.Services;

public class PetService : IPetService
{
    private readonly IPetRepository _petRepository;

    public PetService(IPetRepository petRepository)
    {
        _petRepository = petRepository;
    }

    public async Task<IEnumerable<PetResponseDto>> GetAllAsync()
    {
        var pets = await _petRepository.GetAllAsync();

        return pets.Select(p => new PetResponseDto
        {
            Id = p.Id,
            Name = p.Name,
            Species = p.Species,
            Breed = p.Breed,
            BirthDate = p.BirthDate,
            Weight = p.Weight,
            Gender = (int)p.Gender,
            CustomerId = p.CustomerId
        });
    }

    public async Task<PetResponseDto?> GetByIdAsync(Guid id)
    {
        var pet = await _petRepository.GetByIdAsync(id);

        if (pet is null)
            return null;

        return new PetResponseDto
        {
            Id = pet.Id,
            Name = pet.Name,
            Species = pet.Species,
            Breed = pet.Breed,
            BirthDate = pet.BirthDate,
            Weight = pet.Weight,
            Gender = (int)pet.Gender,
            CustomerId = pet.CustomerId
        };
    }

    public async Task<PetResponseDto> CreateAsync(CreatePetDto dto)
    {
        var pet = new Pet(
            dto.Name,
            dto.Species,
            dto.Breed,
            dto.BirthDate,
            dto.Weight,
            (GenderEnum)dto.Gender,
            dto.CustomerId
        );

        await _petRepository.AddAsync(pet);

        return new PetResponseDto
        {
            Id = pet.Id,
            Name = pet.Name,
            Species = pet.Species,
            Breed = pet.Breed,
            BirthDate = pet.BirthDate,
            Weight = pet.Weight,
            Gender = (int)pet.Gender,
            CustomerId = pet.CustomerId
        };
    }
}