using System;

namespace Repeated_String
{
    internal class Program
    {
        public static long RepeatedString(string s, long n)
        {
            long counter;
            long acount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    acount++;
                }
            }
            if (n % s.Length == 0)
            {
                counter = acount * (n / s.Length);
            }
            else
            {
                counter = acount * (n / s.Length);
                long partial = n % s.Length;
                for (int i = 0; i < partial; i++)
                {
                    if (s[i] == 'a')
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static void Main(string[] args)
        {
            string s = "a";
            long n = 1000000000000;
            Console.WriteLine(RepeatedString(s, n));
            Console.ReadKey();
        }
    }
}
