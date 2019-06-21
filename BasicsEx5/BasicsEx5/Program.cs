using System;

namespace BasicsEx5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads two numbers from the console and prints the greater of them.
            // Solve the problem without using conditional statements and with conditional statements.

            Console.WriteLine("Please enter two numbers!");
            double num1 = int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());

            // With conditional statements
            if (num1 > num2)
            {
                Console.WriteLine("First number is greater than the second one.");
            }
            else
            {
                Console.WriteLine("Second number is greater thant the first one.");
            }

            // Without conditional statements
            Console.WriteLine("{0} >= {1}", Math.Max(num1, num2), Math.Min(num1, num2));
        }
    }
}
