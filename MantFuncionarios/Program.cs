using Autofac;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BLSGM.infraestructura;

namespace MantFuncionarios
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; private set; }
        private static IContainer container { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            ServiceProvider = CreateHostBuilder().Build().Services;
            Application.Run(ServiceProvider.GetService<FrmFuncionario>());
        }


        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .BusinessLayerBuild()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IFormFactory, FormFactory>();

                    // Agregar todos los formularios al contenedor
                    //
                    var forms = typeof(Program).Assembly
                    .GetTypes()
                    .Where(t => t.BaseType == typeof(Form))
                    .ToList();

                    forms.ForEach(form =>
                    {
                        services.AddTransient(form);
                    });
                });
        }
    }
}