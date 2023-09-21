using Models;

namespace BLSGM.interfaces
{
    public interface IFuncionarioTipoContrato
    {
        int Count { get; }  
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        FuncionarioTipoContrato Get(int TipoContrato, int IdEmpleado, int IdCargo);
        List<FuncionarioTipoContrato> GetAll(int TipoContrato);
        bool Delete(int TipoContrato, int IdEmpleado, int IdCargo);
        bool Update();
    }
}
