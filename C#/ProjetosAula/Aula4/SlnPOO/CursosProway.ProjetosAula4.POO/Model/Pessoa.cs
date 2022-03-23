using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Model
{
    public class Pessoa
    {
        private string nome;
        public int Idade { get; set; }

        public Pessoa(string nomeC, int idadeC)
        {
            InsereNome(nomeC);
            Idade = idadeC;
        }

        public Pessoa() { }

        public string ExibeNome()
        {
            return $"Meu nome é {nome}";
        }

        public void InsereNome(string nomeInsert)
        {
            nome = nomeInsert;
        }
    }
}
