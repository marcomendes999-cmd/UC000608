using UC000608.Interfaces;
using UC000608.Models;

namespace UC000608.Services
{
    public class MembroService : IMembroService
    {
        private static List<Membro> membros = new List<Membro>
        {
            new Membro { Id = 1, Nome = "Rita" , Ativo = true},
            new Membro { Id = 2, Nome = "Ines" , Ativo = false},
            new Membro { Id = 3, Nome = "Manuel" , Ativo = true},
            new Membro { Id = 4, Nome = "Ricardo Silva" , Ativo = true},
            new Membro { Id = 5, Nome = "Miguel Guedes" , Ativo = false}
        };


        public List<Membro> ObterMembros()
        {
            return membros;
        }

        public Membro ObterMembroPorID(int id)
        {
            return membros.FirstOrDefault(k => k.Id == id);
        }


    }
}
