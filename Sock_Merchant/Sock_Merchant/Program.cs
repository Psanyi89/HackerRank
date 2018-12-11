using System;
using System.Linq;

internal class Solution
{

    // Complete the sockMerchant function below.
    private static int SockMerchant(int n, int[] ar)
    {
        int[] array = ar.Distinct().ToArray();
        int count = 0;
        int pairs = 0;
        foreach (int number in array)
        {
            count = ar.Where(x => x == number).Count();
            pairs += count / 2;
        }
        return pairs;
    }

    private static void Main(string[] args)
    {
        int[] ar = { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
        Console.WriteLine(SockMerchant(ar.Length, ar));
        Console.ReadKey();
    }
}