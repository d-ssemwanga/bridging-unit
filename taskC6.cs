using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 0, b = 0, c = 0;
        bool found = false;

        for (a = 1; a < 1000; a++)
        {
            for (b = a + 1; b < 1000; b++)
            {
                c = 1000 - a - b;
                if (a * a + b * b == c * c)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                break;
            }
        }

        Console.WriteLine("The Pythagorean triplet is: a = {0}, b = {1}, c = {2}", a, b, c);
        Console.WriteLine("The product abc is: {0}", a * b * c);
        Console.ReadLine();
    }
}