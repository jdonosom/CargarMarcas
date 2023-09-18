
using Microsoft.Extensions.DependencyInjection;
using Models;
using Autofac;
using Interfaces;
using Microsoft.Extensions.Hosting;
using System.Net;

namespace CargarMarcas
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

            ServiceProvider = CreateHostBuilder().Build().Services;

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            Application.Run(new FrmCargaMarca());
        }


        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .BusinessLayerBuild()
                .ConfigureServices((context, services) =>
                {
                    services.AddSingleton<IFormFactory, FormFactory>();
                    services.AddSingleton<ICredenciales, Credenciales>();
                    // services.AddScoped<IBusinessRequest, BusinessRequest>();
                    // services.AddTransient<BussinesRequest>();

                    // Add all forms
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