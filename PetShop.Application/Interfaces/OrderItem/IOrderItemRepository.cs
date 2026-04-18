namespace PetShop.Application.Interfaces.OrderItem;

using PetShop.Domain.Entities;

public interface IOrderItemRepository
{
    Task<IEnumerable<OrderItem>> GetAllAsync();
    Task<OrderItem?> GetByIdAsync(Guid id);
    Task AddAsync(OrderItem orderItem);
}