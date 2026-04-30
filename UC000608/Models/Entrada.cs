namespace UC000608.Models
{
    public class Entrada
    {
        public Membro Membro { get; set; }

        public DateTime DataHora { get; set; }

        public string Tipo { get; set; } // Entrada ou Saida

        public Entrada(Membro membro, string tipo)
        {
            Membro = membro;
            DataHora = DateTime.Now;
            Tipo = tipo;
        }
    }
}
