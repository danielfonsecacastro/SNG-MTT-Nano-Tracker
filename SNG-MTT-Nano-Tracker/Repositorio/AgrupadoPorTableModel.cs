using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Repositorio
{
    public class AgrupadoPorTableModel
    {
        public string Table { get; set; }
        public decimal QuantidadeMesa { get; set; }
        public decimal QuantidadeITM { get; set; }
        public string PorcentagemITM { get; set; }
        public decimal TotalBuyInRake { get; set; }
        public decimal TotalWinning { get; set; }
        public decimal TotalSaldo { get; set; }
        public string ROI { get; set; }
    }
}
