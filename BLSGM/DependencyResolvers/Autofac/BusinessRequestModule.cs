using Autofac;
using Interfaces;
using Models;


namespace SGFBussinesLayer.DependencyResolvers.Autofac
{
    internal class BusinessRequestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Direccion>().As<IDireccion>();
            builder.RegisterType<Cargo>().As<ICargo>();
            builder.RegisterType<Dispositivos>().As<IDispositivos>();
            builder.RegisterType<DispositivosFuncionario>().As<IDispositivosFuncionario>();
            builder.RegisterType<Funcionario>().As<IFuncionario>();
            builder.RegisterType<FuncionarioTipoContrato>().As<IFuncionarioTipoContrato>();
            builder.RegisterType<FuncionarioUnidad>().As<IFuncionarioUnidad>();
            builder.RegisterType<Horario>().As<IHorario>();
            builder.RegisterType<HorarioFuncionario>().As<IHorarioFuncionario>();
            builder.RegisterType<Registro>().As<IRegistro>();
            builder.RegisterType<RegistroDiario>().As<IRegistroDiario>();
            builder.RegisterType<TipoContrato>().As<ITipoContrato>();
            builder.RegisterType<TipoMarca>().As<ITipoMarca>();
            builder.RegisterType<Unidad>().As<IUnidad>();

            //
            // Contiene todos las funcionalidades
            //
            builder.RegisterType<Utiles>();
            builder.RegisterType<HelperDTE>();
            builder.RegisterType<BusinessRequest>();

            //builder.RegisterAssemblyTypes(Assembly.Load(nameof(TestDIRequest)))
            //    .Where(t => t.Namespace.Contains("Interfacez"))
            //    .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            //Assembly? assembly = Assembly.GetExecutingAssembly();
            //builder
            //    .RegisterAssemblyTypes(assembly)
            //    .Where(t => t.Name.EndsWith("Interface"))
            //    //.Where(t => t.Name.StartsWith("I"))
            //    .AsImplementedInterfaces();
        }
    }
}
