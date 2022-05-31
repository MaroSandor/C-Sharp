using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using szigetek;

namespace SzigetekUt
{
    [TestClass]
    public class UnitTest1
    {
        Sziget osztaly = new Sziget();

        [TestMethod]
        public void szigetszamJo()
        {
            int varteredmeny = 8;

            int kapotteredmeny = osztaly.szigetszam("11101011101011100011110000100111");

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }
        
        [TestMethod]
        public void szigetszamRossz()
        {
            int varteredmeny = 7;

            int kapotteredmeny = osztaly.szigetszam("11101011101011100011110000100111");

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void szigethosszJo()
        {
            int varteredmeny = 4;

            int kapotteredmeny = osztaly.szigethossz("11101011101011100011110000100111");

            Assert.AreEqual(kapotteredmeny, varteredmeny);
        }

        [TestMethod]
        public void szigethosszRossz()
        {
            int varteredmeny = 3;

            int kapotteredmeny = osztaly.szigethossz("11101011101011100011110000100111");

            Assert.AreNotEqual(kapotteredmeny, varteredmeny);
        }
    }
}
