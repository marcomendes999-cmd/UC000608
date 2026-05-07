using UC000608.Models;


namespace UC000608.Interfaces
{
    public interface IPagamentoService
    {

        void RegistarPagamento(int membroId, int tipoPagamentoId);
        bool ValidarPagamento(int membroId);
        List<Pagamento> ObterPagamentos();
        Pagamento ObterPorId(int id);
    }
}
