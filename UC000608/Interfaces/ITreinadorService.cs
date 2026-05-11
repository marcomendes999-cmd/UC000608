using UC000608.Models;

namespace UC000608.Interfaces
{
    public interface ITreinadorService
    {
        List<Treinador> ObterTreinadores();

        Treinador ObterTreinadorPorID(int id);
    }
}