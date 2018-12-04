using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Solution
{

    // Complete the compareTriplets function below.
    private static List<int> compareTriplets(List<int> a, List<int> b)
    {
        int Alice = 0;
        int Bob = 0;
        for (int i = 0; i < a.Count; i++)
        {
            if (a[i] > b[i])
            {
                Alice++;
            }
            else if (b[i] > a[i])
            {
                Bob++;
            }
        }
        List<int> result = new List<int>
        {
            Alice,
            Bob
        };
        return result;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

        List<int> result = compareTriplets(a, b);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
