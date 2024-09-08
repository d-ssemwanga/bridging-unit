using System;

class Program
{
    static void Main(string[] args)
    {
        double baseLength, height, area;

        Console.Write("Enter the length of the base of the triangle: ");
        baseLength = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the perpendicular height of the triangle: ");
        height = Convert.ToDouble(Console.ReadLine());

        area = 0.5 * baseLength * height;

        Console.WriteLine("The area of the triangle is {0}", area);
        Console.ReadLine();
    }
}