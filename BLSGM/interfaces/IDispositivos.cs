using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDispositivos
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        Dispositivos Get(int Id);
        List<Dispositivos> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
