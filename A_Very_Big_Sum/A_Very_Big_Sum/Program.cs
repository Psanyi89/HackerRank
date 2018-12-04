using System;
using System.IO;

internal class Solution
{

    // Complete the aVeryBigSum function below.
    private static long aVeryBigSum(long[] ar)
    {
        long result = 0;
        foreach (long item in ar)
        {
            result += item;
        }
        return result;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        long[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt64(arTemp))
        ;
        long result = aVeryBigSum(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
