using MSS_NewsWeb.Data.Entities;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;
using SportsStore.Data.Entities;

namespace MSS_NewsWeb.Data
{
    public static class SeedData
    {
        public async static Task EnsurePopulated(IApplicationBuilder app)
        {
            NewsDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<NewsDbContext>();


            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Categories.Any())
            {
                await context.Categories.AddRangeAsync(
                    new Category()
                    {
                        Defination = "Siyaset",
                    },
                    new Category()
                    {
                        Defination = "Spor"
                    },
                    new Category()
                    {
                        Defination = "Teknoloji"
                    },
                    new Category()
                    {
                        Defination = "Bilim"
                    },
                    new Category()
                    {
                        Defination = "Tatil"
                    });
            }
            if (!context.AppRoles.Any())
            {
                await context.AppRoles.AddRangeAsync(
                    new AppRole()
                    {
                        Defination = "Admin"
                    },
                    new AppRole()
                    {
                        Defination = "User"
                    });

            }
            if (!context.AppUsers.Any())
            {
                await context.AppUsers.AddAsync(
                    new AppUser()
                    {
                        AppRoleId= 1,
                        FirstName = "Admin",
                        LastName = "Admin",
                        Password = "Admin",
                        Username = "Admin",
                    });
            }
            await context.SaveChangesAsync();

        }
    }
}
