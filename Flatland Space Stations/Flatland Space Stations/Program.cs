using System;

namespace Flatland_Space_Stations
{
    internal class Program
    {
        private static int FlatlandSpaceStations(int n, int[] c)
        {
            Array.Sort(c);
            int max = ((n - 1) - c[c.Length - 1]);
            if (c[0] > max)
            {
                max = c[0];
            }

            if (n == c.Length)
            {
                return 0;
            }
            for (int i = 0; i < c.Length - 1; i++)
            {
                int diff = (c[i + 1] - c[i]);
                int part = (int)Math.Floor((double)diff / 2);
                if (part > max)
                {
                    max = part;
                }

            }
            return max;
        }

        private static void Main(string[] args)
        {
            int[] c = { 93, 41, 91, 61, 30, 6, 25, 90, 97 };
            int n = 100;
            Console.WriteLine(FlatlandSpaceStations(n, c));
            Console.ReadKey();
        }
    }
}
