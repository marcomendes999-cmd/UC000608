using Microsoft.AspNetCore.Mvc;
using UC000608.Services;

namespace UC000608.Controllers
{
    public class PlanoController : Controller
    {
        private readonly PlanoService _service = new PlanoService();

        public IActionResult Index()
        {
            return View(_service.ObterPlanos());
        }
    }
}