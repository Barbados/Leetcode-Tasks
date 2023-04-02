using System;
using System.Collections.Generic;

namespace Leetcode_Tasks.Array
{
    public class CombinatonSum
    {
        public static IList<IList<int>> GetCombinationSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            Backtrack(result, new List<int>(), candidates, target, 0);

            return result;
        }

        private static void Backtrack(IList<IList<int>> allSums, IList<int> tempList, int[] candidates, int remain, int start)
        {
            if (remain < 0)
                return;
            else if (remain == 0)
                allSums.Add(new List<int>(tempList));
            else
                for (int i = start; i < candidates.Length; i++)
                {
                    tempList.Add(candidates[i]);
                    Backtrack(allSums, tempList, candidates, remain - candidates[i], i);
                    tempList.RemoveAt(tempList.Count - 1);
                }
        }
    }
}

