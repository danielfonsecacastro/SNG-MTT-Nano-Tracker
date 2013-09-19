namespace Poker
{
    partial class FormEditTorneio
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxQauntidadeDeJogadores = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPosicao = new System.Windows.Forms.TextBox();
            this.textBoxWinning = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(12, 201);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade de Jogadores";
            // 
            // comboBoxQauntidadeDeJogadores
            // 
            this.comboBoxQauntidadeDeJogadores.FormattingEnabled = true;
            this.comboBoxQauntidadeDeJogadores.Location = new System.Drawing.Point(12, 63);
            this.comboBoxQauntidadeDeJogadores.Name = "comboBoxQauntidadeDeJogadores";
            this.comboBoxQauntidadeDeJogadores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxQauntidadeDeJogadores.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Posição";
            // 
            // textBoxPosicao
            // 
            this.textBoxPosicao.Location = new System.Drawing.Point(12, 110);
            this.textBoxPosicao.Name = "textBoxPosicao";
            this.textBoxPosicao.Size = new System.Drawing.Size(100, 20);
            this.textBoxPosicao.TabIndex = 4;
            // 
            // textBoxWinning
            // 
            this.textBoxWinning.Location = new System.Drawing.Point(12, 161);
            this.textBoxWinning.Name = "textBoxWinning";
            this.textBoxWinning.Size = new System.Drawing.Size(100, 20);
            this.textBoxWinning.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Winning";
            // 
            // comboBoxTable
            // 
            this.comboBoxTable.FormattingEnabled = true;
            this.comboBoxTable.Location = new System.Drawing.Point(12, 19);
            this.comboBoxTable.Name = "comboBoxTable";
            this.comboBoxTable.Size = new System.Drawing.Size(382, 21);
            this.comboBoxTable.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Table";
            // 
            // FormEditTorneio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 238);
            this.Controls.Add(this.comboBoxTable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWinning);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPosicao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxQauntidadeDeJogadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditTorneio";
            this.Text = "Editar Torneio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxQauntidadeDeJogadores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPosicao;
        private System.Windows.Forms.TextBox textBoxWinning;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTable;
        private System.Windows.Forms.Label label4;
    }
}