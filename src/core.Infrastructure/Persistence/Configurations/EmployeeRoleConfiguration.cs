using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class EmployeeRoleConfiguration : IEntityTypeConfiguration<EmployeeRole>
{
    public void Configure(EntityTypeBuilder<EmployeeRole> builder)
    {
        builder.ToTable("EMPLOYEE_ROLE");

        builder.HasKey(employeeRole => new { employeeRole.EmployeeId, employeeRole.RoleId });

        builder.HasOne(employeeRole => employeeRole.Employee)
            .WithMany(employee => employee.EmployeeRoles)
            .HasForeignKey(employeeRole => employeeRole.EmployeeId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasOne(employeeRole => employeeRole.Role)
            .WithMany(role => role.EmployeeRoles)
            .HasForeignKey(employeeRole => employeeRole.RoleId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}