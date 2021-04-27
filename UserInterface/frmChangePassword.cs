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
    public partial class frmChangePassword : Form
    {
        public bool testMode = false;

        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Table table = Table.GetInstance("Usuarios.xml");

            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    User user = User.GetInstance();

                    user.Username = txtUsername.Text;
                    user.Password = txtSenha1.Text;

                    table.EditRow(user);

                    table.Save("Usuarios.xml");

                    if (!testMode)
                        MessageBox.Show("Mudança feita com sucesso!!!");
                }
                else
                {
                    throw new Exception("A senhas não coincidem!!!");
                }
            }
            catch (Exception erro)
            {
                if (!testMode)
                    MessageBox.Show(erro.Message);
            }
        }
    }
}
