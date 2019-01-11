using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lisa_s_Workbook
{
    class Program
    {
        static int Workbook(int n, int k, int[] arr)
        {
            int page = 1;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if(page==j)
                    {
                        count++;
                    }
                    if(j%k==0 && j<arr[i])
                    {
                        page++;
                    }
                }
                page++;
            }
            return count;
        }

        static void Main(string[] args)
        {
            int n = 25, k = 10;
            int[] arr = { 1, 29, 94, 15, 87, 100, 20, 55, 100, 45, 82, 80, 100, 100, 3, 53, 100, 2, 100, 100, 100, 100, 100, 100, 1 };
            Console.WriteLine(Workbook(n,k,arr));
            Console.ReadKey();
        }
    }
}
