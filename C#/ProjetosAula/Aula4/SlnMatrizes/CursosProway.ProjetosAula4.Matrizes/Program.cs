using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesList = new List<string>();
            bool controlador = true;

            while (controlador)
            {
                Console.WriteLine("Informe um nome:");
                var entradaDados = Console.ReadLine();

                nomesList.Add(entradaDados);

                Console.WriteLine("Para inserir outro nome, digite S");
                var entradaContinuar = Console.ReadLine();

                if(entradaContinuar.ToUpper() != "S")
                {
                    controlador = false;
                }
            }

            Console.WriteLine("Nomes na Lista:");

            foreach(string nome in nomesList)
            {
                Console.Write($"{nome} | ");
            }

        }

        static void Matriz1()
        {
            int[,] matNotasAlunos = new int[20, 4];
            var rdm = new Random();

            for (int l = 0; l < 20; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    matNotasAlunos[l, c] = rdm.Next(5, 10);
                }
            }

            for (int l = 0; l < 20; l++)
            {
                Console.WriteLine("");
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{matNotasAlunos[l, c]} |");
                }
            }
        }
    }
}
