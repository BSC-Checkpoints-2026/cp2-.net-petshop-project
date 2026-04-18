namespace PetShop.Application.Interfaces.Pet;

using PetShop.Domain.Entities;

public interface IPetRepository
{
    Task<IEnumerable<Pet>> GetAllAsync();
    Task<Pet?> GetByIdAsync(Guid id);
    Task AddAsync(Pet pet);
}