using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Teszt_ujanyag
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string varteredmeny = "Helló világ!";
            // ACT
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw); // Konzol átirányítása sw-be
                Teszt_ujanyag_unitteszt.Program.Main();
                var kapotteredmeny = sw.ToString().Trim();

                // Assert
                Assert.AreEqual(kapotteredmeny, varteredmeny);
            }
            // Unit
        }
    }
}
