using System;

namespace The_Time_in_Words
{
    internal class Program
    {
        private static string TimeInWords(int h, int m)
        {
            if (h > 12)
            {
                h -= 12;
            }
            string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven",
            "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "quarter",
                "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty" };
            int tensremains;
            if (m == 0)
            {
                return $"{ones[h]} o' clock";
            }
            else if (m > 30)
            {
                int remains = 60 - m;
                if (remains > 19)
                {
                    tensremains = remains / 10;
                    return $"{tens[tensremains]} {ones[remains - tensremains * 10]} minutes to {ones[h + 1]}";
                }
                else if (remains == 15)
                {

                    return $"{ones[remains]} to {ones[h + 1]}";
                }
                else if (remains == 1)
                {
                    return $"one minute to {ones[h + 1]}";
                }
                return $"{ones[remains]} minutes to {ones[h + 1]}";
            }
            else if (m == 30)
            {
                return $"half past {ones[h]}";
            }
            else
            {
                if (m > 19)
                {
                    tensremains = m / 10;
                    return $"{tens[tensremains]} {ones[m - tensremains * 10]} minutes past {ones[h]}";
                }
                else if (m == 15)
                {

                    return $"{ones[m]} past {ones[h]}";
                }
                else if (m == 1)
                {
                    return $"one minute past {ones[h]}";
                }

                return $"{ones[m]} minutes past {ones[h]}";

            }
        }

        private static void Main(string[] args)
        {
            Console.WriteLine(TimeInWords(20, 1));
            Console.ReadKey();
        }
    }
}
