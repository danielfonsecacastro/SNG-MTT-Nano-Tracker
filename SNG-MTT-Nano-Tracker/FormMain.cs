using SNGMTTNanoTracker.Dominio;
using SNGMTTNanoTracker.Helpers;
using SNGMTTNanoTracker.Properties;
using SNGMTTNanoTracker.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using WindowScrape.Types;
using Microsoft.WindowsAPICodePack;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using SNGMTTNanoTracker.Data;
using System.Globalization;

namespace Poker
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            _resultadoRepositorio = new ResultadoRepositorio();
            _configuracaoRepositorio = new ConfiguracaoRepositorio();
            IniciarVerificacoes(false);
            if (!String.IsNullOrEmpty(Configuracoes.Path))
            {
                startActivityMonitoring(Configuracoes.Path);
                CarregarDataGrid(DateTime.Now, null);
                CarregarComboBoxFiltro();
            }
            else
            {
                groupBoxJanelasAbertas.Visible = false;
                groupBoxRelatorios.Visible = false;
                labelErroConfiguracao.Visible = true;
            }
        }

        private void IniciarVerificacoes(bool reverificar)
        {
            var configuracoes = _configuracaoRepositorio.ObterTodasConfiguracoes();

            if (!reverificar)
            {
                foreach (var item in configuracoes)
                {
                    if (String.IsNullOrEmpty(item.Valor))
                    {
                        var formConfiguracao = new FormConfiguracao();
                        formConfiguracao.ShowDialog();
                        reverificar = true;
                        break;
                    }
                }
            }

            if (reverificar)
            {
                configuracoes = _configuracaoRepositorio.ObterTodasConfiguracoes();
                foreach (var item in configuracoes)
                {
                    if (String.IsNullOrEmpty(item.Valor))
                    {
                        if (MessageBox.Show(this, "Todas as configurações são obrigatórias, deseja configurar agora?", "Configurações", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
                        {
                            var formConfiguracao = new FormConfiguracao();
                            formConfiguracao.ShowDialog();
                            IniciarVerificacoes(true);
                            break;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }

            foreach (var item in configuracoes)
            {
                if (item.ConfiguracaoID == 1)
                    Configuracoes.Path = item.Valor;

                if (item.ConfiguracaoID == 2)
                    Configuracoes.PathNotas = item.Valor;

                if (item.ConfiguracaoID == 3)
                    Configuracoes.PathTournSummary = item.Valor;

                if (item.ConfiguracaoID == 4)
                    Configuracoes.Jogador = item.Valor;
            }
        }

        public Notas ObterComportamentoDeNotas()
        {
            if (radioButtonNotaNada.Checked)
                return Notas.Nada;

            if (radioButtonNotaTodasAcoes.Checked)
                return Notas.TodasAcoes;

            if (radioButtonNotaTodosShowdown.Checked)
                return Notas.Showdown;

            throw new ObjectNotFoundException();
        }

        private void CarregarComboBoxFiltro()
        {
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Hoje", Data = DateTime.Now });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Ontem", Data = DateTime.Now.AddDays(-1) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Semana", Data = DateTime.Now.AddDays(-7) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Mês", Data = DateTime.Now.AddDays(-30) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Bimestre", Data = DateTime.Now.AddDays(-60) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Trimestre", Data = DateTime.Now.AddDays(-90) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Semestre", Data = DateTime.Now.AddDays(-180) });
            comboBoxFiltro.Items.Add(new ComboBoxFiltroItens { Descricao = "Anual", Data = DateTime.Now.AddDays(-360) });
            comboBoxFiltro.SelectedIndex = 0;
        }

        private void CarregarDataGrid(DateTime dataInicio, DateTime? dataFim)
        {
            List<Resultados> source = null;
            if (dataFim == null)
                source = _resultadoRepositorio.ObterPorDataInicio(dataInicio).ToList();
            else
                source = _resultadoRepositorio.ObterPorDataInicioEhDataFim(dataInicio, dataFim.Value).ToList();

            var quantidade = source.Count;
            if (quantidade > 0)
            {
                var buyInRake = source.Sum(x => x.BuyInRake);
                var retorno = source.Sum(x => x.Winning);
                var quantidadeITM = source.Count(x => x.Winning > 0);
                var saldo = retorno - buyInRake;
                var retornoPorcentagem = saldo / buyInRake;

                labelQuantidade.Text = quantidade.ToString();
                labelQuantidadeITM.Text = quantidadeITM.ToString();
                labelPorcentagemITM.Text = String.Format("{0:##}%", ((Convert.ToDecimal(quantidadeITM) / Convert.ToDecimal(quantidade)) * Convert.ToDecimal(100)));
                labelRetorno.Text = retorno.ToString("C");
                labelTotalBuyInRake.Text = buyInRake.ToString("C");
                labelSaldo.Text = String.Format("{0:C}", saldo);
                labelROI.Text = retornoPorcentagem.ToString("P");
                labelMesasFinais.Text = source.Count(x => x.Posicao <= 9 && x.Posicao > 0).ToString();

                if (retornoPorcentagem >= 0)
                    labelROI.ForeColor = Color.Green;
                else
                    labelROI.ForeColor = Color.Red;

                if (saldo >= 0)
                    labelSaldo.ForeColor = Color.Green;
                else
                    labelSaldo.ForeColor = Color.Red;

                dataGridViewResultados.DataSource = PrepararModel(source);
                CarregarDataGridAgrupadoPorTable(source);
            }
            else
            {
                dataGridViewResultados.DataSource = PrepararModel(source);
                labelQuantidade.Text = "-";
                labelQuantidadeITM.Text = "-";
                labelPorcentagemITM.Text = "-";
                labelRetorno.Text = "-";
                labelTotalBuyInRake.Text = "-";
                labelSaldo.Text = "-";
                labelROI.Text = "-";
                labelMesasFinais.Text = "-";
            }
        }

        private List<ResultadoModel> PrepararModel(List<Resultados> source)
        {
            if (source == null)
                return null;

            var resultado = new List<ResultadoModel>();
            foreach (var item in source)
            {
                resultado.Add(new ResultadoModel
                {
                    Inicio = item.Inicio,
                    Mesa = item.Mesa,
                    BuyInRake = item.BuyInRake,
                    Posicao = item.Posicao,
                    Winning = item.Winning,
                    TorneioID = item.TorneioID,
                    Jogadores = item.Jogadores,
                    Tempo = item.Tempo,
                    ResultadoID = item.ResultadoID
                });
            }

            return resultado;
        }

        private void CarregarDataGridAgrupadoPorTable(List<Resultados> source)
        {
            var resultado = new List<AgrupadoPorTableModel>();

            foreach (var item in source.GroupBy(x => x.Mesa))
            {
                var itensAgrupados = source.Where(x => x.Mesa == item.Key);

                var novoItem = new AgrupadoPorTableModel { Table = item.Key };
                novoItem.QuantidadeITM = itensAgrupados.Count(x => x.Winning > 0);
                novoItem.QuantidadeMesa = itensAgrupados.Count();
                novoItem.PorcentagemITM = (novoItem.QuantidadeITM / itensAgrupados.Count()).ToString("P");
                novoItem.TotalWinning = itensAgrupados.Sum(x => x.Winning);
                novoItem.TotalBuyInRake = itensAgrupados.Sum(x => x.BuyInRake);
                novoItem.TotalSaldo = novoItem.TotalWinning - novoItem.TotalBuyInRake;
                novoItem.ROI = (novoItem.TotalSaldo / novoItem.TotalBuyInRake).ToString("P");

                resultado.Add(novoItem);
            }

            dataGridViewAgrupadoPorValor.DataSource = resultado.OrderByDescending(por => por.QuantidadeMesa).ToList();
        }

        private Dictionary<string, FormNota> janelas = new Dictionary<string, FormNota>();
        FileSystemWatcher _watchFolder = new FileSystemWatcher();
        private IResultadoRepositorio _resultadoRepositorio;
        private IConfiguracaoRepositorio _configuracaoRepositorio;

        private void buttonTop_Click(object sender, EventArgs e)
        {
            foreach (var janela in janelas)
            {
                janela.Value.FormEstrategiaInfo.MainWindowTitle = GetInfoWindows(janela.Key).MainWindowTitle;
                janela.Value.SetarLocalizacao();
                janela.Value.SetTop();

                var valor = Convert.ToDouble(trackBarVisibilidade.Value);
                janela.Value.SetOpacity(valor / 10);
            }
        }

        private void eventRaised(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Deleted)
            {
                Thread.Sleep(2000);
                TS_AddLogText(e.FullPath);

            }
        }

        private void startActivityMonitoring(string sPath)
        {
            // This is the path we want to monitor
            _watchFolder.Path = sPath;

            // Make sure you use the OR on each Filter because we need to monitor
            // all of those activities

            _watchFolder.NotifyFilter = System.IO.NotifyFilters.DirectoryName;

            _watchFolder.NotifyFilter = _watchFolder.NotifyFilter | System.IO.NotifyFilters.FileName;
            _watchFolder.NotifyFilter = _watchFolder.NotifyFilter | System.IO.NotifyFilters.Attributes;

            // Now hook the triggers(events) to our handler (eventRaised)
            _watchFolder.Changed += new FileSystemEventHandler(eventRaised);
            //_watchFolder.Created += new FileSystemEventHandler(eventRaised);
            //_watchFolder.Deleted += new FileSystemEventHandler(eventRaised);

            // And at last.. We connect our EventHandles to the system API (that is all
            // wrapped up in System.IO)

            _watchFolder.EnableRaisingEvents = true;
        }

        private delegate void AddLogText(string caminho);
        private void TS_AddLogText(string caminho)
        {
            if (this.InvokeRequired)
            {
                AddLogText del = new AddLogText(TS_AddLogText);
                Invoke(del, caminho);
            }
            else
            {
                var arquivo = Path.GetFileNameWithoutExtension(caminho);
                var numeroTorneio = Suporte.ObterNumeroTorneio(caminho);

                if (!janelas.ContainsKey(numeroTorneio) && checkBoxBloquearEstatistica.Checked == false)
                {
                    var infoWindows = GetInfoWindows(numeroTorneio);
                    var form = new FormNota();
                    form.SetMesa(arquivo);
                    form.FormClosed += form_FormClosed;
                    form.NovaMao += form_NovaMao;
                    form.FormEstrategiaInfo = infoWindows;
                    form.Show();
                    form.SetarLocalizacao();
                    form.SetTop();
                    form.Notas(ObterComportamentoDeNotas());

                    janelas.Add(numeroTorneio, form);
                    MostrarJanelasAbertas();
                    buttonTop_Click(this, new EventArgs());
                }
            }
        }

        public void form_NovaMao(object sender, EventArgs e)
        {
            buttonTop_Click(sender, e);
        }

        private void MostrarJanelasAbertas()
        {
            richTextBoxJanelasAbertas.Text = "";
            foreach (var janela in janelas)
            {
                var fontNomal = richTextBoxJanelasAbertas.SelectionFont;
                var fontBold = new Font(richTextBoxJanelasAbertas.SelectionFont.FontFamily, richTextBoxJanelasAbertas.SelectionFont.Size, FontStyle.Bold);

                richTextBoxJanelasAbertas.AppendText("Torneio : ");
                richTextBoxJanelasAbertas.SelectionFont = fontBold;
                richTextBoxJanelasAbertas.AppendText(janela.Key);

                richTextBoxJanelasAbertas.AppendText("\r\n");
            }
        }

        public void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            var form = (FormNota)sender;
            janelas.Remove(form.NumeroTorneio);
            MostrarJanelasAbertas();
        }

        private FormNotaInfo GetInfoWindows(string numeroTorneio)
        {
            numeroTorneio = numeroTorneio.Replace("T", "");
            var formEstrategiaInfo = new FormNotaInfo { TipoMesa = "SNG" };

            foreach (var wnd in NativeMethods.GetAllWindows())
            {
                if (wnd.Title.Contains(numeroTorneio) && !wnd.Title.Contains("Lobby") && !wnd.Title.Contains("Nota"))
                {
                    formEstrategiaInfo.MainWindowTitle = wnd.Title;
                    formEstrategiaInfo.MainWindowHandle = wnd.Handle;

                    if (wnd.Title.ToUpper().Contains("[FIFTY50]"))
                        formEstrategiaInfo.TipoMesa = "fifty";
                }
            }

            return formEstrategiaInfo;
        }

        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern IntPtr GetTopWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        private void timerVerificaFoco_Tick(object sender, EventArgs e)
        {
            var foreground = GetForegroundWindow();


            if (janelas.Count(x => x.Value.FormEstrategiaInfo.MainWindowHandle == foreground) > 0)
            {
                var formTop = janelas.FirstOrDefault(x => x.Value.FormEstrategiaInfo.MainWindowHandle == foreground);
                formTop.Value.SetTop();

                foreach (var janela in janelas.Where(x => x.Value.FormEstrategiaInfo.MainWindowHandle != formTop.Value.FormEstrategiaInfo.MainWindowHandle))
                {
                    janela.Value.RemoveTop();
                }
            }
        }

        private void buttonAtualizarRelatorio_Click(object sender, EventArgs e)
        {
            var gerenciadorDeResultados = new GerenciadorDeResultados(new ResultadoRepositorio(), new GerenciadorDeArquivos());
            foreach (var item in Directory.GetFiles(Configuracoes.Path, "*.txt"))
            {
                gerenciadorDeResultados.SalvarResultado(item);
            }

            var filtro = comboBoxFiltro.SelectedItem as ComboBoxFiltroItens;
            CarregarDataGrid(filtro.Data, null);

            MessageBox.Show("Atualizado com sucesso!");
        }

        private void comboBoxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBoxFiltro.SelectedItem as ComboBoxFiltroItens;
            CarregarDataGrid(item.Data, null);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {

        }

        private void dataGridViewResultados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var linha = dataGridViewResultados.Rows[e.RowIndex];
            var resultadoId = Convert.ToInt32(linha.Cells["ResultadoID"].Value);

            var resultado = _resultadoRepositorio.ObterResultadoPorId(resultadoId);
            
            var form = new FormEditTorneio(resultado);
            form.ShowDialog();

            if (form.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                resultado.Jogadores = form.QuantidadeSelecionada;
                resultado.Winning = form.Winning;
                resultado.Posicao = form.Posicao;
                resultado.Mesa = form.Table;

                _resultadoRepositorio.Salvar();

                var filtro = comboBoxFiltro.SelectedItem as ComboBoxFiltroItens;
                CarregarDataGrid(filtro.Data, null);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            CarregarDataGrid(dateTimePickerInicio.Value, dateTimePickerFim.Value);
        }

        private void buttonMapearMesas_Click(object sender, EventArgs e)
        {
            FormMesas formMesas = new FormMesas();
            formMesas.Show();
        }

        private void trackBarVisibilidade_Scroll(object sender, EventArgs e)
        {
            buttonTop_Click(sender, e);
        }

        private void buttonConfiguracao_Click(object sender, EventArgs e)
        {
            var formConfiguracao = new FormConfiguracao();
            if (formConfiguracao.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(this, "Para as alterações surtirem efeitos o programa será fechado, reabra o programa em seguida!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
            }
        }
    }
}
