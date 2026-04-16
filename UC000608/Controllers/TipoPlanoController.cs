using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class TipoPlanoController : Controller
    {
        private static List<TipoPlano> tipos = new List<TipoPlano>();

        public IActionResult Index()
        {
            return View(tipos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TipoPlano tipo)
        {
            tipo.Id = tipos.Count + 1;
            tipos.Add(tipo);

            return RedirectToAction("Index");
        }
    }
}

