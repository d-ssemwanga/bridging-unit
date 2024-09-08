using System;

class Program
{
    static void Main(string[] args)
    {
        string message;
        int number;

        Console.Write("Enter a message: ");
        message = Console.ReadLine();

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine(message);
        }

        Console.ReadLine();
    }
}