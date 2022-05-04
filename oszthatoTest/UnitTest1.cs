using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using oszthato;

namespace oszthatoTest
{
    [TestClass]
    public class osztasTest
    {
        // Arrange
        static int tesztszam = 15;
        Osztas osztaly = new Osztas(tesztszam);

        [TestMethod]
        public void TestOsztas3()
        {
            // Arrange
            string varteredmeny = "három";

            // Act
            string kapotteredmeny = osztaly.getSzam3();

            // Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }

        [TestMethod]
        public void TestOsztas5()
        {
            // Arrange
            string varteredmeny = "öt";

            // Act
            string kapotteredmeny = osztaly.getSzam5();

            // Assert
            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}