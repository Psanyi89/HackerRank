using System;

namespace Circular_Array_Rotation
{
    internal class Program
    {
        private static int[] CircularArrayRotation(int[] a, int k, int[] queries)
        {
            k %= a.Length;
            int[] result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                if (queries[i] - k >= 0)
                {
                    result[i] = a[queries[i] - k];
                }
                else
                {
                    result[i] = a[a.Length - k + queries[i]];
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            int[] query = { 0, 1, 2 };
            int rotation = 2;
            int[] result = CircularArrayRotation(array, rotation, query);
            foreach (int item in result)
            {
                Console.Write($"{item} ");
            }
            Console.ReadKey();
        }
    }
}
