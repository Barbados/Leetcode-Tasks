using System;
namespace Leetcode_Tasks.Array
{
    public class JumpGame
    {
        public static bool CanJump(int[] nums)
        {
            var reachable = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (reachable < i)
                    return false;

                reachable = Math.Max(reachable, i + nums[i]);
            }

            return true;
        }
    }
}

