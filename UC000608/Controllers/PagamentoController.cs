using Microsoft.AspNetCore.Mvc;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class PagamentoController : Controller
    {
        public IActionResult Index()
        {
            Pagamento pagamento = new Pagamento();
            pagamento.Id = 1;
            pagamento.Data = DateTime.Now;
            pagamento.Valor = 30;
            pagamento.TipoPagamento = new TipoPagamento { Id=1,Nome="MBWay"};

            return View(pagamento);
        }
    }
}
