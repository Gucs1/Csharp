using CursoProway.ProjetosAula5.Aula4OOP.Enum;
using CursoProway.ProjetosAula5.Aula4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula5.Aula4OOP.Classes
{
    public class SevenGame : IGame
    {
        public StatusGameEnum Status { get; set; }
        public StatusGameEnum GetStatusGame()
        {
            return Status;
        }

        public void StartGame()
        {
            Console.WriteLine("Iniciando SevenGame");
            Status = StatusGameEnum.RODANDO;
            string opcao;
            bool controlaGame = true;

            while (controlaGame)
            {
                Console.WriteLine("Deseja iniciar nova partida? (S)");
                opcao = Console.ReadLine().ToUpper();

                if (opcao == "S")
                {
                    Console.Clear();
                    GameLoop();
                }
                else
                {
                    controlaGame = false;
                    Status = StatusGameEnum.PARADO;
                }
            }
        }

        public void GameLoop()
        {
            int[] numerosPlayer = new int[7];
            int[] numerosPC = new int[7];
            var random = new Random();
            for (int i = 0; i < numerosPC.Length; i++)
            {
                numerosPC[i] = random.Next(1, 9);
            }

            for (int i = 0;i < numerosPlayer.Length; i++)
            {
                Console.WriteLine($"Informe um número para { i + 1 }/7 numeros");
                numerosPlayer[i] = int.Parse(Console.ReadLine());
            }

            string exibeNumerosPC = "|";
            string exibeNumerosPlayer = "|";
            for (int i = 0; i < 7; i++)
            {
                exibeNumerosPC += $" {numerosPC[i]} |";
                exibeNumerosPlayer += $" {numerosPlayer[i]} |";
            }

            Console.WriteLine(exibeNumerosPlayer);
            Console.WriteLine(exibeNumerosPC);

            CalculaPontuacoes(numerosPC, numerosPlayer);
        }

        public void CalculaPontuacoes(int[] numerosPC, int[] numerosPlayer)
        {
            int pontosPC = 0, pontosPlayer = 0;
            for(int i = 0; i < 7; i++)
            {
                if(numerosPC[i] > numerosPlayer[i])
                {
                    pontosPC += 2;
                } else if(numerosPlayer[i] > numerosPC[i])
                {
                    pontosPlayer += 2;
                } else if(numerosPC[i] == numerosPlayer[i])
                {
                    pontosPC += 1;
                    pontosPlayer += 1;
                }
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Pontuação Player: {pontosPlayer}");
            Console.WriteLine($"Pontuação PC: {pontosPC}");
            Console.WriteLine("-----------------------------------------------");
        }
    }
}
