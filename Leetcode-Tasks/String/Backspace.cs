using System;
using System.Collections;
using System.Collections.Generic;

namespace Leetcode_Tasks.String
{
    public class Backspace
    {
        public static bool BackspaceCompare(string s, string t)
        {
            var left = RemoveBackspaces(s);
            var right = RemoveBackspaces(t);
            return RemoveBackspaces(s) == RemoveBackspaces(t);
        }

        private static Stack<char> RemoveBackspaces(string str)
        {
            var strStack = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '#')
                    strStack.Push(str[i]);
                else if (strStack.Count > 0)
                    strStack.Pop();
            }

            return strStack;
        }
    }
}

