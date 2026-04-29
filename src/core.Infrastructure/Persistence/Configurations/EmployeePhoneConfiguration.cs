using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class EmployeePhoneConfiguration : IEntityTypeConfiguration<EmployeePhone>
{
    public void Configure(EntityTypeBuilder<EmployeePhone> builder)
    {
        builder.ToTable("EMPLOYEE_PHONE");

        builder.HasKey(phone => phone.Id);

        builder.Property(phone => phone.PhoneNumber)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasOne(phone => phone.Employee)
            .WithMany(employee => employee.Phones)
            .HasForeignKey(phone => phone.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}