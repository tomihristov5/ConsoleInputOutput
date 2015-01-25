// Problem 1. Sum of 3 Numbers
// Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int number3 = int.Parse(Console.ReadLine());
        double sum = number1 + number2 + number3;
        Console.WriteLine("The sum is: " + sum);
    }
}

