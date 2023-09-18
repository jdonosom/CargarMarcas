using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITipoContrato
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        TipoContrato Get(int Id);
        List<TipoContrato> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
