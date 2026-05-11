using UC000608.Interfaces;
using UC000608.Models;

namespace UC000608.Services
{
    public class PlanoService : IPlanoService
    {
        private static List<Plano> planos = new List<Plano>
        {
            new Plano
            {
                Id = 1,
                Nome = "Mensal",
                Preco = 25
            },

            new Plano
            {
                Id = 2,
                Nome = "Anual",
                Preco = 200
            },

             new Plano
            {
                Id = 2,
                Nome = "Trimestral",
                Preco = 65
            },

            new Plano
            {
                Id = 3,
                Nome = "Premium",
                Preco = 40
            }
        };

        public List<Plano> ObterPlanos()
        {
            return planos;
        }

        public Plano ObterPlanoPorID(int id)
        {
            return planos.FirstOrDefault(p => p.Id == id);
        }
    }
}
