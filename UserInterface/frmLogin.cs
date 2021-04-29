using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilClasses;

namespace UserInterface
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                DataBase db = DataBase.GetInstance("Usuarios.xml");

                if (db.VerifyLogin(txtUsername.Text, txtPassword.Text))
                {
                    MessageBox.Show("Login efetuado com sucesso!!!");
                    frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    throw new Exception("Usuário ou senha incorretos!!!");
                }

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tsbRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }

        private void tsbForgot_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword();
            frm.ShowDialog();
        }
    }
}
