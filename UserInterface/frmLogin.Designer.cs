namespace UserInterface
{
    partial class frmLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRegister = new System.Windows.Forms.ToolStripButton();
            this.tsbForgot = new System.Windows.Forms.ToolStripButton();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnSingIn = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRegister,
            this.tsbForgot});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(284, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRegister
            // 
            this.tsbRegister.Image = ((System.Drawing.Image)(resources.GetObject("tsbRegister.Image")));
            this.tsbRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRegister.Name = "tsbRegister";
            this.tsbRegister.Size = new System.Drawing.Size(81, 24);
            this.tsbRegister.Text = "Cadastrar";
            this.tsbRegister.Click += new System.EventHandler(this.tsbRegister_Click);
            // 
            // tsbForgot
            // 
            this.tsbForgot.Image = ((System.Drawing.Image)(resources.GetObject("tsbForgot.Image")));
            this.tsbForgot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbForgot.Name = "tsbForgot";
            this.tsbForgot.Size = new System.Drawing.Size(115, 24);
            this.tsbForgot.Text = "Esqueci a Senha";
            this.tsbForgot.Click += new System.EventHandler(this.tsbForgot_Click);
            // 
            // picLogin
            // 
            this.picLogin.Location = new System.Drawing.Point(11, 48);
            this.picLogin.Margin = new System.Windows.Forms.Padding(2);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(75, 80);
            this.picLogin.TabIndex = 1;
            this.picLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 48);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(174, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(98, 92);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(174, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // btnSingIn
            // 
            this.btnSingIn.Location = new System.Drawing.Point(215, 122);
            this.btnSingIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnSingIn.Name = "btnSingIn";
            this.btnSingIn.Size = new System.Drawing.Size(56, 19);
            this.btnSingIn.TabIndex = 6;
            this.btnSingIn.Text = "Entrar";
            this.btnSingIn.UseVisualStyleBackColor = true;
            this.btnSingIn.Click += new System.EventHandler(this.btnSingIn_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 151);
            this.Controls.Add(this.btnSingIn);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.Button btnSingIn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton tsbRegister;
        public System.Windows.Forms.ToolStripButton tsbForgot;
    }
}

