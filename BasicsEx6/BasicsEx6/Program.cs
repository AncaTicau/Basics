using System;

namespace BasicsEx6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that reads from the console a series of 5 integers and prints the smallest and largest of them.

            int[] userNumbers = new int[5];

            for (int i = 0; i < userNumbers.Length; i++)
            {
                userNumbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(userNumbers);

            Console.WriteLine("The smallest number is : {0}", userNumbers[0]);
            Console.WriteLine("The biggest number is : {0}", userNumbers[4]);
        }
    }
}
