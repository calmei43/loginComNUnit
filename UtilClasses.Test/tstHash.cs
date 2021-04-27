using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UtilClasses;

namespace UtilClasses.Test
{
    public class tstHash
    {
        [Test]
        public void T001_Instance()
        {
            Hash hash = new Hash(SHA512.Create());

            Assert.IsInstanceOf<Hash>(hash);
        }

        [Test]
        public void T002_Criptografia()
        {
            Hash hash = new Hash(SHA512.Create());

            string senhaPadrao = "12345678";
            string senhaHash = hash.CriptografarSenha(senhaPadrao);

            Assert.AreEqual(senhaHash, hash.CriptografarSenha(senhaPadrao));
        }

        [Test]
        public void T003_VerificarSenha()
        {
            Hash hash = new Hash(SHA512.Create());

            string senhaPadrao = "12345678";
            string senhaHash = hash.CriptografarSenha(senhaPadrao);

            Assert.AreEqual(true, hash.VerificarSenha(senhaPadrao, senhaHash));

        }
    }
}
