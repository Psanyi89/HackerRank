using System;
using System.Collections;
using System.Collections.Generic;
namespace Non_Divisible_Subset
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] S = { 278, 576, 496, 727, 410, 124, 338, 149, 209, 702, 282, 718, 771, 575, 436 };
            int k = 7;

            int result = LongerstNonDivisibleSubset(S, k);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int LongerstNonDivisibleSubset(int[] s, int k)
        {         
            int[] remainders = new int[k];
            for (int j = 0; j < s.Length; j++)
            {
               
                    remainders[s[j] % k]++;
                
            }

            int result = 0;
            int i = 1;
            for (; i * 2 < k; i++)
            {
                result += Math.Max(remainders[i], remainders[k - i]);

            }
            if (i * 2 == k)
            {
                result++;
            }
            if (remainders[0]>0)
            {
                result++;
            }
            return result;
        }

    }
}
