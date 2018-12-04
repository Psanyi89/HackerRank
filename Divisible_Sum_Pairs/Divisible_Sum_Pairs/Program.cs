using System;
using System.IO;

internal class Solution
{

    // Complete the divisibleSumPairs function below.
    private static int divisibleSumPairs(int n, int k, int[] ar)
    {
        int counter = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if ((ar[i] + ar[j]) % k == 0)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = divisibleSumPairs(n, k, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
