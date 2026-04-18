using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Infrastructure.Mappings;

public class PetMapping : IEntityTypeConfiguration<Pet>
{
    public void Configure(EntityTypeBuilder<Pet> builder)
    {
        builder.ToTable("Pets");
        
        builder.HasKey(p => p.Id);
        
        builder.Property(p => p.Name)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(p => p.Species)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(p => p.Breed)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(p => p.BirthDate)
            .IsRequired();

        builder.Property(p => p.Weight)
            .IsRequired()
            .HasPrecision(5, 2);

        builder.Property(p => p.Gender)
            .IsRequired();

        builder.HasOne(p => p.Customer)
            .WithMany(c => c.Pets)
            .HasForeignKey(p => p.CustomerId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(p => p.Appointments)
            .WithOne(a => a.Pet)
            .HasForeignKey(a => a.PetId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}