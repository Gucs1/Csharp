using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroAleatorio, numeroUsuario, tentativa = 1;
            bool controlador = true;

            Console.WriteLine("Tente adivinhar o número gerado. (1 - 5) \n");
            var rdm = new Random();
            numeroAleatorio = rdm.Next(1, 5);

            while (controlador)
            {
                Console.WriteLine($"Tentativa {tentativa}/2");
                var entradaDados = Console.ReadLine();
                numeroUsuario = entradaDados == null ? 0 : int.Parse(entradaDados);

                if(numeroAleatorio == numeroUsuario)
                {
                    Console.WriteLine($"Parabéns!!! Você acertou. Número {numeroUsuario}");
                    controlador = false;
                } else
                {
                    tentativa++;
                    controlador = true;

                    if(tentativa > 2)
                    {
                        Console.WriteLine("Você perdeu. Tentar de novo? (S)");
                        var entradaTentativa = Console.ReadLine();
                        if(entradaTentativa.ToUpper() == "S")
                        {
                            controlador = true;
                            tentativa = 1;
                            numeroAleatorio = rdm.Next(1, 5);
                        } else
                        {
                            Console.WriteLine("Muito obrigado por jogar! Bye");
                            controlador = false;
                        }
                    }
                }
            }

            
        }

        static void Revisao1()
        {
            int[] notasAluno = new int[4];
            string entradaDados;

            Console.WriteLine("Informe as notas do aluno.\n");

            for (int i = 0; i < notasAluno.Length; i++)
            {
                Console.WriteLine($"Informe a nota da avaliação {i}");
                entradaDados = Console.ReadLine();
                notasAluno[i] = entradaDados == null ? 0 : int.Parse(entradaDados);
            }

            Console.WriteLine("As notas são:");
            for (int i = 0; i < notasAluno.Length; i++)
            {
                Console.Write($"{notasAluno[i]} |");
            }
        }
    }
}
