using System;

namespace Sequence_Equation
{
    internal class Program
    {
        private static int[] PermutationEquation(int[] p)
        {
            int[] y = new int[p.Length];
            int counter = 0;
            for (int i = 1; i <= p.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (i == p[j])
                    {
                        for (int k = 0; k < p.Length; k++)
                        {
                            if (j + 1 == p[k])
                            {
                                y[counter] = k + 1;
                                counter++;
                            }
                        }
                    }
                }
            }
            return y;
        }

        private static void Main(string[] args)
        {
            int[] array = { 4, 3, 5, 1, 2 };
            int[] result = PermutationEquation(array);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
