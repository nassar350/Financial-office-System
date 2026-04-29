using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class FinancialConfiguration : IEntityTypeConfiguration<Financial>
{
    public void Configure(EntityTypeBuilder<Financial> builder)
    {
        builder.ToTable("FINANCIALS");

        builder.HasKey(financial => financial.Id);

        builder.Property(financial => financial.Value)
            .HasColumnType("decimal(18,2)");

        builder.Property(financial => financial.Type)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(financial => financial.FeeType)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(financial => financial.Date)
            .IsRequired()
            .HasColumnType("date");

        builder.HasOne(financial => financial.Employee)
            .WithMany(employee => employee.Financials)
            .HasForeignKey(financial => financial.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(financial => financial.Client)
            .WithMany(client => client.Financials)
            .HasForeignKey(financial => financial.ClientId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}