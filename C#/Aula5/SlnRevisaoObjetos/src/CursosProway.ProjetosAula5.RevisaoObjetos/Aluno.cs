using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula5.RevisaoObjetos
{
    public class Aluno
    {
        public string Nome { get; set; }
        public string Turma { get; set; }
        public List<Nota> Notas { get; set; }

        public Aluno() 
        {
            Notas = new List<Nota>();
        }
        public Aluno(string turma) 
        {
            Turma = turma;
            Notas = new List<Nota>();
        }

    }
}
