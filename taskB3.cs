/*A switch statement can be preferable over 
if-else statements in situations where you need to 
compare a single variable to multiple constant values. 
This is often clearer and more efficient than multiple if-else 
statements.*/

// Using switch to determine 
// the day of the week based on an integer value:

using System;

class Program
{
    static void Main(string[] args)
    {
        int dayNumber;

        Console.Write("Enter a number between 1 and 7: ");
        dayNumber = Convert.ToInt32(Console.ReadLine());

        switch (dayNumber)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid input, please enter a number between 1 and 7.");
                break;
        }

        Console.ReadLine();
    }
}