using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
	public class HappyNumber
	{
        public static bool IsHappy(int n)
        {
            bool isHappy = false;
            var uniqueSums = new HashSet<int>();

            while (n > 0
                )
            {
                var sum = 0;
                while (n > 0)
                {
                    var left = n / 10;
                    var right = n % 10;
                    sum += right * right;
                    n = left;
                }
                if (sum == 1)
                {
                    isHappy = true;
                    break;
                }
                else if (uniqueSums.Contains(sum))
                    break;
                else
                {
                    n = sum;
                    uniqueSums.Add(sum);
                }
            }

            return isHappy;
        }
    }
}

