namespace Poker
{
    partial class FormConfiguracao
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
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxHandHistory = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonHandHistory = new System.Windows.Forms.Button();
            this.buttonTournamentSummary = new System.Windows.Forms.Button();
            this.buttonNotas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNotas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTournamentSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxJogador = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(16, 259);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(87, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(112, 259);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(87, 23);
            this.buttonCancelar.TabIndex = 1;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Caminho Hand History";
            // 
            // textBoxHandHistory
            // 
            this.textBoxHandHistory.Location = new System.Drawing.Point(16, 72);
            this.textBoxHandHistory.Name = "textBoxHandHistory";
            this.textBoxHandHistory.Size = new System.Drawing.Size(444, 20);
            this.textBoxHandHistory.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxJogador);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonHandHistory);
            this.groupBox1.Controls.Add(this.buttonTournamentSummary);
            this.groupBox1.Controls.Add(this.buttonNotas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonCancelar);
            this.groupBox1.Controls.Add(this.textBoxNotas);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxTournamentSummary);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxHandHistory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configurações";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(16, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "*Atenção todos os campos são obrigatórios";
            // 
            // buttonHandHistory
            // 
            this.buttonHandHistory.Location = new System.Drawing.Point(464, 71);
            this.buttonHandHistory.Name = "buttonHandHistory";
            this.buttonHandHistory.Size = new System.Drawing.Size(37, 23);
            this.buttonHandHistory.TabIndex = 10;
            this.buttonHandHistory.Text = "...";
            this.buttonHandHistory.UseVisualStyleBackColor = true;
            this.buttonHandHistory.Click += new System.EventHandler(this.buttonHandHistory_Click);
            // 
            // buttonTournamentSummary
            // 
            this.buttonTournamentSummary.Location = new System.Drawing.Point(464, 120);
            this.buttonTournamentSummary.Name = "buttonTournamentSummary";
            this.buttonTournamentSummary.Size = new System.Drawing.Size(37, 23);
            this.buttonTournamentSummary.TabIndex = 9;
            this.buttonTournamentSummary.Text = "...";
            this.buttonTournamentSummary.UseVisualStyleBackColor = true;
            this.buttonTournamentSummary.Click += new System.EventHandler(this.buttonTournamentSummary_Click);
            // 
            // buttonNotas
            // 
            this.buttonNotas.Location = new System.Drawing.Point(464, 169);
            this.buttonNotas.Name = "buttonNotas";
            this.buttonNotas.Size = new System.Drawing.Size(37, 23);
            this.buttonNotas.TabIndex = 8;
            this.buttonNotas.Text = "...";
            this.buttonNotas.UseVisualStyleBackColor = true;
            this.buttonNotas.Click += new System.EventHandler(this.buttonNotas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caminho Notas";
            // 
            // textBoxNotas
            // 
            this.textBoxNotas.Location = new System.Drawing.Point(16, 170);
            this.textBoxNotas.Name = "textBoxNotas";
            this.textBoxNotas.Size = new System.Drawing.Size(444, 20);
            this.textBoxNotas.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Caminho Tournament Summary";
            // 
            // textBoxTournamentSummary
            // 
            this.textBoxTournamentSummary.Location = new System.Drawing.Point(16, 121);
            this.textBoxTournamentSummary.Name = "textBoxTournamentSummary";
            this.textBoxTournamentSummary.Size = new System.Drawing.Size(444, 20);
            this.textBoxTournamentSummary.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Jogador (seu login no PS)";
            // 
            // textBoxJogador
            // 
            this.textBoxJogador.Location = new System.Drawing.Point(16, 219);
            this.textBoxJogador.Name = "textBoxJogador";
            this.textBoxJogador.Size = new System.Drawing.Size(444, 20);
            this.textBoxJogador.TabIndex = 13;
            // 
            // FormConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 320);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConfiguracao";
            this.Text = "Configurações";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxHandHistory;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNotas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTournamentSummary;
        private System.Windows.Forms.Button buttonNotas;
        private System.Windows.Forms.Button buttonHandHistory;
        private System.Windows.Forms.Button buttonTournamentSummary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJogador;
    }
}