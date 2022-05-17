using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Kettes;

namespace KettesTeszt
{
    [TestClass]
    public class UnitTest1
    {
        Ketteske osztaly = new Ketteske();

        [TestMethod]
        public void KettesSzamrendszer1()
        {
            string varteredmeny = "1111011";

            string kapotteredmeny = osztaly.atvalto(123);

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void KettesSzamrendszer2()
        {
            string varteredmeny = "101000011";

            string kapotteredmeny = osztaly.atvalto(321);

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void KettesSzamrendszer3()
        {
            string varteredmeny = "11011110";

            string kapotteredmeny = osztaly.atvalto(222);

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
