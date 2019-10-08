using System;
using System.Collections.Generic;
using System.Text;

namespace GmoTest.MiddleTier
{
    public static class Fibonnaci
    {
        public static decimal Fib(int fibIndex)
        {
            if (fibIndex <= 0)
                throw new Exception("fibIndex must be greater than zero");

            var initialDict = new Dictionary<int, decimal> {
                {1, 1m},
                {2, 1m},
            };
            return RecursiveFib(fibIndex, initialDict);
        }

        private static decimal RecursiveFib(int fibIndex, Dictionary<int, decimal> history)
        {
            if (!history.ContainsKey(fibIndex))
            {
                var b = RecursiveFib(fibIndex - 2, history);
                var a = RecursiveFib(fibIndex - 1, history);
                history[fibIndex] = a + b;
            }
            return history[fibIndex];
        }

    }
}
