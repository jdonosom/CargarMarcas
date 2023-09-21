using Models;

namespace BLSGM.interfaces
{
    public interface IDispositivosFuncionario
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        DispositivosFuncionario Get(int IdDispositivo, int idEmpleado);
        List<DispositivosFuncionario> GetAll(int IdDispositivo);
        bool Delete(int IdDispositivo, int IdEmpleado);
        bool Update();
    }
}
