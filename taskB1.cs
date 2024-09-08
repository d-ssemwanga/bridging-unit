using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b;

        Console.Write("Enter the first number (A): ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number (B): ");
        b = Convert.ToDouble(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine("A is greater than B");
        }
        else if (b > a)
        {
            Console.WriteLine("B is greater than A");
        }
        else
        {
            Console.WriteLine("A and B are equal");
        }

        Console.ReadLine();
    }
}