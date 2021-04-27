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
        public bool testMode = false;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSingIn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = User.GetInstance();
                user.Username = txtUsername.Text;
                user.Password = txtPassword.Text;

                Table table = Table.GetInstance("Usuarios.xml");

                if (table.VerifyLogin(user.Username, user.Password))
                {
                    if(!testMode)
                        MessageBox.Show("Login efetuado com sucesso!!!");
                }
                else
                {
                    throw new Exception("Usuário ou senha incorretos!!!");
                }

            }
            catch (Exception erro)
            {
                if (!testMode)
                    MessageBox.Show(erro.Message);
            }
            
        }

        private void tsbRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.ShowDialog();
        }
    }
}
