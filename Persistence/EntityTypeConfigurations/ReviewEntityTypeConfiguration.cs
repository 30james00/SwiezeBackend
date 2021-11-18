using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityTypeConfigurations
{
    public class ReviewEntityTypeConfiguration: IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.CreationTime).IsRequired();
            builder.Property(x => x.NumberOfStars).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(800);
        }
    }
}