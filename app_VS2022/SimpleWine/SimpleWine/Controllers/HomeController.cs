using Microsoft.AspNetCore.Mvc;
using SimpleWine.Services.Vinhos;
using System.Diagnostics;

namespace SimpleWine.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVinhoInterface _vinhoInterface;
        public HomeController(IVinhoInterface vinhoInterface)
        {
            _vinhoInterface = vinhoInterface;            
        }

        public async Task<IActionResult> Index(string? strCriterio,string? Filtro )
        {
            if (strCriterio == null)
            {
                var vinhos = await _vinhoInterface.GetVinhos();
                return View(vinhos);
            } 
            else 
            { 
                var vinhos = await _vinhoInterface.GetVinhosFiltro(strCriterio);
                return View(vinhos);

            }

            return View();
        }

    }
}
