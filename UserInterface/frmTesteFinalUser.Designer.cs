
namespace UserInterface
{
    partial class frmTesteFinalUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteFinalUser));
            this.tsDetails = new System.Windows.Forms.ToolStrip();
            this.tslUsername = new System.Windows.Forms.ToolStripLabel();
            this.tslCoins = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTeste = new System.Windows.Forms.Button();
            this.Configurações = new System.Windows.Forms.ToolStripDropDownButton();
            this.diagramaEmÁrvoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagramaEmÁrvoreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tsDetails.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsDetails
            // 
            this.tsDetails.BackColor = System.Drawing.Color.LightGray;
            this.tsDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslUsername,
            this.tslCoins});
            this.tsDetails.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsDetails.Location = new System.Drawing.Point(0, 261);
            this.tsDetails.Name = "tsDetails";
            this.tsDetails.Size = new System.Drawing.Size(343, 18);
            this.tsDetails.TabIndex = 0;
            this.tsDetails.Text = "toolStrip1";
            // 
            // tslUsername
            // 
            this.tslUsername.Name = "tslUsername";
            this.tslUsername.Size = new System.Drawing.Size(102, 15);
            this.tslUsername.Text = "Usuário: #######";
            // 
            // tslCoins
            // 
            this.tslCoins.Name = "tslCoins";
            this.tslCoins.Size = new System.Drawing.Size(71, 15);
            this.tslCoins.Text = "Coins: ####";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Configurações,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(343, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.toolStripButton1.Text = "Exit";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 200);
            this.panel1.TabIndex = 2;
            // 
            // btnTeste
            // 
            this.btnTeste.BackgroundImage = global::UserInterface.Properties.Resources.interruptor_de_alavanca__2_;
            this.btnTeste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeste.Location = new System.Drawing.Point(243, 81);
            this.btnTeste.Name = "btnTeste";
            this.btnTeste.Size = new System.Drawing.Size(70, 140);
            this.btnTeste.TabIndex = 3;
            this.btnTeste.UseVisualStyleBackColor = true;
            this.btnTeste.Click += new System.EventHandler(this.btnTeste_Click);
            // 
            // Configurações
            // 
            this.Configurações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramaEmÁrvoreToolStripMenuItem});
            this.Configurações.Image = ((System.Drawing.Image)(resources.GetObject("Configurações.Image")));
            this.Configurações.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Configurações.Name = "Configurações";
            this.Configurações.Size = new System.Drawing.Size(76, 22);
            this.Configurações.Text = "Opções";
            // 
            // diagramaEmÁrvoreToolStripMenuItem
            // 
            this.diagramaEmÁrvoreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagramaEmÁrvoreToolStripMenuItem1,
            this.tabelaToolStripMenuItem});
            this.diagramaEmÁrvoreToolStripMenuItem.Name = "diagramaEmÁrvoreToolStripMenuItem";
            this.diagramaEmÁrvoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diagramaEmÁrvoreToolStripMenuItem.Text = "Cálculo Esperança";
            // 
            // diagramaEmÁrvoreToolStripMenuItem1
            // 
            this.diagramaEmÁrvoreToolStripMenuItem1.Name = "diagramaEmÁrvoreToolStripMenuItem1";
            this.diagramaEmÁrvoreToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.diagramaEmÁrvoreToolStripMenuItem1.Text = "Diagrama em Árvore";
            // 
            // tabelaToolStripMenuItem
            // 
            this.tabelaToolStripMenuItem.Name = "tabelaToolStripMenuItem";
            this.tabelaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tabelaToolStripMenuItem.Text = "Tabela";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "off");
            this.imageList.Images.SetKeyName(1, "on");
            // 
            // frmTesteFinalUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 279);
            this.Controls.Add(this.btnTeste);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tsDetails);
            this.Name = "frmTesteFinalUser";
            this.Text = "FinalUser";
            this.tsDetails.ResumeLayout(false);
            this.tsDetails.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsDetails;
        private System.Windows.Forms.ToolStripLabel tslUsername;
        private System.Windows.Forms.ToolStripLabel tslCoins;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTeste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Configurações;
        private System.Windows.Forms.ToolStripMenuItem diagramaEmÁrvoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagramaEmÁrvoreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tabelaToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList;
    }
}