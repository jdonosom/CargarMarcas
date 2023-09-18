using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
                    _ = services.AddTransient<BusinessRequest>();
                    _ = services.AddTransient<Utiles>();
                    _ = services.AddTransient<HelperDTE>();
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
