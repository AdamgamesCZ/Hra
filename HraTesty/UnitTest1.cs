using Hra;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HraTesty
{
    [TestClass]
    public class UnitTest1
    {
        public Hrac hrac = new Hrac("Pepik", 10, 2.24, 2.45);
        
        [TestMethod]
        public void TestDelkyJmena()
        {
            Assert.IsTrue(hrac.Jmeno.Length < 10);
        }

        [TestMethod]
        public void TestDelkyJmenaZapor()
        {
            Assert.IsFalse(hrac.Jmeno.Length < 10);
        }

        [TestMethod]
        public void TestPoziceX()
        {
            Assert.IsTrue(hrac.poziceX == 0);
        }

        [TestMethod]
        public void TestPoziceXZapor()
        {
            hrac.poziceX = 10;
            Assert.IsFalse(hrac.poziceX == 0);
        }

        [TestMethod]
        public void TestPoziceY()
        {
            Assert.IsTrue(hrac.poziceY == 0);
        }

        [TestMethod]
        public void TestPoziceYZapor()
        {
            hrac.poziceY = 10;
            Assert.IsFalse(hrac.poziceY == 0);
        }

        [TestMethod]
        public void TestOblicej()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 0, 0, 0);
            Assert.IsTrue(adamek.oblicej == 0);
        }

        [TestMethod]
        public void TestOblicejZapor()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 3, 0, 0);
            Assert.IsFalse(adamek.oblicej == 0);
        }

        [TestMethod]
        public void TestVlasy()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 0, 0, 0);
            Assert.IsTrue(adamek.vlasy == 0);
        }
        [TestMethod]
        public void TestVlasyZapor()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 0, 3, 0);
            Assert.IsFalse(adamek.vlasy == 0);
        }

        [TestMethod]
        public void TestBarvaVlasu()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 3, 0, 0);
            Assert.IsTrue(hrac.barvaVlasu == 0);
        }

        [TestMethod]
        public void TestBarvaVlasuZapor()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 3, 0, 0);
            Assert.IsFalse(hrac.barvaVlasu == 0);
        }

        [TestMethod]
        public void Specializace()
        {
            Hrac adamek = new Hrac("adamek", "Kouzelník", 3, 0, 0);
            Assert.IsTrue(hrac.Specializace.Contains("Kouzelník"));
            Assert.IsTrue(hrac.Specializace.Contains("Berseker"));
            Assert.IsTrue(hrac.Specializace.Contains("Inženýr"));
            Assert.IsTrue(hrac.Specializace.Contains("Cizák"));

        }
        [TestMethod]
        public void TestLevel()
        {
            Assert.IsTrue(hrac.level == 1);
        }
        [TestMethod]
        public void TestLevelZapor()
        {
            hrac.level = 3;
            Assert.IsFalse(hrac.level == 1);
        }

        [TestMethod]
        public void TestXP()
        {
            hrac.level = 3;
            Hrac adamek = new Hrac("adamek", "Kouzelník", 3, 0, 0);
            hrac.PridejXP();
            Assert.IsTrue(alex.XP == 100 * steve.level);
        }
        

    }
}
