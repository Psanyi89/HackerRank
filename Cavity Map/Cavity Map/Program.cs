using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cavity_Map
{
    class Program
    {
        static string[] CavityMap(string[] grid)
        {
            string[] result = grid;
            for (int i = 1; i < grid.Length-1; i++)
            {
                for (int j = 1; j < grid.Length-1; j++)
                {
                    if ((int)grid[i][j]> (int)grid[i+1][j] && (int)grid[i][j]> (int)grid[i-1][j] && grid[i][j] > (int)grid[i][j+1] && grid[i][j] > (int)grid[i][j-1])
                    {
                        char[] temp=result[i].ToCharArray();
                        temp[j] = 'X';
                        result[i] = new string(temp);
                    }
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] grid = {"1112","1912","1892","1234"};
            string[] result = CavityMap(grid);
            Console.WriteLine(String.Join("\n",result));
            Console.ReadKey();

        }
    }
}
