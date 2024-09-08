using System;

class Program
{
    static void Main(string[] args)
    {
        int number;

        Console.Write("Enter a number from 1 to 12: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number < 1 || number > 12)
        {
            Console.WriteLine("Number must be between 1 and 12.");
            return;
        }

        for (int i = 1; i <= 12; i++)
        {
            Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
        }

        Console.ReadLine();
    }
}