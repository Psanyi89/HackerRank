using System;

internal class Solution
{

    // Complete the plusMinus function below.
    private static void plusMinus(int[] arr)
    {
        double plus = 0;
        double minus = 0;
        double nulla = 0;
        foreach (double item in arr)
        {
            if (item == 0)
            {
                nulla++;
            }
            else if (item > 0)
            {
                plus++;
            }
            else if (item < 0)
            {
                minus++;
            }
        }
        Console.WriteLine((plus / arr.Length).ToString("N6"));
        Console.WriteLine((minus / arr.Length).ToString("N6"));
        Console.WriteLine((nulla / arr.Length).ToString("N6"));
    }

    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
