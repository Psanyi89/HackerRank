using System;
using System.IO;

internal class Solution
{

    // Complete the birthdayCakeCandles function below.
    private static int birthdayCakeCandles(int[] ar)
    {

        int max = ar[0];
        int counter = 1;
        for (int i = 1; i < ar.Length; i++)
        {
            if (ar[i] == max)
            {
                counter++;
            }
            else if (ar[i] > max)
            {
                max = ar[i];
                counter = 1;
            }
        }
        return counter;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arCount = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = birthdayCakeCandles(ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
