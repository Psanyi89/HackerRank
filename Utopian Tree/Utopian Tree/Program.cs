using System;

namespace Utopian_Tree
{
    internal class Program
    {
        private static int UtopianTree(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    result = (result * 2);
                }
                else
                {
                    result++;
                }
            }
            return result;
        }

        private static void Main(string[] args)
        {
            int[] array = { 0, 1, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(UtopianTree(array[i]));
            }
            Console.ReadKey();
        }
    }
}
