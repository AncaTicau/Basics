using System;

namespace BasicsEx3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads five numbers from the console and prints the greatest of them.

            Console.WriteLine("Please write 5 numbers:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());

            if ((num1 >= num2) && (num1 >= num3) && (num1 >= num4) && (num1 >= num5))
            {
                Console.WriteLine($"The biggest number is: {num1}");
                return;
            }
            if ((num2 >= num1) && (num2 >= num3) && (num2 >= num4) && (num2 >= num5))
            {
                Console.WriteLine($"The biggest number is: {num2}");
                return;
            }
            if ((num3 >= num1) && (num3 >= num2) && (num3 >= num4) && (num3 >= num5))
            {
                Console.WriteLine($"The biggest number is: {num3}");
                return;
            }
            if ((num4 >= num1) && (num4 >= num2) && (num4 >= num3) && (num4 >= num5))
            {
                Console.WriteLine($"The biggest number is: {num4}");
                return;
            }
            if ((num5 >= num1) && (num5 >= num2) && (num5 >= num3) && (num5 >= num4))
            {
                Console.WriteLine($"The biggest number is: {num5}");
            }
        }
    }
}
