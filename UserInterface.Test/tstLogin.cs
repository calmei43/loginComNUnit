using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;
using UtilClasses;
using System.Drawing;
using System.Threading;

namespace UserInterface.Test
{
    public partial class tstLogin : Form
    {
        private frmLogin frm;
        private frmRegister frmRegister;

        [Test]
        public void T001_Cadastro()
        {
            bool verify;

            try
            {
                frm = new frmLogin();

                frm.Show();

                frmRegister = new frmRegister();

                frmRegister.txtUsername.Text = "Teste1";
                frmRegister.txtSenha1.Text = "12345678";
                frmRegister.txtSenha2.Text = "12345678";

                frmRegister.btnRegister.PerformClick();

                frmRegister.Close();
                frm.Close();

                verify = true;
            }
            catch (Exception erro)
            {
                verify = false;

                Console.WriteLine(erro.Message);
            }

            Assert.AreEqual(true, verify);

        }

        [Test]
        public void T002_Login()
        {
            bool verify;

            try
            {
                frm = new frmLogin();
                frm.Show();

                frm.txtUsername.Text = "Teste1";
                frm.txtPassword.Text = "12345678";

                frm.testMode = true;

                frm.btnSingIn.PerformClick();

                verify = true;
            }
            catch (Exception erro)
            {
                verify = false;

                Console.WriteLine(erro.Message);
            }

            Assert.AreEqual(true, verify);
        }
}
