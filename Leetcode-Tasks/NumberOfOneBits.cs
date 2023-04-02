using System;
namespace Leetcode_Tasks
{
    public class NumberOfOneBits
    {
        public static int HammingWeight(uint n)
        {
            var onesCount = 0;
            var uintSize = Convert.ToString(uint.MaxValue, 2).Length;
            for (int i = 0; i < uintSize; i++, n >>= 1)
            {
                if ((n & 1) == 1)
                    onesCount++;
            }

            return onesCount;
        }
    }
}

