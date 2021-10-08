using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class UnitTypeEntityTypeConfiguration : IEntityTypeConfiguration<UnitType>
    {
        public void Configure(EntityTypeBuilder<UnitType> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
        }
    }
}