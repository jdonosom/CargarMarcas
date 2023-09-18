using Models;

namespace Interfaces
{
    public interface IFuncionarioTipoContrato
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        FuncionarioTipoContrato Get(int TipoContrato, int IdEmpleado, int IdCargo);
        List<FuncionarioTipoContrato> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
