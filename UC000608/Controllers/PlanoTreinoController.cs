using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using UC000608.Models;

namespace UC000608.Controllers
{
    public class PlanoTreinoController : Controller
    {
     
        // Lista estática de Planos
        private static List<PlanoTreino> planos = new List<PlanoTreino>
        {
            new PlanoTreino
            {
                Id = 1,
                Nome = "Plano Raiz",
                Horario = "2x por semana",
                Capacidade = 12,
                Treinador = "Carlos Treinador",
                TipoDeAula = "Fundamentos"
            },
            new PlanoTreino
            {
                Id = 2,
                Nome = "Plano Impulso",
                Horario = "3x por semana",
                Capacidade = 10,
                Treinador = "Helena Coach",
                TipoDeAula = "Treino Funcional"
            },
            new PlanoTreino
            {
                Id = 3,
                Nome = "Plano Fusão",
                Horario = "4x por semana",
                Capacidade = 8,
                Treinador = "Rui Instrutor",
                TipoDeAula = "Cross Training"
            },
            new PlanoTreino
            {
                Id = 4,
                Nome = "Plano Titan",
                Horario = "5x por semana",
                Capacidade = 6,
                Treinador = "Carlos Treinador",
                TipoDeAula = "Alta Intensidade"
            },
            new PlanoTreino
            {
                Id = 5,
                Nome = "Plano Supernova",
                Horario = "6x por semana",
                Capacidade = 4,
                Treinador = "Helena Coach",
                TipoDeAula = "Performance Máxima"
            }
        };

        public IActionResult Index()
        {
            return View(planos);
        }
    }
}