using System;
using System.IO;

internal class Solution
{

    // Complete the diagonalDifference function below.
    private static int diagonalDifference(int[][] arr)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            a += arr[(0 + i)][(0 + i)];
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            b += arr[(0 + i)][((arr.GetLength(0) - 1) - i)];
        }
        return Math.Abs(a - b);
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] arr = new int[n][];

        for (int i = 0; i < n; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = diagonalDifference(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
