using System;

namespace Viral_Advertising
{
    internal class Program
    {
        private static int ViralAdvertising(int n)
        {
            int result = 0;
            int number = 5;
            for (int i = 1; i <= n; i++)
            {
                result += number / 2;
                number = (number / 2) * 3;
            }
            return result;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(ViralAdvertising(4));
            Console.ReadKey();
        }
    }
}
