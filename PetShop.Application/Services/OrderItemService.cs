using PetShop.Application.DTOs.OrderItem;
using PetShop.Application.Interfaces.OrderItem;
using PetShop.Domain.Entities;

namespace PetShop.Application.Services;

public class OrderItemService : IOrderItemService
{
    private readonly IOrderItemRepository _repository;

    public OrderItemService(IOrderItemRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<OrderItemResponseDto>> GetAllAsync()
    {
        var items = await _repository.GetAllAsync();

        return items.Select(i => new OrderItemResponseDto
        {
            Id = i.Id,
            Quantity = i.Quantity,
            UnitPrice = i.UnitPrice,
            OrderId = i.OrderId,
            ProductId = i.ProductId
        });
    }

    public async Task<OrderItemResponseDto?> GetByIdAsync(Guid id)
    {
        var item = await _repository.GetByIdAsync(id);

        if (item is null)
            return null;

        return new OrderItemResponseDto
        {
            Id = item.Id,
            Quantity = item.Quantity,
            UnitPrice = item.UnitPrice,
            OrderId = item.OrderId,
            ProductId = item.ProductId
        };
    }

    public async Task<OrderItemResponseDto> CreateAsync(CreateOrderItemDto dto)
    {
        var item = new OrderItem(
            dto.Quantity,
            dto.UnitPrice,
            dto.OrderId,
            dto.ProductId
        );

        await _repository.AddAsync(item);

        return new OrderItemResponseDto
        {
            Id = item.Id,
            Quantity = item.Quantity,
            UnitPrice = item.UnitPrice,
            OrderId = item.OrderId,
            ProductId = item.ProductId
        };
    }
}