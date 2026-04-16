using System;

namespace UC000608.Models
{
    public class InscricaoPlanoTreino
    {
        // Encapsulamento (get/set)
        public int Id { get; private set; }

        public DateTime DtInicio { get; private set; }
        public DateTime? DtFim { get; private set; }

        public string Estado { get; private set; }

        // Relações entre classes
        public int MembroId { get; set; }
        public Membro Membro { get; set; }

        public int PlanoTreinoId { get; set; }
        public PlanoTreino PlanoTreino { get; set; }

        public int TreinadorId { get; set; }
        public Treinador Treinador { get; set; }

        // Construtor
        //public Inscricao(int id, DateTime dtInicio, string estado)
        //{
           // Id = id;
           // DtInicio = dtInicio;
           // Estado = estado;
        //}

        // Métodos (comportamento)
        public void FinalizarInscricao(DateTime dtFim)
        {
            DtFim = dtFim;
            Estado = "Finalizada";
        }

        public void Cancelar()
        {
            Estado = "Cancelada";
            DtFim = DateTime.Now;
        }

        public void Ativar()
        {
            Estado = "Ativa";
            DtFim = null;
        }

    }
}
