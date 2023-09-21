using Models;

namespace BLSGM.interfaces
{
    public interface IDireccion
    {
        int Count { get; }
        //string Usuario { get; }
        string Host { get; set; }
        //string Mac { get; set; }
        void Clear();
        Direccion Get(int Id);
        List<Direccion> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
