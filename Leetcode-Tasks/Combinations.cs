using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
    public class Combinations
    {
        public static IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();

            Combine(result, new List<int>(), 1, n, k);

            return result;
        }

        private static void Combine(IList<IList<int>> arrOfArrays, IList<int> combinedArray, int startIndex, int n, int k)
        {
            if (k == 0)
            {
                arrOfArrays.Add(new List<int>(combinedArray));
            }

            for (int i = startIndex; i <= n; i++)
            {
                combinedArray.Add(i);
                Combine(arrOfArrays, combinedArray, i + 1, n, k - 1);
                combinedArray.Remove(i);
            }
        }
    }
}
