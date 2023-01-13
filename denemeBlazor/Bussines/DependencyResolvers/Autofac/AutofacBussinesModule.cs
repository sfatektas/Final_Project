using Autofac;
using denemeBlazor.Bussines.Dtos;
using denemeBlazor.Bussines.Interfaces;
using denemeBlazor.Bussines.Services;
using denemeBlazor.Bussines.ValidationRules;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Data.UnitOfWork;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace denemeBlazor.Bussines.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Uow>().As<IUow>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<PostService>().As<IPostService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryCreateDtoValidator>().As<IValidator<CategoryCreateDto>>().InstancePerDependency();//addTransient



            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.Name.EndsWith("Validator"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();



        }
    }
}