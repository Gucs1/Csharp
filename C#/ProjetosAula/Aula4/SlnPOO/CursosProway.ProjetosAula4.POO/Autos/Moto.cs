using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Autos
{
    public class Moto : Automovel
    {
        public bool CapaceteIntegrado { get; set; }
        public Moto()
        {
            Tipo = "Veículo automotivo de 2 rodas";
            QtdeRodas = 2;
        }

        public void Andar()
        {
            if (CapaceteIntegrado)
            {
                Console.WriteLine("Moto está andando...");
            } else
            {
                Console.WriteLine("Coloque o capacete para poder andar");
            }
        }
    }
}
