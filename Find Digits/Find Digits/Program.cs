using System;

namespace Find_Digits
{
    internal class Program
    {
        private static int FindDigits(int n)
        {
            char[] number = n.ToString().ToCharArray();
            int counter = 0;
            foreach (char nums in number)
            {
                int no = Convert.ToInt32(nums.ToString());
                if (no > 0)
                {
                    if (n % no == 0)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(FindDigits(1203));
            Console.ReadKey();
        }
    }
}
