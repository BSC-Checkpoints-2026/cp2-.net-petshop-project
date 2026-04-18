namespace PetShop.Application.Interfaces.Pet;

using PetShop.Application.DTOs.Pet;

public interface IPetService
{
    Task<IEnumerable<PetResponseDto>> GetAllAsync();
    Task<PetResponseDto?> GetByIdAsync(Guid id);
    Task<PetResponseDto> CreateAsync(CreatePetDto dto);
}