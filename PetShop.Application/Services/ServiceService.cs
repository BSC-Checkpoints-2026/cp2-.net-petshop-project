using PetShop.Application.DTOs.Service;
using PetShop.Application.Interfaces.Service;
using PetShop.Domain.Entities;

namespace PetShop.Application.Services;

public class ServiceService : IServiceService
{
    private readonly IServiceRepository _serviceRepository;

    public ServiceService(IServiceRepository serviceRepository)
    {
        _serviceRepository = serviceRepository;
    }

    public async Task<IEnumerable<ServiceResponseDto>> GetAllAsync()
    {
        var services = await _serviceRepository.GetAllAsync();

        return services.Select(s => new ServiceResponseDto
        {
            Id = s.Id,
            Name = s.Name,
            Description = s.Description,
            Price = s.Price,
            DurationInMinutes = s.DurationInMinutes
        });
    }

    public async Task<ServiceResponseDto?> GetByIdAsync(Guid id)
    {
        var service = await _serviceRepository.GetByIdAsync(id);

        if (service is null)
            return null;

        return new ServiceResponseDto
        {
            Id = service.Id,
            Name = service.Name,
            Description = service.Description,
            Price = service.Price,
            DurationInMinutes = service.DurationInMinutes
        };
    }

    public async Task<ServiceResponseDto> CreateAsync(CreateServiceDto dto)
    {
        var service = new Service(
            dto.Name,
            dto.Description,
            dto.Price,
            dto.DurationInMinutes
        );

        await _serviceRepository.AddAsync(service);

        return new ServiceResponseDto
        {
            Id = service.Id,
            Name = service.Name,
            Description = service.Description,
            Price = service.Price,
            DurationInMinutes = service.DurationInMinutes
        };
    }
}