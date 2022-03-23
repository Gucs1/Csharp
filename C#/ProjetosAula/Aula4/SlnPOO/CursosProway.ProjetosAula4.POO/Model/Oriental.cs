using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Model
{
    internal class Oriental : PessoaAbstract
    {
        public Oriental(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
            Etnia = "Oriental";
        }
    }
}
