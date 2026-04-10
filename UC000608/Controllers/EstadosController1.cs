using Microsoft.AspNetCore.Mvc;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class EstadosController1 : Controller
    {
        public IActionResult Index()
        {
            List<Estados> listaEstados = new List<Estados>()
            {
                new Estados { Id = 1, Nome = "Iniciado" },
                new Estados { Id = 2, Nome = "Terminado" }
            };

            return View(listaEstados);
        }
    }
}