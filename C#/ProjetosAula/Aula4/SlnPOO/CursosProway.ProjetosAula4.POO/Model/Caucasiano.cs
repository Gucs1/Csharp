using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Model
{
    public class Caucasiano : PessoaAbstract
    {
        public Caucasiano(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Etnia = "Caucasiano";
        }
    }
}
