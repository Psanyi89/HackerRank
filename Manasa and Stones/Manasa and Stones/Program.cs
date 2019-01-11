using System;
using System.Collections.Generic;
using System.Linq;

namespace Manasa_and_Stones
{
    internal class Program
    {
        private static int[] Stones(int n, int a, int b)
        {
            List<int> arr = new List<int>();
            for (int i = n - 1, j = 0; j < n; i--, j++)
            {

                arr.Add(a * i + b * j);
            }
            int[] result = arr.Distinct().OrderBy(x => x).ToArray();
            return result;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",Stones(4, 10, 100)));
            Console.ReadKey();
        }
    }
}
