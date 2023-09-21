using Models;

namespace BLSGM.interfaces
{
    public interface IRegistroDiario
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        RegistroDiario Get(int IdEmpleado, DateTime Fecha);
        List<RegistroDiario> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
