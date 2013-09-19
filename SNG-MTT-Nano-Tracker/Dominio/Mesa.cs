using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class Mesa
    {
        public List<Mao> Maoes { get; set; }
        private const string _quebra = "***Quebra***";

        public void LerMaoes(string caminhoArquivo)
        {
            var arquivo = "";
            using (StreamReader reader = new StreamReader(caminhoArquivo))
            {
                arquivo = reader.ReadToEnd().Trim();
                reader.Close();
                reader.Dispose();
            }

            if (!String.IsNullOrEmpty(arquivo))
            {
                arquivo = arquivo.Replace("\r\n\r\n\r\n", _quebra);
            }

            Maoes = new List<Mao>();

            foreach (var item in arquivo.Split(new string[] { _quebra }, StringSplitOptions.None))
            {
                if (!String.IsNullOrEmpty(item))
                    Maoes.Add(new Mao(item.Trim()));
            }
        }


    }
}
