using SimpleWine.Models;

namespace SimpleWine.Services.Vinhos
{
    public interface IVinhoInterface
    {
        Task<List<VinhoModel>> GetVinhos();

        Task<VinhoModel> GetVinhoPorId(int id);

        Task<List<VinhoModel>> GetVinhosFiltro(string? strCriterio);
    }
}
