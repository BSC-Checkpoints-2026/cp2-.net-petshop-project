using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Infrastructure.Mappings;

public class EmployeeMapping : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("Employees");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(e => e.LastName)
            .IsRequired()
            .HasMaxLength(20);

        builder.Property(e => e.Role)
            .IsRequired()
            .HasMaxLength(50);
        
        builder.Property(e => e.PhoneNumber)
            .IsRequired()
            .HasMaxLength(15);
        
        builder.Property(e => e.Email)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.HireDate)
            .IsRequired();

        builder.HasIndex(e => e.Email)
            .IsUnique();
        
        builder.HasIndex(e => e.PhoneNumber)
            .IsUnique();

        builder.HasMany(e => e.Appointments)
            .WithOne(a => a.Employee)
            .HasForeignKey(a => a.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}