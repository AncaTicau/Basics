using System;

namespace BasicsEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.

            Console.WriteLine("Please what number you want the radius of the circle to be.");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("The perimeter of the circle is : {0} and the area is : {1}", 2 * Math.PI * radius, Math.PI * radius * radius);
        }
    }
}
