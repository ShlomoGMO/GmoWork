using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GmoTest.MiddleTier.Test
{
    [TestClass]
    public class FibTest
    {
        [TestMethod]
        public void Test_0()
        {
            Assert.ThrowsException<Exception>(() => Fibonnaci.Fib(0));
        }

        [TestMethod]
        public void Test_1()
        {
            Assert.AreEqual(1m, Fibonnaci.Fib(1));
        }

        [TestMethod]
        public void Test_2()
        {
            Assert.AreEqual(2m, Fibonnaci.Fib(1));
        }

        [TestMethod]
        public void Test_3()
        {
            Assert.AreEqual(2m, Fibonnaci.Fib(3));
        }

        [TestMethod]
        public void Test_100()
        {
            Assert.AreEqual(2m, Fibonnaci.Fib(3));
        }
    }
}
