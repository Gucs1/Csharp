using CursoProway.ProjetosAula5.Aula4OOP.Enum;
using CursoProway.ProjetosAula5.Aula4OOP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoProway.ProjetosAula5.Aula4OOP.Classes
{
    public class GenericGame : IGame
    {
        public StatusGameEnum GetStatusGame()
        {
            return StatusGameEnum.RODANDO;
        }

        public void StartGame()
        {
            Console.WriteLine("\n");
        }
    }
}
