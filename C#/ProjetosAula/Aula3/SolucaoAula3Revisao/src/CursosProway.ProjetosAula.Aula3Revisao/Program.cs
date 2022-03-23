using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula.Aula3Revisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor, escolha a opção desejada:");
            Console.WriteLine("01 - Questão 1");
            Console.WriteLine("02 - Questão 2");
            Console.WriteLine("03 - Questão 3");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "01":
                    Questao1();
                    break;
                case "02":
                    Questao2();
                    break;
                case "03":
                    Questao3();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }

        static void Questao3()
        {
            Console.WriteLine("Questão 3");
            int valor1, valor2, valor3, valor4, menorValor = 99999;
            string entradaDados;

            Console.WriteLine("Informe o Valor 1");
            entradaDados = Console.ReadLine();
            valor1 = entradaDados != null ? int.Parse(entradaDados) : 0;

            Console.WriteLine("Informe o Valor 2");
            entradaDados = Console.ReadLine();
            valor2 = entradaDados != null ? int.Parse(entradaDados) : 0;

            Console.WriteLine("Informe o Valor 3");
            entradaDados = Console.ReadLine();
            valor3 = entradaDados != null ? int.Parse(entradaDados) : 0;

            Console.WriteLine("Informe o Valor 4");
            entradaDados = Console.ReadLine();
            valor4 = entradaDados != null ? int.Parse(entradaDados) : 0;

            if (valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if(valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if(valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if(valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine($"O menor valor é: {menorValor}");
        }
        static void Questao1()
        {
            string nomeUsuario, loginUsuario;

            Console.WriteLine("Olá, Informe seu nome:");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe o seu Login:");
            loginUsuario = Console.ReadLine();

            Console.WriteLine($"Olá, {nomeUsuario}, seja bem-vindo!");
            Console.WriteLine($"Seu login é {loginUsuario}.");

            var x = Console.ReadLine();
        }

        static void Questao2()
        {
            int numeroUsuario, numeroAleatorio;

            Console.WriteLine("Informe um número entre 0 - 100");
            var stringNumero = Console.ReadLine();
            numeroUsuario = stringNumero != null ? int.Parse(stringNumero) : 0;

            Console.WriteLine("\n Gerando número aleatório... \n");
            var rdm = new Random();
            numeroAleatorio = rdm.Next(100);

            Console.WriteLine($"Número gerado. Número aleatório: {numeroAleatorio}");
            Console.WriteLine($"Seu número: {numeroUsuario} \n");

            if(numeroUsuario > numeroAleatorio)
            {
                Console.WriteLine("Número escolhido pelo usuárío é o maior!");
            } else if(numeroAleatorio > numeroUsuario)
            {
                Console.WriteLine("Número gerado aleatoriamente é o maior!");
            } else
            {
                Console.WriteLine("Números são iguais!");
            }
        }
    }
}
