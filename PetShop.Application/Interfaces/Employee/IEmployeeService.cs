namespace PetShop.Application.Interfaces.Employee;

using PetShop.Application.DTOs.Employee;

public interface IEmployeeService
{
    Task<IEnumerable<EmployeeResponseDto>> GetAllAsync();
    Task<EmployeeResponseDto?> GetByIdAsync(Guid id);
    Task<EmployeeResponseDto> CreateAsync(CreateEmployeeDto dto);
}