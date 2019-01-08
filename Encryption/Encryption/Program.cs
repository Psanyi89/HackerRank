using System;

namespace Encryption
{
    internal class Program
    {
        private static string Encryption(string s)
        {
            string text = s.Replace(" ", string.Empty);
            int x = Convert.ToInt32(Math.Floor(Math.Sqrt(text.Length))), y = Convert.ToInt32(Math.Ceiling(Math.Sqrt(text.Length)));

            if (x * y < text.Length)
            {
                x++;
            }

            char?[,] codearray = new char?[x, y];
            int k = 0;
            for (int i = 0; i < codearray.GetLength(0); i++)
            {
                for (int j = 0; j < codearray.GetLength(1); j++)
                {
                    if (k < text.Length)
                    {
                        codearray[i, j] = text[k++];

                    }

                    Console.Write($"{codearray[i, j]}");
                }
                Console.WriteLine();
            }
            text = string.Empty;
            for (int j = 0; j < codearray.GetLength(1); j++)
            {
                for (int i = 0; i < codearray.GetLength(0); i++)
                {
                    if (codearray[i, j].HasValue)
                    {
                        text += codearray[i, j];
                    }
                }
                if (j < codearray.GetLength(1) - 1)
                {
                    text += ' ';
                }
            }

            return text;
        }

        private static void Main(string[] args)
        {
            // string s = "if man was meant to stay on the ground god would have given us roots";
            string s = "chillout";
            // string s = "have a nice day";
            //string s = "feed the dog";
            Console.WriteLine(Encryption(s));
            Console.ReadKey();
        }
    }
}
