using System;

namespace ACM_ICPC_Team
{
    internal class Program
    {
        private static int[] AcmTeam(string[] topic)
        {
            int max = 0;
            int counter = 0;
            int pairs = 0;
            for (int i = 0; i < topic.Length - 1; i++)
            {
                for (int j = i + 1; j < topic.Length; j++)
                {
                    counter = 0;
                    for (int k = 0; k < topic[i].Length; k++)
                    {
                        if ((topic[i][k] != topic[j][k]) || (topic[i][k] == '1' && topic[j][k] == '1'))
                        {
                            counter++;
                        }
                    }
                    if (counter > max)
                    {
                        max = counter;
                        pairs = 1;
                    }
                    else if (counter == max)
                    {
                        pairs++;
                    }
                }
            }
            int[] result = { max, pairs };
            return result;
        }

        private static void Main(string[] args)
        {
            string[] topic = { "10101", "11100", "11010", "00101" };
            int[] result = AcmTeam(topic);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
