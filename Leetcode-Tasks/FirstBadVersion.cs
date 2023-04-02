using System;
namespace Leetcode_Tasks
{
    public class FirstBadVersion
    {
        public static int BadVersion { get; set; }

        public static int GetFirstBadVersion(int n)
        {
            var leftIndex = 1;
            var rightIndex = n;

            var badVersion = -1;
            if (n == 1 && IsBadVersion(n))
                return 1;

            while (leftIndex <= rightIndex)
            {
                var middleIndex = (leftIndex + rightIndex) / 2;
                Console.WriteLine("Left: " + leftIndex);
                Console.WriteLine("Right: " + rightIndex);
                Console.WriteLine("Middle: " + middleIndex);
                break;
                if (IsBadVersion(middleIndex))
                {
                    badVersion = middleIndex;
                    rightIndex = middleIndex - 1;
                }
                else if (badVersion == -1)
                    leftIndex = middleIndex + 1;
                else
                {
                    break;
                }
            }

            return badVersion;
        }

        private static bool IsBadVersion(int n)
        {
            return n == BadVersion;
        }
    }
}
