using System;
using System.IO;
using System.Linq;

namespace Beautiful_Triplets
{
    internal class Program
    {
        private static int BeautifulTriplets(int d, int[] arr)
        {
            int triplest = 0;
            for (int i = 0; i < arr.Length - 2; i++)
            {
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[j] - arr[i] == d)
                    {

                        for (int k = j + 1; k < arr.Length; k++)
                        {
                            if (arr[k] - arr[j] == d)
                            {
                                triplest++;
                            }
                        }

                    }
                }
            }
            return triplest;
        }

        private static void Main(string[] args)
        {
            //int[] arr = { 1, 2, 4, 5, 7, 8, 10 };
            //int d = 3;
            string[] temp = File.ReadLines("testcase.txt").ToArray();
            string[] source = temp[0].Split(' ');
            int[] arr = new int[Convert.ToInt32(source[0])];
            int d = Convert.ToInt32(source[1]);
            int index = 0;
            for (int i = 1; i < temp.Length; i++)
            {
                source = temp[i].Split(' ');
                for (int j = 0; j < source.Length; j++)
                {
                    arr[index] = Convert.ToInt32(source[j]);
                    index++;
                }
            }
            Console.WriteLine(BeautifulTriplets(d, arr));
            Console.ReadKey();
        }
    }
}
