namespace PetShop.Application.DTOs.Pet;

public class PetResponseDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Species { get; set; } = string.Empty;
    public string Breed { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public decimal Weight { get; set; }
    public int Gender { get; set; }
    public Guid CustomerId { get; set; }
}