using Autofac.Extensions.DependencyInjection;
using Autofac;
using MSS_NewsWeb.Bussines.DependencyResolvers.Autofac;
using FluentValidation.AspNetCore;
using MSS_NewsWeb.Bussines.Mapper;
using Microsoft.EntityFrameworkCore;
using SportsStore.Data.Context;
using FluentValidation;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.ValidationRules;
using AutoMapper;
using MSS_NewsWeb.Bussines.Services;

namespace MSS_NewsWeb.Bussines.DependencyResolvers
{
    public static class DependencyResolve
    {
        public static void DependencyInjection(this WebApplicationBuilder builder)
        {

            builder.Services.AddDbContext<NewsDbContext>(x =>
x.UseSqlServer(builder.Configuration.GetConnectionString("RealeseDbConnection")).EnableSensitiveDataLogging());
            builder.Services.AddScoped<AppUserService>();

            //Autofac

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBussinesModule());
    });

            //Auto-Mapper

            List<Profile> profiles = new List<Profile>() 
            { 
                new AppRoleProfile(),
                new AppUserProfile(),
                new CategoryProfile(),
                new CommentProfile(),
                new PostProfile()
            };


            builder.Services.AddAutoMapper(x =>
            x.AddProfiles(profiles)
            );

        }



    }
}
