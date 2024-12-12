using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeglaTDD;

namespace TeglaTDD_Ut
{
    [TestClass]
    public class UnitTest1
    {
        int vart,
            kapott;

        Tegla tegla = new Tegla();

        [TestMethod]
        public void Terfogat()
        {
            // Arrange
            tegla.setTegla(1, 2, 3);

            vart = 6;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void Terfogat2()
        {
            // Arrange
            tegla.setTegla(4, 2, 3);

            vart = 24;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void TerfogatR()
        {
            // Arrange
            tegla.setTegla(4, 2, 3);

            vart = 48;

            // Act
            kapott = tegla.getTerfogat();

            // Assert
            Assert.AreNotEqual(vart, kapott);
        }

        [TestMethod]
        public void Felszin()
        {
            tegla.setTegla(1, 2, 3);

            vart = 22;

            kapott = tegla.getFelszin();

            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void Felszin2()
        {
            tegla.setTegla(4, 2, 3);

            vart = 52;

            kapott = tegla.getFelszin();

            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void FelszinR()
        {
            tegla.setTegla(1, 2, 3);

            vart = 24;

            kapott = tegla.getFelszin();

            Assert.AreNotEqual(vart, kapott);
        }
    }
}
