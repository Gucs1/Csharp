using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula3.Repeticao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int SAIR = 0;
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma das opções abaixo:");
                Console.WriteLine("1 - Exemplo1");
                Console.WriteLine("2 - Exemplo2");
                Console.WriteLine("3 - Exemplo3");
                Console.WriteLine("4 - Exemplo4");
                Console.WriteLine("5 - Exemplo5");
                Console.WriteLine("6 - Exemplo6");
                Console.WriteLine("7 - Exemplo7");                
                Console.WriteLine("8 - Exemplo8");                
                Console.WriteLine("9 - Exemplo8");                
                Console.WriteLine("\n0 - SAIR");

                var entDados = Console.ReadLine();
                opcao = entDados != null ? int.Parse(entDados) : SAIR;

                switch (opcao)
                {
                    case SAIR:
                        break;
                    case 1:
                        Exemplo1();
                        break;
                    case 2:
                        Exemplo2();
                        break;
                    case 3:
                        Exemplo3();
                        break;
                    case 4:
                        Exemplo4();
                        break;
                    case 5:
                        Exemplo5();
                        break;
                    case 6:
                        Exemplo6();
                        break;
                    case 7:
                        Exemplo7();
                        break;
                    case 8:
                        Exemplo8();
                        break;
                    case 9:
                        Exemplo9();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Escolha novamente.");
                        break;
                }
                var x = Console.ReadLine();
            } while (opcao != SAIR);
            
        }

        static void Exemplo9()
        {
            for (int i = 1000; i < 2000; i++)
            {
                if(i % 11 == 5)
                {
                    Console.WriteLine($"Resto da divisão {i}/11 = 5");
                }
            }
        }

        static void Exemplo8()
        {
            string appValoresLadoaLado = "|";

            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i < 21; i++)
            {
                appValoresLadoaLado += $" {i} |";
            }

            Console.WriteLine(appValoresLadoaLado);
        }

        static void Exemplo7()
        {
            int numeroAlunos = 20;
            int[] notasAlunos = new int[20];
            double mediaTurma = 0, somaTurma = 0;
            var random = new Random();
            string notasTurma = "|";

            Console.WriteLine("Informe as notas dos alunos:");

            for (int i = 0; i < numeroAlunos; i++)
            {
                notasAlunos[i] = random.Next(5, 10);
                notasTurma += $" {notasAlunos[i]} |";
            }

            Console.WriteLine($"{notasTurma} \n");

            for (int i = 0; i < numeroAlunos; i++)
            {
                somaTurma += notasAlunos[i];
            }

            mediaTurma = somaTurma / numeroAlunos;

            Console.WriteLine($"Média da Turma {mediaTurma}");
        }

        static void Exemplo6()
        {
            int index = 1;
            string appValorI = "|", appValorP = "|";

            while (index <= 10)
            {
                if (index % 2 == 0)
                {
                    appValorP += $" {index} |";
                }
                else
                if (index % 2 != 0)
                {
                    appValorI += $" {index} |";
                }
                index++;
            }


            Console.WriteLine(appValorP + "\n");
            Console.WriteLine(appValorI);
        }

        static void Exemplo5()
        {
            int[] arrNumeros = new int[10];
            int menorValor = 99999, index = 0;
            var random = new Random();

            while (index < 10)
            {
                arrNumeros[index] = random.Next(1000);
                index++;
            }

            Console.WriteLine("Valores Gerados com Sucesso\n");

            index = 0;
            string apresentaValor = "|";
            while (index < 10)
            {
                apresentaValor += $" {arrNumeros[index]} |";
                index++;
            }
            Console.WriteLine(apresentaValor);

            index = 0;

            while (index < 10)
            {
                if (arrNumeros[index] < menorValor)
                {
                    menorValor = arrNumeros[index];
                }
                index++;
            }

            Console.WriteLine($"\n Menor valor é {menorValor}");
        }

        static void Exemplo4()
        {
            int contador = 1;

            while (contador <= 100)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine($"{contador} é par...");
                }
                contador++;
            }
        }

        static void Exemplo3()
        {
            int[] arrNumero = { 12, 20, 5, 18, 34, 56, 41, 76 };
            int index = 0;

            while (index < arrNumero.Length)
            {
                Console.WriteLine($"Posição {index + 1} - Indice {index}: {arrNumero[index]}");
                index++;
            }
        }

        static void Exemplo2()
        {
            int contador = 1;

            while (contador <= 100)
            {
                //var numero = contador - contador/2 * 2;
                var numero = contador % 2;
                if (numero > 0)
                {
                    Console.WriteLine($"{contador} é ímpar.");
                }
                contador++;
            }
        }

        static void Exemplo1()
        {
            int controleUsuario, contador;

            Console.WriteLine("Informe um número para execução do Loop");
            var entradaDados = Console.ReadLine();
            controleUsuario = entradaDados == null ? 0 : int.Parse(entradaDados);

            contador = 0;
            while (contador < controleUsuario)
            {
                Console.WriteLine($"Iteracao {contador + 1}/{controleUsuario}: {contador}.");
                contador++;
            }

            Console.WriteLine("\nIteracao Terminou.");
        }
    }
}
