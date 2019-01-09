using System;
using System.IO;
using System.Linq;

namespace Minimum_Distances
{
    internal class Program
    {
        private static int MinimumDistances(int[] a)
        {
            int min = a.Length;
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j] && j - i < min)
                    {
                        min = j - i;
                    }
                }
            }
            if (min < a.Length && min > 0)
            {
                return min;
            }
            else
            {
                return -1;
            }
        }

        private static void Main(string[] args)
        {
            int[] arr = { 7, 1, 3, 4, 1, 7 };
            string[] temp = File.ReadLines("testcase.txt").ToArray();
            arr = new int[Convert.ToInt32(temp[0])];
            int index = 0;
            for (int i = 1; i < temp.Length; i++)
            {
                string[] source = temp[i].Split(' ');
                for (int j = 0; j < source.Length; j++)
                {
                    arr[index] = Convert.ToInt32(source[j]);
                    index++;
                }
            }
            Console.WriteLine(MinimumDistances(arr));
            Console.ReadKey();
        }
    }
}
