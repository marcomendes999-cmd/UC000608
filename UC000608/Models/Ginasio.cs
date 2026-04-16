namespace UC000608.Models
{
    /// <summary>
    /// Representa o ginásio FitManager — entidade principal do sistema.
    /// </summary>
    public class Ginasio
    {
        public int Id { get; set; }

        private string _nome = string.Empty;
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Nome do ginásio não pode ser vazio.");
                _nome = value;
            }
        }

        public string Morada { get; set; } = string.Empty;
        public string CodigoPostal { get; set; } = string.Empty;
        public string Localidade { get; set; } = string.Empty;
        public string NIF { get; set; } = string.Empty;
        public string HorarioFuncionamento { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Relações — o ginásio agrega membros e staff
        public ICollection<Membro> Membros { get; set; } = new List<Membro>();
        //public ICollection<Staff> StaffList { get; set; } = new List<Staff>();

        public Ginasio() { }

        public Ginasio(string nome, string morada, string codigoPostal,
                       string localidade, string nif,
                       string horario, string telefone, string email)
        {
            Nome = nome;
            Morada = morada;
            CodigoPostal = codigoPostal;
            Localidade = localidade;
            NIF = nif;
            HorarioFuncionamento = horario;
            Telefone = telefone;
            Email = email;
        }
    }
}