using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFBussinesLayer.DependencyResolvers.Autofac
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
