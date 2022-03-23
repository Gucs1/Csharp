using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula2.ExercicioAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercícios Aula 2.\n");
            Console.WriteLine("Escolha a opção desejada:");
            Console.WriteLine("01 - Exercício 1");
            Console.WriteLine("02 - Exercício 2");
            Console.WriteLine("03 - Exercício 3");
            Console.WriteLine("04 - Exercício 4");
            Console.WriteLine("05 - Exercício 5");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "01":
                    Exercicio1();
                    break;

                case "02":
                    Exercicio2();
                    break;

                case "03":
                    Exercicio3();
                    break;

                case "04":
                    Exercicio4();
                    break;

                case "05":
                    Exercicio5();
                    break;

                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        static void Exercicio1()
        {
            Console.WriteLine("Exercício 1\n");
            string nome, cidade;

            Console.WriteLine("Informe seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine($"Nome: {nome}.\nCidade: {cidade}");

            var ul = Console.ReadLine();
        }

        static void Exercicio2()
        {
            Console.WriteLine("Exercício 2\n");
            int numero, numeroExibicao;

            Console.WriteLine("Informe um número:");
            var entradaDados = Console.ReadLine();
            numero = (entradaDados == null) ? 0 : Convert.ToInt32(entradaDados);
            numeroExibicao = numero + 100;

            Console.WriteLine($"Resultado de {numero} + 100 = {numeroExibicao}");

            var ul = Console.ReadLine();
        }

        static void Exercicio3()
        {
            Console.WriteLine("Exercício 3\n");
            int numeroAleatorio;

            Console.WriteLine("Gerando número aleatório...");
            var random = new Random();
            numeroAleatorio = random.Next(100);

            Console.WriteLine($"Número gerado foi: {numeroAleatorio}");

            var ul = Console.ReadLine();
        }

        static void Exercicio4()
        {
            Console.WriteLine("Exercício 4\n");
            int valor1, valor2;

            Console.WriteLine("Informe o primeiro valor:");
            var tmpValor1 = Console.ReadLine();
            valor1 = (tmpValor1 == null) ? 0 : Convert.ToInt32(tmpValor1);

            Console.WriteLine("Informe o segundo valor:");
            var tmpValor2 = Console.ReadLine();
            valor2 = (tmpValor2 == null) ? 0 : Convert.ToInt32(tmpValor2);

            Console.WriteLine("\n------------------------\n");

            if(valor1 > valor2)
            {
                Console.WriteLine("Valor 1 é maior.");
            } else if(valor2 > valor1)
            {
                Console.WriteLine("Valor 2 é maior.");
            } else
            {
                Console.WriteLine("Valores iguais.");
            }

            var ul = Console.ReadLine();
        }

        static void Exercicio5()
        {
            Console.WriteLine("Exercício 5\n");

            var ul = Console.ReadLine();
        }
    }
}
