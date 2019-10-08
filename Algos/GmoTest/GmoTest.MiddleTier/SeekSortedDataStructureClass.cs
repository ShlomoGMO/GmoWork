using System;
using System.Collections.Generic;
using System.Text;

namespace GmoTest.MiddleTier
{
    public static class SeekSortedDataStructureClass
    {
        public static bool SeekSortedDataStructureRec(int[,] array, int numToFind)
        {
            var m = array.GetUpperBound(0);
            var n = array.GetUpperBound(1);
            if (m == 0 || n == 0)
                return false;

            return SeekSortedDataStructureRec(array, numToFind, 0);
        }

        public static bool SeekSortedDataStructureRec(int[,] array, int numToFind, int column)
        {
            if (column > array.GetUpperBound(0))
                return false;
            if (array[column, 0] > numToFind)
                return false;

            for (int i = 0; i <= array.GetUpperBound(1); i++)
            {
                if (array[column, i] == numToFind)
                    return true;
                if (array[column, i] > numToFind)
                    return SeekSortedDataStructureRec(array, numToFind, column + 1);
            }
            return SeekSortedDataStructureRec(array, numToFind, column + 1);
        }
    }
}
