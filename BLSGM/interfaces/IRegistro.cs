using Models;

namespace BLSGM.interfaces
{
    public interface IRegistro
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        Registro Get(int IdEmpleado, DateTime Fecha, DateTime Hora, string Serie);
        List<Registro> GetAll(int IdEmpleado, DateTime Fecha);
        //bool Delete(int IdDispositivo, System.Int32 IdEmpleado);
        bool Update();
    }
}
