namespace PetShop.Application.Interfaces.Employee;

using PetShop.Domain.Entities;

public interface IEmployeeRepository
{
    Task<IEnumerable<Employee>> GetAllAsync();
    Task<Employee?> GetByIdAsync(Guid id);
    Task AddAsync(Employee employee);
}