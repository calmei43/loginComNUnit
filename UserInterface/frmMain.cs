using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilClasses;

namespace UserInterface
{
    public partial class frmMain : Form
    {
        private DataBase db;
        private User currentUser;

        public frmMain()
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

        private void btnAlavanca_Click(object sender, EventArgs e)
        {
            btnAlavanca.Enabled = false;
            btnAlavanca.BackgroundImage = imageList.Images[1];

            AtivaTimer(columns[indexColumns], timer1);

            ControlaColunas();
        }

        private void frmTesteFinalUser_Load(object sender, EventArgs e)
        {
            SetPictureBoxColumns();
        }

        #region Roleta

        #region Variáveis Locais
        private static Random random = new Random();
        private bool ativaMovimentoA = false;
        private bool ativaMovimentoB = false;
        private bool ativaMovimentoC = false;
        private static int contadorTempo = 1;
        private static int deslocamento = 25;
        private static int multiplicadorVoltas;
        private static int voltaCompleta = 4;
        private static char[] columns = { 'A', 'B', 'C' };
        private static int indexColumns = 0;
        #endregion

        #region Movement Controls
        private void ControlaColunas()
        {
            if (indexColumns == 2)
            {
                indexColumns = 0;
            }
            else
            {
                indexColumns++;
            }

        }

        private void Movimenta(bool ativaMovimento, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            if (ativaMovimento)
            {
                pic1.Top -= deslocamento;
                pic2.Top -= deslocamento;
                pic3.Top -= deslocamento;
                pic4.Top -= deslocamento;
                pic5.Top -= deslocamento;
            }
        }

        public void VerificaExtremos(bool ativaMovimento, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5)
        {
            if (ativaMovimento)
            {
                if (pic1.Top <= -200)
                {
                    pic1.Top = 300;
                }
                if (pic2.Top <= -200)
                {
                    pic2.Top = 300;
                }
                if (pic3.Top <= -200)
                {
                    pic3.Top = 300;
                }
                if (pic4.Top <= -200)
                {
                    pic4.Top = 300;
                }
                if (pic5.Top <= -200)
                {
                    pic5.Top = 300;
                }
            }
        }
        #endregion

        #region Timer Controls
        private void timer_Tick(object sender, EventArgs e)
        {
            if (contadorTempo <= voltaCompleta * multiplicadorVoltas)
            {
                if (ativaMovimentoA)
                {
                    Movimenta(ativaMovimentoA, picA1, picA2, picA3, picA4, picA5);
                    VerificaExtremos(ativaMovimentoA, picA1, picA2, picA3, picA4, picA5);
                }
                else if (ativaMovimentoB)
                {
                    Movimenta(ativaMovimentoB, picB1, picB2, picB3, picB4, picB5);
                    VerificaExtremos(ativaMovimentoB, picB1, picB2, picB3, picB4, picB5);
                }
                else if (ativaMovimentoC)
                {
                    Movimenta(ativaMovimentoC, picC1, picC2, picC3, picC4, picC5);
                    VerificaExtremos(ativaMovimentoC, picC1, picC2, picC3, picC4, picC5);
                }

                contadorTempo++;
            }
            else
            {
                timer1.Enabled = false;
                ativaMovimentoA = false;
                ativaMovimentoB = false;
                ativaMovimentoC = false;
                contadorTempo = 1;
                btnAlavanca.Enabled = true;
                btnAlavanca.BackgroundImage = imageList.Images[0];
            }
        }

        private void AtivaTimer(char c, System.Windows.Forms.Timer t)
        {
            if (c == 'A')
                ativaMovimentoA = true;
            else if (c == 'B')
                ativaMovimentoB = true;
            else if (c == 'C')
                ativaMovimentoC = true;

            multiplicadorVoltas = random.Next(5, 15);
            t.Enabled = true;
        }
        #endregion

        #region PictureBox Controls
        private int[] indexImages = { 0, 0, 1, 1, 2}; //Cereja = 0, Laranja = 1, Seven = 2
        private int[] indexImagesColumnA = new int[5];
        private int[] indexImagesColumnB = new int[5];
        private int[] indexImagesColumnC = new int[5];

        private void SetPictureBoxColumns()
        {
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;

            SetSequenceImages();

            foreach (PictureBox item in Roleta.Controls)
            {
                if(item.Tag.ToString() == "A")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnA[indexA]];
                    indexA++;
                }
                if (item.Tag.ToString() == "B")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnB[indexB]];
                    indexB++;
                }
                if (item.Tag.ToString() == "C")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnC[indexC]];
                    indexC++;
                }
            }
        }

        private void SetSequenceImages()
        {
            int[] auxA = VetorSemRepeticao();
            int[] auxB = VetorSemRepeticao();
            int[] auxC = VetorSemRepeticao();

            for (int i = 0; i < 5; i++)
            {
                indexImagesColumnA[i] = indexImages[auxA[i]];
                indexImagesColumnB[i] = indexImages[auxB[i]];
                indexImagesColumnC[i] = indexImages[auxC[i]];
            } 
        }

        private int[] VetorSemRepeticao()
        {
            HashSet<int> listaSemRepeticao = new HashSet<int>();
            int contador = 0;

            do
            {
                if (listaSemRepeticao.Add(random.Next(0, 5)))
                {
                    contador++;
                }
            } while (contador < 5);

            return listaSemRepeticao.ToArray();
        }

        #endregion

        #endregion

    }
}
