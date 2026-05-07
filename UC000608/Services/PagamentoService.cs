using UC000608.Models;
using UC000608.Interfaces;

namespace UC000608.Services
{
    public class PagamentoService : IPagamentoService
    {
        private static List<Pagamento> pagamentos = new List<Pagamento>();

        private readonly IMembroService _membroService;
        private readonly ITipoPagamentoService _tipopagamentoService;

        public PagamentoService(IMembroService membroService, ITipoPagamentoService tipopagamentoService)
        {
            _membroService = membroService;
            _tipopagamentoService = tipopagamentoService;
        }

        public void RegistarPagamento(int membroid, int tipopagamentoid)
        {
            var membro = _membroService.ObterMembroPorID(membroid);

            var tipopagamento = _tipopagamentoService.ObterPorId(tipopagamentoid);

            if (membro == null || tipopagamento == null)
                return;

            pagamentos.Add(new Pagamento
            {
                Membro = membro,
                TipoPagamento = tipopagamento,
                Data = DateTime.Now
            });
        }

        public bool ValidarPagamento(int membro)
        {
            var data_ano_pesq = DateTime.Now.Year;
            var data_mes_pesq = DateTime.Now.Month;

            return pagamentos.Any(p => p.Membro.Id == membro && p.Data.Month == data_mes_pesq && p.Data.Year == data_ano_pesq);

        }

        public List<Pagamento> ObterPagamentos()
        {
            return pagamentos.OrderByDescending(p => p.Data).ToList();

        }

        public Pagamento ObterPorId(int id)
        {
            return pagamentos.FirstOrDefault(k => k.Id == id);
        }

    }
}
