using Microsoft.AspNetCore.Mvc;

namespace UC000608.Controllers
{
    public class EstadosController1 : Controller
    {
        public IActionResult Index()
        {
            List<string> listaEstados = new List<string>();

            listaEstados.Add("Iniciado");
            listaEstados.Add("Terminado");

            return View(listaEstados);
        }
    }
}
