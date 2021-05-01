using Syncfusion.Windows.Forms.Tools;
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
        //Variáveis de Controle de Usuário
        private DataBase db;
        private User currentUser;

        public frmMain()
        {
            InitializeComponent();

            db = DataBase.GetInstance(); //Pega a última Instância
            currentUser = db.GetFinalUser(); //Devolve o último Usuário

            //Seta a barra de Status
            tslCoins.Text = "Coins: "  + currentUser.Coins;
            tslUsername.Text = "Usuário: " + currentUser.Username;
        }

        //Fecha o forms e salva as modificações no arquico .xml
        private void exit_Click(object sender, EventArgs e)
        {
            db.SaveUser(currentUser);
            db.Save("Usuarios.xml");
            this.Close();
        }

        //Aciona a lógica da roleta Coluna por Coluna
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

        //Controla qual coluna sera acionada
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

        //Movimenta as PictureBox passadas como parâmetro
        private void Movimenta(bool ativaMovimento, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6)
        {
            if (ativaMovimento)
            {
                pic1.Top -= deslocamento;
                pic2.Top -= deslocamento;
                pic3.Top -= deslocamento;
                pic4.Top -= deslocamento;
                pic5.Top -= deslocamento;
                pic6.Top -= deslocamento;
            }
        }

        //Verifica ser as PictureBox passaram o limite superior
        //do Panel "Roleta" e as joga para o final
        public void VerificaExtremos(bool ativaMovimento, PictureBox pic1, PictureBox pic2, PictureBox pic3, PictureBox pic4, PictureBox pic5, PictureBox pic6)
        {
            if (ativaMovimento)
            {
                if (pic1.Top <= -200)
                {
                    pic1.Top = 400;
                }
                if (pic2.Top <= -200)
                {
                    pic2.Top = 400;
                }
                if (pic3.Top <= -200)
                {
                    pic3.Top = 400;
                }
                if (pic4.Top <= -200)
                {
                    pic4.Top = 400;
                }
                if (pic5.Top <= -200)
                {
                    pic5.Top = 400;
                }
                if (pic6.Top <= -200)
                {
                    pic6.Top = 400;
                }
            }
        }
        #endregion

        #region Timer Controls

        //Realiza a lógica da roleta de acordo com o tempo passado
        private void timer_Tick(object sender, EventArgs e)
        {
            if (contadorTempo <= voltaCompleta * multiplicadorVoltas)
            {
                if (ativaMovimentoA)
                {
                    Movimenta(ativaMovimentoA, picA1, picA2, picA3, picA4, picA5, picA6);
                    VerificaExtremos(ativaMovimentoA, picA1, picA2, picA3, picA4, picA5, picA6);
                }
                else if (ativaMovimentoB)
                {
                    Movimenta(ativaMovimentoB, picB1, picB2, picB3, picB4, picB5, picB6);
                    VerificaExtremos(ativaMovimentoB, picB1, picB2, picB3, picB4, picB5, picB6);
                }
                else if (ativaMovimentoC)
                {
                    Movimenta(ativaMovimentoC, picC1, picC2, picC3, picC4, picC5, picC6);
                    VerificaExtremos(ativaMovimentoC, picC1, picC2, picC3, picC4, picC5, picC6);
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

                if (indexColumns == 0)
                    VerificaResultado();
            }
        }
        
        //Ativa o Timer e controla a coluna atual de acordo com o
        //char passado como parâmetro ('A', 'B', 'C')
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

        //Index das imagens na ImageList
        private int[] indexImages = { 0, 0, 0, 1, 1, 2}; //Cereja = 0, Laranja = 1, Seven = 2

        //Index das imagens em cada coluna
        private int[] indexImagesColumnA = new int[6];
        private int[] indexImagesColumnB = new int[6];
        private int[] indexImagesColumnC = new int[6];

        //Seta as PictureBox da roleta
        private void SetPictureBoxColumns()
        {
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;

            SetSequenceImages(); 

            //Varre todas as PictureBox no panel "Roleta"
            foreach (PictureBox item in Roleta.Controls)
            {
                if(item.Tag.ToString() == "A")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnA[indexA]];
                    SetTextOfPictureBox(item, indexImagesColumnA[indexA]);
                    indexA++;
                }
                if (item.Tag.ToString() == "B")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnB[indexB]];
                    SetTextOfPictureBox(item, indexImagesColumnB[indexB]);
                    indexB++;
                }
                if (item.Tag.ToString() == "C")
                {
                    item.BackgroundImage = imageList1.Images[indexImagesColumnC[indexC]];
                    SetTextOfPictureBox(item, indexImagesColumnC[indexC]);
                    indexC++;
                }
            }
        }

        //Seta a propriedade AccessibleDescription da PictureBox com o index de sua imagem
        private void SetTextOfPictureBox(PictureBox pic, int imageIndex)
        {
            pic.AccessibleDescription = imageIndex.ToString();
        }

        //Seta a sequência das imagens nas colunas de forma aleatória
        private void SetSequenceImages()
        {
            int[] auxA = VetorSemRepeticao();
            int[] auxB = VetorSemRepeticao();
            int[] auxC = VetorSemRepeticao();

            for (int i = 0; i < 6; i++)
            {
                indexImagesColumnA[i] = indexImages[auxA[i]];
                indexImagesColumnB[i] = indexImages[auxB[i]];
                indexImagesColumnC[i] = indexImages[auxC[i]];
            } 
        }

        //Vetor de inteiros com números de 0 à 5 listados de forma 
        //aleatória sem repetição
        private int[] VetorSemRepeticao()
        {
            //O HashSet não aceita valores repetidos e quando 
            //tentar adicionar um, ele não aceita e retorna false
            HashSet<int> listaSemRepeticao = new HashSet<int>();
            int contador = 0;

            do
            {

                if (listaSemRepeticao.Add(random.Next(0, 6)))
                {
                    contador++;
                }

            } while (contador < 6);

            return listaSemRepeticao.ToArray();
        }

        #endregion

        private void VerificaResultado()
        {
            List<PictureBox> result = new List<PictureBox>();

            foreach(PictureBox pics in Roleta.Controls)
            {
                if (pics.Location.Y == 100)
                {
                    result.Add(pics);
                }
            }

            if (result[0].AccessibleDescription == result[1].AccessibleDescription
            && result[0].AccessibleDescription == result[2].AccessibleDescription)
                MessageBox.Show("Você ganhou!");
            else
                MessageBox.Show("Você perdeu!");
        }

        #endregion

    }
}
