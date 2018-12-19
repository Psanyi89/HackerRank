using System;
using System.Linq;

namespace The_Hurdle_Race
{
    internal class Program
    {
        private static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            if (k > max)
            {
                return 0;
            }
            else
            {
                return max - k;
            }
        }

        private static void Main(string[] args)
        {
            int k = 7;
            int[] height = { 2, 5, 4, 5, 2 };
            Console.WriteLine(hurdleRace(k, height));
            Console.ReadKey();
        }
    }
}
