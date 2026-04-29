using core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace core.Infrastructure.Persistence.Configurations;

public class ClientPhoneConfiguration : IEntityTypeConfiguration<ClientPhone>
{
    public void Configure(EntityTypeBuilder<ClientPhone> builder)
    {
        builder.ToTable("CLIENT_PHONE");

        builder.HasKey(phone => phone.Id);

        builder.Property(phone => phone.PhoneNumber)
            .IsRequired()
            .HasMaxLength(30);

        builder.HasOne(phone => phone.Client)
            .WithMany(client => client.Phones)
            .HasForeignKey(phone => phone.ClientId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}