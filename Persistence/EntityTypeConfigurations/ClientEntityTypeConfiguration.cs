using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ClientEntityTypeConfiguration: IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Surname).IsRequired().HasMaxLength(35);
        }
    }
}