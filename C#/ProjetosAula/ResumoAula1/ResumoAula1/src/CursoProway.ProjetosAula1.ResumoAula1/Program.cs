using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula1.ResumoAula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario;
            int idadeUsuario;

            Console.WriteLine("Olá. Informe seu nome:");
            nomeUsuario = Console.ReadLine();

            Console.WriteLine("Informe sua idade:");
            var entradaUsuario = Console.ReadLine();
            idadeUsuario = (entradaUsuario == null) ? 0 : int.Parse(entradaUsuario);

            Console.WriteLine($"Olá, {nomeUsuario}! Sua idade é {idadeUsuario}");

            var end = Console.ReadLine();   
        }
    }
}
