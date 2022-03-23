using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetosAula.Exercicios.Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio5();

            Console.WriteLine("\nPressione qualquer tecla para sair!");
            var tmp = Console.ReadLine();
        }

        static void Exercicio5()
        {
            int valor1, valor2;
            string tmp;

            Console.WriteLine("Informe o valor 1:");
            tmp = Console.ReadLine();
            valor1 = (tmp == null) ? 0 : Convert.ToInt32(tmp);

            Console.WriteLine("Informe o valor 2:");
            tmp = Console.ReadLine();
            valor2 = (tmp == null) ? 0 : Convert.ToInt32(tmp);

            if(valor1 > valor2)
            {
                Console.WriteLine("Valor 1 é maior: " + valor1);
            } else if(valor2 > valor1)
            {
                Console.WriteLine("Valor 2 é maior: " + valor2);
            } else
            {
                Console.WriteLine("Os valor são iguais.");
            }
        }

        static void Exercicio4()
        {
            /*2.	Faça um programa que receba 4 valores e retorne o menor entre eles ;*/
            
            Console.WriteLine("Exercício 4");
            //Declaração de Variáveis
            int valor1, valor2, valor3, valor4, menorValor = 99999999;
            string tmp;

            //Entrada de Valores
            //Valor 1
            Console.WriteLine("Informe o Valor 1:");
            tmp = Console.ReadLine();
            valor1 = tmp == null ? 0 : int.Parse(tmp);
            tmp = null;

            //Valor 2
            Console.WriteLine("Informe o Valor 2:");
            tmp = Console.ReadLine();
            valor2 = tmp == null ? 0 : int.Parse(tmp);
            tmp = null;

            //Valor 3
            Console.WriteLine("Informe o Valor 3:");
            tmp = Console.ReadLine();
            valor3 = tmp == null ? 0 : int.Parse(tmp);
            tmp = null;

            //Valor 4
            Console.WriteLine("Informe o Valor 4:");
            tmp = Console.ReadLine();
            valor4 = tmp == null ? 0 : int.Parse(tmp);
            tmp = null;

            // Verificação dos valores
            if(valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if(valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine("Menor Valor é: " + menorValor);
        }

        static void Exercicio3()
        {
            Console.WriteLine("Exercício 3\n");
            //Declaração de variáveis
            string nomeUsuario1, nomeUsuario2;
            int idadeUsuario1, idadeUsuario2;

            //--- Entrada de Dados

            //- Usuário 1
            Console.WriteLine("Usuário 1, favor informar o nome");
            nomeUsuario1 = Console.ReadLine();

            Console.WriteLine("Usuário 1, favor informar a idade");
            var tmp1 = Console.ReadLine();
            idadeUsuario1 = (tmp1 == null) ? 0 : int.Parse(tmp1);

            //- Usuário 2
            Console.WriteLine("Usuário 2, favor informar o nome");
            nomeUsuario2 = Console.ReadLine();

            Console.WriteLine("Usuário 2, favor informar a idade");
            var tmp2 = Console.ReadLine();
            idadeUsuario2 = (tmp2 == null) ? 0 : int.Parse(tmp2);


            //Saída de Dados
            if(idadeUsuario1 > idadeUsuario2)
            {
                Console.WriteLine("\n----- Usuário 1");
                Console.WriteLine("--- Nome: " + nomeUsuario1);
                Console.WriteLine("--- Idade: " + idadeUsuario1);
                Console.WriteLine("---------------\n");

                Console.WriteLine("\n----- Usuário 2");
                Console.WriteLine("--- Nome: " + nomeUsuario2);
                Console.WriteLine("--- Idade: " + idadeUsuario2);
                Console.WriteLine("---------------\n");
            } else if(idadeUsuario2 > idadeUsuario1)
            {
                Console.WriteLine("\n----- Usuário 2");
                Console.WriteLine("--- Nome: " + nomeUsuario2);
                Console.WriteLine("--- Idade: " + idadeUsuario2);
                Console.WriteLine("---------------\n");

                Console.WriteLine("\n----- Usuário 1");
                Console.WriteLine("--- Nome: " + nomeUsuario1);
                Console.WriteLine("--- Idade: " + idadeUsuario1);
                Console.WriteLine("---------------\n");
            } else
            {
                Console.WriteLine("\n----- Usuário 1");
                Console.WriteLine("--- Nome: " + nomeUsuario1);
                Console.WriteLine("--- Idade: " + idadeUsuario1);
                Console.WriteLine("---------------\n");

                Console.WriteLine("\n----- Usuário 2");
                Console.WriteLine("--- Nome: " + nomeUsuario2);
                Console.WriteLine("--- Idade: " + idadeUsuario2);
                Console.WriteLine("---------------\n");
            }
        }

        static void Exercicio2()
        {
            int idade1, idade2;

            Console.WriteLine("Informe a primeira Idade:");
            var tmp1 = Console.ReadLine();
            idade1 = (tmp1 == null) ? 0 : int.Parse(tmp1);

            Console.WriteLine("Informe a segunda Idade:");
            var tmp2 = Console.ReadLine();
            idade2 = (tmp2 == null) ? 0 : int.Parse(tmp2);

            if(idade1 > idade2)
            {
                Console.WriteLine("A primeira idade é maior!");
            } else if(idade2 > idade1)
            {
                Console.WriteLine("A segunda idade é maior!");
            } else
            {
                Console.WriteLine("As idades são iguais!");
            }
        }

        static void Exercicio1()
        {
            string nome, cidade;
            int idade;

            Console.WriteLine("Favor, informe seu nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Favor, informe sua idade:");
            var tmpIdade = Console.ReadLine();
            idade = (tmpIdade == null) ? 0 : int.Parse(tmpIdade);

            Console.WriteLine("Favor, informar sua cidade:");
            cidade = Console.ReadLine();

            Console.WriteLine("\nSeja bem-vindo, sr(a) " + nome + "!");
            Console.WriteLine("\n----- Seus dados ------");
            Console.WriteLine("Idade: " + idade.ToString() + "\n Cidade: " + cidade);
        }
    }
}
