using UC000608.Interfaces;
using UC000608.Models;
using Microsoft.AspNetCore.Mvc;

namespace UC000608.Controllers
{
    public class EntradaController : Controller
    {
        private readonly IEntradaService _entradaService;
        private readonly IMembroService _membroService;

        public EntradaController(IEntradaService entradaService, IMembroService membroService)
        {
            _entradaService = entradaService;
            _membroService = membroService;
        }


        public IActionResult Index()
        {
            ViewBag.Membros = _membroService.ObterMembros();

            var entradas = _entradaService.ObterEntradas();

            return View(entradas);
        }

        [HttpPost]

        public IActionResult RegistarEntradas(int membroId)
        {
            var membro = _membroService.ObterMembroPorID(membroId);

            var mensagem = _entradaService.Entrada(membro);

            if (mensagem.StartsWith("Membro"))
                TempData["Erro"] = mensagem;
            else
                TempData["Sucesso"] = mensagem;

            return RedirectToAction("Index");
        }


    }
}
