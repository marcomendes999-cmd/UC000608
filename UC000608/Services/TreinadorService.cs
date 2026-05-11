using UC000608.Interfaces;
using UC000608.Models;

namespace UC000608.Services
{
    public class TreinadorService : ITreinadorService
    {
        private static List<Treinador> treinadores = new List<Treinador>
        {
            new Treinador
            {
                Id = 1,
                Nome = "Carlos Silva",
                Email = "carlos@gmail.com",
                Telefone = "912345678",
                Especialidade = "Musculação"
            },

            new Treinador
            {
                Id = 2,
                Nome = "Ana Costa",
                Email = "Ana@gmail.com",
                Telefone = "923456789",
                Especialidade = "Cardio"
            },

             new Treinador
            {
                Id = 3,
                Nome = "João Peixoto",
                Email = "JPeixoto@gmail.com",
                Telefone = "927564889",
                Especialidade = "Cardio"
            },
              new Treinador
            {
                Id = 4,
                Nome = "Henrique Soares",
                Email = "henrique@gmail.com",
                Telefone = "939856231",
                Especialidade = "Musculação"
            }
        };

        public List<Treinador> ObterTreinadores()
        {
            return treinadores;
        }

        public Treinador ObterTreinadorPorID(int id)
        {
            return treinadores.FirstOrDefault(t => t.Id == id);
        }
    }
}
