using UC000608.Models;

namespace UC000608.Interfaces
{
    public interface IPlanoService
    {
        List<Plano> ObterPlanos();

        Plano ObterPlanoPorID(int id);
    }
}
