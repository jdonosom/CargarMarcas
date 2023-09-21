using Models;

namespace BLSGM.interfaces
{
    public interface IHorarioFuncionario
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        HorarioFuncionario Get(int IdHorario, int IdEmpleado);
        List<HorarioFuncionario> GetAll(int IdHorario);
        bool Delete(int IdHorario, int IdEmpleado);
        bool Update();
    }
}