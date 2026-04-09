using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class EspecialidadeController : Controller
    {
        public IActionResult Index()
        {
            List<Especialidade> lista=new List<Especialidade>();
            Especialidade Esp1 = new Especialidade();
            Esp1.Nome = "Crossfit";

            Especialidade Esp2 = new Especialidade();
            Esp2.Nome = "Yoga";

            Especialidade Esp3 = new Especialidade();
            Esp3.Nome = "Ciclying";

            lista.Add(Esp1);
            lista.Add(Esp2);
            lista.Add (Esp3);

            return View(lista);
        }
    }
}
