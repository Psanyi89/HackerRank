using System;

internal class CatsAndAMouse
{

    // Complete the catAndMouse function below.
    private static string CatAndMouse(int x, int y, int z)
    {
        //if (Math.Abs(z - x) == Math.Abs(z - y))
        //{
        //    return "Mouse C";
        //}
        //else if (Math.Abs(z - x) < Math.Abs(z - y))
        //{
        //    return "Cat A";
        //}
        //else
        //{
        //    return "Cat B";
        //}
        // One line version
        return (Math.Abs(z - x) == Math.Abs(z - y)) ? "Mouse C" : (Math.Abs(z - x) < Math.Abs(z - y)) ? "Cat A" : "Cat B";
    }

    private static void Main(string[] args)
    {
        Console.WriteLine(CatAndMouse(10, 30, 19));
        Console.ReadKey();
    }
}
