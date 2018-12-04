using System;
using System.IO;

internal class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    private static string timeConversion(string s)
    {
        DateTime time = Convert.ToDateTime(s);
        return time.ToString("HH:mm:ss");
    }

    private static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
