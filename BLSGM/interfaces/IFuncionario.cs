using Models;

namespace BLSGM.interfaces
{
    public interface IFuncionario
    {

        int Count { get; }
        Funcionario Current { get; set; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        Funcionario Get(int Id);
        List<Funcionario> GetAll();
        List<FuncionarioSinMarca> GetEmpleadosSinMarca(string Fecha, int IdUnidad);
        bool Delete(int Id);
        bool Update();
        List<Funcionario> GetByNombre(string nombre);
    }
}
