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
        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            DataBase db = DataBase.GetInstance("Usuarios.xml");

            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    if (db.EditPassword(txtUsername.Text, txtSenha1.Text))
                    {
                        MessageBox.Show("Senha Alterada com sucesso!!!");
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("Usuário inexistente!!");
                    }
                }
                else
                {
                    throw new Exception("A senhas não coincidem!!!");
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
