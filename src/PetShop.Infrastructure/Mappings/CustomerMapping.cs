using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Infrastructure.Mappings;

public class CustomerMapping : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");
        
        builder.HasKey(c => c.Id);

        builder.Property(c => c.FirstName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.LastName)
            .IsRequired()
            .HasMaxLength(30);

        builder.Property(c => c.Cpf)
            .IsRequired()
            .HasMaxLength(11);

        builder.Property(c => c.Email)
            .IsRequired()
            .HasMaxLength(100);
        
        builder.Property(c => c.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);

        builder.Property(c => c.Address)
            .IsRequired()
            .HasMaxLength(200);

        builder.HasIndex(c => c.Cpf)
            .IsUnique();
        
        builder.HasIndex(c => c.Email)
            .IsUnique();
        
        builder.HasIndex(c => c.PhoneNumber)
            .IsUnique();

        builder.HasMany(c => c.Pets)
            .WithOne(p => p.Customer)
            .HasForeignKey(p => p.CustomerId);

        builder.HasMany(c => c.Orders)
            .WithOne(o => o.Customer)
            .HasForeignKey(o => o.CustomerId);
    }
}