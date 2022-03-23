using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula2.PrjAula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario1, nomeUsuario2;
            bool permissaoUsuario1, permissaoUsuario2;
            int opcao, idadeUsuario1, idadeUsuario2, opUsuario1, opUsuario2;
            double saldoUsuario1, saldoUsuario2;

            Console.WriteLine("Bem vindo ao jogo 'Advinha'!");

            /* Dados Usuario 1 */
            Console.WriteLine("Informe seu nickname/nome:");
            nomeUsuario1 = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            var entradaDados = Console.ReadLine();
            idadeUsuario1 = (entradaDados == null) ? 0 : int.Parse(entradaDados);

            /* Dados Usuario 2 */
            nomeUsuario2 = "[NPC] Carlos";
            idadeUsuario2 = 20;

            //saldoUsuario1 = saldoUsuario2 = 10;
            saldoUsuario1 = 10;
            saldoUsuario2 = 10;

            /* Verificação de Idade
             * - Usuario deve ter mais que 15 anos
             * - Caso não, encerra o game com uma
             * mensagem de restrição de idade
             */

            Console.WriteLine("... verificando a idade dos jogadores...");

            if(idadeUsuario1 < 15)
            {
                permissaoUsuario1 = false;
            }
            else
            {
                permissaoUsuario1 = true;
            }

            if(idadeUsuario2 < 15)
            {
                permissaoUsuario2 = false;
            }
            else
            {
                permissaoUsuario2 = true;
            }

            if(permissaoUsuario1 &&
               permissaoUsuario2)
            {
                //# - Game
                Console.WriteLine("Começando o jogo...");

                Console.WriteLine("Ecolha um número entre 1 e 10:");
                var opt1 = Console.ReadLine();
                opUsuario1 = (opt1 == null) ? 0 : int.Parse(opt1);

                var random = new Random();
                opcao = random.Next(9) + 1;

                opUsuario2 = random.Next(9) + 1;

                //Validando números escolhidos
                saldoUsuario1 = saldoUsuario1 - Math.Abs(opcao - opUsuario1);
                saldoUsuario2 = saldoUsuario2 - Math.Abs(opcao - opUsuario2);

                Console.WriteLine("\nComputando pontuações!");

                //Exibir Informações Jogador 1 e 2
                Console.WriteLine($"\n--- Jogador 1: {nomeUsuario1}");
                Console.WriteLine($"--- Idade: {idadeUsuario1}");
                Console.WriteLine($"--- Pontuação: {saldoUsuario1}");

                Console.WriteLine("\n------------------------------\n");

                Console.WriteLine($"--- Jogador 2: {nomeUsuario2}");
                Console.WriteLine($"--- Idade: {idadeUsuario2}");
                Console.WriteLine($"--- Pontuação: {saldoUsuario2}\n");

                //Apresentar vencedor
                if(opcao == opUsuario1)
                {
                    Console.WriteLine("Jogador 1 acertou!");
                }
                if(opcao == opUsuario2)
                {
                    Console.WriteLine("Jogador 2 acertou!");
                }

                if(saldoUsuario1 > saldoUsuario2)
                {
                    Console.WriteLine("O Jogador 1 venceu!");
                } else if(saldoUsuario2 > saldoUsuario1) {
                    Console.WriteLine("O Jogador 2 venceu!");
                } else
                {
                    Console.WriteLine("Jogo empatou!");
                }

                Console.WriteLine("\n-----------------------------");
                Console.WriteLine($"Número escolhido: {opcao}");
                Console.WriteLine($"Número escolhido por Jogador 1 - {nomeUsuario1}: {opUsuario1}");
                Console.WriteLine($"Número escolhido por Jogador 2 - {nomeUsuario2}: {opUsuario2}");
                Console.WriteLine("-----------------------------");
            }
            else
            {
                Console.WriteLine("Usuário(s) com idade menor que 15 anos");
            }

            var ul = Console.ReadLine();
        }
    }
}
