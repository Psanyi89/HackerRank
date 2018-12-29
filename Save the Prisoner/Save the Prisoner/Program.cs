using System;

namespace Save_the_Prisoner
{
    internal class Program
    {
        private static int SaveThePrisoner(int n, int m, int s)
        {
            int candy = s + m - 1;
            if (candy > n)
            {
                if (candy % n == 0)
                {
                    return n;
                }
                else
                {
                    return candy % n;
                }
            }
            return candy;
        }

        private static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { 7, 19, 2 };
            array[1] = new int[] { 3, 7, 3 };
            for (int i = 0; i < array.GetLength(0); i++)
            {

                Console.WriteLine(SaveThePrisoner(array[i][0], array[i][1], array[i][2]));
            }
            Console.ReadKey();
        }
    }
}
