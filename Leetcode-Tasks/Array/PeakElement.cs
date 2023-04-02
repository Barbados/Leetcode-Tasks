using System;
namespace Leetcode_Tasks.Array
{
    public class PeakElement
    {
        public static int FindPeakElement(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                    return i;
            }

            return nums.Length - 1;
        }
    }
}

