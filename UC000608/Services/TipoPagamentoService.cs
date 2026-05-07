using UC000608.Models;
using UC000608.Interfaces;

namespace UC000608.Services
{
    public class TipoPagamentoService : ITipoPagamentoService
    {

        private static List<TipoPagamento> tipos = new List<TipoPagamento>
        {
            new TipoPagamento { Id = 1, Nome = "MBWAY"},
            new TipoPagamento { Id = 2, Nome = "DINHEIRO"},
            new TipoPagamento { Id = 3, Nome = "CARTAO DEBITO"},
            new TipoPagamento { Id = 4, Nome = "DEBITO DIRETO"},
        };


        public List<TipoPagamento> ObterTiposPagamento()
        {
            return tipos;
        }

        public TipoPagamento ObterPorId(int id)
        {
            return tipos.FirstOrDefault(j => j.Id == id);
        }
    }
}
