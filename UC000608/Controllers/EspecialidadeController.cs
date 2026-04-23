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

            Especialidade Esp4 = new Especialidade();
            Esp4.Nome = "Pilates";

            Especialidade Esp5 = new Especialidade();
            Esp5.Nome = "Treino Funcional";

            Especialidade Esp6 = new Especialidade();
            Esp6.Nome = "Zumba";

            Especialidade Esp7 = new Especialidade();
            Esp7.Nome = "Circuitos";

            Especialidade Esp8 = new Especialidade();
            Esp8.Nome = "Aula de Mobilidade";

            Especialidade Esp9 = new Especialidade();
            Esp9.Nome = "Ginástica localizada";

            Especialidade Esp10 = new Especialidade();
            Esp10.Nome = "Aula de Cardio";

            lista.Add(Esp1);
            lista.Add(Esp2);
            lista.Add(Esp3);
            lista.Add(Esp4);
            lista.Add(Esp5);
            lista.Add(Esp6);
            lista.Add(Esp7);
            lista.Add(Esp8);
            lista.Add(Esp9);
            lista.Add(Esp10);

            return View(lista);
        }
    }
}
