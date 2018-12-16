using System;
using System.Collections.Generic;
using System.Linq;

internal class Solution
{
    private static int FormingMagicSquare(int[][] s)
    {
        int n = s.GetLength(0);

        int range = Convert.ToInt32(Math.Pow(n, 2));
        List<int[,]> possibilities = MagicSquare(n);
        List<int> Total = new List<int>();
        int sum = 0;
        foreach (int[,] item in possibilities)
        {
            sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += (Math.Abs(item[i, j] - s[i][j]));
                }

            }

            Total.Add(sum);
        }

        return Total.Min();


    }
    private static List<int[,]> MagicSquare(int n)
    {

        Random rnd = new Random();
        int number = 0;
        int range = Convert.ToInt32(Math.Pow(n, 2));
        List<int> stock = new List<int>();
        List<int[,]> twoArrays = new List<int[,]>();
        int[,] sudoku3X3 = new int[n, n];
        while (twoArrays.Count != 8)
        {
            do
            {
                do
                {
                    stock = new List<int>();
                    for (int k = 1; k <= range; k++)
                    {
                        stock.Add(k);
                    }
                    sudoku3X3 = new int[n, n];
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            number = rnd.Next(0, stock.Count);
                            sudoku3X3[i, j] = stock[number];
                            stock.Remove(stock[number]);
                        }
                    }
                } while (!IsMagic(sudoku3X3, n));
            } while (!IsNotOnTheList(sudoku3X3, twoArrays));
            twoArrays.Add(sudoku3X3);
        }
        return twoArrays;
    }

    private static bool IsNotOnTheList(int[,] sudoku3X3, List<int[,]> twoArrays)
    {
        int counter = 0;
        foreach (var item in twoArrays)
        {
            counter = 0;
            for (int i = 0; i < sudoku3X3.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku3X3.GetLength(1); j++)
                {
                    if (item[i, j] == sudoku3X3[i, j])
                    {
                        counter++;
                    }
                }
            }
            if (counter == sudoku3X3.Length)
            {
                return false;
            }
        }
        return true;
    }


    private static bool IsMagic(int[,] array, int n)
    {
        int sum = Convert.ToInt32(n * ((Math.Pow(n, 2) + 1) / 2));
        int result = 0, result2 = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {

            for (int j = 0; j < array.GetLength(1); j++)
            {

                result += array[i, j];

                result2 += array[j, i];
            }
            if (result != sum || result2 != sum) return false;
            result = 0;
            result2 = 0;
        }

        for (int x = 0, y = array.GetLength(1) - 1; x < array.GetLength(0); x++, y--)
        {
            result += array[x, y];
            result2 += array[x, x];
        }
        if (result != sum || result2 != sum) return false;
        return true;
    }


    private static void Main(string[] args)
    {

        int[][] s = new int[3][];
        s[0] = new int[] { 4, 8, 2 };
        s[1] = new int[] { 4, 5, 7 };
        s[2] = new int[] { 6, 1, 6 };
        Console.WriteLine(FormingMagicSquare(s));
        Console.ReadKey();
    }
}
