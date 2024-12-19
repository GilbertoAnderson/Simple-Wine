using Microsoft.EntityFrameworkCore;
using SimpleWine.Data;
using SimpleWine.Models;

namespace SimpleWine.Services.Vinhos
{
    public class VinhoService : IVinhoInterface
    {
        private readonly AppDBContext _context;
        private readonly string _sistema;

      

        public VinhoService(AppDBContext context, IWebHostEnvironment sistema)
        {
            _context = context;
            _sistema = sistema.WebRootPath;

        }

        public Task<VinhoModel> GetVinhoPorId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<VinhoModel>> GetVinhos()
        {
            try { 

               return  await _context.Vinhos.ToListAsync();
            } 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<List<VinhoModel>> GetVinhosFiltro(string? strCriterio)
        {
            try
            {
                return await _context.Vinhos.Where(vinhoBanco => vinhoBanco.Origem.Contains(strCriterio)
                                                ||  vinhoBanco.Nome.Contains(strCriterio)
                                                ||  vinhoBanco.Variedade.Contains(strCriterio)).ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
