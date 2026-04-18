using PetShop.Application.DTOs.Service;

namespace PetShop.Application.Interfaces.Service;

public interface IServiceService
{
    Task<IEnumerable<ServiceResponseDto>> GetAllAsync();
    Task<ServiceResponseDto?> GetByIdAsync(Guid id);
    Task<ServiceResponseDto> CreateAsync(CreateServiceDto dto);
}