using PetShop.Application.DTOs.Customer;

namespace PetShop.Application.Interfaces.Customer;

public interface ICustomerService
{
    Task<IEnumerable<CustomerResponseDto>> GetAllAsync();
    Task<CustomerResponseDto?> GetByIdAsync(Guid id);
    Task<CustomerResponseDto> CreateAsync(CreateCustomerDto dto);
}