using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using GmoTest.MiddleTier;

namespace GmoTest.MiddleTier.Test
{
    [TestClass]
    public class SeekClosestToAverageTest
    {
        [TestMethod]
        public void GivenTestCase()
        {
            var testArray = new[] { 1, 2, 3, 5, -1, 7, 145, -33, 22, 14 };
            var result = SeekClosestToAverageClass.SeekClosestToAverage(testArray);

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void EmptyArray()
        {
            Assert.ThrowsException<Exception>(() => SeekClosestToAverageClass.SeekClosestToAverage(new int[0]));
        }

        [TestMethod]
        public void SingleItemArray()
        {
            var testArray = new[] { 1 };
            var result = SeekClosestToAverageClass.SeekClosestToAverage(testArray);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void RepeatingArray()
        {
            var testArray = new[] { 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3, };
            var result = SeekClosestToAverageClass.SeekClosestToAverage(testArray);

            Assert.AreEqual(2, result);
        }



    }
}
