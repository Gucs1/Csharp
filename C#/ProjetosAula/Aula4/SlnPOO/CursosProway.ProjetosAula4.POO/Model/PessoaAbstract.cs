using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Model
{
    public class PessoaAbstract
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Etnia { get; set; }

        public PessoaAbstract() { }
        public PessoaAbstract(string nome, int idade, string etnia) 
        {
            Nome = nome;
            Idade = idade;
            Etnia = etnia;
        }

        public string GetInformacoes()
        {
            return $"Nome: {Nome}, {Idade} anos. {Etnia}";
        }
    }
}
