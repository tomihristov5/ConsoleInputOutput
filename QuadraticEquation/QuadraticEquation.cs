// Problem 6. Quadratic Equation
// Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
// (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());
        int x = 0;
        double x1 = 0;
        double x2 = 0;
        int equation = a * x * x + b * x + c;
        equation = 0;
        double D = b * b - 4 * a * c;
        x1 = (-b + Math.Sqrt(D)) / (2 * a);
        x2 = (-b - Math.Sqrt(D)) / (2 * a);
        Console.WriteLine("The roots are: {0} and {1}", x1, x2);
        
    }
}

