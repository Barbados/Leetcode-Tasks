using System;
namespace Leetcode_Tasks
{
    public class ClimbingStairs
    {
        public static int ClimbStairs(int n)
        {
            var prev = 0;
            var next = 1;
            var res = prev + next;
            for (int i = 0; i < n; i++)
            {
                res = prev + next;
                prev = next;
                next = res;
            }

            return res;
        }
    }
}

