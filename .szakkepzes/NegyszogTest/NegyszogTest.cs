using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyszog;

namespace NegyszogTest
{
    [TestClass]
    public class NegyszogTest
    {
        // Arrange
        static double s = 2.0;
        Nszog nsz = new Nszog(s);

        [TestMethod]
        public void TestKerulet()
        {
            // Arrange
            double varteredmeny = 8.0;

            // Act
            double kapotteredmeny = nsz.Kerulet();

            // Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TestTerulet()
        {
            // Arrange
            double varteredmeny = 4.0;

            // Act
            double kapotteredmeny = nsz.Terulet();

            // Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TestAtlo()
        {
            // Arrange
            double varteredmeny =  Math.Sqrt(8);

            // Act
            double kapotteredmeny = nsz.Atlo();

            // Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void TestOszlop()
        {
            double m = 0;
            // Assert.Fail()
            nsz.setOszlop(m);
        }
    }
}
