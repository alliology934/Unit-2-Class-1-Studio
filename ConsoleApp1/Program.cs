//using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double area;
            string radiusInput;
            double circumference;
            double diameter;
            string mpgInput;
            double mpg;
            double gallonsOfGas;

            Console.Write("Enter a radius:");
            radiusInput = Console.ReadLine();
            radius = double.Parse(radiusInput);
            area =  Math.PI * radius * radius;
            Console.WriteLine($"The area of a circle of radius {radius} is: {area}");

            circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference of a circle of radius {radius} is: {circumference}");

            diameter = 2 * radius;
            Console.WriteLine($"The diameter of a circle of radius {radius} is: {diameter}");

            Console.Write("Enter the miles per gallon of your car: ");
            mpgInput = Console.ReadLine();
            mpg = double.Parse(mpgInput);
            gallonsOfGas = circumference / mpg;
            Console.WriteLine($"It would take {gallonsOfGas} gallons of gas to drive the circumference of a circle with a radius of {radius} miles");

        }
    }
}