using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GmoTest.MiddleTier
{
    public static class SeekClosestToAverageClass
    {
        public static int SeekClosestToAverage(int[] array)
        {
            if (array.Length == 0)
                throw new Exception("Contents empty.");

            var average = array.Average();
            int closest = array[0];
            double closestDiff = Math.Abs(closest - average);

            for (int i = 1; i < array.Length; i++)
            {
                var localNum = array[i];
                var localDiff = Math.Abs(localNum - average);
                if (localDiff < closestDiff)
                {
                    closest = localNum;
                    closestDiff = localDiff;
                }
            }
            return closest;
        }

    }
}
