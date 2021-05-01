using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using YatzyBibliotek;

namespace YatzyBibliotekTest
{
    [TestClass]
    public class EnhetsTest1
    {
        public PoengBibliotek poengBibliotek = new PoengBibliotek();

        [TestMethod]
        public void TestEnere()
        {
            string [] terningKast = {"1,1,1,1,1","1,1,2,2,2","1,2,3,4,5"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "enere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "enere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "enere");

            Assert.AreEqual(5,resultat1);
            Assert.AreEqual(2,resultat2);
            Assert.AreEqual(1,resultat3);
        }

        [TestMethod]
        public void TestToere()
        {
            string [] terningKast = {"1,1,1,1,1","1,1,2,2,2","1,2,3,4,5"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "toere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "toere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "toere");

            Assert.AreEqual(0,resultat1);
            Assert.AreEqual(6,resultat2);
            Assert.AreEqual(2,resultat3);
        }

        [TestMethod]
        public void TestTreere()
        {
            string [] terningKast = {"3,3,3,3,3","1,1,3,2,2","1,3,3,4,5"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "treere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "treere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "treere");

            Assert.AreEqual(15,resultat1);
            Assert.AreEqual(3,resultat2);
            Assert.AreEqual(6,resultat3);
        }

        [TestMethod]
        public void TestFirere()
        {
            string [] terningKast = {"1,4,1,4,1","1,1,2,2,2","4,2,4,4,6"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "firere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "firere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "firere");

            Assert.AreEqual(8,resultat1);
            Assert.AreEqual(0,resultat2);
            Assert.AreEqual(12,resultat3);
        }

        [TestMethod]
        public void TestFemmere()
        {
            string [] terningKast = {"5,5,4,4,4","1,2,3,5,5","5,1,3,4,4"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "femmere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "femmere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "femmere");

            Assert.AreEqual(10,resultat1);
            Assert.AreEqual(10,resultat2);
            Assert.AreEqual(5,resultat3);
        }

        [TestMethod]
        public void TestSeksere()
        {
            string [] terningKast = {"1,4,1,4,1","6,2,3,6,5","4,2,4,4,6"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "seksere");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "seksere");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "seksere");

            Assert.AreEqual(0,resultat1);
            Assert.AreEqual(12,resultat2);
            Assert.AreEqual(6,resultat3);
        }

        [TestMethod]
        public void TestPar()
        {
            string [] terningKast = {"1,4,1,4,1","1,6,2,3,1","5,2,4,4,5"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "par");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "par");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "par");

            Assert.AreEqual(8,resultat1);
            Assert.AreEqual(2,resultat2);
            Assert.AreEqual(10,resultat3);
        }

        [TestMethod]
        public void ToPar()
        {
            string [] terningKast = {"1,4,1,4,1","1,1,2,2,2","4,2,4,4,6"};

            int resultat1 = poengBibliotek.kalkulerPoengsum(terningKast[0], "to par");
            int resultat2 = poengBibliotek.kalkulerPoengsum(terningKast[1], "to par");
            int resultat3 = poengBibliotek.kalkulerPoengsum(terningKast[2], "to par");

            Assert.AreEqual(10,resultat1);
            Assert.AreEqual(6,resultat2);
            Assert.AreEqual(0,resultat3);
        }

        

        

    }
}
