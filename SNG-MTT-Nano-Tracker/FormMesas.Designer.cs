namespace Poker
{
    partial class FormMesas
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
            this.comboBoxMesas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNomeAmigavel = new System.Windows.Forms.TextBox();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.dataGridViewMesas = new System.Windows.Forms.DataGridView();
            this.buttonReatualizar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxQuantidadeDeJogadores = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxMesas
            // 
            this.comboBoxMesas.FormattingEnabled = true;
            this.comboBoxMesas.Location = new System.Drawing.Point(12, 25);
            this.comboBoxMesas.Name = "comboBoxMesas";
            this.comboBoxMesas.Size = new System.Drawing.Size(272, 21);
            this.comboBoxMesas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mesas do Arquivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Amigável";
            // 
            // textBoxNomeAmigavel
            // 
            this.textBoxNomeAmigavel.Location = new System.Drawing.Point(12, 84);
            this.textBoxNomeAmigavel.Name = "textBoxNomeAmigavel";
            this.textBoxNomeAmigavel.Size = new System.Drawing.Size(272, 20);
            this.textBoxNomeAmigavel.TabIndex = 3;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(18, 174);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 4;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // dataGridViewMesas
            // 
            this.dataGridViewMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMesas.Location = new System.Drawing.Point(12, 219);
            this.dataGridViewMesas.Name = "dataGridViewMesas";
            this.dataGridViewMesas.Size = new System.Drawing.Size(595, 150);
            this.dataGridViewMesas.TabIndex = 5;
            this.dataGridViewMesas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMesas_CellDoubleClick);
            // 
            // buttonReatualizar
            // 
            this.buttonReatualizar.Location = new System.Drawing.Point(322, 23);
            this.buttonReatualizar.Name = "buttonReatualizar";
            this.buttonReatualizar.Size = new System.Drawing.Size(75, 23);
            this.buttonReatualizar.TabIndex = 6;
            this.buttonReatualizar.Text = "Reatualizar";
            this.buttonReatualizar.UseVisualStyleBackColor = true;
            this.buttonReatualizar.Click += new System.EventHandler(this.buttonReatualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade de jogadores";
            // 
            // comboBoxQuantidadeDeJogadores
            // 
            this.comboBoxQuantidadeDeJogadores.FormattingEnabled = true;
            this.comboBoxQuantidadeDeJogadores.Location = new System.Drawing.Point(12, 136);
            this.comboBoxQuantidadeDeJogadores.Name = "comboBoxQuantidadeDeJogadores";
            this.comboBoxQuantidadeDeJogadores.Size = new System.Drawing.Size(272, 21);
            this.comboBoxQuantidadeDeJogadores.TabIndex = 7;
            // 
            // FormMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 388);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxQuantidadeDeJogadores);
            this.Controls.Add(this.buttonReatualizar);
            this.Controls.Add(this.dataGridViewMesas);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.textBoxNomeAmigavel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMesas);
            this.Name = "FormMesas";
            this.Text = "Mesas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMesas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNomeAmigavel;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.DataGridView dataGridViewMesas;
        private System.Windows.Forms.Button buttonReatualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxQuantidadeDeJogadores;
    }
}