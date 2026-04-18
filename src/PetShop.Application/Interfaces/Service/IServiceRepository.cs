namespace PetShop.Application.Interfaces.Service;

using PetShop.Domain.Entities;

public interface IServiceRepository
{
    Task<IEnumerable<Service>> GetAllAsync();
    Task<Service?> GetByIdAsync(Guid id);
    Task AddAsync(Service service);
}