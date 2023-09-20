using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SGFBussinesLayer.Tools;
using System.Reflection;

namespace BLSGM.Infraestructura
{
    public static class ContainerBuild
    {
        public static IHostBuilder BusinessLayerBuild(this IHostBuilder host)
        {
            _ = host.UseServiceProviderFactory(new AutofacServiceProviderFactory());

            _ = host.ConfigureContainer<ContainerBuilder>(
                (config, builder) =>
                {
                    _ = builder.RegisterModule(new Container());
                }
            );

            _ = host.ConfigureServices(
                (config, services) =>
                {
                    // Aqui las clases
                    _ = services.AddTransient<BusinessRequest>();
                    _ = services.AddTransient<Utiles>();
                    //_ = services.AddTransient<HelperDTE>();
                });
            return host;
        }

        internal sealed class Container : Autofac.Module
        {
            // Registra todos los elementos del assembly cuyos nombres terminan en Services
            //
            protected override void Load(ContainerBuilder builder)
            {

                Assembly? assembly = Assembly.GetExecutingAssembly();

                // Aqui los servicios
                _ = builder
                    .RegisterAssemblyTypes(assembly)
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();

                //_ = builder.RegisterAssemblyTypes(assembly)
                //    .Where(t => t.Name == "BusinessRequest")
                //    .AsImplementedInterfaces();

                // _ = builder.RegisterAssemblyTypes(assembly)
                //     .Where(t => t.Name == "Utiles")
                //     .AsImplementedInterfaces();


            }
        }

    }
}
