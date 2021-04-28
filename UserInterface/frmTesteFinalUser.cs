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
            Random rdm = new Random();
            int num = rdm.Next(1,10);

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
    }
}
