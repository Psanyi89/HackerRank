using System;

namespace Queen_s_Attack_II
{
    internal class Program
    {
        public static int QueensAttack(int n, int k, int r_q, int c_q, int[][] obstacles)
        {
            // 8 directions
            int up = Math.Abs(n - r_q);
            int down = Math.Abs(1 - r_q);
            int left = Math.Abs(1 - c_q);
            int right = Math.Abs(n - c_q);
            int leftup = 0;
            int rightup = 0;
            int rightdown = 0;
            int leftdown = 0;
            for (int i = 1; i < n + 1; i++)
            {
                if (Math.Abs(1 - r_q) == Math.Abs(i - c_q))
                {
                    if (i < c_q)
                    {
                        leftdown = Math.Abs(i - c_q);
                    }
                    else if (i > c_q)
                    {
                        rightdown = Math.Abs(i - c_q);
                    }
                }
                if (Math.Abs(n - r_q) == Math.Abs(i - c_q))
                {
                    if (i < c_q)
                    {
                        leftup = Math.Abs(i - c_q);
                    }
                    else if (i > c_q)
                    {
                        rightup = Math.Abs(i - c_q);
                    }
                }
                if (Math.Abs(i - r_q) == Math.Abs(c_q - 1))
                {
                    if (i < r_q)
                    {
                        leftdown = Math.Abs(i - r_q);
                    }
                    else if (i > r_q)
                    {
                        leftup = Math.Abs(i - r_q);
                    }
                }
                if (Math.Abs(i - r_q) == Math.Abs(c_q - n))
                {
                    if (i < r_q)
                    {
                        rightdown = Math.Abs(i - r_q);
                    }
                    else if (i > r_q)
                    {
                        rightup = Math.Abs(i - r_q);
                    }
                }
            }
            foreach (int[] item in obstacles)
            {
                int ydiff = Math.Abs(item[0] - r_q) - 1;
                int xdiff = Math.Abs(item[1] - c_q) - 1;
                if (item[0] == r_q)
                {
                    if (item[1] > c_q && right > xdiff)
                    {
                        right = Math.Abs(item[1] - c_q) - 1;
                    }
                    else if (item[1] < c_q && left > xdiff)
                    {
                        left = xdiff;
                    }
                }
                else if (item[1] == c_q)
                {
                    if (item[0] > r_q && up > ydiff)
                    {
                        up = ydiff;
                    }
                    else if (item[0] < r_q && down > ydiff)
                    {
                        down = ydiff;
                    }
                }
                else if (xdiff == ydiff)
                {
                    if (item[0] > r_q && item[1] < c_q && leftup > xdiff)
                    {
                        leftup = xdiff;
                    }
                    else if (item[0] > r_q && item[1] > c_q && rightup > xdiff)
                    {
                        rightup = xdiff;
                    }
                    else if (item[0] < r_q && item[1] > c_q && rightdown > xdiff)
                    {
                        rightdown = xdiff;
                    }
                    else if (item[0] < r_q && item[1] < c_q && leftdown > xdiff)
                    {
                        leftdown = xdiff;
                    }
                }
            }
            return left + right + up + down + leftup + rightup + rightdown + leftdown;
        }

        private static void Main(string[] args)
        {
            int n = 5;
            int k = 3;
            int r_q = 4;
            int c_q = 3;
            int[][] obstacles = new int[k][];
            obstacles[0] = new int[2] { 5, 5 };
            obstacles[1] = new int[2] { 4, 2 };
            obstacles[2] = new int[2] { 2, 3 };
            Console.WriteLine(QueensAttack(n, k, r_q, c_q, obstacles));
            Console.ReadKey();
        }
    }
}
