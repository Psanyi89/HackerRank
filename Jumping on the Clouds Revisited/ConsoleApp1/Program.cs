using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static int jumpingOnClouds(int[] c, int k)
        {
            int pos = 0;
            int energy = 100;
            int n = c.Length;
            while (true)
            {
                int position = (pos + k) % n;
                if (pos + k > n)
                {
                    position = 0;
                }

                if (c[position] == 1)
                {
                    energy -= 3;
                }
                else
                {
                    energy--;
                }
                if (position == 0)
                {
                    break;
                }

                pos += k;
            }


            return energy;
        }

        private static void Main(string[] args)
        {
            int[] c = { 0, 0, 1, 0, 0, 1, 1, 0 };
            int k = 2;
            Console.WriteLine(jumpingOnClouds(c, k));
            Console.ReadKey();
        }
    }
}
