using System;
using System.Linq;

namespace Fair_Rations
{
    internal class Program
    {
        private static string FairRations(int[] B)
        {
            int counter = 0;
            for (int i = 0; i < B.Length - 1; i++)
            {
                if (B[i] % 2 != 0)
                {
                    B[i]++;
                    B[i + 1]++;
                    counter += 2;
                }
            }
            if (B.Sum() % 2 != 0)
            {
                return "NO";
            }
            return counter.ToString();

        }

        private static void Main(string[] args)
        {
            int[] B = { 1, 2, 4 };
            Console.WriteLine(FairRations(B));
            Console.ReadKey();
        }
    }
}
