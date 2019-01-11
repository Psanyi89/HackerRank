using System;
using System.Numerics;

namespace Strange_Counter
{
    internal class Program
    {
        private static BigInteger strangeCounter(BigInteger t)
        {
            BigInteger a = 3;
            while (t > a)
            {
                t -= a;
                a *= 2;
            }
            return a - (t - 1);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(strangeCounter(999999));
            Console.ReadKey();
        }
    }
}
