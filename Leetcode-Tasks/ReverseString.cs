using System;
using System.Collections.Generic;

namespace Leetcode_Tasks
{
    public class ReverseString
    {
        public static string ReverseWords(string s)
        {
            var reversedStrings = new List<string>();
            var word = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                word += s[i];
                if (s[i] == ' ' || i == 0)
                {
                    reversedStrings.Add(i == 0 ? word + ' ' : word);
                    word = "";
                }
            }

            string reversedStr = "";
            for (var i = reversedStrings.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(reversedStrings[i]);
                reversedStr += reversedStrings[i];
            }

            return reversedStr;
        }
    }
}
