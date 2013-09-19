using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class Suporte
    {
        public static string ObterNumeroTorneio(string arquivo)
        {
            var itens = arquivo.Split(' ');
            return itens[1];
        }

    }
}
