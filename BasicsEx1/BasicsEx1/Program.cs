using System;

namespace BasicsEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console three numbers of type int and prints their sum.

            Console.WriteLine("Please write a integer number!");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third integer number");
            int number3 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3;
            Console.WriteLine("The sum of your numbers is : {0}", sum);
        }
    }
}
