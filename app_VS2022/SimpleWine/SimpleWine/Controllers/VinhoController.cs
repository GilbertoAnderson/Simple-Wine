using Microsoft.AspNetCore.Mvc;
using SimpleWine.Services.Vinhos;

namespace SimpleWine.Controllers
{


    public class VinhoController : Controller
    {
        private readonly IVinhoInterface _vinhosInterface;

        public VinhoController(IVinhoInterface vinhoInterface) {
            _vinhosInterface = vinhoInterface;
        }



        public async Task<IActionResult> Index(string strCriterio)
        {
            var vinhos = await _vinhosInterface.GetVinhos();
            return View(vinhos);
        }
    }
}
