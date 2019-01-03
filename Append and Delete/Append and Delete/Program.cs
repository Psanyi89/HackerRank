using System;

namespace Append_and_Delete
{
    internal class Program
    {
        private static string AppendAndDelete(string s, string t, int k)
        {
            int counter = 0;
            for (int i = 0; i < Math.Min(s.Length, t.Length); i++)
            {

                if (s[i] != t[i])
                {

                    break;
                }
                else
                {
                    counter++;
                }
            }
            int result = (s.Length - counter) + (t.Length - counter);
            if (s.Length + t.Length < k)
            {
                return "Yes";
            }
            else if (k < (result))
            {
                return "No";
            }
            else if (result % 2 == k % 2)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }
        }

        private static void Main(string[] args)
        {
            string s = "ash";
            string t = "ashley";
            int k = 2;
            Console.WriteLine(AppendAndDelete(s, t, k));
            Console.ReadKey();
        }
    }
}
