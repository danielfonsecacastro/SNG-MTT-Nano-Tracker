using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class GerenciadorDeArquivos : SNGMTTNanoTracker.Dominio.IGerenciadorDeArquivos
    {
        public void MoverArquivoParaLido(string caminho)
        {
            var path = Path.GetDirectoryName(caminho);
            var nomeArquivo = Path.GetFileName(caminho);
            var pastaArquivosLido = Path.Combine(path, "Lidos");

            if (!Directory.Exists(pastaArquivosLido))
            {
                Directory.CreateDirectory(pastaArquivosLido);
            }

            File.Copy(caminho, Path.Combine(pastaArquivosLido, nomeArquivo));
            File.Delete(caminho);
        }
    }
}
