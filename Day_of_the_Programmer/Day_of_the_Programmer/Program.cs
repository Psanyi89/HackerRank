using System;

internal class Solution
{

    // Complete the dayOfProgrammer function below.
    private static string dayOfProgrammer(int year)
    {
        int countthedays = 0;
        int day = 0;
        int month = 0;
        if (year > 1918)
        {
            for (int i = 1; i < 12; i++)
            {
                countthedays += DateTime.DaysInMonth(year, i);
                if (256 - countthedays < DateTime.DaysInMonth(year, i + 1))
                {
                    day = 256 - countthedays;
                    month = i + 1;
                    break;
                }
            }
        }
        else if (year < 1918)
        {
            for (int i = 1; i < 12; i++)
            {
                if (year % 4 == 0 && i == 2)
                {
                    countthedays += 29;
                }
                else if (i == 2)
                {
                    countthedays += 28;
                }
                else
                {
                    countthedays += DateTime.DaysInMonth(year, i);
                }

                if (256 - countthedays < DateTime.DaysInMonth(year, i + 1))
                {
                    day = 256 - countthedays;
                    month = i + 1;
                    break;
                }
            }

        }
        else
        {
            for (int i = 1; i < 12; i++)
            {

                if (i == 2)
                {
                    countthedays += 15;
                }
                else
                {
                    countthedays += DateTime.DaysInMonth(year, i);
                }

                if (256 - countthedays < DateTime.DaysInMonth(year, i + 1))
                {
                    day = 256 - countthedays;
                    month = i + 1;
                    break;
                }
            }

        }
        string result = $"{day.ToString("00")}:{month.ToString("00")}:{year}";
        return result;
    }

    private static void Main(string[] args)
    {

        int year = Convert.ToInt32(Console.ReadLine().Trim());

        string result = dayOfProgrammer(year);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}
