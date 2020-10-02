using System;

namespace Studio_2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.6.1
            //Write a program that prompts the user for the radius of a circle.Calculate the area of the
            //user’s circle and print the result.
            Console.Write("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("\nThe area of a circle of radius " + radius + " is: " + Math.Round((Math.PI * Math.Pow(radius, 2)), 3));

            //2.6.2
            /*
             * Using the same radius, calculate the circumference (2*pi*r) and diameter of the circle (2*r).
             * Output the results
             */
            Console.WriteLine("The circumference is of circle is: " + Math.Round((2*Math.PI*radius)),3);

            //2.6.3
            /*
             * Ask the user for the miles per gallon of their car.radius that they entered is in miles, 
             * output how many gallons of gas they will use to go around this circle.
             */
            Console.Write("Enter mpg of your car: ");
            double mpg = double.Parse(Console.ReadLine());
            Console.WriteLine("\nYou'd use " + Math.Round(radius / mpg,1) + " gallons of gas to drive around that circle!");

        }
    }
}
