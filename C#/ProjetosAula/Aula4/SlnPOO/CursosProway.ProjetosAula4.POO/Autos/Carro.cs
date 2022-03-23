using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Autos
{
    public class Carro : Automovel
    {
        public int QtdePortas { get; set; }
        public Carro()
        {
            Tipo = "Veículo Automotivo de 4 rodas";
            QtdeRodas = 4;
        }

        public void MarchaRe()
        {
            Console.WriteLine("O veícula está na Marcha Ré");
        }
    }
}
