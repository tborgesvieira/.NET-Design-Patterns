using System;

namespace DP.Helpers
{
    public static class ConsoleColorHelper
    {
        public static ConsoleColor FromRgbColor(int red, int green, int blue)
        {
            System.Drawing.Color c = System.Drawing.Color.FromArgb(red, green, blue);

            int index = (c.R > 128 | c.G > 128 | c.B > 128) ? 8 : 0; // Bright bit
            index |= (c.R > 64) ? 4 : 0; // Red bit
            index |= (c.G > 64) ? 2 : 0; // Green bit
            index |= (c.B > 64) ? 1 : 0; // Blue bit

            return (System.ConsoleColor)index;
        }
    }
}
