using Models;

namespace BLSGM.interfaces
{
    public interface IHorario
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        Horario Get(int Id);
        List<Horario> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
