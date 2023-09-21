using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    public interface IHorarioFuncionario
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        HorarioFuncionario Get(int IdHorario, int IdEmpleado);
        List<HorarioFuncionario> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}