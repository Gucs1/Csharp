using CursoProway.ProjetosAula5.Aula4OOP.Classes;
using CursoProway.ProjetosAula5.Aula4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula5.Aula5OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPlayer player, npc;
            IGame game;
            bool controlaPrograma = true;
            string opcao;

            while (controlaPrograma)
            {
                ExibeMenu();
                opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        game = new SevenGame();
                        break;
                    case "2":
                        game = new TargetGame();
                        break;
                    case "0":
                        game = new GenericGame();
                        controlaPrograma = false;
                        break;
                    case "L":
                        game = new GenericGame();
                        Console.Clear();
                        break;
                    default:
                        game = new GenericGame();
                        break;
                }

                game.StartGame();
            }
        }

        static void ExibeMenu()
        {
            Console.Clear();
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1 - Seven Game");
            Console.WriteLine("2 - Target Game");
            Console.WriteLine("L - Limpar");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha o Jogo Desejado");
        }
    }
}
