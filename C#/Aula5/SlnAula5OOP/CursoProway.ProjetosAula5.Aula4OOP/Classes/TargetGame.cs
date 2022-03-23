using CursoProway.ProjetosAula5.Aula4OOP.Enum;
using CursoProway.ProjetosAula5.Aula4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula5.Aula4OOP.Classes
{
    public class TargetGame : IGame
    {
        public StatusGameEnum Status { get; set; }
        public StatusGameEnum GetStatusGame()
        {
            return Status;
        }

        public void StartGame()
        {
            Console.WriteLine("Iniciando TargetGame");
            Status = StatusGameEnum.RODANDO;
            string opcao;
            bool controlaGame = true;

            while (controlaGame)
            {
                Console.WriteLine("Deseja iniciar nova partida? (S)");
                opcao = Console.ReadLine().ToUpper();

                if(opcao == "S")
                {
                    GameLoop();
                } else
                {
                    controlaGame = false;
                    Status = StatusGameEnum.PARADO;
                }
            }
        }

        public void GameLoop()
        {
            int numeroAleatorio, numeroPlayer, chances = 3, cont = 0;
            var random = new Random();
            numeroAleatorio = random.Next(1,10);
            while (cont < chances)
            {
                Console.WriteLine($"Chance {cont}/{chances}");
                numeroPlayer = int.Parse(Console.ReadLine());

                if(numeroPlayer == numeroAleatorio)
                {
                    Console.WriteLine("Parabéns, você ganhou!");
                    Console.WriteLine($"Número Aleatório: {numeroAleatorio}");
                    cont = 100;
                } else
                {
                    cont++;
                    if(cont == chances)
                    {
                        Console.WriteLine("Você perdeu! Comece um novo jogo.");
                    } else
                    {
                        Console.WriteLine("Você errou! Tente novamente.");
                    }
                }

            }
        }
    }
}
