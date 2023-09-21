using Models;

namespace interfaces
{
    public interface IUnidad
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        Unidad Get(int Id);
        List<Unidad> GetAll();
        bool Delete(int Id);
        bool Update();
    }
}
