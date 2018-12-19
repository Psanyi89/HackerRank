using System;
using System.Linq;

namespace Designer_PDF_Viewer
{
    internal class Program
    {
        private static int designerPdfViewer(int[] h, string word)
        {
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] array = word.ToLower().ToArray();
            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < h.Length; j++)
                {
                    if (array[i] == letters[j])
                    {
                        if (h[j] > max)
                        {
                            max = h[j];
                        }
                    }
                }
            }
            return array.Length * max;
        }

        private static void Main(string[] args)
        {
            string word = "zaba";
            int[] h = { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 };
            Console.WriteLine(designerPdfViewer(h, word));
            Console.ReadKey();
        }
    }
}
