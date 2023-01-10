using Autofac.Extensions.DependencyInjection;
using Autofac;
using denemeBlazor.Bussines.DependencyResolvers.Autofac;

namespace denemeBlazor.Bussines.DependencyResolvers
{
    public static class DependencyResolve
    {
        public static void DependencyInjection(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBussinesModule());
    });
            //Auto-Mapper

            builder.Services.AddAutoMapper(typeof(Program));
        }



    }
}
