namespace UC000608.Models
{
    public class Horario
    {
        public int ID { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFim { get; set; }
        
    }
}
