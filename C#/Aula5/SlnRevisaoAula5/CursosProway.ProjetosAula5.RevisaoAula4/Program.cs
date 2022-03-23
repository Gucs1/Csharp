using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula5.RevisaoAula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Filme> listaFilmes = new List<Filme>();
            bool controlaPrograma = true;
            string opcao;

            while (controlaPrograma)
            {
                Console.WriteLine("\nEscolha a opção:");
                Console.WriteLine("I - Inserir Novo Filme");
                Console.WriteLine("L - Listar Filmes");
                Console.WriteLine("S - Sair\n");

                opcao = Console.ReadLine().ToUpper();

                switch (opcao)
                {
                    case "I":
                        Filme filme = new Filme();
                        Console.WriteLine("Informe um título");
                        filme.Titulo = Console.ReadLine();
                        Console.WriteLine("Informe a classificação (0, 12, 14, 16, 18):");
                        filme.Classificacao = int.Parse(Console.ReadLine());
                        listaFilmes.Add(filme);
                        break;
                    case "L":
                        var cont = 1;
                        foreach(Filme objFilme in listaFilmes)
                        {
                            Console.WriteLine($"{cont} - {objFilme.Titulo} {{Class.: {objFilme.Classificacao}}}");
                            cont++;
                        }
                        break;
                    case "S":
                        controlaPrograma = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção inválida!\n");
                        break;
                }
            }
        }
    }
}
