using System;

namespace Jumping_On_The_Clouds
{
    internal class Program
    {
        private static int JumpingOnClouds(int[] c)
        {
            int position = 0;
            int counter = 0;

            while (position < c.Length - 1)
            {

                if (position + 2 < c.Length && c[position + 2] != 1)
                {
                    counter++;
                    position += 2;
                }
                else
                {
                    counter++;
                    position++;
                }
            }
            return counter;
        }

        private static void Main(string[] args)
        {
            int[] c = { 0, 0, 1, 0, 0, 1, 0 };
            Console.WriteLine(JumpingOnClouds(c));
            Console.ReadKey();
        }
    }
}
