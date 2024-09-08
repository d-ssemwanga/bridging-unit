using System;

class Program
{
    static void Main(string[] args)
    {
        double celsius, fahrenheit;
        string choice;

        Console.Write("Enter 'C' to convert Celsius to Fahrenheit or 'F' to convert Fahrenheit to Celsius: ");
        choice = Console.ReadLine().ToUpper();

        if (choice == "C")
        {
            Console.Write("Enter temperature in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("{0} Celsius is {1} Fahrenheit", celsius, fahrenheit);
        }
        else if (choice == "F")
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0} Fahrenheit is {1} Celsius", fahrenheit, celsius);
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }

        Console.ReadLine();
    }
}