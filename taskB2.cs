using System;

class Program
{
    static void Main(string[] args)
    {
        double a, b, c;
        double discriminant, root1, root2;

        Console.Write("Enter coefficient a: ");
        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        c = Convert.ToDouble(Console.ReadLine());

        discriminant = b * b - 4 * a * c;

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("There are two solutions: x1 = {0} and x2 = {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            Console.WriteLine("There is a single solution: x = {0}", root1);
        }
        else
        {
            Console.WriteLine("The equation cannot be solved with the formula.");
        }

        Console.ReadLine();
    }
}