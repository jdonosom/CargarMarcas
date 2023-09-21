using Models;

namespace BLSGM.interfaces
{
    public interface IDispositivos
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        Dispositivos Get(int Id);
        List<Dispositivos> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
