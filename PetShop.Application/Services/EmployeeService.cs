using PetShop.Application.DTOs.Employee;
using PetShop.Application.Interfaces.Employee;
using PetShop.Domain.Entities;

namespace PetShop.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public async Task<IEnumerable<EmployeeResponseDto>> GetAllAsync()
    {
        var employees = await _employeeRepository.GetAllAsync();

        return employees.Select(e => new EmployeeResponseDto
        {
            Id = e.Id,
            FirstName = e.FirstName,
            LastName = e.LastName,
            Role = e.Role,
            PhoneNumber = e.PhoneNumber,
            Email = e.Email,
            HireDate = e.HireDate
        });
    }

    public async Task<EmployeeResponseDto?> GetByIdAsync(Guid id)
    {
        var employee = await _employeeRepository.GetByIdAsync(id);

        if (employee is null)
            return null;

        return new EmployeeResponseDto
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Role = employee.Role,
            PhoneNumber = employee.PhoneNumber,
            Email = employee.Email,
            HireDate = employee.HireDate
        };
    }

    public async Task<EmployeeResponseDto> CreateAsync(CreateEmployeeDto dto)
    {
        var employee = new Employee(
            dto.FirstName,
            dto.LastName,
            dto.Role,
            dto.PhoneNumber,
            dto.Email,
            dto.HireDate
        );

        await _employeeRepository.AddAsync(employee);

        return new EmployeeResponseDto
        {
            Id = employee.Id,
            FirstName = employee.FirstName,
            LastName = employee.LastName,
            Role = employee.Role,
            PhoneNumber = employee.PhoneNumber,
            Email = employee.Email,
            HireDate = employee.HireDate
        };
    }
}