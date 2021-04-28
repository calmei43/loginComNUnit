using System;
using System.Windows.Forms;
using UtilClasses;

namespace UserInterface
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            DataBase db = DataBase.GetInstance("Usuarios.xml");
            
            try
            {
                if (txtSenha1.Text == txtSenha2.Text)
                {
                    User user = new User();

                    user.Username = txtUsername.Text;
                    user.Password = txtSenha1.Text;
                    user.Coins = 1000;

                    db.AddUser(user);

                    db.Save("Usuarios.xml");

                    MessageBox.Show("Cadastro realizado com sucesso!!!");
                    this.Close();
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
