using UC000608.Interfaces;
using UC000608.Models;

namespace UC000608.Services
{
    public class EntradaService : IEntradaService
    {
        private static List<Entrada> registos = new List<Entrada>();

        public string Entrada(Membro membro)
        {
            if(membro == null)
            {
                return "Membro inválido!";
            }

            if (membro.Ativo == false)
            {
                return "Membro está inativo!";
            }

            var ultimo = registos.Where(r => r.Membro.Id == membro.Id)
                .OrderByDescending(r => r.DataHora)
                .FirstOrDefault();

            string tipo;

            if(ultimo == null || ultimo.Tipo == "Saida")
            {
                tipo = "Entrada";
            }
            else
            {
                tipo = "Saida";
            }

            registos.Add(new Models.Entrada(membro, tipo));

            return $" registo do membro {membro.Nome} efectuado com sucesso.";
        }

        public List<Entrada> ObterEntradas()
        {
            return registos.OrderByDescending(j => j.DataHora).ToList();
        }

    }
}
