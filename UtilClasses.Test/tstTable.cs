using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilClasses;
using System.IO;
using NUnit.Framework;
using System.Security.Cryptography;

namespace UtilClasses.Test
{
    public class tstTable
    {
        private Table table = Table.GetInstance("UsuariosTest.xml");
        private User user = new User();

        [Test]
        public void T001_SingleInstance()
        {
            Assert.AreEqual(table, Table.GetInstance("UsuariosTest.xml"));
        }

        [Test]
        public void T002_AddRow()
        {
            T006_DeleteForRepeatUnitTests();

            bool verify;

            try
            {
                user.Username = "Teste1";
                user.Password = "12345678";

                table.AddRow(user);

                verify = true;
            }
            catch (Exception erro)
            {
                verify = false;
                Console.Write(erro.Message);
            }

            Assert.AreEqual(true, verify);

        }

        [Test]
        public void T003_VerifyUsernameExistsTrue()
        {
            Assert.AreEqual(true, table.VerifyUsernameExists("Teste1"));
        }

        [Test]
        public void T003_VerifyUsernameExistsFalse()
        {
            Assert.AreNotEqual(true, table.VerifyUsernameExists("Teste2"));
        }

        [Test]
        public void T004_VerifyLoginTrue()
        {
            Assert.AreEqual(true, table.VerifyLogin(user.Username, user.Password));
        }

        [Test]
        public void T004_VerifyLoginFalse()
        {
            Assert.AreNotEqual(true, table.VerifyLogin("Teste2", "87654321"));
        }

        [Test]
        public void T005_Save()
        {
            bool verify;

            try
            {
                table.Save("UsuariosTest.xml");
                verify = true;
            }
            catch (Exception)
            {
                verify = false;
            }

            Assert.AreEqual(true, verify);
        }

        [Test]
        public void T006_DeleteForRepeatUnitTests()
        {
            bool verify;

            try
            {
                File.Delete("UsuariosTest.xml");
                table.dt.Clear();

                verify = true;
            }
            catch (Exception)
            {
                verify = false;
            }

            Assert.AreEqual(true, verify);
        }
    }
}
