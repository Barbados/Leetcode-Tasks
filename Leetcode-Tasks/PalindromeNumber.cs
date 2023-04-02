using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            var intList = new List<int>();
            for (; ; )
            {
                intList.Add(x % 10);
                x /= 10;

                if (x == 0)
                    break;
            }

            var isPalindrome = false;
            var halfLenth = intList.Count / 2;
            var rightIndex = intList.Count - 1;
            for (int i = 0; i < halfLenth; i++)
            {
                if (intList[i] == intList[rightIndex])
                {
                    isPalindrome = true;
                    rightIndex--;
                }
            }

            return isPalindrome;
        }
    }
}
