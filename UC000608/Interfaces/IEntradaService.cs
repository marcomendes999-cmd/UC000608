using UC000608.Models;

namespace UC000608.Interfaces
{
    public interface IEntradaService
    {
        string Entrada(Membro membro);

        List<Entrada> ObterEntradas();
    }
}
