using System;
namespace Leetcode_Tasks
{
    public class FloodFill
    {
        public static int[][] PerformFloodFill(int[][] image, int sr, int sc, int color)
        {
            int initialColor = image[sr][sc];

            if (initialColor != color)
                ChangeColor(image, sr, sc, initialColor, color);

            return image;
        }

        private static void ChangeColor(int[][] image, int sr, int sc, int color, int newColor)
        {
            var rowCount = image.Length;
            var rowSize = image[0].Length;

            if (image[sr][sc] == color)
            {
                image[sr][sc] = newColor;
                if (sr > 0)
                {
                    ChangeColor(image, sr - 1, sc, color, newColor);
                }

                if (sr < rowCount - 1)
                {
                    ChangeColor(image, sr + 1, sc, color, newColor);
                }

                if (sc > 0)
                {
                    ChangeColor(image, sr, sc - 1, color, newColor);
                }

                if (sc < rowSize - 1)
                {
                    ChangeColor(image, sr, sc + 1, color, newColor);
                }
            }
        }
    }
}
