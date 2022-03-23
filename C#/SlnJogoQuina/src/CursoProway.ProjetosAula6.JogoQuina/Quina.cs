using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula6.JogoQuina
{
    public class Quina
    {
        public int[] NumerosQuina { get; set; }
        public enum Opcao { S, N };

        public Quina()
        {
            NumerosQuina = new int[5];
        }

        public void RodarGame()
        {
            var jogar = true;

            while (jogar)
            {
                Console.WriteLine("Iniciar Jogo? (S)");
                var opcao = Console.ReadLine().ToUpper();

                if (!opcao.Equals("S"))
                {
                    jogar = false;
                } else
                {
                    Console.Clear();
                    GerarNumeros();
                    var player = new Player();
                    
                    Console.WriteLine("Informe seu nome");
                    player.Nome = Console.ReadLine();


                    player.EscolheNumeros();

                    var pontuacao = CalcularPontuacao(player.NumerosPlayer);

                    Console.WriteLine($"Pontuação do Player {player.Nome}: {pontuacao} pontos!!");
                    Console.WriteLine("\n\n ##### Fim da Partida ##### \n\n");
                }
            }
        }
        public void GerarNumeros()
        {
            var rdm = new Random();
            for (int i = 0; i < 5; i++)
            {
                NumerosQuina[i] = rdm.Next(1, 25);
            }
            Console.WriteLine("Números Gerados Com Sucesso!");
        }

        public void ExibeNumerosQuina()
        {
            Console.WriteLine("Números Gerados Para Quina:");
            for (int i = 0;i < 5; i++)
            {
                Console.Write($"{NumerosQuina[i]} | ");
            }
        }
        public int CalcularPontuacao(int[] numerosPlayer)
        {
            int[] pontuacao = { 0, 1, 3, 10, 50, 100};
            int acertos = 0;
            ExibeNumerosQuina(); 
            for (int i = 0;i < 5; i++)
            {
                for(int j = 0;j < 5; j++)
                {
                    if (numerosPlayer[i] == NumerosQuina[j])
                    {
                        acertos++;
                    }
                }
            }

            return pontuacao[acertos];
        }
    }
}
