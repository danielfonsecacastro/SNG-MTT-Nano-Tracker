using SNGMTTNanoTracker.Dominio;
using SNGMTTNanoTracker.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace Poker
{
    public partial class FormConfiguracao : Form
    {
        public FormConfiguracao()
        {
            InitializeComponent();

            _configuracaoRepositorio = new ConfiguracaoRepositorio();
            CarregarTela();
        }

        private void CarregarTela()
        {
            var configuracoes = _configuracaoRepositorio.ObterTodasConfiguracoes();
            foreach (var item in configuracoes)
            {
                if (item.ConfiguracaoID == 1)
                    textBoxHandHistory.Text = item.Valor;

                if (item.ConfiguracaoID == 2)
                    textBoxNotas.Text = item.Valor;

                if (item.ConfiguracaoID == 3)
                    textBoxTournamentSummary.Text = item.Valor;

                if (item.ConfiguracaoID == 4)
                    textBoxJogador.Text = item.Valor;
            }
        }

        private IConfiguracaoRepositorio _configuracaoRepositorio;

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNotas_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione o diretório para salvar suas notas";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxNotas.Text = dialog.SelectedPath;
                }
            }
        }

        private void buttonTournamentSummary_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione o diretório com Tournament Summary";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxTournamentSummary.Text = dialog.SelectedPath;
                }
            }

        }

        private void buttonHandHistory_Click(object sender, EventArgs e)
        {
            string startupPath = Application.StartupPath;
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Selecione o diretório com Hand History";
                dialog.ShowNewFolderButton = false;
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxHandHistory.Text = dialog.SelectedPath;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxHandHistory.Text))
            {
                MessageBox.Show(this, "O campo 'Caminho Hand History' é obrigatório!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBoxTournamentSummary.Text))
            {
                MessageBox.Show(this, "O campo 'Caminho Tournament Summary' é obrigatório!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBoxNotas.Text))
            {
                MessageBox.Show(this, "O campo 'Caminho Notas' é obrigatório!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(textBoxJogador.Text))
            {
                MessageBox.Show(this, "O campo 'Jogador' é obrigatório!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.Directory.Exists(textBoxHandHistory.Text))
            {
                MessageBox.Show(this, "O caminho informado para o campo 'Caminho Hand History' é inválido!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.Directory.Exists(textBoxTournamentSummary.Text))
            {
                MessageBox.Show(this, "O caminho informado para o campo 'Caminho Tournament Summary' é inválido!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.IO.Directory.Exists(textBoxNotas.Text))
            {
                MessageBox.Show(this, "O caminho informado para o campo 'Caminho Notas' é inválido!'", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var pathHandHistoryLidos = Path.Combine(textBoxHandHistory.Text, "Lidos");
            var criouPathHandHistoryLidos = false;
            if (!System.IO.Directory.Exists(pathHandHistoryLidos))
            {
                Directory.CreateDirectory(pathHandHistoryLidos);
                criouPathHandHistoryLidos = true;
            }

            var pathTournamentSummaryLidos = Path.Combine(textBoxTournamentSummary.Text, "Lidos");
            var criouPathTournamentSummaryLidos = false;
            if (!System.IO.Directory.Exists(pathTournamentSummaryLidos))
            {
                Directory.CreateDirectory(pathTournamentSummaryLidos);
                criouPathTournamentSummaryLidos = true;
            }

            var configuracoes = _configuracaoRepositorio.ObterTodasConfiguracoes();
            foreach (var item in configuracoes)
            {
                if (item.ConfiguracaoID == 1)
                    item.Valor = textBoxHandHistory.Text;

                if (item.ConfiguracaoID == 2)
                    item.Valor = textBoxNotas.Text;

                if (item.ConfiguracaoID == 3)
                    item.Valor = textBoxTournamentSummary.Text;

                if (item.ConfiguracaoID == 4)
                    item.Valor = textBoxJogador.Text;
            }

            if (criouPathHandHistoryLidos || criouPathTournamentSummaryLidos)
            {
                MessageBox.Show(this, String.Format("Dois novos diretórios foram criados:\r\n {0} \r\n {1}", @pathHandHistoryLidos, @pathTournamentSummaryLidos), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            _configuracaoRepositorio.Salvar();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
