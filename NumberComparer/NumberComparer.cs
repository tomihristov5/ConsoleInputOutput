// Problem 4. Number Comparer
// Write a program that gets two numbers from the console and prints the greater of them.
// Try to implement this without if statements.

using System;

class NumberComparer
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Enter first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.WriteLine(number1 > number2 ? "First number is greater" : "Second number is greater");
    }
}

