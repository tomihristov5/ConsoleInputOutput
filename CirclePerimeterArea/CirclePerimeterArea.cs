// Problem 3. Circle Perimeter and Area
// Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the 
// decimal point.

using System;

class CirclePerimeterArea
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter circle's radius: ");
        double r = double.Parse(Console.ReadLine());
        double area = Math.PI * r * r;
        Console.WriteLine("The circle's area is: {0:0.00} ", area );
    }
}

