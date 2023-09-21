using Models;

namespace BLSGM.interfaces
{
    public interface ITipoContrato
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        TipoContrato Get(int Id);
        List<TipoContrato> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
