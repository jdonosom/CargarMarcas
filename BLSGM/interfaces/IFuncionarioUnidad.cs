using Models;

namespace BLSGM.interfaces
{
    public interface IFuncionarioUnidad
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        FuncionarioUnidad Get( int IdEmpleado, int IdUnidad);
        List<FuncionarioUnidad> GetAll(System.Int32 IdEmpleado, System.Int32 IdUnidad);
        bool Delete(System.Int32 IdEmpleado, System.Int32 IdUnidad);
        bool Update();
    }
}
