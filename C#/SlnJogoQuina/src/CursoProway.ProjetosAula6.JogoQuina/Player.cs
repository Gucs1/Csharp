using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula6.JogoQuina
{
    public class Player
    {
        public string Nome { get; set; }
        public int[] NumerosPlayer { get; set; }

        public Player()
        {
            NumerosPlayer = new int[5];
        }

        public void EscolheNumeros()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Escolha um número. [{i + 1}/5]");
                var numStr = Console.ReadLine() ?? "0";
                NumerosPlayer[i] = int.Parse(numStr);
            }
            Console.WriteLine("Números escolhidos");
        }
    }
}
