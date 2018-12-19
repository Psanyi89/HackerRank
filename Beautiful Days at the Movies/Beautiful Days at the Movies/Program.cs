using System;

namespace Beautiful_Days_at_the_Movies
{
    internal class Program
    {
        private static int BeautifulDays(int i, int j, int k)
        {
            int result = 0;
            int reverse, left, r;
            for (int l = i; l <= j; l++)
            {
                reverse = 0;
                left = l;
                while (left > 0)
                {
                    r = left % 10;
                    reverse = reverse * 10 + r;
                    left = left / 10;
                }
                if (Math.Abs(l - reverse) % k == 0)
                {
                    result++;
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(BeautifulDays(13, 45, 3));
            Console.ReadKey();
        }
    }
}
