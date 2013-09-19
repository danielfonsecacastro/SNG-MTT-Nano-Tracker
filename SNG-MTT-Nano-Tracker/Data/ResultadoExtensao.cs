using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNGMTTNanoTracker.Data
{
    public partial class Resultados
    {
        public string Tempo { get { var tempo = Fim.Subtract(Inicio); return String.Format("{0:00}:{1:00}:{2:00}", tempo.Hours, tempo.Minutes, tempo.Seconds); } }
    }
}
