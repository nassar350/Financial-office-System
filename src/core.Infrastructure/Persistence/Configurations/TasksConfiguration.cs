using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class TasksConfiguration : IEntityTypeConfiguration<Tasks>
{
    public void Configure(EntityTypeBuilder<Tasks> builder)
    {
        builder.ToTable("TASKS");

        builder.HasKey(task => task.Id);

        builder.Property(task => task.AddDate)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(task => task.EndDate)
            .IsRequired()
            .HasColumnType("date");

        builder.Property(task => task.DoneDate)
            .HasColumnType("date");

        builder.Property(task => task.EmployeeId)
            .IsRequired();

        builder.HasOne(task => task.Employee)
            .WithMany(employee => employee.Tasks)
            .HasForeignKey(task => task.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(task => task.Client)
            .WithMany(client => client.Tasks)
            .HasForeignKey(task => task.ClientId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}