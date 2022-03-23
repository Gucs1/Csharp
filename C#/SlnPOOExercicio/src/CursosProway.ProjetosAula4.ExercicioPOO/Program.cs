using CursosProway.ProjetosAula4.ExercicioPOO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.ExercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Filme> ListaFilmes = new List<Filme>();
            bool controlaPrograma = true;

            while(controlaPrograma)
            {
                Console.WriteLine("L - Listar");
                Console.WriteLine("I - Inserir");
                Console.WriteLine("S - Sair");

                var opcao = Console.ReadLine();

                if (opcao.ToUpper() == "I")
                {
                    Filme filme = new Filme();

                    Console.WriteLine("Informe o Título:");
                    filme.Titulo = Console.ReadLine();

                    Console.WriteLine("Informe a Classificação Indicativa");
                    filme.Classificacao = int.Parse(Console.ReadLine());

                    Console.WriteLine("Informe a Duração");
                    filme.Duracao = int.Parse(Console.ReadLine());

                    ListaFilmes.Add(filme);
                }
                else if(opcao.ToUpper() == "L")
                {
                    foreach (Filme filme in ListaFilmes)
                    {
                        Console.WriteLine(filme.ExibeInformacoesFilme());
                    }
                } else
                {
                    controlaPrograma=false;
                }

            }
            
        }
    }
}
