using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNGMTTNanoTracker.Repositorio
{
    public class ResultadoModel
    {
        public int TorneioID { get; set; }
        public string Tempo { get; set; }
        public System.DateTime Inicio { get; set; }
        public string Mesa { get; set; }
        public string Jogadores { get; set; }
        public decimal BuyInRake { get; set; }
        public int Posicao { get; set; }
        public decimal Winning { get; set; }
        public int ResultadoID { get; set; }
    }
}
