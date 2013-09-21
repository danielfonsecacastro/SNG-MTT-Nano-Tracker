using SNGMTTNanoTracker.Data;
using SNGMTTNanoTracker.Properties;
using SNGMTTNanoTracker.Repositorio;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class GerenciadorDeResultados
    {
        public GerenciadorDeResultados(IResultadoRepositorio resultadoRepositorio, IGerenciadorDeArquivos gerenciadorDeArquvos)
        {
            _resultadoRepositorio = resultadoRepositorio;
            _gerenciadorDeArquvos = gerenciadorDeArquvos;
        }

        private IResultadoRepositorio _resultadoRepositorio;
        private IGerenciadorDeArquivos _gerenciadorDeArquvos;
        
        public void SalvarResultado(string caminho)
        {
            Mesa mesa = new Mesa();
            var arquivo = Path.GetFileNameWithoutExtension(caminho);
            mesa.LerMaoes(caminho);

            var ultimaMao = mesa.Maoes.OrderBy(por => por.Data).Last();
            var primeiraMao = mesa.Maoes.OrderBy(por => por.Data).First();
            var arquivoSalvo = false;
            foreach (var linha in ultimaMao.Linhas)
            {
                if (linha.IndexOf(Configuracoes.Jogador + " wins", StringComparison.CurrentCultureIgnoreCase) >= 0 || linha.IndexOf(Configuracoes.Jogador + " finished", StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    SalvarResultado(caminho, arquivo, ultimaMao, primeiraMao, linha);
                    arquivoSalvo = true;
                }
            }

            if (arquivoSalvo == false && ultimaMao.Data < DateTime.Now.AddMinutes(-8))
            {
                SalvarResultado(caminho, arquivo, ultimaMao, primeiraMao, null);
            }
        }

        private void SalvarResultado(string caminho, string arquivo, Mao ultimaMao, Mao primeiraMao, string linha)
        {
            var resultado = new Resultados();

            var itensArquivo = arquivo.Split(' ');
            resultado.TorneioID = Convert.ToInt32(itensArquivo[1].Replace("T", ""));

            foreach (var item in itensArquivo)
            {
                if (item.StartsWith("$"))
                    resultado.BuyInRake += Convert.ToDecimal(item.Replace("$", "").Replace(".", ","));
            }

            if (_resultadoRepositorio.ObterResultadoPorTorneioId(resultado.TorneioID) == null && resultado.BuyInRake > 0)
            {
                if (!String.IsNullOrEmpty(linha))
                {
                    if (linha.IndexOf(Configuracoes.Jogador + " wins", StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        resultado.Posicao = 1;
                    }
                    else
                    {
                        var posicao = linha.Substring(linha.LastIndexOf(" in ") + 3).Trim();
                        posicao = posicao.Substring(0, posicao.IndexOf(" ")).Trim();
                        posicao = posicao.Replace("th", "").Replace("rd", "").Replace("nd", "").Replace("st", "").Trim();

                        resultado.Posicao = Convert.ToInt32(posicao);
                    }

                    if (linha.Contains("$"))
                    {
                        var valor = "";
                        if (linha.IndexOf(Configuracoes.Jogador + " wins",  StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            valor = linha.Substring(linha.IndexOf("$") + 1);
                            valor = valor.Substring(0, valor.IndexOf(" ")).Trim();
                        }
                        else
                        {
                            valor = linha.Substring(linha.IndexOf("$") + 1);
                            valor = valor.Substring(0, valor.LastIndexOf("."));
                        }

                        valor = valor.Replace(".", ",");
                        resultado.Winning = Convert.ToDecimal(valor);
                    }
                }

                for (int i = 2; i < itensArquivo.Length; i++)
                    resultado.Mesa += itensArquivo[i] + " ";

                resultado.Mesa = resultado.Mesa.Trim();
                resultado.Fim = ExtrairDataEhHora(ultimaMao.Linhas[0]);
                resultado.Inicio = ExtrairDataEhHora(primeiraMao.Linhas[0]);
                resultado.Jogadores = BuscarQuantidadeDeJogadores(resultado.TorneioID);


                _resultadoRepositorio.Novo(resultado);
                _gerenciadorDeArquvos.MoverArquivoParaLido(caminho);
            }
        }

        private string BuscarQuantidadeDeJogadores(int torneioId)
        {
            foreach (var item in Directory.GetFiles(Configuracoes.PathTournSummary, "*.txt"))
            {
                if (item.Contains(String.Format("T{0}", torneioId)))
                {

                    using (StreamReader reader = new StreamReader(item))
                    {
                        var linhaComQuantidadeDeJogadores = "";
                        for (int i = 0; i < 3; i++)
                        {
                            linhaComQuantidadeDeJogadores = reader.ReadLine();
                        }
                        reader.Close();
                        reader.Dispose();

                        _gerenciadorDeArquvos.MoverArquivoParaLido(item);

                        return linhaComQuantidadeDeJogadores;
                    }

                }
            }

            return "-";
        }

        private DateTime ExtrairDataEhHora(string linha)
        {
            var itens = linha.Split('-');
            var valoresDatas = itens[2].Trim().Split(' ');

            return Convert.ToDateTime(valoresDatas[0] + " " + valoresDatas[1]);
        }
    }
}
