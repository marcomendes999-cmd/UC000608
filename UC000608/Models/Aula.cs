namespace UC000608.Models
{
    public class Aula
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }

        // Relações com as classes Sala e Horario
        public Sala Sala { get; set; }
        public Horario Horario { get; set; }
        
    }
}
