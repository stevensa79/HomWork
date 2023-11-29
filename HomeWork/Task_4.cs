using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine()!);

        int first, mid, second, last;

        if (number < 10)
        {
            Console.WriteLine("1D Number: " + number);
        }

        if (number > 100 && number < 999)
        {
            first = number / 100;
            second = (number / 10) % 10;
            last = number % 10;
            Console.WriteLine($"3D Number: {first}, {second}, {last}");
        }

        if (number >= 1000)
        {
            first = number / 1000;
            mid = (number / 100) % 10;
            second = (number / 10) % 10;
            last = number % 10;
            Console.WriteLine($"4D Number: {first}, {mid}, {second}, {last}");
        }
    }
}