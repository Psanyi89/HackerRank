using System;
using System.IO;
using System.Linq;

namespace Happy_Ladybugs
{
    internal class Program
    {
        private static string HappyLadybugs(string b)
        {
            char[] temp = b.Replace("_", "").Distinct().ToArray();
            int count = 0;
            if (b.Length == 1 && !b.Contains("_"))
            {
                return "NO";
            }
            if (!b.Contains("_"))
            {
                for (int i = 1; i < b.Length - 1; i++)
                {
                    count = 0;
                    if (b[i] == b[i - 1] || b[i] == b[i + 1])
                    {
                        count++;
                    }
                    if (count == 0)
                    {
                        return "NO";
                    }
                }
            }
            for (int i = 0; i < temp.Length; i++)
            {
                count = 0;
                for (int j = 0; j < b.Length; j++)
                {
                    if (temp[i] == b[j])
                    {
                        count++;
                    }
                }
                if (count < 2)
                {
                    return "NO";
                }
            }
            return "YES";
        }

        private static void Main(string[] args)
        {
            string[] temp = File.ReadLines("testcase.txt").ToArray();
            foreach (string item in temp)
            {

                Console.WriteLine(HappyLadybugs(item));
            }
            Console.ReadKey();
        }
    }
}
