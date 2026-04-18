namespace PetShop.Application.Interfaces.OrderItem;

using PetShop.Application.DTOs.OrderItem;

public interface IOrderItemService
{
    Task<IEnumerable<OrderItemResponseDto>> GetAllAsync();
    Task<OrderItemResponseDto?> GetByIdAsync(Guid id);
    Task<OrderItemResponseDto> CreateAsync(CreateOrderItemDto dto);
}