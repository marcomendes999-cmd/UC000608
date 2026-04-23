
namespace UC000608.Models
{
    public class Membro
    {
        public int Id { get; set; }

        public int NrSocio { get; set; }

        public bool Ativo { get; set; }

        // ligação à Pessoa
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; } = null!;

        // ligação ao Plano
        public int PlanoId { get; set; }
        public Plano Plano { get; set; } = null!;
    }
}
