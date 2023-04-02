using System;
using System.Collections.Generic;

namespace Leetcode_Tasks.Array
{
    public class Subsets
    {
        public static IList<IList<int>> GetSubsets(int[] nums)
        {
            var list = new List<IList<int>>();
            Backtrack(list, new List<int>(), nums, 0);

            return list;
        }

        private static void Backtrack(IList<IList<int>> list, IList<int> innerList, int[] nums, int start)
        {
            list.Add(new List<int>(innerList));
            for (int i = start; i < nums.Length; i++)
            {
                innerList.Add(nums[i]);
                Backtrack(list, innerList, nums, i + 1);
                innerList.RemoveAt(innerList.Count - 1);
            }
        }
    }
}

