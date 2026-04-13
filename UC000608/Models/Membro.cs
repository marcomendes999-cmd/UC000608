using System.Numerics;

namespace UC000608.Models
{
    public class Membro : Pessoa
    {
        public int Id { get; set; }

        public int NrSocio { get; set; }
        public bool Ativo { get; set; }

        // Relação com Plano
        public int PlanoId { get; set; }
        public Plano Plano { get; set; }
    }
}
