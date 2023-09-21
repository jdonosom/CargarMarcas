using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IDispositivosFuncionario
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        DispositivosFuncionario Get(int IdDispositivo, int idEmpleado);
        List<DispositivosFuncionario> GetAll();
        bool Delete(int IdDispositivo, int IdEmpleado);
        bool Update();
    }
}
