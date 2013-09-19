using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class ComboBoxFiltroItens
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public override string ToString()
        {
            return Descricao;
        }
    }
}
