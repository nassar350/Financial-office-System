using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.ToTable("CLIENT");

        builder.HasKey(client => client.Id);

        builder.Property(client => client.Name)
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(client => client.Email)
            .IsRequired()
            .HasMaxLength(250);

        builder.Property(client => client.Password)
            .IsRequired();

        builder.Property(client => client.Ssn)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(client => client.FileNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(client => client.TaxesNumber)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(client => client.ClientType)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(client => client.ActivityType)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(client => client.ActivityAddress)
            .HasMaxLength(250);

        builder.Property(client => client.ClientAddress)
            .HasMaxLength(250);
    }
}