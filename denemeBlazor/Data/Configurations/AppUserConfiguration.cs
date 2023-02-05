using MSS_NewsWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MSS_NewsWeb.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName).IsRequired();
            builder.Property(x => x.LastName).IsRequired();
            builder.Property(x => x.Username).IsRequired();
            builder.HasAlternateKey(x => x.Username);
            builder.Property(x => x.Password).IsRequired();
            builder.HasMany(x => x.Posts).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
            builder.HasMany(x=>x.Comments).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserId);
        }
    }
}
