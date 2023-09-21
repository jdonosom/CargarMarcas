using Models;

namespace BLSGM.interfaces
{
    public interface ITipoMarca
    {
        int Count { get; }
        // string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        TipoMarca Get(int Id);
        List<TipoMarca> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
