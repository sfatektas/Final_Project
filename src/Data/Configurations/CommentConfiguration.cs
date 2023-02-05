using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.PostId).IsRequired();
            builder.Property(x => x.AppUserId).IsRequired();
            builder.Property(x => x.Content_).IsRequired();
            builder.Property(x => x.CreatedTime).HasDefaultValueSql("getdate()");

            builder.HasOne(x => x.Post).WithMany(x => x.Comments).HasForeignKey(x => x.PostId);
            
        }
    }
}
