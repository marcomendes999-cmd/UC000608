using Microsoft.AspNetCore.Mvc;
using UC000608.Interfaces;
using UC000608.Models;
using UC000608.Services;

namespace UC000608.Controllers
{
    public class PagamentoController : Controller
    {

        private readonly IMembroService _membroService;
        private readonly ITipoPagamentoService _tipopagamentoService;
        private readonly IPagamentoService _pagamentoService;


        public PagamentoController(IMembroService membroService, ITipoPagamentoService tipopagamentoService, IPagamentoService pagamentoService)
        {
            _membroService = membroService;
            _tipopagamentoService = tipopagamentoService;
            _pagamentoService = pagamentoService;

        }
        public IActionResult Index()
        {

            ViewBag.Membros = _membroService.ObterMembros();
            ViewBag.TipoPagamentos = _tipopagamentoService.ObterTiposPagamento();

            var pagamentos = _pagamentoService.ObterPagamentos();


            return View(pagamentos);
        }


        [HttpPost]

        public IActionResult RegistarPagamento(int membroId, int tipopagamentoId)
        {
            _pagamentoService.RegistarPagamento(membroId, tipopagamentoId);

            TempData["Sucesso"] = "Registado Com Sucesso";

            //if (mensagem.StartsWith("Membro"))
            //    TempData["Erro"] = mensagem;
            //else
            //    TempData["Sucesso"] = mensagem;

            return RedirectToAction("Index");
        }
    }
}
