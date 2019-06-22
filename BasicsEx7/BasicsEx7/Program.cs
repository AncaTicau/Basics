using System;

namespace BasicsEx7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
            // The number N should be read from the standard input.

            Console.Write("Enter a number. ");
            int givenNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i < givenNumber; i++)
            {
                if (i % (3 * 7) != 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
