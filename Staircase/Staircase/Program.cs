using System;

internal class Solution
{

    // Complete the staircase function below.
    private static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string(' ', n - i) + new string('#', i));
        }
    }

    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}
