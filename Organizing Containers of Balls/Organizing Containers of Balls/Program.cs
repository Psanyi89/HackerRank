using System;
using System.Linq;
using System.Numerics;

namespace Organizing_Containers_of_Balls
{
    internal class Program
    {
        private static string OrganizingContainers(BigInteger[][] container)
        {
            BigInteger[] type = new BigInteger[container.GetLength(0)];
            BigInteger[] box = new BigInteger[container.GetLength(0)];
            BigInteger countertype;
            for (int i = 0; i < container[0].Length; i++)
            {
                countertype = 0;
                for (int j = 0; j < container.GetLength(0); j++)
                {
                    countertype += container[j][i];

                }
                type[i] = countertype;
                box[i] = container[i].Aggregate(BigInteger.Add);
            }
            Array.Sort(box);
            Array.Sort(type);
            if (box.SequenceEqual(type))
            {
                return "Possible";

            }
            else
            {
                return "Impossible";
            }
        }

        private static void Main(string[] args)
        {
            BigInteger[][] arr = new BigInteger[3][];
            arr[0] = new BigInteger[] { 0, 2, 1 };
            arr[1] = new BigInteger[] { 1, 1, 1 };
            arr[2] = new BigInteger[] { 2, 0, 0 };

            Console.WriteLine(OrganizingContainers(arr));
            Console.ReadKey();
        }
    }
}
