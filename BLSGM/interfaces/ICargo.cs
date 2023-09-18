using Models;

namespace Interfaces
{
    public interface ICargo
    {
        int Count { get; }
        string Usuario { get; }
        string Host { get; set; }
        string Mac { get; set; }
        void Clear();
        Cargo Get(int Id);
        List<Cargo> GetAll();
        bool Delete (int  Id);
        bool Update();
    }
}
