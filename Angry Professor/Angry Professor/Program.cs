using System;
using System.Linq;

namespace Angry_Professor
{
    internal class Program
    {
        private static string AngryProfessor(int k, int[] a)
        {
            int attendes = a.Where(x => x <= 0).Count();
            if (attendes < k)
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
        }

        private static void Main(string[] args)
        {
            int[][] array = new int[2][];
            array[0] = new int[] { -1, -3, 4, 2 };
            array[1] = new int[] { 0, -1, 2, 1 };
            int[] cancel = { 3, 2 };
            for (int i = 0; i < cancel.Length; i++)
            {
                Console.WriteLine(AngryProfessor(cancel[i], array[i]));
            }
            Console.ReadKey();
        }
    }
}
