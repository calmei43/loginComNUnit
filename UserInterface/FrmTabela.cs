using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FrmTabela : Form
    {
        public FrmTabela()
        {
            InitializeComponent();
            string[] row0 = { "4,00", "1/1000", "4/1000" };
            string[] row1 = { "2,00", "27/1000", "108/1000" };
            string[] row2 = { "0", "216/1000", "0" };
            string[] row3 = { "-1,00", "756/1000", "-774/1000" };

            dgTabela.Rows.Clear();
            dgTabela.Rows.Add(row0);
            dgTabela.Rows.Add(row1);
            dgTabela.Rows.Add(row2);
            dgTabela.Rows.Add(row3);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTabela_Load(object sender, EventArgs e)
        {            
            
        }
    }
}
