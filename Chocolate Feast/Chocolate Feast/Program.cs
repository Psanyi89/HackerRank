using System;

namespace Chocolate_Feast
{
    internal class Program
    {
        private static int ChocolateFeast(int n, int c, int m)
        {
            int count = n / c;
            int wrappers = n / c;
            while (wrappers >= m)
            {
                int exchange = wrappers / m;
                count += exchange;

                wrappers = wrappers % m + exchange;

            }
            return count;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(ChocolateFeast(12, 4, 4));
            Console.ReadKey();
        }
    }
}
