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
    public partial class FormMesas : Form
    {
        public FormMesas()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");

            _mesasRepositorios = new MesasRepositorios();
            _resultadoRepositorio = new ResultadoRepositorio();
            CarregarForm();
        }

        private MesasRepositorios _mesasRepositorios;
        private ResultadoRepositorio _resultadoRepositorio;

        private void CarregarForm()
        {
            dataGridViewMesas.DataSource = _mesasRepositorios.ObterTodas().ToList();

            var todasMesas = _resultadoRepositorio.ObterTodasTablesCadastrada();
            comboBoxMesas.Items.Clear();
            foreach (var item in todasMesas.OrderBy(x => x))
            {
                if (String.IsNullOrEmpty(item)) continue;
                comboBoxMesas.Items.Add(item);
            }

            var todasQuantidadeDeJogadoresCadastradas = _resultadoRepositorio.ObterTodasQuantidadesDeJogadoresCadastrados();
            comboBoxQuantidadeDeJogadores.Items.Clear();
            comboBoxQuantidadeDeJogadores.Items.Add("");
            foreach (var item in todasQuantidadeDeJogadoresCadastradas.OrderBy(x => x))
            {
                if (String.IsNullOrEmpty(item)) continue;
                comboBoxQuantidadeDeJogadores.Items.Add(item);
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            _mesasRepositorios.Inserir(new Mesas
            {
                NomeAmigavel = textBoxNomeAmigavel.Text,
                Table = comboBoxMesas.Text,
                Players = String.IsNullOrEmpty(comboBoxQuantidadeDeJogadores.Text) ? null : comboBoxQuantidadeDeJogadores.Text,

            });
            CarregarForm();
        }

        private void buttonReatualizar_Click(object sender, EventArgs e)
        {
            var resultados = _resultadoRepositorio.ObterTodos();
            foreach (var mesa in resultados.GroupBy(x => x.Mesa))
            {
                var mapeamentos = _mesasRepositorios.ObterPorTable(mesa.Key);
                foreach (var mapeamento in mapeamentos)
                {
                    if (String.IsNullOrEmpty(mapeamento.Players))
                    {
                        foreach (var item in resultados.Where(x => x.Mesa == mesa.Key))
                        {
                            item.Mesa = mapeamento.NomeAmigavel;
                        }
                    }
                    else
                    {
                        foreach (var item in resultados.Where(x => x.Mesa == mesa.Key && x.Jogadores == mapeamento.Players))
                        {
                            item.Mesa = mapeamento.NomeAmigavel;
                        }
                    }
                }
            }

            _resultadoRepositorio.Salvar();
            MessageBox.Show("Atualizado com sucesso!");
        }

        private void dataGridViewMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var linha = dataGridViewMesas.Rows[e.RowIndex];
            var mesaId = Convert.ToInt32(linha.Cells["MesaID"].Value);

            if (MessageBox.Show("Tem certeza que deseja excluir este item?", "Confirmação", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                _mesasRepositorios.Excluir(mesaId);
                CarregarForm();
            }
        }
    }
}
