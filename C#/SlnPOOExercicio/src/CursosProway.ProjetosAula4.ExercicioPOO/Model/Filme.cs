using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.ExercicioPOO.Model
{
    public class Filme
    {
        public string Titulo { get; set; }
        public int Classificacao { get; set; }
        public int Duracao { get; set; }

        public string ExibeInformacoesFilme()
        {
            return $"Título: {Titulo}. Classificacao: {Classificacao}. Duração: {Duracao}";
        }
    }
}
