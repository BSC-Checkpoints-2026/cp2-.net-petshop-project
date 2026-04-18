using PetShop.Application.DTOs.Order;
using PetShop.Application.Interfaces.Order;
using PetShop.Domain.Entities;

namespace PetShop.Application.Services;

public class OrderService : IOrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public async Task<IEnumerable<OrderResponseDto>> GetAllAsync()
    {
        var orders = await _orderRepository.GetAllAsync();

        return orders.Select(o => new OrderResponseDto
        {
            Id = o.Id,
            OrderDate = o.OrderDate,
            TotalAmount = o.TotalAmount,
            CustomerId = o.CustomerId
        });
    }

    public async Task<OrderResponseDto?> GetByIdAsync(Guid id)
    {
        var order = await _orderRepository.GetByIdAsync(id);

        if (order is null)
            return null;

        return new OrderResponseDto
        {
            Id = order.Id,
            OrderDate = order.OrderDate,
            TotalAmount = order.TotalAmount,
            CustomerId = order.CustomerId
        };
    }

    public async Task<OrderResponseDto> CreateAsync(CreateOrderDto dto)
    {
        var order = new Order(dto.OrderDate, dto.TotalAmount, dto.CustomerId);

        await _orderRepository.AddAsync(order);

        return new OrderResponseDto
        {
            Id = order.Id,
            OrderDate = order.OrderDate,
            TotalAmount = order.TotalAmount,
            CustomerId = order.CustomerId
        };
    }
}