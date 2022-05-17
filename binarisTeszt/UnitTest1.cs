using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Binaris;

namespace binarisTeszt
{
    [TestClass]
    public class UnitTest1
    {
        static string szam = "1010111001";
        Binarisok osztaly = new Binarisok(szam);

        [TestMethod]

        public void egyesek()
        {
            int varteredmeny = 6;

            int kapotteredmeny = osztaly.szamolas();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
