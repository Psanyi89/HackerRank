using System;
using System.Linq;

internal class Solution
{

    // Complete the miniMaxSum function below.
    private static void miniMaxSum(ulong[] arr)
    {
        ulong min = arr.Min();
        ulong max = arr.Max();
        ulong sum = arr.Aggregate((a, c) => a + c);
        Console.WriteLine("{0} {1}", (sum - max).ToString(), (sum - min).ToString());

    }

    private static void Main(string[] args)
    {
        ulong[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToUInt64(arrTemp));
        miniMaxSum(arr);
    }
}
