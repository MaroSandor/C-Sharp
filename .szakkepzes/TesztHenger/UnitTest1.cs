using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger;

namespace TesztHenger
{
    [TestClass]
    public class UnitTest1
    {
            static double magassag = 3.0,
                sugar = 2.0;

            Hengera henger = new Hengera(magassag, sugar);

            [TestMethod]
            public void TestKerulet()
            {
                // Arrange
                double varteredmeny = 2 * sugar * Math.PI;

                // Act
                double kapotteredmeny = henger.Kerulet();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestTerulet()
            {
                // Arrange
                double varteredmeny = Math.Pow(sugar, 2) * Math.PI;

                // Act
                double kapotteredmeny = henger.Terulet();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestFelszin()
            {
                // Arrange
                double varteredmeny = 2 * (Math.Pow(sugar, 2) * Math.PI) + (2 * sugar * Math.PI) * magassag;

                // Act
                double kapotteredmeny = henger.Felszin();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }

            [TestMethod]
            public void TestTerfogat()
            {
                // Arrange
                double varteredmeny = (Math.Pow(sugar, 2) * Math.PI) * magassag;

                // Act
                double kapotteredmeny = henger.Terfogat();

                // Assert
                Assert.AreEqual(varteredmeny, kapotteredmeny);
            }
        }
    }
