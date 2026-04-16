using Microsoft.AspNetCore.Mvc;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class TipoPagamentoController : Controller
    {
        public IActionResult Index()
        {
            List<TipoPagamento> lista = new List<TipoPagamento>();
            TipoPagamento tipo = new TipoPagamento { Id=1, Nome= "MBWay"};
            TipoPagamento tipo2 = new TipoPagamento { Id=2, Nome= "Dinheiro"};
            TipoPagamento tipo3 = new TipoPagamento { Id=3, Nome= "Débito Direto"};
            TipoPagamento tipo4 = new TipoPagamento { Id=4, Nome= "Transferência"};
            TipoPagamento tipo5 = new TipoPagamento { Id=1, Nome= "Cartão de Crédito"};
            lista.Add(tipo);
            lista.Add(tipo2);
            lista.Add(tipo3);
            lista.Add(tipo4);
            lista.Add(tipo5);

            return View(lista);
        }
    }
}
