using System;

namespace BasicsEx4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console two integer numbers(int) and prints how many numbers between them exist that are divisible with 5,
            //such that the remainder of their division by 5 is 0.

            int counter = 0;

            Console.Write("Please enter a number.");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter a second number.");
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1 + 1; i < num2; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"We found {counter} numbers that are divisible with 5");
        }
    }
}
