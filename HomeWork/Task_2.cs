using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter coordinate point X and Y:");

        Console.Write("X: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Y: ");
        int y = int.Parse(Console.ReadLine());
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Enter any number but 0");
        }

        if (x > 0 && y > 0)
            Console.WriteLine("1");
        else if (x < 0 && y > 0)
            Console.WriteLine("2");
        else if (x < 0 && y < 0)
            Console.WriteLine("3");
        else if (x > 0 && y < 0)
            Console.WriteLine("4");
        else
            Console.WriteLine("The point on the coordinate");
    }
}






 

