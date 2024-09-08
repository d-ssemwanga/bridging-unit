using System;

class Program
{
    static void Main(string[] args)
    {
        int numerator, denominator;
        int a, b, hcf;

        Console.Write("Enter the numerator: ");
        numerator = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the denominator: ");
        denominator = Convert.ToInt32(Console.ReadLine());

        a = numerator;
        b = denominator;

        while (a != b)
        {
            if (a > b)
            {
                a = a - b;
            }
            else
            {
                b = b - a;
            }
        }

        hcf = a; // or b, since a and b are equal here
        Console.WriteLine("The HCF is: " + hcf);

        Console.ReadLine();
    }
}