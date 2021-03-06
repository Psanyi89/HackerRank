﻿using System;
using System.IO;

internal class Solution
{

    // Complete the breakingRecords function below.
    private static int[] breakingRecords(int[] scores)
    {
        int min = scores[0];
        int max = scores[0];
        int[] records = new int[2];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > max)
            {
                max = scores[i];
                records[0]++;

            }
            else if (scores[i] < min)
            {
                min = scores[i];
                records[1]++;
            }
        }
        return records;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
