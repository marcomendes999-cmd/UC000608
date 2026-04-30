namespace UC000608.Models
{
    public class Treinador
    {
        public int Id { get; set; }

        public string Especialidade { get; set; } = "";

        // Ligação à Pessoa
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; } = null!;
    }
}
