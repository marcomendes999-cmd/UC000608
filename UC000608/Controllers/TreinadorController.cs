using Microsoft.AspNetCore.Mvc;
using UC000608.Services;

namespace UC000608.Controllers
{
    public class TreinadorController : Controller
    {
        private readonly TreinadorService _service = new TreinadorService();

        public IActionResult Index()
        {
            return View(_service.ObterTreinadores());
        }
    }
}