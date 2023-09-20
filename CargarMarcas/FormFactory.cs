using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace CargarMarcas
{
    public interface IFormFactory
    {
        T? Create<T>() where T : Form;
    }

    public class FormFactory : IFormFactory
    {
        private readonly IServiceScope _scope;

        public FormFactory(IServiceScopeFactory scopeFactory)
        {
            _scope = scopeFactory.CreateScope();
        }

        public T? Create<T>() where T : Form
        {
            return _scope.ServiceProvider.GetService<T>();
        }
    }
}
