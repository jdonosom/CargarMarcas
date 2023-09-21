using Autofac;

namespace BLSGM.DependencyResolvers.Autofac
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new BusinessRequestModule());

            IContainer Container = builder.Build();
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }

        }
    }
}
