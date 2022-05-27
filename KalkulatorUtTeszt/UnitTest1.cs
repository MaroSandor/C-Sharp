using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KalkulatorUt;

namespace KalkulatorUtTeszt
{
    [TestClass]
    public class UnitTest1
    {
        Calculator osztaly = new Calculator();

        [TestMethod]
        public void osszeadRossz()
        {
            int varteredmeny = 5;

            int kapotteredmeny = osztaly.szamitas(15, 5, '+');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osszeadJo()
        {
            int varteredmeny = 20;

            int kapotteredmeny = osztaly.szamitas(15, 5, '+');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonRossz()
        {
            int varteredmeny = 10;

            int kapotteredmeny = osztaly.szamitas(5, 5, '-');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonJo()
        {
            int varteredmeny = 10;

            int kapotteredmeny = osztaly.szamitas(15, 5, '-');

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void szorozRossz()
        {
            int varteredmeny = 15;

            int kapotteredmeny = osztaly.szamitas(2, 5, '*');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void szorozJo()
        {
            int varteredmeny = 10;

            int kapotteredmeny = osztaly.szamitas(2, 5, '*');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztRossz()
        {
            int varteredmeny = 3;

            int kapotteredmeny = osztaly.szamitas(10, 5, '/');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztJo()
        {
            int varteredmeny = 2;

            int kapotteredmeny = osztaly.szamitas(10, 5, '/');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztasNullaval()
        {
            string varteredmeny = "0-val való osztás értelmetlen";

            int kapotteredmeny = osztaly.szamitas(10, 0, '/');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }
    }
}
