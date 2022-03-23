using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursosProway.ProjetosAula4.POO.Autos
{
    public class Automovel
    {
        public string Tipo { get; set; }
        public int QtdeRodas { get; set; }
        public int LimiteVelocidade { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }

        public string GetInformacoes()
        {
            var retorno = $"----------- Tipo: {Tipo} ---------------\n";
            retorno += $"Marca/Modelo: {Marca}/{Nome}\n";
            retorno += $"Quantidade Rodas: {QtdeRodas}\n";
            retorno += $"Velocidade Máxima: {LimiteVelocidade}";

            return retorno;
        }
    }
}
