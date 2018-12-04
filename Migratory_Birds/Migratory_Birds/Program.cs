using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class Solution
{
    public class Birds
    {
        public int Id { get; set; }
        public int count { get; set; }
    }

    // Complete the migratoryBirds function below.
    private static int migratoryBirds(List<int> arr)
    {
        int counter1 = 0;
        int counter2 = 0;
        int counter3 = 0;
        int counter4 = 0;
        int counter5 = 0;


        foreach (int item in arr)
        {
            if (item == 1)
            {
                counter1++;
            }
            else if (item == 2)
            {
                counter2++;
            }

            else if (item == 3)
            {
                counter3++;
            }

            else if (item == 4)
            {
                counter4++;
            }

            else if (item == 5)
            {
                counter5++;
            }
        }
        List<Birds> birds = new List<Birds>() {
            new Birds { Id = 1, count = counter1 },
            new Birds { Id = 2, count = counter2 },
            new Birds { Id = 3, count = counter3 },
            new Birds { Id = 4, count = counter4 },
            new Birds { Id = 5, count = counter5 }};
        Birds result = birds.OrderByDescending(x => x.count).ThenBy(x => x.Id).First();
        return result.Id;
    }

    private static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
