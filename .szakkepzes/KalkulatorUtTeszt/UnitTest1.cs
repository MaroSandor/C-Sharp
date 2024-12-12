using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KalkulatorUt;
using System.IO;

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

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(15, 5, '+');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osszeadJo()
        {
            int varteredmeny = 20;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(15, 5, '+');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonRossz()
        {
            int varteredmeny = 10;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(5, 5, '-');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void kivonJo()
        {
            int varteredmeny = 10;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(15, 5, '-');

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void szorozRossz()
        {
            int varteredmeny = 15;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(2, 5, '*');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void szorozJo()
        {
            int varteredmeny = 10;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(2, 5, '*');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztRossz()
        {
            int varteredmeny = 3;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(10, 5, '/');

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztJo()
        {
            int varteredmeny = 2;

            int kapotteredmeny = KalkulatorUt.Calculator.szamitas(10, 5, '/');

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void osztasNullaval()
        {
            string varteredmeny = "0-val való osztás értelmetlen";

            string kapotteredmeny;

            using (var szoveg = new StringWriter())
            {
                Console.SetOut(szoveg);

                KalkulatorUt.Calculator.szamitas(10, 0, '/');

                kapotteredmeny = szoveg.ToString().Trim();
            }

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }
    }
}
