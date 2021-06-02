using System;

namespace OperationsExercise2
{
    class Program
    {
        public static double AreaOfCircle(int radius)
        {
            return Math.PI * (radius * radius);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = int.Parse(Console.ReadLine());

            var circleValue = AreaOfCircle(radius);

            Console.WriteLine($"The area of a circle with a radius of {radius} is equal to {circleValue}.");

        }
    }
}
