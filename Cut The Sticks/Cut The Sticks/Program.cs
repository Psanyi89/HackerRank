using System;
using System.Collections.Generic;
using System.Linq;

namespace Cut_The_Sticks
{
    internal class Program
    {
        private static int[] CutTheSticks(int[] arr)
        {

            List<int> array = new List<int>();
            List<int> list = arr.ToList();


            while (list.Count > 0)
            {
                array.Add(list.Count);
                if (list.Min() == list.Max())
                {
                    list.Clear();
                    break;
                }
                int cut = list.Min();
                list = list.Where(x => x != cut).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] -= cut;
                }
            }
            return array.ToArray();
        }

        private static void Main(string[] args)
        {
            int[] arr = { 5, 4, 4, 2, 2, 8 };
            int[] result = CutTheSticks(arr);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
