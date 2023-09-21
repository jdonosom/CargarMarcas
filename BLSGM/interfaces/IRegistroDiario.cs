using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IRegistroDiario
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        RegistroDiario Get(int IdEmpleado, DateTime Fecha);
        List<RegistroDiario> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
