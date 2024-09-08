using System;

class Program
{
    static void Main(string[] args)
    {
        double base1, base2, height, area;

        Console.Write("Enter the length of the first base of the trapezium: ");
        base1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the length of the second base of the trapezium: ");
        base2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the trapezium: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * (base1 + base2) * height;

        Console.WriteLine("The area of the trapezium is {0}", area);
        Console.ReadLine();
    }
}