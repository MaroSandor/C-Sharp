using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Henger;

namespace HengerTeszt
{
    [TestClass]
    public class hengerTeszt
    {
            static double a = 3.0,
                b = 2.0;

            Hengera henger = new Hengera(a, b);

            [TestMethod]
            public void TestKerulet()
            {
                // Arrange
                double varteredmeny = 12.57;

                // Act
                double kapotteredmeny = henger.Kerulet();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestTerulet()
            {
                // Arrange
                double varteredmeny = 12.57;

                // Act
                double kapotteredmeny = henger.Terulet();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestFelszin()
            {
                // Arrange
                double varteredmeny = 62.83;

                // Act
                double kapotteredmeny = henger.Felszin();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestTerfogat()
            {
                // Arrange
                double varteredmeny = 37.70;

                // Act
                double kapotteredmeny = henger.Terfogat();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }
        }
    }
