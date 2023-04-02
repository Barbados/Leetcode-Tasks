using System;
namespace Leetcode_Tasks.Array
{
    public class MergeSortedArray
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var tail1 = m - 1;
            var tail2 = n - 1;

            for (var i = m + n - 1; tail2 >= 0; i--)
            {
                nums1[i] = (tail1 >= 0 && nums1[tail1] > nums2[tail2])
                    ? nums1[tail1--]
                    : nums2[tail2--];
            }
        }
    }
}

