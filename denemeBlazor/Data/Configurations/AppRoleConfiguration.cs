using denemeBlazor.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace denemeBlazor.Data.Configurations
{
    public class AppRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Defination).IsRequired();
            builder.HasMany(x => x.AppUsers).WithOne(x => x.AppRole).HasForeignKey(x => x.AppRoleId);
        }
    }
}
