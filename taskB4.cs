using System;

class Program
{
    static void Main(string[] args)
    {
        int a, b;

        Console.Write("Enter the first number: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        b = Convert.ToInt32(Console.ReadLine());

        // Using the ternary operator to determine the larger number
        string result = (a > b) ? "A is greater than B" : (b > a) ? "B is greater than A" : "A and B are equal";

        Console.WriteLine(result);

        Console.ReadLine();
    }
}