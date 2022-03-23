using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula5.RevisaoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> listAluno = new List<Aluno>();
            bool controlaPrograma = true;
            string opcao;

            while (controlaPrograma)
            {
                Console.WriteLine("Escolha uma opção");
                Console.WriteLine("I - Inserir Aluno");
                Console.WriteLine("L - Listar Aluno");
                Console.WriteLine("S - Sair");

                opcao = Console.ReadLine().ToUpper();

                Console.Clear();
                switch (opcao)
                {
                    case "I":
                        Aluno aluno = new Aluno("1AM");
                        Console.WriteLine("Informe o nome do aluno");
                        aluno.Nome = Console.ReadLine();
                        var rdm = new Random();
                        for(int i = 0; i < 4; i++)
                        {
                            Nota nota = new Nota();
                            nota.Avaliacao = $"Avaliação {i + 1}";
                            nota.ValorNota = rdm.Next(5, 10);
                            aluno.Notas.Add(nota);
                        }
                        listAluno.Add(aluno);
                        break;
                    case "L":
                        var count = 1;
                        Console.WriteLine("\n");
                        foreach (Aluno oAluno in listAluno)
                        {
                            Console.WriteLine($"{count} - {oAluno.Nome} ({oAluno.Turma})\n");
                            foreach(Nota oNota in oAluno.Notas)
                            {
                                Console.Write($"{oNota.Avaliacao} - {oNota.ValorNota} | ");
                            }
                            Console.WriteLine("\n------------------------------------------------\n");
                        }
                        break;
                    case "S":
                        controlaPrograma = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }
        }
    }
}
