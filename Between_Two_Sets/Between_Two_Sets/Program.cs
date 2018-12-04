using System;
using System.IO;
using System.Linq;

internal class Solution
{

    /*
     * Complete the getTotalX function below.
     */
    private static int getTotalX(int[] a, int[] b)
    {
        int amax = a.Max();
        int bmin = b.Min();
        int counter = 1;
        int total = 0;
        int maxfactor = amax;
        while (maxfactor <= bmin)
        {
            bool factorofall = true;
            foreach (int item in a)
            {
                if (maxfactor % item != 0)
                {
                    factorofall = false;
                    break;
                }
            }
            if (factorofall)
            {
                foreach (int item in b)
                {
                    if (item % maxfactor != 0)
                    {
                        factorofall = false;
                        break;
                    }
                }
            }
            if (factorofall)
            {
                total++;
            }

            counter++;
            maxfactor = counter * amax;
        }
        return total;
    }

    private static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;

        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), bTemp => Convert.ToInt32(bTemp))
        ;
        int total = getTotalX(a, b);

        tw.WriteLine(total);

        tw.Flush();
        tw.Close();
    }
}
