using Autofac;
using MSS_NewsWeb.Bussines.Dtos;
using MSS_NewsWeb.Bussines.Interfaces;
using MSS_NewsWeb.Bussines.Services;
using MSS_NewsWeb.Bussines.ValidationRules;
using MSS_NewsWeb.Data.Interfaces;
using MSS_NewsWeb.Data.UnitOfWork;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace MSS_NewsWeb.Bussines.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Uow>().As<IUow>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryService>().As<ICategoryService>().InstancePerLifetimeScope();
            builder.RegisterType<PostService>().As<IPostService>().InstancePerLifetimeScope();
            builder.RegisterType<AppUserService>().As<IAppUserService>().InstancePerLifetimeScope();
            builder.RegisterType<CommentService>().As<ICommentService>().InstancePerLifetimeScope();
            builder.RegisterType<CategoryCreateDtoValidator>().As<IValidator<CategoryCreateDto>>().InstancePerDependency();//addTransient
            builder.RegisterType<CommentCreateDtoValidator>().As<IValidator<CommentCreateDto>>().InstancePerDependency();//addTransient



            builder.RegisterAssemblyTypes(ThisAssembly)
                   .Where(t => t.Name.EndsWith("Validator"))
            .AsImplementedInterfaces()
            .InstancePerLifetimeScope();



        }
    }
}