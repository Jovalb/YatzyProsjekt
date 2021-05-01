using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YatzyBibliotek;

namespace YatzyBibliotekTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEnere()
        {
            string terningKast = "1,1,1,1,1";
            PoengBibliotek poengBibliotek = new PoengBibliotek();

            int resultat = poengBibliotek.kalkulerPoengsum(terningKast, "enere");

            Assert.AreEqual(5,resultat);
        }
    }
}
