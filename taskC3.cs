using System;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;

        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            sum += i * i * i;
        }

        Console.WriteLine("Sum of cubes from 1 to {0} is {1}", number, sum);
        Console.ReadLine();
    }
}