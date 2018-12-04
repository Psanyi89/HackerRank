using System;
using System.Collections.Generic;
using System.Linq;

internal class Solution
{

    // Complete the bonAppetit function below.
    private static void bonAppetit(List<int> bill, int k, int b)
    {
        int exp = bill[k];
        int sum = bill.Aggregate((x, y) => x + y);
        int real = (sum - exp) / 2;
        if (real == b)
        {
            Console.WriteLine("Bon Appetit");
        }
        else
        {
            Console.WriteLine(b - real);
        }
    }

    private static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

        int b = Convert.ToInt32(Console.ReadLine().Trim());

        bonAppetit(bill, k, b);
        Console.ReadKey();

    }
}
