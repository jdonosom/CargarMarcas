using Autofac;
using BL;
using BLSGM.interfaces;

namespace BLSGM.DependencyResolvers.Autofac
{
    internal class BusinessRequestModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CargoService>().As<ICargo>();
            builder.RegisterType<DireccionService>().As<IDireccion>();
            builder.RegisterType<DispositivosFuncionarioService>().As<IDispositivosFuncionario>();
            builder.RegisterType<DispositivosService>().As<IDispositivos>();
            builder.RegisterType<FuncionarioService>().As<IFuncionario>();
            builder.RegisterType<FuncionarioTipoContratoService>().As<IFuncionarioTipoContrato>();
            builder.RegisterType<FuncionarioUnidadService>().As<IFuncionarioUnidad>();
            builder.RegisterType<HorarioFuncionarioService>().As<IHorarioFuncionario>();
            builder.RegisterType<HorarioService>().As<IHorario>();
            builder.RegisterType<RegistroDiarioService>().As<IRegistroDiario>();
            builder.RegisterType<RegistroService>().As<IRegistro>();
            builder.RegisterType<TipoContratoService>().As<ITipoContrato>();
            builder.RegisterType<TipoMarcaService>().As<ITipoMarca>();
            builder.RegisterType<UnidadService>().As<IUnidad>();

            // Registro de todos los servicios
            //
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly)
                .Where(t => t.Name.EndsWith("Service"))
                .AsImplementedInterfaces();

            //builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly())
            //    .Where(t => t.Name.StartsWith("I"))
            //    .AsImplementedInterfaces();

            //
            // Registros de otras funcionalidades
            //
            //builder.RegisterType<Utiles>();
            //builder.RegisterType<HelperDTE>();
            //builder.RegisterType<BusinessRequest>();


        }
    }
}
