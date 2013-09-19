using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SNGMTTNanoTracker.Dominio
{
    public class Mao
    {
        public Mao(string conteudo)
        {
            this.Conteudo = conteudo;
            CarregarLinhas();
        }
       
        private void CarregarLinhas()
        {
            if (linhas == null)
            {
                linhas = Conteudo.Split(new string[] { "\r\n" }, StringSplitOptions.None).ToList();
            }
        }

        public string Conteudo { get; private set; }
        public string HandId { get { return GetHandId(); } }
        public bool TemShowDown { get { return VeriricaSeTemShowDown(); } }
        public bool TeveAcao { get { return VeriricaSeTeveAcao(); } }

        private bool VeriricaSeTeveAcao()
        {
            var linhaInicio = 0;
            var linhaFim = 0;
            var boolAchoAcao = false;

            for (int i = 0; i < Linhas.Count; i++)
            {
                if (Linhas[i] == "*** HOLE CARDS ***")
                {
                    linhaInicio = i + 1;
                    boolAchoAcao = true;
                }

                if (Linhas[i] == "*** SUMMARY ***" || Linhas[i] == "*** FLOP ***")
                {
                    linhaFim = i - 1;
                }
            }

            if (boolAchoAcao)
            {
                for (int i = linhaInicio; i <= linhaFim; i++)
                {
                    if (Linhas[i].StartsWith(String.Format("{0}", Configuracoes.Jogador), StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (!Linhas[i].Trim().Equals(String.Format("{0}: folds", Configuracoes.Jogador), StringComparison.CurrentCultureIgnoreCase))
                            return true;
                    }
                }
            }

            return false;
        }

        private List<string> linhas;
        public List<string> Linhas { get { return linhas; } }
        public DateTime Data { get { return CarregarDataDaMao(); } }

        private bool VeriricaSeTemShowDown()
        {
            var linhaInicio = 0;
            var linhaFim = 0;
            var boolAchoInicioShowDown = false;

            for (int i = 0; i < Linhas.Count; i++)
            {
                if (Linhas[i] == "*** SHOW DOWN ***")
                {
                    linhaInicio = i + 1;
                    boolAchoInicioShowDown = true;
                }

                if (Linhas[i] == "*** SUMMARY ***")
                {
                    linhaFim = i - 1;
                }
            }

            if (boolAchoInicioShowDown)
            {
                for (int i = linhaInicio; i <= linhaFim; i++)
                {
                    if (Linhas[i].StartsWith(String.Format("{0}", Configuracoes.Jogador), StringComparison.CurrentCultureIgnoreCase))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private string GetHandId()
        {
            var primeira = ObterLinha(1);
            var resultado = primeira.Substring(primeira.IndexOf("Hand #"));
            resultado = resultado.Substring(6, resultado.IndexOf(":") - 6);

            return resultado.Replace("#", "");
        }

        private DateTime CarregarDataDaMao()
        {
            var primeira = ObterLinha(1);
            var data = primeira.Substring(primeira.LastIndexOf("-"));
            data = data.Substring(0, data.IndexOf("BRT")).Replace("-", "").Trim();

            return Convert.ToDateTime(data);

        }

        private string ObterLinha(int linha)
        {
            return linhas[linha - 1];
        }
    }
}
