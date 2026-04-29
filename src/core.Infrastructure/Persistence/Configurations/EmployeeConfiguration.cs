using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.ToTable("EMPLOYEE");

        builder.HasKey(employee => employee.Id);

        builder.Property(employee => employee.Username)
            .IsRequired()
            .HasMaxLength(150);

        builder.Property(employee => employee.Password)
            .IsRequired();

        builder.Property(employee => employee.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(employee => employee.Email)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(employee => employee.Salary)
            .HasDefaultValue(0)
            .HasColumnType("decimal(18,2)");
    }
}