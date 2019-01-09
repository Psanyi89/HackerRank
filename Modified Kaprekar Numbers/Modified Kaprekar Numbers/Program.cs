using System;
using System.Collections.Generic;
using System.Linq;

namespace Modified_Kaprekar_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            KaprekarNumbers(1, 100000);
            Console.ReadKey();
        }

        private static void KaprekarNumbers(int v1, int v2)
        {
            List<int> result = new List<int>();
            for (int i = v1; i <= v2; i++)
            {
                long square = Convert.ToInt64(Math.Pow(i, 2));
                int numberlenght = square.ToString().Length;
                numberlenght = (int)Math.Ceiling((float)numberlenght / 2);
                int part1 = Convert.ToInt32(square / Math.Pow(10, numberlenght));
                int part2 = Convert.ToInt32(square - (part1 * Math.Pow(10, numberlenght)));
                if (part1 + part2 == i)
                {
                    result.Add(i);
                }
            }
            if (!result.Any())
            {
                Console.WriteLine("INVALID RANGE");
            }
            else
            {
                string total = string.Empty;
                for (int i = 0; i < result.Count; i++)
                {
                    total += result[i].ToString();
                    if (i < result.Count - 1)
                    {
                        total += " ";
                    }
                }
                Console.WriteLine(total);

            }
        }
    }
}
