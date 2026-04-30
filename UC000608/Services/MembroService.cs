using UC000608.Interfaces;
using UC000608.Models;

namespace UC000608.Services
{
    public class MembroService : IMembroService
    {
        private static List<Membro> membros = new List<Membro>
        {
    new Membro
    {
        Id = 1,
        Ativo = true,
        Pessoa = new Pessoa { Id = 1, Nome = "Rita" },
         Plano = new Plano { Nome = "Anual" }
    },
    new Membro
    {
        Id = 2,
        Ativo = false,
        Pessoa = new Pessoa { Id = 2, Nome = "Ines" },
        Plano = new Plano { Nome = "Mensal" }
    },
    new Membro
    {
        Id = 3,
        Ativo = true,
        Pessoa = new Pessoa { Id = 3, Nome = "Manuel" },
         Plano = new Plano { Nome = "Anual" }
    },
    new Membro
    {
        Id = 4,
        Ativo = true,
        Pessoa = new Pessoa { Id = 4, Nome = "Ricardo Silva" },
         Plano = new Plano { Nome = "Mensal" }
    },
    new Membro
    {
        Id = 5,
        Ativo = false,
        Pessoa = new Pessoa { Id = 5, Nome = "Miguel Guedes" },
         Plano = new Plano { Nome = "Mensal" }
    }
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
