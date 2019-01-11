using System;

namespace Service_Lane
{
    internal class Program
    {
        private static int[] serviceLane(int n, int[][] cases, int[] width)
        {
            int[] result = new int[cases.GetLength(0)];


            int min;
            for (int i = 0; i < cases.GetLength(0); i++)
            {
                min = n;
                for (int j = cases[i][0]; j <= cases[i][1]; j++)
                {
                    if (width[j] < min)
                    {
                        min = width[j];
                    }
                }
                result[i] = min;
            }
            return result;
        }

        private static void Main(string[] args)
        {
            int[] width = { 2, 3, 1, 2, 3, 2, 3, 3 };
            int[][] arr = new int[5][];
            arr[0] = new int[] { 0, 3 };
            arr[1] = new int[] { 4, 6 };
            arr[2] = new int[] { 6, 7 };
            arr[3] = new int[] { 3, 5 };
            arr[4] = new int[] { 0, 7 };
            int[] array = serviceLane(8, arr, width);
            Console.WriteLine(string.Join(" ", array));
            Console.ReadKey();
        }
    }
}
