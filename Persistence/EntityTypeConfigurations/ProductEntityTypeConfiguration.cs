using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(30);
            builder.Property(a => a.Value).IsRequired();
            builder.Property(a => a.Unit).IsRequired();
            builder.Property(a => a.Stock).IsRequired();
        }
    }
}