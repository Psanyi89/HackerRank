using System;
using System.Numerics;

namespace Taum_and_B_day
{
    internal class Program
    {
        private static BigInteger TaumBday(int b, int w, int bc, int wc, int z)
        {
            BigInteger black = b, white = w, blackprice = bc, whiteprice = wc, swap = z;
            return black * BigInteger.Min(blackprice, whiteprice + swap) + white * BigInteger.Min(whiteprice, blackprice + swap);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(TaumBday(10, 10, 1, 1, 1));
            Console.ReadKey();
        }
    }
}
