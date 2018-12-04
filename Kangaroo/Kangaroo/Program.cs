using System;
using System.IO;

internal class Solution
{

    // Complete the kangaroo function below.
    private static string kangaroo(int x1, int v1, int x2, int v2)
    {

        string result = "";
        if (x1 < x2 && v1 < v2)
        {
            result = "NO";
        }
        else if (x2 < x1 && v2 < v1)
        {
            result = "NO";
        }
        else if (x2 < x1)
        {
            double tempo = ((double)(x1 - x2)) / (v2 - v1);
            if (tempo % 1 == 0)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }
        }
        else
        {
            double tempo = ((double)(x2 - x1)) / (v1 - v2);
            if (tempo % 1 == 0)
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }
        }
        return result;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] x1V1X2V2 = Console.ReadLine().Split(' ');

        int x1 = Convert.ToInt32(x1V1X2V2[0]);

        int v1 = Convert.ToInt32(x1V1X2V2[1]);

        int x2 = Convert.ToInt32(x1V1X2V2[2]);

        int v2 = Convert.ToInt32(x1V1X2V2[3]);

        string result = kangaroo(x1, v1, x2, v2);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
