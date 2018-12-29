using System;
using System.Numerics;

namespace Extra_Long_Factorials
{
    internal class Program
    {
        public static BigInteger Factorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }

            else
            {
                return number * Factorial(number - 1);
            }
        }

        private static void ExtraLongFactorials(int n)
        {
            Console.WriteLine(Factorial(n));
            Console.ReadKey();
        }


        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            ExtraLongFactorials(n);

        }
    }

}

