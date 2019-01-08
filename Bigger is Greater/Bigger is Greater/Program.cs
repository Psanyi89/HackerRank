using System;
using System.IO;
using System.Linq;

namespace Bigger_is_Greater
{
    internal class Program
    {
        private static string BiggerIsGreater(string w)
        {
            char[] Warray = w.ToCharArray();
            int i = w.Length - 1;
            if (i != 0)
            {
                while (w[i] <= w[i - 1])
                {
                    i--;
                    if (i == 0)
                    {
                        break;
                    }
                }
            }
            if (i <= 0)
            {
                return "no answer";
            }
            int j = w.Length - 1;
            while (w[i - 1] >= w[j])
            {
                j--;
            }
            char temp = Warray[i - 1];
            Warray[i - 1] = Warray[j];
            Warray[j] = temp;
            j = w.Length - 1;
            while (i < j)
            {
                temp = Warray[i];
                Warray[i] = Warray[j];
                Warray[j] = temp;
                i++;
                j--;
            }
            return new string(Warray);
        }

        private static void Main(string[] args)
        {
            string[] temp = File.ReadLines("permutation.txt").ToArray();

            foreach (string item in temp)
            {

                Console.WriteLine(BiggerIsGreater(item));
            }
            //Random rnd = new Random();
            //int lenght = rnd.Next(1, 101);
            //const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            //string text = new string(Enumerable.Repeat(chars, lenght).Select(x => x[rnd.Next(chars.Length)]).ToArray());
            //Console.WriteLine($"Input: {text}");
            //Console.WriteLine($" Result: {BiggerIsGreater(text)}");
            Console.ReadKey();
        }
    }
}
