using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
    public class LargestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var charSequence = new HashSet<char>();
            var longestSubstringLength = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    if (!charSequence.Contains(s[j]))
                        charSequence.Add(s[j]);
                    else
                    {
                        longestSubstringLength = longestSubstringLength < charSequence.Count
                            ? charSequence.Count
                            : longestSubstringLength;
                        charSequence.Clear();
                        break;
                    }
                }
            }

            return longestSubstringLength;
        }

        public static int LengthOfLongestSubstring_2(string s)
        {
            var chars = new Dictionary<char, int>();

            int left = 0;
            int right = 0;

            int res = 0;
            while(right < s.Length)
            {
                var rightElem = s[right];
                if (!chars.ContainsKey(rightElem))
                    chars.Add(rightElem, 0);
                chars[rightElem]++;

                while (chars[rightElem] > 1)
                {
                    var leftElem = s[left];
                    chars[leftElem]--;
                    left++;
                }

                res = Math.Max(res, right - left + 1);
                right++;
            }

            return res;
        }
    }
}
