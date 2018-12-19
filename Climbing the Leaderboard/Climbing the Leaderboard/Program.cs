using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Climbing_the_Leaderboard
{
    class Program
    {
        
   public static int[] ClimbingLeaderboard(int[] scores, int[] alice)
        {
            List<int> points = scores.Distinct().ToList();
            int[] result = new int[alice.Length];
            int count = 0;

            int index = points.Count - 1;
            while (count < result.Length)
            {
                if (index != -1)
                {
                    while (alice[count] >= points[index])
                    {
                        index--;
                        if (index == -1) break;
                    }
                }
                result[count] = index + 2;
                count++;

            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] scores = { 100, 90, 90, 80, 75, 60 };
            int[] alice = { 50, 65, 77, 90, 102 };
            int[] alicepositions = ClimbingLeaderboard(scores, alice);
            alicepositions.ToList().ForEach(x => Console.Write($"{x} "));
            Console.ReadKey();
        }
    }
}
