using System;
using System.Collections.Generic;

namespace UC000608.Models

{
    public class Presenca
    {
        public int Id { get; private set; }

        // Relação com Aula
        public int AulaId { get; set; }
        public Aula Aula { get; set; }

        // Lista de membros presentes
        public List<Membro> Membros { get; private set; }

        // Construtor
        public Presenca(int id)
        {
            Id = id;
            Membros = new List<Membro>();
        }

        // Métodos (comportamento)
        public void AdicionarMembro(Membro membro)
        {
            if (!Membros.Contains(membro))
            {
                Membros.Add(membro);
            }
        }

        public void RemoverMembro(Membro membro)
        {
            if (Membros.Contains(membro))
            {
                Membros.Remove(membro);
            }
        }
    }
}
