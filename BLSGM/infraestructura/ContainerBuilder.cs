using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BLSGM.Tools;
using BLSGM.DependencyResolvers.Autofac;

namespace BLSGM.infraestructura
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
                    _ = services.AddTransient<Utiles>();
                    _ = services.AddTransient<BusinessRequest>();
                 // _ = services.AddTransient<HelperDTE>();

                });
            return host;
        }

        internal sealed class Container : Autofac.Module
        {
            protected override void Load(ContainerBuilder builder)
            {
                System.Reflection.Assembly? assembly = System.Reflection.Assembly.GetExecutingAssembly();
                // Registra todos los elementos del assembly cuyos nombres terminan en Services
                //
                _ = builder
                    .RegisterAssemblyTypes(assembly)
                    .Where(t => t.Name.EndsWith("Service"))
                    .AsImplementedInterfaces();
            }
        }

    }
}
