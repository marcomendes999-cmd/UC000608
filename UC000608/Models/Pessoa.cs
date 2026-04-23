using System.ComponentModel.DataAnnotations;

namespace UC000608.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        public string Nome { get; set; } ="";

        [Required(ErrorMessage = "O email é obrigatório")]
        public string Email { get; set; } = "";

        public string Telefone { get; set; } = "";

        public int Idade { get; set; } 
    }
}