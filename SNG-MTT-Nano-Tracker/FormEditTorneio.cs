using SNGMTTNanoTracker.Data;
using SNGMTTNanoTracker.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Poker
{
    public partial class FormEditTorneio : Form
    {
        public FormEditTorneio(Resultados resultado)
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            _resultadoRepositorio = new ResultadoRepositorio();
            _resultado = resultado;
            CarregarQuantidadesDeJogadores();

            textBoxPosicao.Text = resultado.Posicao.ToString();
            textBoxWinning.Text = resultado.Winning.ToString();
        }

        private ResultadoRepositorio _resultadoRepositorio;
        private Resultados _resultado;
        public string QuantidadeSelecionada { get; private set; }
        public int Posicao { get; set; }
        public decimal Winning { get; set; }
        public string Table { get; set; }

        private void CarregarQuantidadesDeJogadores()
        {
            var todasQuantidadeDeJogadoresCadastradas = _resultadoRepositorio.ObterTodasQuantidadesDeJogadoresCadastrados();
            foreach (var item in todasQuantidadeDeJogadoresCadastradas.OrderBy(x => x))
            {
                if (String.IsNullOrEmpty(item)) continue;
                comboBoxQauntidadeDeJogadores.Items.Add(item);
            }
            for (int i = 0; i < comboBoxQauntidadeDeJogadores.Items.Count; i++)
            {
                if (comboBoxQauntidadeDeJogadores.Items[i].ToString() == _resultado.Jogadores)
                {
                    comboBoxQauntidadeDeJogadores.SelectedIndex = i;
                }
            }

            var todasTables = _resultadoRepositorio.ObterTodasTablesCadastrada();
            foreach (var item in todasTables.OrderBy(x => x))
            {
                if (String.IsNullOrEmpty(item)) continue;
                comboBoxTable.Items.Add(item);
            }

            for (int i = 0; i < comboBoxTable.Items.Count; i++)
            {
                if (comboBoxTable.Items[i].ToString() == _resultado.Mesa)
                {
                    comboBoxTable.SelectedIndex = i;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            QuantidadeSelecionada = comboBoxQauntidadeDeJogadores.Text;
            Posicao = Convert.ToInt32(textBoxPosicao.Text);
            Winning = Convert.ToDecimal(textBoxWinning.Text);
            Table = comboBoxTable.Text;

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
    }
}
