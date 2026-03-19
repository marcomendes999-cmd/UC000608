namespace UC000608.Controllers
{
    public class Reservas
    {
        // Propriedades
        public string NomeDaAula { get; set; }
        public DateTime Horario { get; set; }
        public string NomeDoInstrutor { get; set; }

        // Construtor vazio 
        public Reservas()
        {
        }

        // Construtor com parâmetros
        public Reservas(string nomeDaAula, DateTime horario, string nomeDoInstrutor)
        {
            NomeDaAula = nomeDaAula;
            Horario = horario;
            NomeDoInstrutor = nomeDoInstrutor;
        }

        // Método para exibir os dados (opcional)
        public void ExibirReserva()
        {
            Console.WriteLine($"Aula: {NomeDaAula}");
            Console.WriteLine($"Horário: {Horario}");
            Console.WriteLine($"Instrutor: {NomeDoInstrutor}");
        }
    }
}
