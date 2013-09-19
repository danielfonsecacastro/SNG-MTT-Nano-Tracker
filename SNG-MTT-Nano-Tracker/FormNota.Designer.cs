using SNGMTTNanoTracker;
namespace Poker
{
    partial class FormNota
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNota));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.topToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelInstrucao = new SNGMTTNanoTracker.GrowLabel();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTodasAcoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarShowdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fecharToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // topToolStripMenuItem
            // 
            this.topToolStripMenuItem.Checked = true;
            this.topToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.topToolStripMenuItem.Name = "topToolStripMenuItem";
            this.topToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.topToolStripMenuItem.Text = "Top";
            this.topToolStripMenuItem.Click += new System.EventHandler(this.topToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // labelInstrucao
            // 
            this.labelInstrucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstrucao.ForeColor = System.Drawing.Color.Blue;
            this.labelInstrucao.Location = new System.Drawing.Point(5, 4);
            this.labelInstrucao.Name = "labelInstrucao";
            this.labelInstrucao.Size = new System.Drawing.Size(132, 13);
            this.labelInstrucao.TabIndex = 4;
            this.labelInstrucao.Text = "-";
            this.labelInstrucao.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.labelInstrucao.MouseEnter += new System.EventHandler(this.FormEstrategia_MouseEnter);
            this.labelInstrucao.MouseLeave += new System.EventHandler(this.FormEstrategia_MouseLeave);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Enabled = false;
            this.buttonSalvar.Location = new System.Drawing.Point(8, 24);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(122, 23);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "Aguardando Mão";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            this.buttonSalvar.MouseEnter += new System.EventHandler(this.FormEstrategia_MouseEnter);
            this.buttonSalvar.MouseLeave += new System.EventHandler(this.FormEstrategia_MouseLeave);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarTodasAcoesToolStripMenuItem,
            this.salvarShowdownToolStripMenuItem,
            this.nadaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Notas";
            // 
            // salvarTodasAcoesToolStripMenuItem
            // 
            this.salvarTodasAcoesToolStripMenuItem.Name = "salvarTodasAcoesToolStripMenuItem";
            this.salvarTodasAcoesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salvarTodasAcoesToolStripMenuItem.Text = "Todas Ações";
            // 
            // salvarShowdownToolStripMenuItem
            // 
            this.salvarShowdownToolStripMenuItem.Name = "salvarShowdownToolStripMenuItem";
            this.salvarShowdownToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salvarShowdownToolStripMenuItem.Text = "Todos Showdown";
            // 
            // nadaToolStripMenuItem
            // 
            this.nadaToolStripMenuItem.Name = "nadaToolStripMenuItem";
            this.nadaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.nadaToolStripMenuItem.Text = "Nada";
            // 
            // FormEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(142, 59);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelInstrucao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstrategia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mãos";
            this.toolTip1.SetToolTip(this, "Nenhuma mesa selecionada!");
            this.DoubleClick += new System.EventHandler(this.FormEstrategia_DoubleClick);
            this.Leave += new System.EventHandler(this.FormEstrategia_Leave);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.MouseEnter += new System.EventHandler(this.FormEstrategia_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.FormEstrategia_MouseLeave);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private GrowLabel labelInstrucao;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarTodasAcoesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarShowdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nadaToolStripMenuItem;
    }
}

