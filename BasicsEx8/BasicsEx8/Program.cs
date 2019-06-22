using System;
using System.Globalization;

namespace BasicsEx8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads five integer numbers and prints their sum. 
            //If an invalid number is entered the program should prompt the user to enter another number(only once)

            Console.WriteLine("Please write 5 numbers:");

            int[] userNumbers = new int[5];

            for (int i = 0; i < userNumbers.Length; i++)
            {
                if (!int.TryParse(Console.ReadLine(), NumberStyles.None, CultureInfo.InvariantCulture, out userNumbers[i]))
                {
                    Console.WriteLine("The number is invalid, please enter another number.");
                    int.TryParse(Console.ReadLine(), NumberStyles.None, CultureInfo.InvariantCulture, out userNumbers[i]);
                }
            }

            int sum = 0;

            for (int i = 0; i < userNumbers.Length; i++)
            {
                sum += userNumbers[i];
            }
            Console.WriteLine("The sum of your numbers is : {0}", sum);
        }
    }
}
