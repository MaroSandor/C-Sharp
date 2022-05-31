using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using minmaxvalaszto;

namespace MinMaxUt
{
    [TestClass]
    public class UnitTest1
    {
        MinMaxValasz minmax = new MinMaxValasz();

        [TestMethod]
        public void minimumJo()
        {
            int varteredmeny = 3;

            int kapotteredmeny = minmax.minValasztoNONRND();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void minimumRossz()
        {
            int varteredmeny = 5;

            int kapotteredmeny = minmax.minValasztoNONRND();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void maximumJo()
        {
            int varteredmeny = 199;

            int kapotteredmeny = minmax.maxValasztoNONRND();

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void maximumRossz()
        {
            int varteredmeny = 198;

            int kapotteredmeny = minmax.maxValasztoNONRND();

            Assert.AreNotEqual(varteredmeny, kapotteredmeny);
        }
    }
}
