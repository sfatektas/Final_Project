using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Data.Entities;

namespace SportsStore.Data.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Defination1).IsRequired();
            builder.Property(x => x.AppUserId).IsRequired();
            builder.Property(x => x.CreatedTime).HasDefaultValueSql("getdate()");
            builder.Property(x => x.CategoryId).IsRequired();

            builder.HasMany(x => x.Comments).WithOne(x => x.Post).HasForeignKey(x => x.PostId);
        }
    }
}
