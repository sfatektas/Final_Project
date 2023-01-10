using Autofac;
using denemeBlazor.Data.Interfaces;
using denemeBlazor.Data.UnitOfWork;

namespace denemeBlazor.Bussines.DependencyResolvers.Autofac
{
    public class AutofacBussinesModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Uow>().As<IUow>().InstancePerLifetimeScope();


        }
    }
}