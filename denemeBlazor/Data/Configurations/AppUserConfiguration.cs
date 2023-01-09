using denemeBlazor.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace denemeBlazor.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.Username).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.HasMany(x => x.Posts).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
            builder.HasMany(x=>x.Comments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
        }
    }
}
