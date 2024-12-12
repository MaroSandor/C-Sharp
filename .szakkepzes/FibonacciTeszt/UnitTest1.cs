using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Fibonacci;

namespace FibonacciTeszt
{
    [TestClass]
    public class UnitTest1
    {
        Fibonaci ok = new Fibonaci();

        [TestMethod]
        public void sorozatteszt()
        {
            int varteredmeny = 1;

            int kapotteredmeny = ok.feltoltes(5);

            Assert.AreEqual(varteredmeny, kapotteredmeny);
        }
    }
}
