using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilClasses;
using NUnit.Framework;

namespace UtilClasses.Test
{
    public class tstUser
    {
        private User user = User.GetInstance();

        [Test]
        public void T001_SingleInstance()
        {
            Assert.AreEqual(user, User.GetInstance());
        }

        [Test]
        public void T002_SetUsernameCorrect()
        {
            user.Username = "André";
            Assert.AreEqual("André", user.Username);
        }

        [Test]
        public void T002_SetPasswordCorrect()
        {
            user.Password = "12345678";
            Assert.AreEqual("12345678", user.Password);
        }

        [Test]
        public void T002_GetCoinsCorrect()
        {
            Assert.AreEqual(1000, user.Coins);
        }

        [Test]
        public void T002_SetInvalidUsername()
        {
            // the exception we expect thrown from the IsValidFileName method
            var ex = Assert.Throws<Exception>(() => user.Username = "");

            // now we can test the exception itself
            Assert.That(ex.Message == "O Login não pode ser nulo.");
        }

        [Test]
        public void T002_SetInvalidPassword1()
        {
            // the exception we expect thrown from the IsValidFileName method
            var ex = Assert.Throws<Exception>(() => user.Password = "1234");

            // now we can test the exception itself
            Assert.That(ex.Message == "A senha deve ter no mínimo 10 caracteres.");
        }

        [Test]
        public void T002_SetInvalidPassword2()
        {
            // the exception we expect thrown from the IsValidFileName method
            var ex = Assert.Throws<Exception>(() => user.Password = "");

            // now we can test the exception itself
            Assert.That(ex.Message == "A senha não pode ser nula.");
        }

    }
}
