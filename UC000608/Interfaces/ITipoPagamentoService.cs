using UC000608.Models;

namespace UC000608.Interfaces
{
    public interface ITipoPagamentoService
    {

        List<TipoPagamento> ObterTiposPagamento();

        TipoPagamento ObterPorId(int id);
    }
}
