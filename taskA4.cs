using System;

class Program
{
    static void Main(string[] args)
    {
        double averageSpeed, distance, timeInHours, timeInMinutes;

        Console.Write("Enter the average speed of the car (in km/h): ");
        averageSpeed = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the distance of the journey (in km): ");
        distance = Convert.ToDouble(Console.ReadLine());

        // Calculate time in hours
        timeInHours = distance / averageSpeed;

        // Convert hours to minutes
        timeInMinutes = timeInHours * 60;

        Console.WriteLine("The journey will take approximately {0} minutes", timeInMinutes);
        Console.ReadLine();
    }
}