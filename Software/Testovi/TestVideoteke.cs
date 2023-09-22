using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using E_videoteka;

namespace Testovi
{
    [TestClass]
    public class TestVideoteke
    {
        [TestMethod]
        public void TestMethod1()
        {
            Autentifikator autentifikator = new Autentifikator();
            Assert.ThrowsException<PasswordMissMatchException>(() => autentifikator.ProvjeriLozinku("123", "1234"));
            
        }
        [TestMethod]
        public void TestMethod2()
        {
            Autentifikator autentifikator = new Autentifikator();
            Assert.ThrowsException<InvalidInputException>(() => autentifikator.VerificirajRegistraciju("", "dada", "dada", "dada", "123", "123"));
        }
        [TestMethod]
        public void TestMethod3()
        {

        }
    }
}
