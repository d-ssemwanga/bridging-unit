using System;

class Program
{
    
    static void Main(string[] args)
    {
        int firstNumber;
        int secondNumber;
        int total;
        Console.Write("Enter the first number");
        firstNumber = System.Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number");
        secondNumber = System.Convert.ToInt32(Console.ReadLine());
        total = firstNumber + secondNumber;
        Console.WriteLine();
        Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, total);
        Console.ReadLine();
    }
}