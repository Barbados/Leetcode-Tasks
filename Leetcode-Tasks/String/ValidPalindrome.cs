using System;
namespace Leetcode_Tasks.String
{
    public class ValidPalindrome
    {
        public static bool IsPalindrome(string s)
        {
            bool isValid = true;
            var head = 0;
            var tail = s.Length - 1;
            while (head < tail)
            {
                var left = s[head];
                var right = s[tail];
                if (!char.IsLetterOrDigit(left))
                {
                    head++;
                    continue;
                }

                if (!char.IsLetterOrDigit(right))
                {
                    tail--;
                    continue;
                }

                if (char.ToLower(left) != char.ToLower(right))
                {
                    isValid = false;
                }
                head++;
                tail--;
            }

            return isValid;
        }
    }
}

