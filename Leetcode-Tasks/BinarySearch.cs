using System;
namespace Leetcode_Tasks
{
    public class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            var targetIndex = -1;
            var leftIndex = 0;
            var rightIndex = nums.Length - 1;

            while (leftIndex <= rightIndex)
            {
                var mediumIndex = (leftIndex + rightIndex) / 2;
                if (nums[mediumIndex] < target)
                    leftIndex = mediumIndex + 1;
                else if (nums[mediumIndex] > target)
                    rightIndex = mediumIndex - 1;
                else
                {
                    targetIndex = mediumIndex;
                    break;
                }
            }

            return targetIndex;
        }
    }
}
