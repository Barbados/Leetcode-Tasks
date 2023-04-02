using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
    public class PermutationInString
    {
        public static bool CheckInclusion(string s1, string s2)
        {
            var s1Chars = new Dictionary<char, int>();
            for (int i = 0; i < s1.Length; i++)
            {
                var elem = s1[i];
                if (!s1Chars.ContainsKey(elem))
                    s1Chars.Add(elem, 0);
                s1Chars[elem]++;
            }

            var s1CharsCopy = s1Chars;
            var foundIndex = -1;
            for (int i = 0; i < s2.Length; i++)
            {
                var s2Char = s2[i];
                if (s1CharsCopy.ContainsKey(s2Char))
                {
                    if (foundIndex != -1 && (i - foundIndex) != 1)
                    {
                        s1CharsCopy = s1Chars;
                        foundIndex = -1;
                        continue;
                    }
                    s1CharsCopy[s2Char]--;
                    foundIndex = i;
                    if (s1CharsCopy[s2Char] == 0)
                        s1CharsCopy.Remove(s2Char);
                }
                if (s1Chars.Count == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
