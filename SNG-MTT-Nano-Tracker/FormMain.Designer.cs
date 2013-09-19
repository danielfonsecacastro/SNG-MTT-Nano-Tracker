namespace Poker
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonTop = new System.Windows.Forms.Button();
            this.groupBoxJanelasAbertas = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.trackBarVisibilidade = new System.Windows.Forms.TrackBar();
            this.checkBoxBloquearEstatistica = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonNotaNada = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButtonNotaTodasAcoes = new System.Windows.Forms.RadioButton();
            this.radioButtonNotaTodosShowdown = new System.Windows.Forms.RadioButton();
            this.richTextBoxJanelasAbertas = new System.Windows.Forms.RichTextBox();
            this.groupBoxRelatorios = new System.Windows.Forms.GroupBox();
            this.buttonConfiguracao = new System.Windows.Forms.Button();
            this.tabControlGrid = new System.Windows.Forms.TabControl();
            this.tabPageGeral = new System.Windows.Forms.TabPage();
            this.dataGridViewResultados = new System.Windows.Forms.DataGridView();
            this.tabPageAgrupadoPorTable = new System.Windows.Forms.TabPage();
            this.dataGridViewAgrupadoPorValor = new System.Windows.Forms.DataGridView();
            this.labelMesasFinais = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.labelROI = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxFiltro = new System.Windows.Forms.ComboBox();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelRetorno = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotalBuyInRake = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelPorcentagemITM = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelQuantidadeITM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAtualizarRelatorio = new System.Windows.Forms.Button();
            this.labelErroConfiguracao = new System.Windows.Forms.Label();
            this.ResultadoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TorneioID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogadores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyInRake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Posicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Winning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxJanelasAbertas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisibilidade)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxRelatorios.SuspendLayout();
            this.tabControlGrid.SuspendLayout();
            this.tabPageGeral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).BeginInit();
            this.tabPageAgrupadoPorTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgrupadoPorValor)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTop
            // 
            this.buttonTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTop.Location = new System.Drawing.Point(11, 22);
            this.buttonTop.Name = "buttonTop";
            this.buttonTop.Size = new System.Drawing.Size(175, 23);
            this.buttonTop.TabIndex = 0;
            this.buttonTop.Text = "Exibir todas janelas";
            this.buttonTop.UseVisualStyleBackColor = true;
            this.buttonTop.Click += new System.EventHandler(this.buttonTop_Click);
            // 
            // groupBoxJanelasAbertas
            // 
            this.groupBoxJanelasAbertas.Controls.Add(this.label14);
            this.groupBoxJanelasAbertas.Controls.Add(this.trackBarVisibilidade);
            this.groupBoxJanelasAbertas.Controls.Add(this.checkBoxBloquearEstatistica);
            this.groupBoxJanelasAbertas.Controls.Add(this.panel2);
            this.groupBoxJanelasAbertas.Controls.Add(this.richTextBoxJanelasAbertas);
            this.groupBoxJanelasAbertas.Controls.Add(this.buttonTop);
            this.groupBoxJanelasAbertas.Location = new System.Drawing.Point(12, 520);
            this.groupBoxJanelasAbertas.Name = "groupBoxJanelasAbertas";
            this.groupBoxJanelasAbertas.Size = new System.Drawing.Size(998, 119);
            this.groupBoxJanelasAbertas.TabIndex = 1;
            this.groupBoxJanelasAbertas.TabStop = false;
            this.groupBoxJanelasAbertas.Text = "Janelas abertas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(744, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Visibilidade:";
            // 
            // trackBarVisibilidade
            // 
            this.trackBarVisibilidade.LargeChange = 1;
            this.trackBarVisibilidade.Location = new System.Drawing.Point(826, 11);
            this.trackBarVisibilidade.Name = "trackBarVisibilidade";
            this.trackBarVisibilidade.Size = new System.Drawing.Size(134, 45);
            this.trackBarVisibilidade.TabIndex = 10;
            this.trackBarVisibilidade.Value = 2;
            this.trackBarVisibilidade.Scroll += new System.EventHandler(this.trackBarVisibilidade_Scroll);
            // 
            // checkBoxBloquearEstatistica
            // 
            this.checkBoxBloquearEstatistica.AutoSize = true;
            this.checkBoxBloquearEstatistica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBloquearEstatistica.Location = new System.Drawing.Point(195, 25);
            this.checkBoxBloquearEstatistica.Name = "checkBoxBloquearEstatistica";
            this.checkBoxBloquearEstatistica.Size = new System.Drawing.Size(113, 17);
            this.checkBoxBloquearEstatistica.TabIndex = 9;
            this.checkBoxBloquearEstatistica.Text = "Bloquear Notas";
            this.checkBoxBloquearEstatistica.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButtonNotaNada);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.radioButtonNotaTodasAcoes);
            this.panel2.Controls.Add(this.radioButtonNotaTodosShowdown);
            this.panel2.Location = new System.Drawing.Point(354, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 28);
            this.panel2.TabIndex = 8;
            // 
            // radioButtonNotaNada
            // 
            this.radioButtonNotaNada.AutoSize = true;
            this.radioButtonNotaNada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNotaNada.Location = new System.Drawing.Point(283, 4);
            this.radioButtonNotaNada.Name = "radioButtonNotaNada";
            this.radioButtonNotaNada.Size = new System.Drawing.Size(55, 17);
            this.radioButtonNotaNada.TabIndex = 7;
            this.radioButtonNotaNada.Text = "Nada";
            this.radioButtonNotaNada.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(4, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Notas:";
            // 
            // radioButtonNotaTodasAcoes
            // 
            this.radioButtonNotaTodasAcoes.AutoSize = true;
            this.radioButtonNotaTodasAcoes.Checked = true;
            this.radioButtonNotaTodasAcoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNotaTodasAcoes.Location = new System.Drawing.Point(54, 4);
            this.radioButtonNotaTodasAcoes.Name = "radioButtonNotaTodasAcoes";
            this.radioButtonNotaTodasAcoes.Size = new System.Drawing.Size(99, 17);
            this.radioButtonNotaTodasAcoes.TabIndex = 5;
            this.radioButtonNotaTodasAcoes.TabStop = true;
            this.radioButtonNotaTodasAcoes.Text = "Todas Ações";
            this.radioButtonNotaTodasAcoes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNotaTodosShowdown
            // 
            this.radioButtonNotaTodosShowdown.AutoSize = true;
            this.radioButtonNotaTodosShowdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNotaTodosShowdown.Location = new System.Drawing.Point(153, 4);
            this.radioButtonNotaTodosShowdown.Name = "radioButtonNotaTodosShowdown";
            this.radioButtonNotaTodosShowdown.Size = new System.Drawing.Size(125, 17);
            this.radioButtonNotaTodosShowdown.TabIndex = 5;
            this.radioButtonNotaTodosShowdown.Text = "Todos Showdown";
            this.radioButtonNotaTodosShowdown.UseVisualStyleBackColor = true;
            // 
            // richTextBoxJanelasAbertas
            // 
            this.richTextBoxJanelasAbertas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxJanelasAbertas.Location = new System.Drawing.Point(11, 50);
            this.richTextBoxJanelasAbertas.Name = "richTextBoxJanelasAbertas";
            this.richTextBoxJanelasAbertas.Size = new System.Drawing.Size(387, 63);
            this.richTextBoxJanelasAbertas.TabIndex = 0;
            this.richTextBoxJanelasAbertas.Text = "";
            // 
            // groupBoxRelatorios
            // 
            this.groupBoxRelatorios.Controls.Add(this.buttonConfiguracao);
            this.groupBoxRelatorios.Controls.Add(this.tabControlGrid);
            this.groupBoxRelatorios.Controls.Add(this.labelMesasFinais);
            this.groupBoxRelatorios.Controls.Add(this.label12);
            this.groupBoxRelatorios.Controls.Add(this.label10);
            this.groupBoxRelatorios.Controls.Add(this.dateTimePickerFim);
            this.groupBoxRelatorios.Controls.Add(this.label8);
            this.groupBoxRelatorios.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxRelatorios.Controls.Add(this.label2);
            this.groupBoxRelatorios.Controls.Add(this.labelROI);
            this.groupBoxRelatorios.Controls.Add(this.label6);
            this.groupBoxRelatorios.Controls.Add(this.comboBoxFiltro);
            this.groupBoxRelatorios.Controls.Add(this.labelSaldo);
            this.groupBoxRelatorios.Controls.Add(this.label4);
            this.groupBoxRelatorios.Controls.Add(this.labelRetorno);
            this.groupBoxRelatorios.Controls.Add(this.label7);
            this.groupBoxRelatorios.Controls.Add(this.labelTotalBuyInRake);
            this.groupBoxRelatorios.Controls.Add(this.label9);
            this.groupBoxRelatorios.Controls.Add(this.labelPorcentagemITM);
            this.groupBoxRelatorios.Controls.Add(this.label5);
            this.groupBoxRelatorios.Controls.Add(this.labelQuantidadeITM);
            this.groupBoxRelatorios.Controls.Add(this.label3);
            this.groupBoxRelatorios.Controls.Add(this.labelQuantidade);
            this.groupBoxRelatorios.Controls.Add(this.label1);
            this.groupBoxRelatorios.Controls.Add(this.buttonAtualizarRelatorio);
            this.groupBoxRelatorios.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRelatorios.Name = "groupBoxRelatorios";
            this.groupBoxRelatorios.Size = new System.Drawing.Size(998, 499);
            this.groupBoxRelatorios.TabIndex = 2;
            this.groupBoxRelatorios.TabStop = false;
            this.groupBoxRelatorios.Text = "Relatórios";
            // 
            // buttonConfiguracao
            // 
            this.buttonConfiguracao.Location = new System.Drawing.Point(881, 88);
            this.buttonConfiguracao.Name = "buttonConfiguracao";
            this.buttonConfiguracao.Size = new System.Drawing.Size(94, 23);
            this.buttonConfiguracao.TabIndex = 25;
            this.buttonConfiguracao.Text = "Configurações";
            this.buttonConfiguracao.UseVisualStyleBackColor = true;
            this.buttonConfiguracao.Click += new System.EventHandler(this.buttonConfiguracao_Click);
            // 
            // tabControlGrid
            // 
            this.tabControlGrid.Controls.Add(this.tabPageGeral);
            this.tabControlGrid.Controls.Add(this.tabPageAgrupadoPorTable);
            this.tabControlGrid.Location = new System.Drawing.Point(6, 108);
            this.tabControlGrid.Name = "tabControlGrid";
            this.tabControlGrid.SelectedIndex = 0;
            this.tabControlGrid.Size = new System.Drawing.Size(986, 372);
            this.tabControlGrid.TabIndex = 3;
            // 
            // tabPageGeral
            // 
            this.tabPageGeral.Controls.Add(this.dataGridViewResultados);
            this.tabPageGeral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeral.Name = "tabPageGeral";
            this.tabPageGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeral.Size = new System.Drawing.Size(978, 346);
            this.tabPageGeral.TabIndex = 0;
            this.tabPageGeral.Text = "Geral";
            this.tabPageGeral.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultados
            // 
            this.dataGridViewResultados.AllowUserToAddRows = false;
            this.dataGridViewResultados.AllowUserToDeleteRows = false;
            this.dataGridViewResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResultadoID,
            this.TorneioID,
            this.Fim,
            this.Inicio,
            this.Tempo,
            this.Table,
            this.Jogadores,
            this.BuyInRake,
            this.Posicao,
            this.Winning});
            this.dataGridViewResultados.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewResultados.Name = "dataGridViewResultados";
            this.dataGridViewResultados.ReadOnly = true;
            this.dataGridViewResultados.Size = new System.Drawing.Size(968, 334);
            this.dataGridViewResultados.TabIndex = 0;
            this.dataGridViewResultados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResultados_CellDoubleClick);
            // 
            // tabPageAgrupadoPorTable
            // 
            this.tabPageAgrupadoPorTable.Controls.Add(this.dataGridViewAgrupadoPorValor);
            this.tabPageAgrupadoPorTable.Location = new System.Drawing.Point(4, 22);
            this.tabPageAgrupadoPorTable.Name = "tabPageAgrupadoPorTable";
            this.tabPageAgrupadoPorTable.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAgrupadoPorTable.Size = new System.Drawing.Size(978, 346);
            this.tabPageAgrupadoPorTable.TabIndex = 1;
            this.tabPageAgrupadoPorTable.Text = "Agrupado por table";
            this.tabPageAgrupadoPorTable.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAgrupadoPorValor
            // 
            this.dataGridViewAgrupadoPorValor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAgrupadoPorValor.Location = new System.Drawing.Point(4, 7);
            this.dataGridViewAgrupadoPorValor.Name = "dataGridViewAgrupadoPorValor";
            this.dataGridViewAgrupadoPorValor.Size = new System.Drawing.Size(968, 333);
            this.dataGridViewAgrupadoPorValor.TabIndex = 0;
            // 
            // labelMesasFinais
            // 
            this.labelMesasFinais.AutoSize = true;
            this.labelMesasFinais.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesasFinais.Location = new System.Drawing.Point(115, 78);
            this.labelMesasFinais.Name = "labelMesasFinais";
            this.labelMesasFinais.Size = new System.Drawing.Size(11, 13);
            this.labelMesasFinais.TabIndex = 24;
            this.labelMesasFinais.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(23, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Mesas Finais :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(351, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Fim  :";
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.CustomFormat = "";
            this.dateTimePickerFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFim.Location = new System.Drawing.Point(390, 17);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerFim.TabIndex = 21;
            this.dateTimePickerFim.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(192, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Início  :";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.CustomFormat = "";
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(244, 17);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(101, 20);
            this.dateTimePickerInicio.TabIndex = 19;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Desde  :";
            // 
            // labelROI
            // 
            this.labelROI.AutoSize = true;
            this.labelROI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelROI.Location = new System.Drawing.Point(618, 78);
            this.labelROI.Name = "labelROI";
            this.labelROI.Size = new System.Drawing.Size(11, 13);
            this.labelROI.TabIndex = 17;
            this.labelROI.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "ROI :";
            // 
            // comboBoxFiltro
            // 
            this.comboBoxFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltro.FormattingEnabled = true;
            this.comboBoxFiltro.Location = new System.Drawing.Point(85, 17);
            this.comboBoxFiltro.Name = "comboBoxFiltro";
            this.comboBoxFiltro.Size = new System.Drawing.Size(101, 21);
            this.comboBoxFiltro.TabIndex = 14;
            this.comboBoxFiltro.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltro_SelectedIndexChanged);
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(618, 51);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(11, 13);
            this.labelSaldo.TabIndex = 13;
            this.labelSaldo.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(565, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Saldo :";
            // 
            // labelRetorno
            // 
            this.labelRetorno.AutoSize = true;
            this.labelRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRetorno.Location = new System.Drawing.Point(471, 73);
            this.labelRetorno.Name = "labelRetorno";
            this.labelRetorno.Size = new System.Drawing.Size(11, 13);
            this.labelRetorno.TabIndex = 11;
            this.labelRetorno.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Winning $ :";
            // 
            // labelTotalBuyInRake
            // 
            this.labelTotalBuyInRake.AutoSize = true;
            this.labelTotalBuyInRake.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBuyInRake.Location = new System.Drawing.Point(471, 51);
            this.labelTotalBuyInRake.Name = "labelTotalBuyInRake";
            this.labelTotalBuyInRake.Size = new System.Drawing.Size(11, 13);
            this.labelTotalBuyInRake.TabIndex = 9;
            this.labelTotalBuyInRake.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(375, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Buy-in & Rake :";
            // 
            // labelPorcentagemITM
            // 
            this.labelPorcentagemITM.AutoSize = true;
            this.labelPorcentagemITM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPorcentagemITM.Location = new System.Drawing.Point(279, 73);
            this.labelPorcentagemITM.Name = "labelPorcentagemITM";
            this.labelPorcentagemITM.Size = new System.Drawing.Size(11, 13);
            this.labelPorcentagemITM.TabIndex = 7;
            this.labelPorcentagemITM.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ITM(%) :";
            // 
            // labelQuantidadeITM
            // 
            this.labelQuantidadeITM.AutoSize = true;
            this.labelQuantidadeITM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidadeITM.Location = new System.Drawing.Point(279, 51);
            this.labelQuantidadeITM.Name = "labelQuantidadeITM";
            this.labelQuantidadeITM.Size = new System.Drawing.Size(11, 13);
            this.labelQuantidadeITM.TabIndex = 5;
            this.labelQuantidadeITM.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantidade ITM :";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuantidade.Location = new System.Drawing.Point(100, 51);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(11, 13);
            this.labelQuantidade.TabIndex = 3;
            this.labelQuantidade.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantidade :";
            // 
            // buttonAtualizarRelatorio
            // 
            this.buttonAtualizarRelatorio.Location = new System.Drawing.Point(900, 21);
            this.buttonAtualizarRelatorio.Name = "buttonAtualizarRelatorio";
            this.buttonAtualizarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.buttonAtualizarRelatorio.TabIndex = 1;
            this.buttonAtualizarRelatorio.Text = "Atualizar";
            this.buttonAtualizarRelatorio.UseVisualStyleBackColor = true;
            this.buttonAtualizarRelatorio.Click += new System.EventHandler(this.buttonAtualizarRelatorio_Click);
            // 
            // labelErroConfiguracao
            // 
            this.labelErroConfiguracao.AutoSize = true;
            this.labelErroConfiguracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErroConfiguracao.ForeColor = System.Drawing.Color.Red;
            this.labelErroConfiguracao.Location = new System.Drawing.Point(252, 291);
            this.labelErroConfiguracao.Name = "labelErroConfiguracao";
            this.labelErroConfiguracao.Size = new System.Drawing.Size(501, 31);
            this.labelErroConfiguracao.TabIndex = 3;
            this.labelErroConfiguracao.Text = "Nenhum configuração foi encontrada!";
            // 
            // ResultadoID
            // 
            this.ResultadoID.DataPropertyName = "ResultadoID";
            this.ResultadoID.HeaderText = "ResultadosID ";
            this.ResultadoID.Name = "ResultadoID";
            this.ResultadoID.ReadOnly = true;
            this.ResultadoID.Visible = false;
            // 
            // TorneioID
            // 
            this.TorneioID.DataPropertyName = "TorneioID";
            this.TorneioID.HeaderText = "TorneioID";
            this.TorneioID.Name = "TorneioID";
            this.TorneioID.ReadOnly = true;
            // 
            // Fim
            // 
            this.Fim.DataPropertyName = "Fim";
            this.Fim.HeaderText = "Fim";
            this.Fim.Name = "Fim";
            this.Fim.ReadOnly = true;
            this.Fim.Visible = false;
            // 
            // Inicio
            // 
            this.Inicio.DataPropertyName = "Inicio";
            this.Inicio.HeaderText = "Início";
            this.Inicio.Name = "Inicio";
            this.Inicio.ReadOnly = true;
            // 
            // Tempo
            // 
            this.Tempo.DataPropertyName = "Tempo";
            this.Tempo.HeaderText = "Tempo";
            this.Tempo.Name = "Tempo";
            this.Tempo.ReadOnly = true;
            // 
            // Table
            // 
            this.Table.DataPropertyName = "Mesa";
            this.Table.HeaderText = "Table";
            this.Table.Name = "Table";
            this.Table.ReadOnly = true;
            this.Table.Width = 200;
            // 
            // Jogadores
            // 
            this.Jogadores.DataPropertyName = "Jogadores";
            this.Jogadores.HeaderText = "Jogadores";
            this.Jogadores.Name = "Jogadores";
            this.Jogadores.ReadOnly = true;
            // 
            // BuyInRake
            // 
            this.BuyInRake.DataPropertyName = "BuyInRake";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.BuyInRake.DefaultCellStyle = dataGridViewCellStyle1;
            this.BuyInRake.HeaderText = "Buy-in & Rake";
            this.BuyInRake.Name = "BuyInRake";
            this.BuyInRake.ReadOnly = true;
            // 
            // Posicao
            // 
            this.Posicao.DataPropertyName = "Posicao";
            this.Posicao.HeaderText = "Posição";
            this.Posicao.Name = "Posicao";
            this.Posicao.ReadOnly = true;
            // 
            // Winning
            // 
            this.Winning.DataPropertyName = "Winning";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Winning.DefaultCellStyle = dataGridViewCellStyle2;
            this.Winning.HeaderText = "Winning $";
            this.Winning.Name = "Winning";
            this.Winning.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 649);
            this.Controls.Add(this.groupBoxRelatorios);
            this.Controls.Add(this.labelErroConfiguracao);
            this.Controls.Add(this.groupBoxJanelasAbertas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Poker";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBoxJanelasAbertas.ResumeLayout(false);
            this.groupBoxJanelasAbertas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVisibilidade)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxRelatorios.ResumeLayout(false);
            this.groupBoxRelatorios.PerformLayout();
            this.tabControlGrid.ResumeLayout(false);
            this.tabPageGeral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultados)).EndInit();
            this.tabPageAgrupadoPorTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAgrupadoPorValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTop;
        private System.Windows.Forms.GroupBox groupBoxJanelasAbertas;
        private System.Windows.Forms.RichTextBox richTextBoxJanelasAbertas;
        private System.Windows.Forms.GroupBox groupBoxRelatorios;
        private System.Windows.Forms.DataGridView dataGridViewResultados;
        private System.Windows.Forms.Button buttonAtualizarRelatorio;
        private System.Windows.Forms.Label labelRetorno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotalBuyInRake;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelPorcentagemITM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelQuantidadeITM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFiltro;
        private System.Windows.Forms.Label labelROI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelMesasFinais;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButtonNotaTodasAcoes;
        private System.Windows.Forms.RadioButton radioButtonNotaTodosShowdown;
        private System.Windows.Forms.RadioButton radioButtonNotaNada;
        private System.Windows.Forms.CheckBox checkBoxBloquearEstatistica;
        private System.Windows.Forms.TabControl tabControlGrid;
        private System.Windows.Forms.TabPage tabPageGeral;
        private System.Windows.Forms.TabPage tabPageAgrupadoPorTable;
        private System.Windows.Forms.DataGridView dataGridViewAgrupadoPorValor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TrackBar trackBarVisibilidade;
        private System.Windows.Forms.Button buttonConfiguracao;
        private System.Windows.Forms.Label labelErroConfiguracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultadoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TorneioID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyInRake;
        private System.Windows.Forms.DataGridViewTextBoxColumn Posicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Winning;
    }
}