using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class CargoController : Controller
    {
        private static List<Cargo> cargos = new List<Cargo>
        {
            new Cargo { Id = 1, Nome = "Rececionista" },
            new Cargo { Id = 2, Nome = "Administrativo" },
            new Cargo { Id = 3, Nome = "Personal Trainer" },
            new Cargo { Id = 4, Nome = "Limpeza" }
        };

        public IActionResult Index()
        {
            return View(cargos);
        }
    }
}
