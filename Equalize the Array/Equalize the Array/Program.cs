using System;
using System.Linq;

namespace Equalize_the_Array
{
    internal class Program
    {
        private static int EqualizeArray(int[] arr)
        {
            int counter;
            int max = 0;
            int[] arrayNums = arr.ToList().Distinct().ToArray();
            for (int i = 0; i < arrayNums.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] == arrayNums[i])
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                }
            }
            return arr.Length - max;
        }

        private static void Main(string[] args)
        {
            int[] arr = { 3, 3, 2, 1, 3 };
            Console.WriteLine(EqualizeArray(arr));
            Console.ReadKey();

        }
    }
}
