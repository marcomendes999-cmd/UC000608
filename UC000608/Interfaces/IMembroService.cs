using UC000608.Models;

namespace UC000608.Interfaces
{
    public interface IMembroService
    {
        List<Membro> ObterMembros();

        Membro ObterMembroPorID(int id);
    }
}
