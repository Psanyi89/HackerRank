using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the getMoneySpent function below.
     */
    static int GetMoneySpent(int[] keyboards, int[] drives, int b)
    {
        int max = -1;
        foreach (int Kprice in keyboards)
        {
            foreach (int Dprice in drives)
            {
                int total = Kprice + Dprice;
                if (total <= b && total > max)
                {
                    max = total;
                }
            }
        }
        return max;
    }

    static void Main(string[] args)
    {
        int[] keyboardprices = { 3, 1 };
        int[] driveprices = { 5, 2, 8 };
        int budget =10;
        Console.WriteLine(GetMoneySpent(keyboardprices, driveprices, budget));
        Console.ReadKey();
    }
}
