
namespace UserInterface
{
    partial class FrmTabela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTabela));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dgTabela = new System.Windows.Forms.DataGridView();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probabilidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Esperanca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripButton1.Text = "SAIR";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dgTabela
            // 
            this.dgTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Valor,
            this.Probabilidade,
            this.Esperanca});
            this.dgTabela.Location = new System.Drawing.Point(97, 103);
            this.dgTabela.Name = "dgTabela";
            this.dgTabela.Size = new System.Drawing.Size(423, 150);
            this.dgTabela.TabIndex = 2;
            // 
            // Valor
            // 
            this.Valor.Frozen = true;
            this.Valor.HeaderText = "X";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Probabilidade
            // 
            this.Probabilidade.Frozen = true;
            this.Probabilidade.HeaderText = "P(x)";
            this.Probabilidade.Name = "Probabilidade";
            this.Probabilidade.ReadOnly = true;
            // 
            // Esperanca
            // 
            this.Esperanca.Frozen = true;
            this.Esperanca.HeaderText = "X.P(x)";
            this.Esperanca.Name = "Esperanca";
            this.Esperanca.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(338, 233);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "E(x) = R$ - 0,752";
            // 
            // FrmTabela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgTabela);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmTabela";
            this.Text = "FrmTabela";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dgTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probabilidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Esperanca;
        private System.Windows.Forms.TextBox textBox1;
    }
}