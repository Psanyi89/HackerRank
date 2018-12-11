using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Drawing_Book
{

    /*
     * Complete the pageCount function below.
     */
    static int PageCount(int n, int p)
    {

        if (p / 2 > (n / 2 - p / 2))
        {
            return n / 2 - p / 2;
        }
        else return p / 2;

    }

    static void Main(string[] args)
    {
        Console.WriteLine(PageCount(9,3));
        Console.ReadKey();
    }
}
