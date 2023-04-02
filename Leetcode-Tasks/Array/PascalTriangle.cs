using System;
using System.Collections.Generic;

namespace Leetcode_Tasks.Array
{
    public class PascalTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            var res = new List<IList<int>>();
            var current = new List<int>();
            var previous = new List<int>();

            for (int i = 0; i < numRows; i++)
            {
                current = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        current.Add(1);
                    }
                    else
                    {
                        current.Add((previous[j - 1] + previous[j]));
                    }
                }
                res.Add(current);
                previous = current;
            }

            return res;
        }
    }
}

