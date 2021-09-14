using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ContactEntityTypeConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(a => a.Mail).IsRequired().HasMaxLength(128);
            builder.Property(a => a.Phone).IsRequired().HasMaxLength(13);
            builder.Property(a => a.Voivodeship).IsRequired().HasMaxLength(20);
            builder.Property(a => a.PostalCode).IsRequired().HasMaxLength(6);
            builder.Property(a => a.City).IsRequired().HasMaxLength(40);
            builder.Property(a => a.Street).IsRequired().HasMaxLength(120);
            builder.Property(a => a.HouseNumber).IsRequired().HasMaxLength(6);
            builder.Property(a => a.FlatNumber).HasMaxLength(4);
        }
    }
}