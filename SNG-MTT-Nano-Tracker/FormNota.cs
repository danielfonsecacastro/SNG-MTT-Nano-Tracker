using SNGMTTNanoTracker.Dominio;
using SNGMTTNanoTracker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WindowScrape.Types;

namespace Poker
{
    public partial class FormNota : FormBase
    {
        string path = Configuracoes.Path;
        public FormNotaInfo FormEstrategiaInfo { get; set; }
        public FormNota()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            mesas = new List<string>();
            startActivityMonitoring(path);
            SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        protected void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private List<string> _notasSalvas = new List<string>();
        FileSystemWatcher _watchFolder = new FileSystemWatcher();
        string ultimoArquivo;
        Mao ultimaMao;
        List<string> mesas;
        public string NumeroTorneio { get; set; }

        private double opacidadeSelecionada;

        public event EventHandler NovaMao;
        public void NovaMaoExecute()
        {
            EventHandler handler = NovaMao;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }

        public void SetarLocalizacao()
        {
            foreach (var item in HwndObject.GetWindows())
            {
                if (item.Title == FormEstrategiaInfo.MainWindowTitle)
                {
                    try
                    {
                        this.Location = new Point(item.Location.X, item.Location.Y + (item.Size.Height - this.Height));
                    }
                    catch { }
                }
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
            _watchFolder.Created += new FileSystemEventHandler(eventRaised);
            _watchFolder.Deleted += new FileSystemEventHandler(eventRaised);

            // And at last.. We connect our EventHandles to the system API (that is all
            // wrapped up in System.IO)

            _watchFolder.EnableRaisingEvents = true;
        }

        private void stopActivityMonitoring()
        {
            _watchFolder.EnableRaisingEvents = false;
        }

        private delegate void AddLogText(string caminho);
        private void TS_AddLogText(string caminho)
        {

            try
            {
                if (this.InvokeRequired)
                {
                    AddLogText del = new AddLogText(TS_AddLogText);
                    Invoke(del, caminho);
                }
                else
                {
                    if (!mesas.Contains(Path.GetFileNameWithoutExtension(caminho)))
                    {
                        mesas.Add(Path.GetFileNameWithoutExtension(caminho));

                        var itemMenu = new ToolStripMenuItem
                        {
                            Tag = Path.GetFileNameWithoutExtension(caminho),
                            Text = Path.GetFileNameWithoutExtension(caminho),
                        };
                    }

                    if (!String.IsNullOrEmpty(ultimoArquivo))
                    {
                        if (!ultimoArquivo.Equals(Path.GetFileNameWithoutExtension(caminho)))
                        {
                            return;
                        }
                    }

                    Mesa mesa = new Mesa();
                    ultimoArquivo = Path.GetFileNameWithoutExtension(caminho);
                    mesa.LerMaoes(caminho);
                    ultimaMao = mesa.Maoes.OrderBy(por => por.Data).Last();
                    toolTip1.SetToolTip(this, ultimoArquivo);

                    //MessageBox.Show("SalvarShowDown : " + salvarShowdownToolStripMenuItem.Checked + " TemShowDown : " + ultimaMao.TemShowDown + " -- Salvar Todas Acções: " + salvarTodasAcoesToolStripMenuItem.Checked + " Teve Ação : " + ultimaMao.TeveAcao + "\r\n" + ultimaMao.Conteudo);
                    if ((salvarShowdownToolStripMenuItem.Checked && ultimaMao.TemShowDown) || (salvarTodasAcoesToolStripMenuItem.Checked && ultimaMao.TeveAcao))
                        SalvarNota();

                    labelInstrucao.Text = String.Format("Torneio {0}", NumeroTorneio);
                    buttonSalvar.Enabled = true;
                    buttonSalvar.Text = "Salvar última mão";
                    NovaMaoExecute();
                }
            }
            catch { }
        }

        public void SetMesa(string arquivo)
        {
            NumeroTorneio = Suporte.ObterNumeroTorneio(arquivo);
            labelInstrucao.Text = String.Format("Torneio {0}", NumeroTorneio);
            ultimoArquivo = arquivo;
            toolTip1.SetToolTip(this, ultimoArquivo);
        }

        private void selecionarMesa_Click(object sender, EventArgs e)
        {
            ultimoArquivo = (sender as ToolStripMenuItem).Tag.ToString();
        }

        private void eventRaised(object sender, System.IO.FileSystemEventArgs e)
        {
            if (e.ChangeType != WatcherChangeTypes.Deleted)
            {
                Thread.Sleep(2000);
                TS_AddLogText(e.FullPath);
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topToolStripMenuItem_Click(object sender, EventArgs e)
        {
            topToolStripMenuItem.Checked = !topToolStripMenuItem.Checked;
        }

        private void SalvarNota()
        {
            if (ultimaMao == null) return;
            if (!_notasSalvas.Contains(ultimaMao.HandId))
            {
                var pathArquivo = Path.Combine(Configuracoes.PathNotas, String.Format("Nota - {0}.txt", NumeroTorneio));
                if (File.Exists(pathArquivo))
                    File.AppendAllText(pathArquivo, String.Format("\r\n\r\n{0}", ultimaMao.Conteudo));
                else
                    File.WriteAllText(pathArquivo, ultimaMao.Conteudo);

                _notasSalvas.Add(ultimaMao.HandId);
            }
        }

        private void FormEstrategia_Leave(object sender, EventArgs e)
        {
            this.Focus();
        }

        private void FormEstrategia_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = opacidadeSelecionada;
        }

        private void FormEstrategia_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void FormEstrategia_DoubleClick(object sender, EventArgs e)
        {

        }

        private void salvarShowdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvarShowdownToolStripMenuItem.Checked = !salvarShowdownToolStripMenuItem.Checked;
            salvarTodasAcoesToolStripMenuItem.Checked = false;
        }

        private void salvarTodasAcoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salvarTodasAcoesToolStripMenuItem.Checked = !salvarTodasAcoesToolStripMenuItem.Checked;
            salvarShowdownToolStripMenuItem.Checked = false;
        }

        public void Notas(Notas nota)
        {
            if (nota == SNGMTTNanoTracker.Dominio.Notas.Nada)
            {
                salvarShowdownToolStripMenuItem.Checked = false;
                salvarTodasAcoesToolStripMenuItem.Checked = false;
                nadaToolStripMenuItem.Checked = true;
            }

            if (nota == SNGMTTNanoTracker.Dominio.Notas.Showdown)
            {
                salvarShowdownToolStripMenuItem.Checked = true;
                salvarTodasAcoesToolStripMenuItem.Checked = false;
                nadaToolStripMenuItem.Checked = false;
            }

            if (nota == SNGMTTNanoTracker.Dominio.Notas.TodasAcoes)
            {
                salvarShowdownToolStripMenuItem.Checked = false;
                salvarTodasAcoesToolStripMenuItem.Checked = true;
                nadaToolStripMenuItem.Checked = false;
            }
        }

        public void SetOpacity(double opacity)
        {
            opacidadeSelecionada = opacity;
            if (opacidadeSelecionada <= 0)
                opacidadeSelecionada = 1d / 100d;

            this.Opacity = opacidadeSelecionada;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            SalvarNota();
            buttonSalvar.Enabled = false;
            buttonSalvar.Text = "Nota Salva!";
        }
    }
}

