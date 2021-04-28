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
    public partial class frmTesteFinalUser : Form
    {
        private DataBase db;
        private User currentUser;
        private bool On = false;

        public frmTesteFinalUser()
        {
            InitializeComponent();
            db = DataBase.GetInstance();
            currentUser = db.GetFinalUser();
            tslCoins.Text = "Coins: "  + currentUser.Coins;
            tslUsername.Text = "Usuário: " + currentUser.Username;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            db.SaveUser(currentUser);
            db.Save("Usuarios.xml");
            this.Close();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (On)
            {
                On = false;
                btnTeste.BackgroundImage = imageList.Images[0];
            }
            else
            {
                On = true;
                btnTeste.BackgroundImage = imageList.Images[1];
            }


            Random rdm = new Random();
            int num = rdm.Next(1,10);
            try
            {
                if (num % 2 == 0)
                {
                    currentUser.Coins += 100;
                    tslCoins.Text = "Coins: " + currentUser.Coins;
                }
                else
                {
                    currentUser.Coins -= 100;
                    tslCoins.Text = "Coins: " + currentUser.Coins;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
