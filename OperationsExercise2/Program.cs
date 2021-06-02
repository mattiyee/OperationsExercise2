using System;

namespace OperationsExercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double circleValue = Math.PI * radius * radius;

            Console.WriteLine($"The area of a circle with radius of {radius} is {circleValue}.");

        }
    }
}
