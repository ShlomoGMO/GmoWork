using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

using GmoTest.MiddleTier;

namespace GmoTest.MiddleTier.Test
{
    [TestClass]
    public class SeekSortedDataStructureTest
    {
        private int[,] GivenMatrix => new int[,] {
            {4, 7, 12, 23, 27, 34, },
            {6, 10, 15, 24, 30, 40, },
            {12, 15, 18, 29, 32, 48, },
            {14, 18, 21, 30, 35, 54, },
            {20, 23, 24, 35, 37, 62, },
            {22, 27, 29, 39, 40, 68, },
            {28, 32, 33, 44, 46, 76, },
            {30, 36, 38, 48, 49, 82, },
        };

        [TestMethod]
        public void Test_Given_Corners()
        {
            Assert.AreEqual(true, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 4));
            Assert.AreEqual(true, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 34));
            Assert.AreEqual(true, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 30));
            Assert.AreEqual(true, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 82));
        }

        [TestMethod]
        public void Test_Given_OutOfBounds()
        {
            Assert.AreEqual(false, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 3));
            Assert.AreEqual(false, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 83));
        }

        [TestMethod]
        public void Test_Given_GivenCases()
        {
            Assert.AreEqual(true, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 18));
            Assert.AreEqual(false, SeekSortedDataStructureClass.SeekSortedDataStructureRec(GivenMatrix, 26));
        }
    }
}
